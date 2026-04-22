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
        public bool UserRegist(RegistModel model)
        {
            UserModel userModel = new UserModel(model.Name,model.Account,model.Password,model.Address,"");
            userModel.Account = model.Account;
            userModel.Password = model.Password;
            SendEmail(model.Account,"帳號註冊認證信","請輸入驗證碼");
            return true;
        }

        public void SendEmail(string account ,string subject,string content)
        {
            Mail.SendEmail(account, subject, content);
        } 






    }
}
