namespace ESD_Editor
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ESDLABEL = new System.Windows.Forms.Label();
            this.StateGroupBox = new System.Windows.Forms.ListBox();
            this.StateBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openESDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveESDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStateGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cloneSelectedStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEntryCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newExitCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWhileCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conditionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newConditionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSubconditionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPassCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PassCmdBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GoToStateBtn = new System.Windows.Forms.Button();
            this.RevertTargetStateBtn = new System.Windows.Forms.Button();
            this.TargetStateBox = new System.Windows.Forms.TextBox();
            this.SaveTargetStateBtn = new System.Windows.Forms.Button();
            this.ConditionTree = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RevEditorBtn = new System.Windows.Forms.Button();
            this.SaveEditorBtn = new System.Windows.Forms.Button();
            this.EditorTitle = new System.Windows.Forms.TextBox();
            this.Editor = new Be.Windows.Forms.HexBox();
            this.CommandGroupBox = new System.Windows.Forms.GroupBox();
            this.CommandArgDownBtn = new System.Windows.Forms.Button();
            this.CommandArgUpBtn = new System.Windows.Forms.Button();
            this.DeleteArgBtn = new System.Windows.Forms.Button();
            this.AddArgBtn = new System.Windows.Forms.Button();
            this.CommandArgBox = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.CommandDownBtn = new System.Windows.Forms.Button();
            this.CommandUpBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WhileCmdBox = new System.Windows.Forms.ListBox();
            this.ExitCmdBox = new System.Windows.Forms.ListBox();
            this.EntryCmdBox = new System.Windows.Forms.ListBox();
            this.CommandBankLabel = new System.Windows.Forms.Label();
            this.CommandBankVal = new System.Windows.Forms.NumericUpDown();
            this.CmdProperties = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.CommandGroupBox.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CommandBankVal)).BeginInit();
            this.CmdProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // ESDLABEL
            // 
            this.ESDLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESDLABEL.Location = new System.Drawing.Point(12, 31);
            this.ESDLABEL.Name = "ESDLABEL";
            this.ESDLABEL.Size = new System.Drawing.Size(111, 23);
            this.ESDLABEL.TabIndex = 2;
            this.ESDLABEL.Text = "State Groups";
            this.ESDLABEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StateGroupBox
            // 
            this.StateGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StateGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateGroupBox.FormattingEnabled = true;
            this.StateGroupBox.ItemHeight = 16;
            this.StateGroupBox.Location = new System.Drawing.Point(12, 57);
            this.StateGroupBox.Name = "StateGroupBox";
            this.StateGroupBox.Size = new System.Drawing.Size(111, 676);
            this.StateGroupBox.TabIndex = 4;
            this.StateGroupBox.SelectedIndexChanged += new System.EventHandler(this.StateGroupBox_SelectedIndexChanged);
            // 
            // StateBox
            // 
            this.StateBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateBox.FormattingEnabled = true;
            this.StateBox.ItemHeight = 16;
            this.StateBox.Location = new System.Drawing.Point(129, 57);
            this.StateBox.Name = "StateBox";
            this.StateBox.Size = new System.Drawing.Size(111, 676);
            this.StateBox.TabIndex = 5;
            this.StateBox.SelectedIndexChanged += new System.EventHandler(this.StateBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "States";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.commandsToolStripMenuItem,
            this.conditionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1059, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openESDToolStripMenuItem,
            this.saveESDToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openESDToolStripMenuItem
            // 
            this.openESDToolStripMenuItem.Name = "openESDToolStripMenuItem";
            this.openESDToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openESDToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.openESDToolStripMenuItem.Text = "Open ESD";
            this.openESDToolStripMenuItem.Click += new System.EventHandler(this.openESDToolStripMenuItem_Click);
            // 
            // saveESDToolStripMenuItem
            // 
            this.saveESDToolStripMenuItem.Name = "saveESDToolStripMenuItem";
            this.saveESDToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveESDToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.saveESDToolStripMenuItem.Text = "Save ESD";
            this.saveESDToolStripMenuItem.Click += new System.EventHandler(this.saveESDToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.exitToolStripMenuItem.Text = "Quit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStateToolStripMenuItem,
            this.addNewStateGroupToolStripMenuItem,
            this.cloneSelectedStateToolStripMenuItem,
            this.deleteStateToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.editToolStripMenuItem.Text = "States";
            // 
            // addNewStateToolStripMenuItem
            // 
            this.addNewStateToolStripMenuItem.Name = "addNewStateToolStripMenuItem";
            this.addNewStateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addNewStateToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.addNewStateToolStripMenuItem.Text = "New State";
            this.addNewStateToolStripMenuItem.Click += new System.EventHandler(this.addNewStateToolStripMenuItem_Click);
            // 
            // addNewStateGroupToolStripMenuItem
            // 
            this.addNewStateGroupToolStripMenuItem.Name = "addNewStateGroupToolStripMenuItem";
            this.addNewStateGroupToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.addNewStateGroupToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.addNewStateGroupToolStripMenuItem.Text = "New State Group";
            // 
            // cloneSelectedStateToolStripMenuItem
            // 
            this.cloneSelectedStateToolStripMenuItem.Name = "cloneSelectedStateToolStripMenuItem";
            this.cloneSelectedStateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.cloneSelectedStateToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.cloneSelectedStateToolStripMenuItem.Text = "Clone State";
            this.cloneSelectedStateToolStripMenuItem.Click += new System.EventHandler(this.cloneSelectedStateToolStripMenuItem_Click);
            // 
            // deleteStateToolStripMenuItem
            // 
            this.deleteStateToolStripMenuItem.Name = "deleteStateToolStripMenuItem";
            this.deleteStateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.deleteStateToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.deleteStateToolStripMenuItem.Text = "Delete State";
            this.deleteStateToolStripMenuItem.Click += new System.EventHandler(this.deleteStateToolStripMenuItem_Click);
            // 
            // commandsToolStripMenuItem
            // 
            this.commandsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEntryCommandToolStripMenuItem,
            this.newExitCommandToolStripMenuItem,
            this.newWhileCommandToolStripMenuItem,
            this.deleteCommandToolStripMenuItem});
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            this.commandsToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.commandsToolStripMenuItem.Text = "Commands";
            // 
            // newEntryCommandToolStripMenuItem
            // 
            this.newEntryCommandToolStripMenuItem.Name = "newEntryCommandToolStripMenuItem";
            this.newEntryCommandToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.newEntryCommandToolStripMenuItem.Text = "New Entry Command";
            this.newEntryCommandToolStripMenuItem.Click += new System.EventHandler(this.newEntryCommandToolStripMenuItem_Click);
            // 
            // newExitCommandToolStripMenuItem
            // 
            this.newExitCommandToolStripMenuItem.Name = "newExitCommandToolStripMenuItem";
            this.newExitCommandToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.newExitCommandToolStripMenuItem.Text = "New Exit Command";
            this.newExitCommandToolStripMenuItem.Click += new System.EventHandler(this.newExitCommandToolStripMenuItem_Click);
            // 
            // newWhileCommandToolStripMenuItem
            // 
            this.newWhileCommandToolStripMenuItem.Name = "newWhileCommandToolStripMenuItem";
            this.newWhileCommandToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.newWhileCommandToolStripMenuItem.Text = "New While Command";
            this.newWhileCommandToolStripMenuItem.Click += new System.EventHandler(this.newWhileCommandToolStripMenuItem_Click);
            // 
            // deleteCommandToolStripMenuItem
            // 
            this.deleteCommandToolStripMenuItem.Name = "deleteCommandToolStripMenuItem";
            this.deleteCommandToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.deleteCommandToolStripMenuItem.Text = "Delete Command";
            this.deleteCommandToolStripMenuItem.Click += new System.EventHandler(this.deleteCommandToolStripMenuItem_Click);
            // 
            // conditionsToolStripMenuItem
            // 
            this.conditionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newConditionToolStripMenuItem,
            this.newSubconditionToolStripMenuItem,
            this.newPassCommandToolStripMenuItem});
            this.conditionsToolStripMenuItem.Name = "conditionsToolStripMenuItem";
            this.conditionsToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.conditionsToolStripMenuItem.Text = "Conditions";
            // 
            // newConditionToolStripMenuItem
            // 
            this.newConditionToolStripMenuItem.Name = "newConditionToolStripMenuItem";
            this.newConditionToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.newConditionToolStripMenuItem.Text = "New Condition";
            this.newConditionToolStripMenuItem.Click += new System.EventHandler(this.newConditionToolStripMenuItem_Click);
            // 
            // newSubconditionToolStripMenuItem
            // 
            this.newSubconditionToolStripMenuItem.Name = "newSubconditionToolStripMenuItem";
            this.newSubconditionToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.newSubconditionToolStripMenuItem.Text = "New Subcondition";
            this.newSubconditionToolStripMenuItem.Click += new System.EventHandler(this.newSubconditionToolStripMenuItem_Click);
            // 
            // newPassCommandToolStripMenuItem
            // 
            this.newPassCommandToolStripMenuItem.Name = "newPassCommandToolStripMenuItem";
            this.newPassCommandToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.newPassCommandToolStripMenuItem.Text = "New Pass Command";
            this.newPassCommandToolStripMenuItem.Click += new System.EventHandler(this.newPassCommandToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.ConditionTree);
            this.groupBox1.Location = new System.Drawing.Point(246, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 365);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conditions";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PassCmdBox);
            this.groupBox4.Location = new System.Drawing.Point(251, 189);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(134, 161);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pass Commands";
            // 
            // PassCmdBox
            // 
            this.PassCmdBox.FormattingEnabled = true;
            this.PassCmdBox.ItemHeight = 16;
            this.PassCmdBox.Location = new System.Drawing.Point(7, 22);
            this.PassCmdBox.Name = "PassCmdBox";
            this.PassCmdBox.Size = new System.Drawing.Size(121, 132);
            this.PassCmdBox.TabIndex = 0;
            this.PassCmdBox.SelectedIndexChanged += new System.EventHandler(this.PassCmdBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GoToStateBtn);
            this.groupBox2.Controls.Add(this.RevertTargetStateBtn);
            this.groupBox2.Controls.Add(this.TargetStateBox);
            this.groupBox2.Controls.Add(this.SaveTargetStateBtn);
            this.groupBox2.Location = new System.Drawing.Point(251, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 162);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Target State";
            // 
            // GoToStateBtn
            // 
            this.GoToStateBtn.Location = new System.Drawing.Point(10, 127);
            this.GoToStateBtn.Name = "GoToStateBtn";
            this.GoToStateBtn.Size = new System.Drawing.Size(115, 29);
            this.GoToStateBtn.TabIndex = 9;
            this.GoToStateBtn.Text = "Go To State";
            this.GoToStateBtn.UseVisualStyleBackColor = true;
            this.GoToStateBtn.Click += new System.EventHandler(this.GoToStateBtn_Click);
            // 
            // RevertTargetStateBtn
            // 
            this.RevertTargetStateBtn.Location = new System.Drawing.Point(10, 92);
            this.RevertTargetStateBtn.Name = "RevertTargetStateBtn";
            this.RevertTargetStateBtn.Size = new System.Drawing.Size(115, 29);
            this.RevertTargetStateBtn.TabIndex = 6;
            this.RevertTargetStateBtn.Text = "Revert";
            this.RevertTargetStateBtn.UseVisualStyleBackColor = true;
            // 
            // TargetStateBox
            // 
            this.TargetStateBox.Location = new System.Drawing.Point(10, 23);
            this.TargetStateBox.Name = "TargetStateBox";
            this.TargetStateBox.Size = new System.Drawing.Size(115, 22);
            this.TargetStateBox.TabIndex = 6;
            // 
            // SaveTargetStateBtn
            // 
            this.SaveTargetStateBtn.Location = new System.Drawing.Point(10, 57);
            this.SaveTargetStateBtn.Name = "SaveTargetStateBtn";
            this.SaveTargetStateBtn.Size = new System.Drawing.Size(115, 29);
            this.SaveTargetStateBtn.TabIndex = 8;
            this.SaveTargetStateBtn.Text = "Save";
            this.SaveTargetStateBtn.UseVisualStyleBackColor = true;
            this.SaveTargetStateBtn.Click += new System.EventHandler(this.SaveTargetStateBtn_Click);
            // 
            // ConditionTree
            // 
            this.ConditionTree.Location = new System.Drawing.Point(6, 30);
            this.ConditionTree.Name = "ConditionTree";
            this.ConditionTree.Size = new System.Drawing.Size(239, 320);
            this.ConditionTree.TabIndex = 11;
            this.ConditionTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ConditionTree_AfterSelect);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.RevEditorBtn);
            this.groupBox3.Controls.Add(this.SaveEditorBtn);
            this.groupBox3.Controls.Add(this.EditorTitle);
            this.groupBox3.Controls.Add(this.Editor);
            this.groupBox3.Location = new System.Drawing.Point(475, 407);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(566, 331);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hex Editor";
            // 
            // RevEditorBtn
            // 
            this.RevEditorBtn.Location = new System.Drawing.Point(90, 18);
            this.RevEditorBtn.Name = "RevEditorBtn";
            this.RevEditorBtn.Size = new System.Drawing.Size(92, 27);
            this.RevEditorBtn.TabIndex = 5;
            this.RevEditorBtn.Text = "Revert";
            this.RevEditorBtn.UseVisualStyleBackColor = true;
            this.RevEditorBtn.Click += new System.EventHandler(this.RevEditorBtn_Click);
            // 
            // SaveEditorBtn
            // 
            this.SaveEditorBtn.Location = new System.Drawing.Point(9, 18);
            this.SaveEditorBtn.Name = "SaveEditorBtn";
            this.SaveEditorBtn.Size = new System.Drawing.Size(75, 27);
            this.SaveEditorBtn.TabIndex = 4;
            this.SaveEditorBtn.Text = "Save";
            this.SaveEditorBtn.UseVisualStyleBackColor = true;
            this.SaveEditorBtn.Click += new System.EventHandler(this.SaveEditorBtn_Click);
            // 
            // EditorTitle
            // 
            this.EditorTitle.Location = new System.Drawing.Point(188, 20);
            this.EditorTitle.Name = "EditorTitle";
            this.EditorTitle.ReadOnly = true;
            this.EditorTitle.Size = new System.Drawing.Size(372, 22);
            this.EditorTitle.TabIndex = 3;
            // 
            // Editor
            // 
            this.Editor.BytesPerLine = 8;
            this.Editor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Editor.LineInfoVisible = true;
            this.Editor.Location = new System.Drawing.Point(9, 48);
            this.Editor.Name = "Editor";
            this.Editor.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.Editor.Size = new System.Drawing.Size(551, 275);
            this.Editor.StringViewVisible = true;
            this.Editor.TabIndex = 0;
            this.Editor.UseFixedBytesPerLine = true;
            // 
            // CommandGroupBox
            // 
            this.CommandGroupBox.Controls.Add(this.CommandArgDownBtn);
            this.CommandGroupBox.Controls.Add(this.CommandArgUpBtn);
            this.CommandGroupBox.Controls.Add(this.DeleteArgBtn);
            this.CommandGroupBox.Controls.Add(this.AddArgBtn);
            this.CommandGroupBox.Controls.Add(this.CommandArgBox);
            this.CommandGroupBox.Location = new System.Drawing.Point(21, 89);
            this.CommandGroupBox.Name = "CommandGroupBox";
            this.CommandGroupBox.Size = new System.Drawing.Size(171, 222);
            this.CommandGroupBox.TabIndex = 6;
            this.CommandGroupBox.TabStop = false;
            this.CommandGroupBox.Text = "Arguments";
            // 
            // CommandArgDownBtn
            // 
            this.CommandArgDownBtn.Location = new System.Drawing.Point(6, 70);
            this.CommandArgDownBtn.Name = "CommandArgDownBtn";
            this.CommandArgDownBtn.Size = new System.Drawing.Size(108, 32);
            this.CommandArgDownBtn.TabIndex = 4;
            this.CommandArgDownBtn.Text = "Move Arg ↓";
            this.CommandArgDownBtn.UseVisualStyleBackColor = true;
            this.CommandArgDownBtn.Click += new System.EventHandler(this.CommandArgDownBtn_Click);
            // 
            // CommandArgUpBtn
            // 
            this.CommandArgUpBtn.Location = new System.Drawing.Point(6, 32);
            this.CommandArgUpBtn.Name = "CommandArgUpBtn";
            this.CommandArgUpBtn.Size = new System.Drawing.Size(108, 32);
            this.CommandArgUpBtn.TabIndex = 3;
            this.CommandArgUpBtn.Text = "Move Arg ↑";
            this.CommandArgUpBtn.UseVisualStyleBackColor = true;
            this.CommandArgUpBtn.Click += new System.EventHandler(this.CommandArgUpBtn_Click);
            // 
            // DeleteArgBtn
            // 
            this.DeleteArgBtn.Location = new System.Drawing.Point(6, 180);
            this.DeleteArgBtn.Name = "DeleteArgBtn";
            this.DeleteArgBtn.Size = new System.Drawing.Size(108, 32);
            this.DeleteArgBtn.TabIndex = 2;
            this.DeleteArgBtn.Text = "Delete";
            this.DeleteArgBtn.UseVisualStyleBackColor = true;
            this.DeleteArgBtn.Click += new System.EventHandler(this.DeleteArgBtn_Click);
            // 
            // AddArgBtn
            // 
            this.AddArgBtn.Location = new System.Drawing.Point(6, 139);
            this.AddArgBtn.Name = "AddArgBtn";
            this.AddArgBtn.Size = new System.Drawing.Size(108, 32);
            this.AddArgBtn.TabIndex = 1;
            this.AddArgBtn.Text = "Add";
            this.AddArgBtn.UseVisualStyleBackColor = true;
            this.AddArgBtn.Click += new System.EventHandler(this.AddArgBtn_Click);
            // 
            // CommandArgBox
            // 
            this.CommandArgBox.FormattingEnabled = true;
            this.CommandArgBox.ItemHeight = 16;
            this.CommandArgBox.Location = new System.Drawing.Point(120, 32);
            this.CommandArgBox.Name = "CommandArgBox";
            this.CommandArgBox.Size = new System.Drawing.Size(45, 180);
            this.CommandArgBox.TabIndex = 0;
            this.CommandArgBox.SelectedIndexChanged += new System.EventHandler(this.CommandArgBox_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.CommandDownBtn);
            this.groupBox6.Controls.Add(this.CommandUpBtn);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.WhileCmdBox);
            this.groupBox6.Controls.Add(this.ExitCmdBox);
            this.groupBox6.Controls.Add(this.EntryCmdBox);
            this.groupBox6.Location = new System.Drawing.Point(646, 32);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(395, 364);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Commands";
            // 
            // CommandDownBtn
            // 
            this.CommandDownBtn.Location = new System.Drawing.Point(17, 172);
            this.CommandDownBtn.Name = "CommandDownBtn";
            this.CommandDownBtn.Size = new System.Drawing.Size(99, 29);
            this.CommandDownBtn.TabIndex = 7;
            this.CommandDownBtn.Text = "Move ↓";
            this.CommandDownBtn.UseVisualStyleBackColor = true;
            this.CommandDownBtn.Click += new System.EventHandler(this.CommandDownBtn_Click);
            // 
            // CommandUpBtn
            // 
            this.CommandUpBtn.Location = new System.Drawing.Point(17, 137);
            this.CommandUpBtn.Name = "CommandUpBtn";
            this.CommandUpBtn.Size = new System.Drawing.Size(99, 29);
            this.CommandUpBtn.TabIndex = 6;
            this.CommandUpBtn.Text = "Move ↑";
            this.CommandUpBtn.UseVisualStyleBackColor = true;
            this.CommandUpBtn.Click += new System.EventHandler(this.CommandUpBtn_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(302, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "While";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(211, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Exit";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(117, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Entry";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WhileCmdBox
            // 
            this.WhileCmdBox.FormattingEnabled = true;
            this.WhileCmdBox.ItemHeight = 16;
            this.WhileCmdBox.Location = new System.Drawing.Point(302, 50);
            this.WhileCmdBox.Name = "WhileCmdBox";
            this.WhileCmdBox.Size = new System.Drawing.Size(85, 308);
            this.WhileCmdBox.TabIndex = 2;
            this.WhileCmdBox.SelectedIndexChanged += new System.EventHandler(this.WhileCmdBox_SelectedIndexChanged);
            // 
            // ExitCmdBox
            // 
            this.ExitCmdBox.FormattingEnabled = true;
            this.ExitCmdBox.ItemHeight = 16;
            this.ExitCmdBox.Location = new System.Drawing.Point(211, 50);
            this.ExitCmdBox.Name = "ExitCmdBox";
            this.ExitCmdBox.Size = new System.Drawing.Size(85, 308);
            this.ExitCmdBox.TabIndex = 1;
            this.ExitCmdBox.SelectedIndexChanged += new System.EventHandler(this.ExitCmdBox_SelectedIndexChanged);
            // 
            // EntryCmdBox
            // 
            this.EntryCmdBox.FormattingEnabled = true;
            this.EntryCmdBox.ItemHeight = 16;
            this.EntryCmdBox.Location = new System.Drawing.Point(120, 50);
            this.EntryCmdBox.Name = "EntryCmdBox";
            this.EntryCmdBox.Size = new System.Drawing.Size(85, 308);
            this.EntryCmdBox.TabIndex = 0;
            this.EntryCmdBox.SelectedIndexChanged += new System.EventHandler(this.EntryCmdBox_SelectedIndexChanged);
            // 
            // CommandBankLabel
            // 
            this.CommandBankLabel.AutoSize = true;
            this.CommandBankLabel.Location = new System.Drawing.Point(25, 48);
            this.CommandBankLabel.Name = "CommandBankLabel";
            this.CommandBankLabel.Size = new System.Drawing.Size(107, 17);
            this.CommandBankLabel.TabIndex = 10;
            this.CommandBankLabel.Text = "Command Bank";
            // 
            // CommandBankVal
            // 
            this.CommandBankVal.Location = new System.Drawing.Point(138, 46);
            this.CommandBankVal.Name = "CommandBankVal";
            this.CommandBankVal.ReadOnly = true;
            this.CommandBankVal.Size = new System.Drawing.Size(51, 22);
            this.CommandBankVal.TabIndex = 9;
            this.CommandBankVal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CmdProperties
            // 
            this.CmdProperties.Controls.Add(this.CommandBankLabel);
            this.CmdProperties.Controls.Add(this.CommandBankVal);
            this.CmdProperties.Controls.Add(this.CommandGroupBox);
            this.CmdProperties.Enabled = false;
            this.CmdProperties.Location = new System.Drawing.Point(246, 407);
            this.CmdProperties.Name = "CmdProperties";
            this.CmdProperties.Size = new System.Drawing.Size(223, 331);
            this.CmdProperties.TabIndex = 12;
            this.CmdProperties.TabStop = false;
            this.CmdProperties.Text = "Command Properties";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 750);
            this.Controls.Add(this.CmdProperties);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StateBox);
            this.Controls.Add(this.StateGroupBox);
            this.Controls.Add(this.ESDLABEL);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1077, 797);
            this.MinimumSize = new System.Drawing.Size(1077, 797);
            this.Name = "GUI";
            this.Text = "Zeddit";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.CommandGroupBox.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CommandBankVal)).EndInit();
            this.CmdProperties.ResumeLayout(false);
            this.CmdProperties.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label ESDLABEL;
        private System.Windows.Forms.ListBox StateGroupBox;
        private System.Windows.Forms.ListBox StateBox;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openESDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveESDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cloneSelectedStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStateGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStateToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button GoToStateBtn;
        private System.Windows.Forms.Button RevertTargetStateBtn;
        private System.Windows.Forms.TextBox TargetStateBox;
        private System.Windows.Forms.Button SaveTargetStateBtn;
        private System.Windows.Forms.TreeView ConditionTree;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox PassCmdBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private Be.Windows.Forms.HexBox Editor;
        private System.Windows.Forms.TextBox EditorTitle;
        private System.Windows.Forms.Button RevEditorBtn;
        private System.Windows.Forms.Button SaveEditorBtn;
        private System.Windows.Forms.GroupBox CommandGroupBox;
        private System.Windows.Forms.ListBox CommandArgBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox WhileCmdBox;
        private System.Windows.Forms.ListBox ExitCmdBox;
        private System.Windows.Forms.ListBox EntryCmdBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newEntryCommandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newExitCommandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWhileCommandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCommandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conditionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newConditionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSubconditionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPassCommandToolStripMenuItem;
        private System.Windows.Forms.Button DeleteArgBtn;
        private System.Windows.Forms.Button AddArgBtn;
        private System.Windows.Forms.Button CommandArgUpBtn;
        private System.Windows.Forms.Button CommandArgDownBtn;
        private System.Windows.Forms.Label CommandBankLabel;
        private System.Windows.Forms.NumericUpDown CommandBankVal;
        private System.Windows.Forms.Button CommandDownBtn;
        private System.Windows.Forms.Button CommandUpBtn;
        private System.Windows.Forms.GroupBox CmdProperties;
    }
}

