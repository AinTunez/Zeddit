using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoulsFormats;
using System.Design;
using System.ComponentModel.Design;
using Be.Windows.Forms;
using Microsoft.VisualBasic;
using static SoulsFormats.ESD;

namespace ESD_Editor
{
    public partial class GUI : Form
    {
        static ESD activeESD;
        static Dictionary<long, ESD.State> activeStateGroup;
        static ESD.State activeState;
        static ESD.Condition activeCondition;
        static ESD.CommandCall activeCommand;
        static TreeNode activeNode;
        static EditType activeEditType = EditType.Null;

        public GUI()
        {
            InitializeComponent();
        }

        private enum EditType { Null, Evaluator, CommandArg }



        private void StateGroupBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = StateGroupBox.SelectedIndex;
            StateBox.Items.Clear();
            if (index == -1)
            {
                activeStateGroup = null;
            } else
            {
                long groupKey = (long) StateGroupBox.Items[index];
                activeStateGroup = activeESD.StateGroups[groupKey];
                foreach (var stateKey in activeStateGroup.Keys)
                {
                    StateBox.Items.Add(stateKey);
                }
            }
        }

        private void StateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeState = null;
            if (activeStateGroup != null)
            {
                activeCondition = null;
                ConditionTree.SelectedNode = null;
                ConditionTree.Nodes.Clear();
                Editor.ByteProvider = new DynamicByteProvider(new byte[] { });
                TargetStateBox.Clear();
                PassCmdBox.Items.Clear();
                EntryCmdBox.Items.Clear();
                ExitCmdBox.Items.Clear();
                WhileCmdBox.Items.Clear();

                if (StateBox.SelectedItem != null)
                {
                    long stateKey = (long)StateBox.SelectedItem;
                    activeState = activeStateGroup[stateKey];
                    foreach (var condition in activeState.Conditions) AddConditionNode(condition);

                    foreach (var command in activeState.EntryCommands) EntryCmdBox.Items.Add(command.CommandID);
                    foreach (var command in activeState.ExitCommands) ExitCmdBox.Items.Add(command.CommandID);
                    foreach (var command in activeState.WhileCommands) WhileCmdBox.Items.Add(command.CommandID);
                }
            }
        }

        private void AddConditionNode(ESD.Condition condition)
        {
            int cNum = activeState.Conditions.IndexOf(condition);
            TreeNode cNode = new TreeNode();
            cNode.Name = "CND " + cNum;
            cNode.Text = "CND " + cNum;
            if (condition.TargetState != null) cNode.Text += " → " + condition.TargetState.ToString();
            ConditionTree.Nodes.Add(cNode);
            foreach (var subcondition in condition.Subconditions)
            {
                AddConditionNode(subcondition, cNode);
            }
        }

        private void AddConditionNode(ESD.Condition condition, TreeNode parent)
        {
            string cName = parent.Name + "-" + parent.Nodes.Count;
            TreeNode cNode = new TreeNode(cName);
            if (condition.TargetState != null) cNode.Text = cName + " → " + condition.TargetState.ToString();
            cNode.Name = cName;
            parent.Nodes.Add(cNode);
            foreach (var subcondition in condition.Subconditions)
            {
                AddConditionNode(subcondition, cNode);
            }
        }

        private void ConditionTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (ConditionTree.SelectedNode == null)
            {
                PassCmdBox.Items.Clear();
                TargetStateBox.Text = "";
                activeCondition = null;
            } else
            {
                activeNode = ConditionTree.SelectedNode;
                activeCommand = null;
                CmdProperties.Enabled = false;
                int[] nodePath = activeNode.Name.Substring(4).Split('-').Select(k => Int32.Parse(k)).ToArray();
                activeCondition = activeState.Conditions[nodePath[0]];

                for (int i = 1; i < nodePath.Length; i++)
                {
                    try
                    {
                        activeCondition = activeCondition.Subconditions[nodePath[i]];
                    } catch (Exception ex)
                    {
                        MessageBox.Show("ERROR on node path " + ConditionTree.SelectedNode.Name.Substring(4));
                        Editor.ByteProvider = new DynamicByteProvider(new byte[] { });
                        TargetStateBox.Text = "";
                        activeCondition = null;
                        return;
                    }
                }

                TargetStateBox.Text = activeCondition.TargetState.ToString();

                activeCommand = null;
                activeEditType = EditType.Evaluator;
                RefreshEditor();
                RefreshTitle();

                foreach (var command in activeCondition.PassCommands)
                {
                   PassCmdBox.Items.Add(command.CommandID);
                }

                PassCmdBox.SelectedItem = null;
                EntryCmdBox.SelectedItem = null;
                ExitCmdBox.SelectedItem = null;
                WhileCmdBox.SelectedItem = null;
            }
        }

        private void SaveTargetStateBtn_Click(object sender, EventArgs e)
        {
            if (activeCondition != null)
            {
                long targetState;
                bool success = long.TryParse(TargetStateBox.Text, out targetState);
                if (success)
                {
                    activeCondition.TargetState = targetState;
                    activeNode.Text = activeNode.Name + " → " + targetState;
                    ConditionTree.SelectedNode = activeNode;
                }
                else if (String.IsNullOrWhiteSpace(TargetStateBox.Text))
                {
                    activeCondition.TargetState = null;
                } else
                {
                    MessageBox.Show("ERROR: Invalid target state");
                }
            }
        }

        private void RevertEvalBtn_Click(object sender, EventArgs e)
        {
            Editor.ByteProvider = new DynamicByteProvider(activeCondition.Evaluator);
        }

        private void RevertTargetStateBtn_Click(object sender, EventArgs e)
        {
            TargetStateBox.Text = activeCondition.TargetState.ToString();
        }

        private void GoToStateBtn_Click(object sender, EventArgs e)
        {
            long targetState;
            bool success = long.TryParse(TargetStateBox.Text, out targetState);
            if (success && StateBox.Items.Contains(targetState))
            {
                StateBox.SelectedItem = targetState;
                StateBox_SelectedIndexChanged(sender, e);
            }
        }

        private void NotYet()
        {
            MessageBox.Show("This functionality is not yet implemented.");
        }

        private void addNewStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (activeESD != null && activeStateGroup != null)
            {
                long newStateNum = activeStateGroup.Max(k => k.Key) + 1;
                activeStateGroup.Add(newStateNum, new ESD.State());
                StateBox.Items.Add(newStateNum);
                StateBox.SelectedItem = newStateNum;
            }
        }

        private void cloneSelectedStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (activeESD != null && activeStateGroup != null && activeState != null)
            {
                long newStateNum = activeStateGroup.Max(k => k.Key) + 1;
                activeStateGroup.Add(newStateNum, CloneState(activeState));
                StateBox.Items.Add(newStateNum);
                StateBox.SelectedItem = newStateNum;
            }
        }

        private ESD.State CloneState(ESD.State orig)
        {
            var newState = new ESD.State();
            foreach (var v in orig.EntryCommands)
                newState.EntryCommands.Add(new CommandCall()
                {
                    CommandBank = v.CommandBank,
                    CommandID = v.CommandID,
                    Arguments = v.Arguments,
                });

            foreach (var v in orig.ExitCommands)
                newState.ExitCommands.Add(new CommandCall()
                {
                    CommandBank = v.CommandBank,
                    CommandID = v.CommandID,
                    Arguments = v.Arguments,
                });

            foreach (var v in orig.Conditions)
            {
                var newCondition = new ESD.Condition()
                {
                    Evaluator = v.Evaluator,
                    TargetState = v.TargetState,
                };

                foreach (var vv in v.PassCommands)
                    newCondition.PassCommands.Add(new CommandCall()
                    {
                        CommandBank = vv.CommandBank,
                        CommandID = vv.CommandID,
                        Arguments = vv.Arguments,
                    });

                foreach (var vv in v.Subconditions)
                {
                    var newSubCondition = new ESD.Condition()
                    {
                        Evaluator = vv.Evaluator,
                        TargetState = vv.TargetState,
                        Subconditions = vv.Subconditions,
                    };

                    foreach (var vvv in vv.PassCommands)
                        newSubCondition.PassCommands.Add(new CommandCall()
                        {
                            CommandBank = vvv.CommandBank,
                            CommandID = vvv.CommandID,
                            Arguments = vvv.Arguments,
                        });

                    newCondition.Subconditions.Add(newSubCondition);
                }

                newState.Conditions.Add(newCondition);
            }

            return newState;
        }

        private void deleteStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (activeState != null)
            {
                var result = MessageBox.Show("Delete state " + StateBox.SelectedItem, "Confirm", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    long item = (long)StateBox.SelectedItem;
                    StateBox.SelectedItem = null;
                    StateBox.Items.Remove(item);
                    activeStateGroup.Remove(item);
                }
            }

        }

        private void GUI_Load(object sender, EventArgs e)
        {

        }

        private void EntryCmdBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = EntryCmdBox.SelectedIndex;
            if (index != -1) SelectCommand(EntryCmdBox, activeState.EntryCommands[index]);
        }

        private void ExitCmdBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = ExitCmdBox.SelectedIndex;
            if (index != -1) SelectCommand(ExitCmdBox, activeState.ExitCommands[index]);
        }

        private void WhileCmdBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = WhileCmdBox.SelectedIndex;
            if (index != -1) SelectCommand(WhileCmdBox, activeState.WhileCommands[index]);
        }

        private void PassCmdBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = PassCmdBox.SelectedIndex;
            if (index != -1 && activeCondition.PassCommands.Count > 0) SelectCommand(PassCmdBox, activeCondition.PassCommands[index]);
        }

        private void SelectCommand(ListBox commandBox, ESD.CommandCall command)
        {
            activeEditType = EditType.Null;
            ListBox[] boxes = { EntryCmdBox, ExitCmdBox, WhileCmdBox, PassCmdBox };
            foreach (var box in boxes.Where(b => b != commandBox)) box.SelectedItem = null;
            Editor.ByteProvider = new DynamicByteProvider(new byte[] { });
            activeCommand = command;
            activeEditType = EditType.CommandArg;
            if (commandBox != PassCmdBox)
            {
                ConditionTree.SelectedNode = null;
                activeCondition = null;
            }
            RefreshEditor();
            RefreshTitle();
        }

        private void CommandArgBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = CommandArgBox.SelectedIndex;
            if (index != -1) Editor.ByteProvider = new DynamicByteProvider(activeCommand.Arguments[index]);
            activeEditType = EditType.CommandArg;
            RefreshTitle();
        }

        #region Command Management
        private enum CommandType { Entry, Exit, While, Pass };

        private void NewCommand(CommandType commandType)
        {
            if (activeState != null)
            {
                string raw = Interaction.InputBox("Enter command ID: ", "New Command");
                int commandID;
                bool success = int.TryParse(raw.Trim(), out commandID);
                if (!success)
                {
                    MessageBox.Show("ERROR: Invalid command ID.");
                }
                else
                {
                    var cmd = new CommandCall() { CommandID = commandID };
                    if (commandType == CommandType.Entry) activeState.EntryCommands.Add(cmd);
                    else if (commandType == CommandType.Exit) activeState.ExitCommands.Add(cmd);
                    else if (commandType == CommandType.While) activeState.WhileCommands.Add(cmd);
                    else activeCondition.PassCommands.Add(cmd);

                    if (activeCondition != null)
                    {
                        var s = ConditionTree.SelectedNode;
                        ConditionTree.SelectedNode = null;
                        ConditionTree.SelectedNode = s;
                    } else
                    {

                    }
                }
            }

        }

        private void newEntryCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCommand(CommandType.Entry);
        }

        private void newExitCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCommand(CommandType.Exit);
        }

        private void newWhileCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCommand(CommandType.While);
        }

        private void deleteCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBox cmdBox = null;
            int index = -1;
            ListBox[] boxes = { EntryCmdBox, ExitCmdBox, WhileCmdBox, PassCmdBox };
            foreach (var box in boxes)
            {
                if (box.SelectedIndex > -1)
                {
                    index = box.SelectedIndex;
                    cmdBox = box;
                    break;
                }
            }

            if (index > -1 && MessageBox.Show("Really delete command?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                List<CommandCall> cmds = null;
                if (cmdBox == EntryCmdBox) cmds = activeState.EntryCommands;
                else if (cmdBox == ExitCmdBox) cmds = activeState.ExitCommands;
                else if (cmdBox == WhileCmdBox) cmds = activeState.WhileCommands;
                else cmds = activeCondition.PassCommands;

                cmds.RemoveAt(index);
                StateBox_SelectedIndexChanged(sender, e);
            }

        }

        private void CommandUpBtn_Click(object sender, EventArgs e)
        {
            ListBox cmdBox = null;
            int index = -1;
            ListBox[] boxes = { EntryCmdBox, ExitCmdBox, WhileCmdBox, PassCmdBox };
            foreach (var box in boxes)
            {
                if (box.SelectedIndex > -1)
                {
                    index = box.SelectedIndex;
                    cmdBox = box;
                    break;
                }
            }

            if (index > 0)
            {
                List<CommandCall> cmds = null;
                if (cmdBox == EntryCmdBox) cmds = activeState.EntryCommands;
                else if (cmdBox == ExitCmdBox) cmds = activeState.ExitCommands;
                else if (cmdBox == WhileCmdBox) cmds = activeState.WhileCommands;
                else cmds = activeCondition.PassCommands;

                var cmd = cmds[index];
                cmds.Remove(cmd);
                cmds.Insert(index - 1, cmd);

                StateBox_SelectedIndexChanged(sender, e);
                cmdBox.SelectedIndex = index - 1;
            }

        }

        private void CommandDownBtn_Click(object sender, EventArgs e)
        {
            ListBox cmdBox = null;
            int index = -1;
            ListBox[] boxes = { EntryCmdBox, ExitCmdBox, WhileCmdBox, PassCmdBox };
            foreach (var box in boxes)
            {
                if (box.SelectedIndex > -1)
                {
                    index = box.SelectedIndex;
                    cmdBox = box;
                    break;
                }
            }

            if (index < cmdBox.Items.Count - 1)
            {
                List<CommandCall> cmds = null;
                if (cmdBox == EntryCmdBox) cmds = activeState.EntryCommands;
                else if (cmdBox == ExitCmdBox) cmds = activeState.ExitCommands;
                else if (cmdBox == WhileCmdBox) cmds = activeState.WhileCommands;
                else cmds = activeCondition.PassCommands;

                var cmd = cmds[index];
                cmds.Remove(cmd);
                cmds.Insert(index + 1, cmd);

                StateBox_SelectedIndexChanged(sender, e);
                cmdBox.SelectedIndex = index + 1;
            }
        }
        #endregion

        #region Command Property Management
        private void CommandBankVal_ValueChanged(object sender, EventArgs e)
        {
            activeCommand.CommandBank = (int)CommandBankVal.Value;
        }

        private void CommandArgUpBtn_Click(object sender, EventArgs e)
        {
            int index = CommandArgBox.SelectedIndex;
            if (index > 0)
            {
                var arg = activeCommand.Arguments[index];
                activeCommand.Arguments.Remove(arg);
                activeCommand.Arguments.Insert(index - 1, arg);
                CommandArgBox_SelectedIndexChanged(sender, e);
                CommandArgBox.SelectedIndex = index - 1;
            }
        }

        private void CommandArgDownBtn_Click(object sender, EventArgs e)
        {
            int index = CommandArgBox.SelectedIndex;
            if (index < CommandArgBox.Items.Count - 1)
            {
                var arg = activeCommand.Arguments[index];
                activeCommand.Arguments.Remove(arg);
                activeCommand.Arguments.Insert(index + 1, arg);
                CommandArgBox_SelectedIndexChanged(sender, e);
                CommandArgBox.SelectedIndex = index + 1;
            }
        }

        private void AddArgBtn_Click(object sender, EventArgs e)
        {
            if (activeCommand != null)
            {
                activeCommand.Arguments.Add(new byte[] { });
                RefreshEditor();
            }
        }

        private void DeleteArgBtn_Click(object sender, EventArgs e)
        {
            if (activeCommand != null && CommandArgBox.SelectedIndex > -1)
            {
                activeCommand.Arguments.RemoveAt(CommandArgBox.SelectedIndex);
                RefreshEditor();
            }
        }
        #endregion

        #region Hex Editor Management
        private void SaveEditorBtn_Click(object sender, EventArgs e)
        {
            SaveEditorSource();
        }

        private void SaveEditorSource()
        {
            var bytes = new List<byte>();
            for (int i = 0; i < Editor.ByteProvider.Length; i++)
            {
                bytes.Add(Editor.ByteProvider.ReadByte(i));
            }

            if (activeEditType == EditType.CommandArg)
            {
                activeCommand.Arguments[CommandArgBox.SelectedIndex] = bytes.ToArray();
            }
            else if (activeEditType == EditType.Evaluator)
            {
                activeCondition.Evaluator = bytes.ToArray();
            }
        }

        private void RefreshEditor()
        {
            int initIndex = CommandArgBox.SelectedIndex;
            if (activeEditType == EditType.CommandArg)
            {
                CmdProperties.Enabled = true;
                CommandBankVal.Value = activeCommand.CommandBank;
                for (int i = 0; i < activeCommand.Arguments.Count; i++)
                {
                    CommandArgBox.Items.Add(i);
                }
                if (CommandArgBox.Items.Count > 0) CommandArgBox.SelectedIndex = 0;
                if (initIndex > -1 && initIndex < activeCommand.Arguments.Count)
                {
                    CommandArgBox.SelectedIndex = initIndex;
                }           
            }
            else if (activeEditType == EditType.Evaluator)
            {
                Editor.ByteProvider = new DynamicByteProvider(activeCondition.Evaluator);
            }
            else
            {
                Editor.ByteProvider = new DynamicByteProvider(new byte[] { });
            }

            if (activeCommand != null)
            {

            }

        }

        private void RefreshTitle()
        {
            if (activeEditType == EditType.Evaluator)
            {
                EditorTitle.Text = ConditionTree.SelectedNode.Name + " : Evaluator";
            }
            else if (activeEditType == EditType.CommandArg)
            {
                string cmdString = "";
                if (PassCmdBox.SelectedItem != null)
                {
                    cmdString = ConditionTree.SelectedNode.Name + " : PassCommands[" + PassCmdBox.SelectedIndex + "] (" + activeCommand.CommandID + ")";
                }
                else if (EntryCmdBox.SelectedItem != null)
                {
                    cmdString = "EntryCommands[" + EntryCmdBox.SelectedIndex + "] (" + activeCommand.CommandID + ")";
                }
                else if (ExitCmdBox.SelectedItem != null)
                {
                    cmdString = "ExitCommands[" + ExitCmdBox.SelectedIndex + "] (" + activeCommand.CommandID + ")";
                }
                else if (WhileCmdBox.SelectedItem != null)
                {
                    cmdString = "WhileCommands[" + WhileCmdBox.SelectedIndex + "] (" + activeCommand.CommandID + ")";
                }

                if (CommandArgBox.SelectedItem != null)
                {
                    EditorTitle.Text = cmdString + " : Arguments[" + CommandArgBox.SelectedIndex + "]";
                }
                else
                {
                    EditorTitle.Text = "";
                }
            }
            else
            {
                EditorTitle.Text = "";

            }
        }

        private void RevEditorBtn_Click(object sender, EventArgs e)
        {
            RefreshEditor();
        }
        #endregion

        #region File Management
        private void saveESDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (activeESD == null) return;
            var sfd = new SaveFileDialog();
            sfd.OverwritePrompt = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    activeESD.Write(sfd.FileName);
                    ActiveForm.Text = "Zeddit - " + Path.GetFileName(sfd.FileName);
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void openESDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    activeESD = ESD.Read(ofd.FileName);
                    GUI.ActiveForm.Text = "Zeddit - " + Path.GetFileName(ofd.FileName);
                    foreach (var group in activeESD.StateGroups)
                    {
                        StateGroupBox.Items.Add(group.Key);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        #endregion

        private void newConditionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotYet();
        }

        private void newSubconditionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotYet();
        }

        private void newPassCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotYet();
        }
    }
}
