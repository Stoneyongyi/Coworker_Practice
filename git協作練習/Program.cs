// See https://aka.ms/new-console-template for more information
using git協作練習;
using git協作練習.Login;
using System.Reflection;




Console.Write("請輸入帳號:");
string Account = Console.ReadLine();
Console.Write("請輸入密碼:");
string Password = Console.ReadLine();

LoginModel loginModel = new LoginModel(Account, Password);
LoginService loginService = new LoginService();
loginService.UserLogin(loginModel);
