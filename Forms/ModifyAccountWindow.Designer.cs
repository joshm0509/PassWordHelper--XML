namespace PassWordHelper__XML
{
    partial class ModifyAccount
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
            this.user_acct_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.username_box = new System.Windows.Forms.TextBox();
            this.account_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.note_field = new System.Windows.Forms.TextBox();
            this.clearFormButton = new System.Windows.Forms.Button();
            this.addAcctButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_acct_box
            // 
            this.user_acct_box.Location = new System.Drawing.Point(76, 88);
            this.user_acct_box.Name = "user_acct_box";
            this.user_acct_box.Size = new System.Drawing.Size(144, 20);
            this.user_acct_box.TabIndex = 3;
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(76, 58);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(144, 20);
            this.password_box.TabIndex = 2;
            // 
            // username_box
            // 
            this.username_box.Location = new System.Drawing.Point(76, 30);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(144, 20);
            this.username_box.TabIndex = 1;
            // 
            // account_label
            // 
            this.account_label.AutoSize = true;
            this.account_label.Location = new System.Drawing.Point(23, 91);
            this.account_label.Name = "account_label";
            this.account_label.Size = new System.Drawing.Size(47, 13);
            this.account_label.TabIndex = 8;
            this.account_label.Text = "Account";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(17, 61);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(53, 13);
            this.password_label.TabIndex = 6;
            this.password_label.Text = "Password";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(17, 33);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(55, 13);
            this.username_label.TabIndex = 4;
            this.username_label.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Notes:";
            // 
            // note_field
            // 
            this.note_field.Location = new System.Drawing.Point(20, 140);
            this.note_field.Multiline = true;
            this.note_field.Name = "note_field";
            this.note_field.Size = new System.Drawing.Size(360, 78);
            this.note_field.TabIndex = 4;
            // 
            // clearFormButton
            // 
            this.clearFormButton.Location = new System.Drawing.Point(241, 30);
            this.clearFormButton.Name = "clearFormButton";
            this.clearFormButton.Size = new System.Drawing.Size(99, 32);
            this.clearFormButton.TabIndex = 5;
            this.clearFormButton.Text = "Clear Form";
            this.clearFormButton.UseVisualStyleBackColor = true;
            this.clearFormButton.Click += new System.EventHandler(this.clearFormButton_Click);
            // 
            // addAcctButton
            // 
            this.addAcctButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.addAcctButton.Location = new System.Drawing.Point(241, 76);
            this.addAcctButton.Name = "addAcctButton";
            this.addAcctButton.Size = new System.Drawing.Size(99, 32);
            this.addAcctButton.TabIndex = 6;
            this.addAcctButton.Text = "Add Account";
            this.addAcctButton.UseVisualStyleBackColor = true;
            this.addAcctButton.Click += new System.EventHandler(this.addAcctButton_Click);
            // 
            // ModifyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 240);
            this.Controls.Add(this.clearFormButton);
            this.Controls.Add(this.addAcctButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.note_field);
            this.Controls.Add(this.user_acct_box);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.account_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(50, -50);
            this.Name = "ModifyAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enter Account Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_acct_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.Label account_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox note_field;
        private System.Windows.Forms.Button clearFormButton;
        private System.Windows.Forms.Button addAcctButton;
    }
}