using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git協作練習.Login
{
    internal class LoginModel
    {
        public string Account { get; set; }
        public string Password { get; set; }



        public LoginModel(string account, string password)
        {
            this.Account = account;
            this.Password = password;

        }

    }
}
