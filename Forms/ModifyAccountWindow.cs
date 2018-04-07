using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassWordHelper__XML.Forms;
using PassWordHelper__XML.Classes;

namespace PassWordHelper__XML
{
    public partial class ModifyAccount : Form
    {
        public UserAccount mod_acct;
        public ProcessModel _pm;

        public ModifyAccount()
        {
            InitializeComponent();
        }


        public void PopulateAccountInfo(UserAccount modifiedAcct)
        {
            username_box.Text = modifiedAcct.UserName;
            password_box.Text = modifiedAcct.PassWord;
            user_acct_box.Text = modifiedAcct.LoginAcct;
            note_field.Text = modifiedAcct.NoteField;
        }

        private void clearFormButton_Click(object sender, EventArgs e)
        {
            username_box.Text = "";
            password_box.Text = "";
            user_acct_box.Text = "";
            note_field.Text = "";
            
        }

        private void addAcctButton_Click(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.OK;
            
            mod_acct = new UserAccount(username_box.Text, password_box.Text, user_acct_box.Text, note_field.Text);
            //_pm.UserAccountList.Add(mod_acct);
            
            //_pm.createNewAcct(mod_acct);

            //foreach (UserAccount ua in _pm.UserAccountList)
            //{
            //    Console.WriteLine("After Adding:  " + ua.UserName);
            //}

            Close();
        }
    }
}
