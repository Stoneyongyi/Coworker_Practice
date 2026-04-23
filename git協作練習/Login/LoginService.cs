using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git協作練習.Login
{
    internal class LoginService
    {

        public bool UserLogin(LoginModel model)
        {
            UserModel user = new UserModel();
            user.Account = model.Account;
            user.Password = model.Password;

            bool isAccountOk = (model.Account == user.Account);
            bool isPasswordOk = (model.Password == user.Password);

            if (model.Account != null)
            {
                isAccountOk = true;

            }
            else
            {
                Console.WriteLine("請輸入帳號");
            }

            if (model.Password != null)
            {
                isPasswordOk = true;
            }
            else
            {
                Console.WriteLine("請輸入密碼");
            }


            return true;

        }










    }
}
