using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassWordHelper__XML.Classes
{
    public class UserAccount
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string LoginAcct { get; set; }
        public string NoteField { get; set; }

        public UserAccount(string username, string password, string loginacct, string notefield)
        {
            UserName = username;
            PassWord = password;
            LoginAcct = loginacct;
            NoteField = notefield;
        }

        public UserAccount() { }

    }
}
