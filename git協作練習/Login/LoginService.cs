using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using git協作練習.Register;
using git協作練習.Utility;

namespace git協作練習.Login
{
    internal class LoginService
    {

        public bool UserLogin(LoginModel model)
        {
            bool isCanLogin=false;

            if (model.Account == null)
            {
                Console.WriteLine("請輸入帳號");
                return isCanLogin;
            }

            if (model.Password == null)
            {
                Console.WriteLine("請輸入密碼");
                return isCanLogin;
            }
            
            if(model.Account=="Abbie"&model.Password=="123456")
            {
                Mail.SendEmail(model.Account, "登入認證信", "請輸入驗證碼");
                return true;
            }

            
            return false;

        }



    }
}
