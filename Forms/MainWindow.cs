using System;
using System.Windows.Forms;
using PassWordHelper__XML.Classes;
using PassWordHelper__XML.Forms;



namespace PassWordHelper__XML
{
    public partial class MainWindow : Form
    {
        public ProcessModel _pm = new ProcessModel();
        public InitialPrompt _init;

        
        
        public MainWindow()
        {
            InitializeComponent();
            this.Show();
            LaunchInitialWindow();
        }

        public void UpdateFilePathDisplay()
        {
            acctNameDisplay.Text = _pm.newFilePath;
        }
        
        public void viewAccountList_Debug()       // only used for debugging
        {
            foreach (UserAccount a in _pm.UserAccountList)   
            {
                Console.WriteLine("Account Info: {0}, {1}, {2}, {3}", a.UserName, a.PassWord, a.LoginAcct, a.NoteField);
            }
        }
        
        public void addAccounts()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Username";
            dataGridView1.Columns[1].Name = "Password";
            dataGridView1.Columns[2].Name = "Login Account";
            dataGridView1.Columns[3].Name = "Notes";
            try
            {
                foreach (UserAccount b in _pm.UserAccountList)
                {
                    string[] dataRow = { b.UserName, b.PassWord, b.LoginAcct, b.NoteField };
                    dataGridView1.Rows.Add(dataRow);
                }
            }
            catch
            {
                MessageBox.Show("Error Loading Accounts", "Accounts Not Loaded");
            }

        }
        
        private void deleteAcctButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount > 0)
                {
                    if (MessageBox.Show("Are you sure you want to delete?", "Confirm", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        {
                            _pm.UserAccountList.RemoveAt(row.Index);
                            dataGridView1.Rows.RemoveAt(row.Index);
                        }

                    }
                    _pm.writeXML_file(_pm.activeFilePath);
                    _pm.generateDatafromXML(_pm.activeFilePath);

                }
                else
                {
                    MessageBox.Show("No Account Selected", "Error Deleting Account");
                }
                
            }
            catch
            {
                MessageBox.Show("Problem Deleting Account", "Error Deleting Account");
            }
            
            
        }

        private void modify_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int modifyIndex = row.Index;
                    UserAccount modifiedUserAcct;
                    modifiedUserAcct = new UserAccount(
                        _pm.UserAccountList[modifyIndex].UserName,
                        _pm.UserAccountList[modifyIndex].PassWord,
                        _pm.UserAccountList[modifyIndex].LoginAcct,
                        _pm.UserAccountList[modifyIndex].NoteField
                        );
                    
                    _pm.UserAccountList.RemoveAt(modifyIndex);
                    addAccounts();
                    LaunchModifyWindow(modifiedUserAcct);
                    
                }
            }
            else
            {
                MessageBox.Show("No Account Selected", "Error Modifying Account");
            }
            
            
        }

        private void LaunchInitialWindow()
        {
            InitialPrompt _init = new InitialPrompt();

            if (_init.ShowDialog() == DialogResult.No)  // load an existing list
            {
                _pm.loadAccountFile();
                _pm.generateDatafromXML(_pm.activeFilePath);
                addAccounts();
                UpdateFilePathDisplay();
            }
            
        }

        private void LaunchModifyWindow(UserAccount modified_account)
        {
            ModifyAccount _modify = new ModifyAccount();
            _modify.PopulateAccountInfo(modified_account);
            UserAccount backupCopy = new UserAccount();
            backupCopy = modified_account;
            

            if (_modify.ShowDialog() == DialogResult.OK)
            {
                modified_account = _modify.mod_acct;
                _pm.UserAccountList.Add(modified_account);
                addAccounts();
            }
            else
            {
                _pm.UserAccountList.Add(backupCopy);
                addAccounts();
                _modify.Close();
            }
            
        }

        private void loadAcctListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _pm.loadAccountFile();
            _pm.generateDatafromXML(_pm.activeFilePath);
            addAccounts();
            UpdateFilePathDisplay();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (MessageBox.Show("Do you want to save before exit?", "Save Account List?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ConditionalFileSave();
                    Application.Exit();
                }
                else
                {
                    Application.Exit();
                }

            }
            else
            {
                Application.Exit();
            }
        }
            
        public void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Password Helper Version 2.0 \n\nReleased February 2018\n\n\nCreated by: \n\n         JMiller", "About Password Helper");
        }

        
        private void saveAcctListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConditionalFileSave();
        }

        private void newAcctListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAcctList();
        }

        public void NewAcctList()
        {
            _pm.activeFilePath = null;
            _pm.UserAccountList.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows.Clear();
            }
            
            _pm.newFilePath = "";
            UpdateFilePathDisplay();
        }

        public void SaveAcctFile()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                _pm.saveAccountList();
            }
            else
            {
                MessageBox.Show("No Account Data Entered", "Error Saving Account");
            }

            UpdateFilePathDisplay();
            
        }

        public void ConditionalFileSave()
        {
            //   Ask if a file is currently loaded it saves to that.  Otherwise new save file dalog opens
            if (_pm.activeFilePath == null)
            {
                SaveAcctFile();
            }
            else
            {
                _pm.writeXML_file(_pm.activeFilePath);
                MessageBox.Show("File Successfully Saved", "Data Saved");
            }
        }

        private void saveAcctListAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAcctFile();
        }

        private void addAcctButton_Click(object sender, EventArgs e)
        {
            ModifyAccount new_Acct = new ModifyAccount();
            
            if (new_Acct.ShowDialog() == DialogResult.OK)
            {
                
                _pm.UserAccountList.Add(new_Acct.mod_acct);
                addAccounts();
            }
            else
            {
                new_Acct.Close();
            }
        }
    }
}
