namespace PassWordHelper__XML
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteAcctButton = new System.Windows.Forms.Button();
            this.modify_Button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAcctListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAcctListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAcctListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAcctListAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acctFilelabel = new System.Windows.Forms.Label();
            this.acctFileName = new System.Windows.Forms.Label();
            this.acctNameDisplay = new System.Windows.Forms.TextBox();
            this.addAcctButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(0, 78);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(1000, 228);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(654, 228);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(654, 228);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.TabStop = false;
            // 
            // deleteAcctButton
            // 
            this.deleteAcctButton.Location = new System.Drawing.Point(419, 29);
            this.deleteAcctButton.Name = "deleteAcctButton";
            this.deleteAcctButton.Size = new System.Drawing.Size(99, 39);
            this.deleteAcctButton.TabIndex = 7;
            this.deleteAcctButton.TabStop = false;
            this.deleteAcctButton.Text = "Delete Selected Acct";
            this.deleteAcctButton.UseVisualStyleBackColor = true;
            this.deleteAcctButton.Click += new System.EventHandler(this.deleteAcctButton_Click);
            // 
            // modify_Button
            // 
            this.modify_Button.Location = new System.Drawing.Point(303, 29);
            this.modify_Button.Name = "modify_Button";
            this.modify_Button.Size = new System.Drawing.Size(99, 39);
            this.modify_Button.TabIndex = 12;
            this.modify_Button.TabStop = false;
            this.modify_Button.Text = "Modify Selected Acct";
            this.modify_Button.UseVisualStyleBackColor = true;
            this.modify_Button.Click += new System.EventHandler(this.modify_Button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(654, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAcctListToolStripMenuItem,
            this.loadAcctListToolStripMenuItem,
            this.saveAcctListToolStripMenuItem,
            this.saveAcctListAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // newAcctListToolStripMenuItem
            // 
            this.newAcctListToolStripMenuItem.Name = "newAcctListToolStripMenuItem";
            this.newAcctListToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.newAcctListToolStripMenuItem.Text = "New Acct List";
            this.newAcctListToolStripMenuItem.Click += new System.EventHandler(this.newAcctListToolStripMenuItem_Click);
            // 
            // loadAcctListToolStripMenuItem
            // 
            this.loadAcctListToolStripMenuItem.Name = "loadAcctListToolStripMenuItem";
            this.loadAcctListToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.loadAcctListToolStripMenuItem.Text = "Load Acct List";
            this.loadAcctListToolStripMenuItem.Click += new System.EventHandler(this.loadAcctListToolStripMenuItem_Click);
            // 
            // saveAcctListToolStripMenuItem
            // 
            this.saveAcctListToolStripMenuItem.Name = "saveAcctListToolStripMenuItem";
            this.saveAcctListToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.saveAcctListToolStripMenuItem.Text = "Save Acct List";
            this.saveAcctListToolStripMenuItem.Click += new System.EventHandler(this.saveAcctListToolStripMenuItem_Click);
            // 
            // saveAcctListAsToolStripMenuItem
            // 
            this.saveAcctListAsToolStripMenuItem.Name = "saveAcctListAsToolStripMenuItem";
            this.saveAcctListAsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.saveAcctListAsToolStripMenuItem.Text = "Save Acct List As...";
            this.saveAcctListAsToolStripMenuItem.Click += new System.EventHandler(this.saveAcctListAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // acctFilelabel
            // 
            this.acctFilelabel.AutoSize = true;
            this.acctFilelabel.Location = new System.Drawing.Point(12, 51);
            this.acctFilelabel.Name = "acctFilelabel";
            this.acctFilelabel.Size = new System.Drawing.Size(109, 13);
            this.acctFilelabel.TabIndex = 15;
            this.acctFilelabel.Text = "Current Account File: ";
            // 
            // acctFileName
            // 
            this.acctFileName.AutoSize = true;
            this.acctFileName.Location = new System.Drawing.Point(127, 201);
            this.acctFileName.Name = "acctFileName";
            this.acctFileName.Size = new System.Drawing.Size(0, 13);
            this.acctFileName.TabIndex = 16;
            // 
            // acctNameDisplay
            // 
            this.acctNameDisplay.Location = new System.Drawing.Point(127, 48);
            this.acctNameDisplay.Name = "acctNameDisplay";
            this.acctNameDisplay.ReadOnly = true;
            this.acctNameDisplay.Size = new System.Drawing.Size(153, 20);
            this.acctNameDisplay.TabIndex = 17;
            // 
            // addAcctButton
            // 
            this.addAcctButton.Location = new System.Drawing.Point(539, 29);
            this.addAcctButton.Name = "addAcctButton";
            this.addAcctButton.Size = new System.Drawing.Size(99, 39);
            this.addAcctButton.TabIndex = 18;
            this.addAcctButton.TabStop = false;
            this.addAcctButton.Text = "Add New Account";
            this.addAcctButton.UseVisualStyleBackColor = true;
            this.addAcctButton.Click += new System.EventHandler(this.addAcctButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(654, 306);
            this.Controls.Add(this.addAcctButton);
            this.Controls.Add(this.acctNameDisplay);
            this.Controls.Add(this.acctFileName);
            this.Controls.Add(this.acctFilelabel);
            this.Controls.Add(this.modify_Button);
            this.Controls.Add(this.deleteAcctButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 345);
            this.MinimumSize = new System.Drawing.Size(670, 345);
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Password Helper - XML";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource userAccountBindingSource;
        private System.Windows.Forms.Button deleteAcctButton;
        private System.Windows.Forms.Button modify_Button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAcctListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAcctListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAcctListToolStripMenuItem;
        private System.Windows.Forms.Label acctFilelabel;
        private System.Windows.Forms.Label acctFileName;
        private System.Windows.Forms.TextBox acctNameDisplay;
        private System.Windows.Forms.ToolStripMenuItem saveAcctListAsToolStripMenuItem;
        private System.Windows.Forms.Button addAcctButton;
    }
}

