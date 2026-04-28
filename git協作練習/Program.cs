// See https://aka.ms/new-console-template for more information
using git協作練習;
using git協作練習.Login;
using System.Reflection;
using git協作練習.Register;

Console.WriteLine("歡迎來到 [XXX 註冊系統]！");
Console.WriteLine("請依照指示完成註冊，讓我們開始吧！");
Console.WriteLine("請輸入您的姓名：");
string userName = Console.ReadLine();

Console.WriteLine("接下來，請輸入您的帳號：");
string account = Console.ReadLine();

Console.WriteLine("請設置一個安全的密碼：");
string password = Console.ReadLine();

Console.WriteLine("最後，請輸入您的聯絡地址，讓我們方便與您保持聯繫：");
string address = Console.ReadLine();
RegisterService service = new RegisterService();
RegistModel user = new RegistModel(userName, account, password, address);

if (service.UserRegist(user))
{
    Console.WriteLine("恭喜您，註冊成功！歡迎加入我們的大家庭！");
}
else
{
    Console.WriteLine("很抱歉，註冊失敗了。請稍後再試，或聯繫我們的客服團隊以獲取協助。");
}

Console.WriteLine("註冊完成！接下來請重新輸入帳號與密碼進行登入。");


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
