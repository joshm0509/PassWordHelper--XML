using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassWordHelper__XML.Classes;
using PassWordHelper__XML.Forms;
using PassWordHelper__XML;

namespace PassWordHelper__XML.Forms
{
    public partial class InitialPrompt : Form
    {
        public InitialPrompt()
        {
            InitializeComponent();

            // Window Prompt to Create New Acct or Load Existing
        }

        public void LoadExisting_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        public void CreateNewbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        

    }
}
