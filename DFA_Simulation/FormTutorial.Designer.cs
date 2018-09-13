namespace DFA_Simulation
{
    partial class FormTutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTutorial));
            this.labelTutorial = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTutorial
            // 
            this.labelTutorial.AutoEllipsis = true;
            this.labelTutorial.AutoSize = true;
            this.labelTutorial.BackColor = System.Drawing.SystemColors.Window;
            this.labelTutorial.Location = new System.Drawing.Point(1, 1);
            this.labelTutorial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 2);
            this.labelTutorial.Name = "labelTutorial";
            this.labelTutorial.Size = new System.Drawing.Size(426, 494);
            this.labelTutorial.TabIndex = 0;
            this.labelTutorial.Text = resources.GetString("labelTutorial.Text");
            this.labelTutorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTutorial.UseMnemonic = false;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOK.Location = new System.Drawing.Point(338, 506);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormTutorial
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.buttonOK;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(428, 539);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelTutorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTutorial";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "How to use this program --- A Step by Step Guide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTutorial;
        private System.Windows.Forms.Button buttonOK;
    }
}