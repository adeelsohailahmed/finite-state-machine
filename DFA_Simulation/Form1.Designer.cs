namespace DFA_Simulation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonGenerateTable = new System.Windows.Forms.Button();
            this.labelEnterTransitionTable = new System.Windows.Forms.Label();
            this.textBoxDfaLanguage = new System.Windows.Forms.TextBox();
            this.labelEnterDfaCharacters = new System.Windows.Forms.Label();
            this.labelEnterStateNames = new System.Windows.Forms.Label();
            this.textBoxStates = new System.Windows.Forms.TextBox();
            this.buttonClearTable = new System.Windows.Forms.Button();
            this.buttonSetInitialState = new System.Windows.Forms.Button();
            this.textBoxTestString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTestString = new System.Windows.Forms.Button();
            this.buttonSetFinalState = new System.Windows.Forms.Button();
            this.checkBoxMultiFinal = new System.Windows.Forms.CheckBox();
            this.buttonClearFinalStates = new System.Windows.Forms.Button();
            this.labelFinalStates = new System.Windows.Forms.Label();
            this.checkBoxShowTraverse = new System.Windows.Forms.CheckBox();
            this.labelInitialState = new System.Windows.Forms.Label();
            this.labelFinalState = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.helpProvider1.SetHelpString(this.dataGridView1, "Enter the proper states in their corresponding cells.");
            this.dataGridView1.Location = new System.Drawing.Point(29, 185);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.helpProvider1.SetShowHelp(this.dataGridView1, true);
            this.dataGridView1.Size = new System.Drawing.Size(595, 220);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonGenerateTable
            // 
            this.buttonGenerateTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.helpProvider1.SetHelpString(this.buttonGenerateTable, "Click this button after entering language\'s characters and names of the state to " +
        "generate a corresponding two-dimension state transition table.");
            this.buttonGenerateTable.Location = new System.Drawing.Point(400, 110);
            this.buttonGenerateTable.Name = "buttonGenerateTable";
            this.helpProvider1.SetShowHelp(this.buttonGenerateTable, true);
            this.buttonGenerateTable.Size = new System.Drawing.Size(167, 23);
            this.buttonGenerateTable.TabIndex = 1;
            this.buttonGenerateTable.Text = "Generate State Transition Table";
            this.buttonGenerateTable.UseVisualStyleBackColor = true;
            this.buttonGenerateTable.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelEnterTransitionTable
            // 
            this.labelEnterTransitionTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEnterTransitionTable.AutoSize = true;
            this.labelEnterTransitionTable.Location = new System.Drawing.Point(265, 169);
            this.labelEnterTransitionTable.Name = "labelEnterTransitionTable";
            this.labelEnterTransitionTable.Size = new System.Drawing.Size(129, 13);
            this.labelEnterTransitionTable.TabIndex = 2;
            this.labelEnterTransitionTable.Text = "Enter the Transition Table";
            // 
            // textBoxDfaLanguage
            // 
            this.textBoxDfaLanguage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.helpProvider1.SetHelpString(this.textBoxDfaLanguage, "Enter individual characters (separated by space, comma, or dot).");
            this.textBoxDfaLanguage.Location = new System.Drawing.Point(287, 58);
            this.textBoxDfaLanguage.Name = "textBoxDfaLanguage";
            this.helpProvider1.SetShowHelp(this.textBoxDfaLanguage, true);
            this.textBoxDfaLanguage.Size = new System.Drawing.Size(280, 20);
            this.textBoxDfaLanguage.TabIndex = 3;
            // 
            // labelEnterDfaCharacters
            // 
            this.labelEnterDfaCharacters.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEnterDfaCharacters.AutoSize = true;
            this.labelEnterDfaCharacters.Location = new System.Drawing.Point(26, 61);
            this.labelEnterDfaCharacters.Name = "labelEnterDfaCharacters";
            this.labelEnterDfaCharacters.Size = new System.Drawing.Size(254, 13);
            this.labelEnterDfaCharacters.TabIndex = 5;
            this.labelEnterDfaCharacters.Text = "Enter the language characters (separated by Space)";
            // 
            // labelEnterStateNames
            // 
            this.labelEnterStateNames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEnterStateNames.AutoSize = true;
            this.labelEnterStateNames.Location = new System.Drawing.Point(26, 87);
            this.labelEnterStateNames.Name = "labelEnterStateNames";
            this.labelEnterStateNames.Size = new System.Drawing.Size(251, 13);
            this.labelEnterStateNames.TabIndex = 6;
            this.labelEnterStateNames.Text = "Enter the names of the States (seperated by Space)";
            // 
            // textBoxStates
            // 
            this.textBoxStates.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.helpProvider1.SetHelpString(this.textBoxStates, "Enter individual state name (separated by space, comma, or dot).");
            this.textBoxStates.Location = new System.Drawing.Point(287, 84);
            this.textBoxStates.Name = "textBoxStates";
            this.helpProvider1.SetShowHelp(this.textBoxStates, true);
            this.textBoxStates.Size = new System.Drawing.Size(280, 20);
            this.textBoxStates.TabIndex = 4;
            // 
            // buttonClearTable
            // 
            this.buttonClearTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClearTable.Enabled = false;
            this.helpProvider1.SetHelpString(this.buttonClearTable, "Clears the entire transition table. Use this, if you want to add, edit, and/or de" +
        "lete states or lanaguage characters.");
            this.buttonClearTable.Location = new System.Drawing.Point(242, 473);
            this.buttonClearTable.Name = "buttonClearTable";
            this.helpProvider1.SetShowHelp(this.buttonClearTable, true);
            this.buttonClearTable.Size = new System.Drawing.Size(164, 23);
            this.buttonClearTable.TabIndex = 7;
            this.buttonClearTable.Text = "Clear Transition Table";
            this.buttonClearTable.UseVisualStyleBackColor = true;
            this.buttonClearTable.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSetInitialState
            // 
            this.buttonSetInitialState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSetInitialState.Enabled = false;
            this.helpProvider1.SetHelpString(this.buttonSetInitialState, "Click on any one of the states in the transition table, and then click on this bu" +
        "tton to select that particular state as your initial state");
            this.buttonSetInitialState.Location = new System.Drawing.Point(29, 409);
            this.buttonSetInitialState.Name = "buttonSetInitialState";
            this.helpProvider1.SetShowHelp(this.buttonSetInitialState, true);
            this.buttonSetInitialState.Size = new System.Drawing.Size(92, 23);
            this.buttonSetInitialState.TabIndex = 8;
            this.buttonSetInitialState.Text = "Set Initial State";
            this.buttonSetInitialState.UseVisualStyleBackColor = true;
            this.buttonSetInitialState.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxTestString
            // 
            this.textBoxTestString.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.helpProvider1.SetHelpString(this.textBoxTestString, "Enter a string to test it according to your entered DFA.");
            this.textBoxTestString.Location = new System.Drawing.Point(142, 559);
            this.textBoxTestString.Name = "textBoxTestString";
            this.helpProvider1.SetShowHelp(this.textBoxTestString, true);
            this.textBoxTestString.Size = new System.Drawing.Size(100, 20);
            this.textBoxTestString.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 562);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter the string to test";
            // 
            // buttonTestString
            // 
            this.buttonTestString.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTestString.Enabled = false;
            this.helpProvider1.SetHelpString(this.buttonTestString, "Enter a string in the text box to test it according to your entered DFA");
            this.buttonTestString.Location = new System.Drawing.Point(248, 557);
            this.buttonTestString.Name = "buttonTestString";
            this.helpProvider1.SetShowHelp(this.buttonTestString, true);
            this.buttonTestString.Size = new System.Drawing.Size(75, 23);
            this.buttonTestString.TabIndex = 11;
            this.buttonTestString.Text = "Test String";
            this.buttonTestString.UseVisualStyleBackColor = true;
            this.buttonTestString.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonSetFinalState
            // 
            this.buttonSetFinalState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSetFinalState.Enabled = false;
            this.helpProvider1.SetHelpString(this.buttonSetFinalState, resources.GetString("buttonSetFinalState.HelpString"));
            this.buttonSetFinalState.Location = new System.Drawing.Point(414, 409);
            this.buttonSetFinalState.Name = "buttonSetFinalState";
            this.helpProvider1.SetShowHelp(this.buttonSetFinalState, true);
            this.buttonSetFinalState.Size = new System.Drawing.Size(92, 23);
            this.buttonSetFinalState.TabIndex = 12;
            this.buttonSetFinalState.Text = "Set Final State";
            this.buttonSetFinalState.UseVisualStyleBackColor = true;
            this.buttonSetFinalState.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkBoxMultiFinal
            // 
            this.checkBoxMultiFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxMultiFinal.AutoSize = true;
            this.checkBoxMultiFinal.Enabled = false;
            this.helpProvider1.SetHelpString(this.checkBoxMultiFinal, "Check this if you want to two or more states as final states.");
            this.checkBoxMultiFinal.Location = new System.Drawing.Point(286, 413);
            this.checkBoxMultiFinal.Name = "checkBoxMultiFinal";
            this.helpProvider1.SetShowHelp(this.checkBoxMultiFinal, true);
            this.checkBoxMultiFinal.Size = new System.Drawing.Size(120, 17);
            this.checkBoxMultiFinal.TabIndex = 13;
            this.checkBoxMultiFinal.Text = "Multiple Final States";
            this.checkBoxMultiFinal.UseVisualStyleBackColor = true;
            this.checkBoxMultiFinal.CheckedChanged += new System.EventHandler(this.checkBoxMultiFinal_CheckedChanged);
            // 
            // buttonClearFinalStates
            // 
            this.buttonClearFinalStates.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClearFinalStates.Enabled = false;
            this.helpProvider1.SetHelpString(this.buttonClearFinalStates, "Clears the list of final states. Use this if you want to change your final states" +
        "\' list.");
            this.buttonClearFinalStates.Location = new System.Drawing.Point(522, 409);
            this.buttonClearFinalStates.Name = "buttonClearFinalStates";
            this.helpProvider1.SetShowHelp(this.buttonClearFinalStates, true);
            this.buttonClearFinalStates.Size = new System.Drawing.Size(102, 23);
            this.buttonClearFinalStates.TabIndex = 14;
            this.buttonClearFinalStates.Text = "Clear Final States";
            this.buttonClearFinalStates.UseVisualStyleBackColor = true;
            this.buttonClearFinalStates.Visible = false;
            this.buttonClearFinalStates.Click += new System.EventHandler(this.button6_Click);
            // 
            // labelFinalStates
            // 
            this.labelFinalStates.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFinalStates.AutoEllipsis = true;
            this.labelFinalStates.AutoSize = true;
            this.labelFinalStates.Location = new System.Drawing.Point(587, 437);
            this.labelFinalStates.Name = "labelFinalStates";
            this.labelFinalStates.Size = new System.Drawing.Size(0, 13);
            this.labelFinalStates.TabIndex = 15;
            this.labelFinalStates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxShowTraverse
            // 
            this.checkBoxShowTraverse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxShowTraverse.AutoSize = true;
            this.helpProvider1.SetHelpString(this.checkBoxShowTraverse, "Select this if you want to view detailed, step-by-step transition as your string " +
        "is being checked according to your entered DFA.");
            this.checkBoxShowTraverse.Location = new System.Drawing.Point(340, 561);
            this.checkBoxShowTraverse.Name = "checkBoxShowTraverse";
            this.helpProvider1.SetShowHelp(this.checkBoxShowTraverse, true);
            this.checkBoxShowTraverse.Size = new System.Drawing.Size(166, 17);
            this.checkBoxShowTraverse.TabIndex = 16;
            this.checkBoxShowTraverse.Text = "Show Step-by-Step Transition";
            this.checkBoxShowTraverse.UseVisualStyleBackColor = true;
            // 
            // labelInitialState
            // 
            this.labelInitialState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInitialState.AutoSize = true;
            this.helpProvider1.SetHelpString(this.labelInitialState, "Displays the name of the state set as initial state.");
            this.labelInitialState.Location = new System.Drawing.Point(36, 437);
            this.labelInitialState.Name = "labelInitialState";
            this.helpProvider1.SetShowHelp(this.labelInitialState, true);
            this.labelInitialState.Size = new System.Drawing.Size(65, 13);
            this.labelInitialState.TabIndex = 17;
            this.labelInitialState.Text = "Initial State: ";
            // 
            // labelFinalState
            // 
            this.labelFinalState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFinalState.AutoSize = true;
            this.helpProvider1.SetHelpString(this.labelFinalState, "Displays the name of the state(s) set as final state(s)");
            this.labelFinalState.Location = new System.Drawing.Point(519, 437);
            this.labelFinalState.Name = "labelFinalState";
            this.helpProvider1.SetShowHelp(this.labelFinalState, true);
            this.labelFinalState.Size = new System.Drawing.Size(63, 13);
            this.labelFinalState.TabIndex = 18;
            this.labelFinalState.Text = "Final State: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tutorialToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tutorialToolStripMenuItem
            // 
            this.tutorialToolStripMenuItem.Name = "tutorialToolStripMenuItem";
            this.tutorialToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.tutorialToolStripMenuItem.Text = "&Tutorial";
            this.tutorialToolStripMenuItem.Click += new System.EventHandler(this.tutorialToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 584);
            this.Controls.Add(this.buttonClearTable);
            this.Controls.Add(this.labelFinalState);
            this.Controls.Add(this.labelInitialState);
            this.Controls.Add(this.checkBoxShowTraverse);
            this.Controls.Add(this.labelFinalStates);
            this.Controls.Add(this.buttonClearFinalStates);
            this.Controls.Add(this.checkBoxMultiFinal);
            this.Controls.Add(this.buttonSetFinalState);
            this.Controls.Add(this.buttonTestString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTestString);
            this.Controls.Add(this.buttonSetInitialState);
            this.Controls.Add(this.labelEnterStateNames);
            this.Controls.Add(this.labelEnterDfaCharacters);
            this.Controls.Add(this.textBoxStates);
            this.Controls.Add(this.textBoxDfaLanguage);
            this.Controls.Add(this.labelEnterTransitionTable);
            this.Controls.Add(this.buttonGenerateTable);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DFA (Deterministic Finite Automata) Machine";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonGenerateTable;
        private System.Windows.Forms.Label labelEnterTransitionTable;
        private System.Windows.Forms.TextBox textBoxDfaLanguage;
        private System.Windows.Forms.Label labelEnterDfaCharacters;
        private System.Windows.Forms.Label labelEnterStateNames;
        private System.Windows.Forms.TextBox textBoxStates;
        private System.Windows.Forms.Button buttonClearTable;
        private System.Windows.Forms.Button buttonSetInitialState;
        private System.Windows.Forms.TextBox textBoxTestString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTestString;
        private System.Windows.Forms.Button buttonSetFinalState;
        private System.Windows.Forms.CheckBox checkBoxMultiFinal;
        private System.Windows.Forms.Button buttonClearFinalStates;
        private System.Windows.Forms.Label labelFinalStates;
        private System.Windows.Forms.CheckBox checkBoxShowTraverse;
        private System.Windows.Forms.Label labelInitialState;
        private System.Windows.Forms.Label labelFinalState;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tutorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

