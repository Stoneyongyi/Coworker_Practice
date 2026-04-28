// See https://aka.ms/new-console-template for more information
using git協作練習;
using git協作練習.Login;
using System.Reflection;

bool userLogin = false;
while (userLogin == false)
{
    Console.Write("請輸入帳號:");
    string Account = Console.ReadLine();
    Console.Write("請輸入密碼:");
    string Password = Console.ReadLine();
    LoginModel loginModel = new LoginModel(Account, Password);
    LoginService loginService = new LoginService();
    userLogin = loginService.UserLogin(loginModel);
    Console.WriteLine("登入失敗,請重新登入");
    if (userLogin == true)
    {
        Console.WriteLine("歡迎進入圖書管理系統");
        break;
    }
}
