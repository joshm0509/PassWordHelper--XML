namespace PassWordHelper__XML.Forms
{
    partial class InitialPrompt
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
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadExisting_button = new System.Windows.Forms.Button();
            this.CreateNewbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do you want to load an existing account list ";
            // 
            // LoadExisting_button
            // 
            this.LoadExisting_button.Location = new System.Drawing.Point(31, 77);
            this.LoadExisting_button.Name = "LoadExisting_button";
            this.LoadExisting_button.Size = new System.Drawing.Size(68, 36);
            this.LoadExisting_button.TabIndex = 1;
            this.LoadExisting_button.Text = "Load Existing";
            this.LoadExisting_button.UseVisualStyleBackColor = true;
            this.LoadExisting_button.Click += new System.EventHandler(this.LoadExisting_button_Click);
            // 
            // CreateNewbutton
            // 
            this.CreateNewbutton.Location = new System.Drawing.Point(119, 77);
            this.CreateNewbutton.Name = "CreateNewbutton";
            this.CreateNewbutton.Size = new System.Drawing.Size(68, 36);
            this.CreateNewbutton.TabIndex = 2;
            this.CreateNewbutton.Text = "Create New List";
            this.CreateNewbutton.UseVisualStyleBackColor = true;
            this.CreateNewbutton.Click += new System.EventHandler(this.CreateNewbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "or create a new one from scratch?";
            // 
            // InitialPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(266, 138);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CreateNewbutton);
            this.Controls.Add(this.LoadExisting_button);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(150, 50);
            this.Name = "InitialPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Open Accounts?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadExisting_button;
        private System.Windows.Forms.Button CreateNewbutton;
        private System.Windows.Forms.Label label2;
    }
}