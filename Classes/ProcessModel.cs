using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassWordHelper__XML.Classes;
using PassWordHelper__XML.Forms;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO;

namespace PassWordHelper__XML.Classes
{
    public class ProcessModel
    {
        public List<UserAccount> UserAccountList = new List<UserAccount>();
        public List<UserAccount> ModifyList = new List<UserAccount>();
        public string activeFilePath;
        public string newFilePath;
        

        public void createNewAcct(UserAccount userAccount)
        {
            if (userAccount.UserName.Length != 0)
            {
                UserAccountList.Add(userAccount);  // adds new account to UserAccounts list, if username is filled out
            }
            else
            {
                MessageBox.Show("No Account Data Entered", "Error Adding Account");
            }
            
        }

        public void writeXML_file(string writeAcct)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<UserAccount>));
                using (TextWriter tw = new StreamWriter(writeAcct))
                {
                    serializer.Serialize(tw, UserAccountList);
                }
            }
            catch
            {
                MessageBox.Show("Problem Writing File", "File Write Error");
            }

        }

        public void generateDatafromXML(string readAcct)
        {
            try
            {
                XmlSerializer serializer2 = new XmlSerializer(typeof(List<UserAccount>));
                using (FileStream fs = File.Open(readAcct, FileMode.OpenOrCreate))
                {
                    UserAccountList = (List<UserAccount>)serializer2.Deserialize(fs);
                }
            }
            catch
            {
                MessageBox.Show("Problem Reading File", "File Read Error");
            }
            

        }

        public void saveAccountList()
        {
            if (newFilePath == "")
            {
                SaveFileDialog saveAcctFile = new SaveFileDialog();
                saveAcctFile.Filter = "XML Files (*.xml)|*.xml";

                if (saveAcctFile.ShowDialog() == DialogResult.OK)
                {
                    writeXML_file(saveAcctFile.FileName);
                    newFilePath = Path.GetFileNameWithoutExtension(saveAcctFile.FileName);
                }

            }
            else
            {
                SaveFileDialog saveAcctFile = new SaveFileDialog();
                saveAcctFile.FileName = newFilePath;
                saveAcctFile.Filter = "XML Files (*.xml)|*.xml";
                if (saveAcctFile.ShowDialog() == DialogResult.OK)
                {
                    writeXML_file(saveAcctFile.FileName);
                    newFilePath = Path.GetFileNameWithoutExtension(saveAcctFile.FileName);
                    
                }
            }
            
        }
        
        public void loadAccountFile()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "XML Files (*.xml)|*.xml";

                    activeFilePath = openFileDialog.FileName;
                    newFilePath = openFileDialog.SafeFileName;
                }

            }
            catch
            {
                MessageBox.Show("Problem Loading Accounts", "Account Load Error");
            }
            
        }


    } 
}
