namespace git協作練習;

public class UserModel
{
    public string UserName { get; set; }
    public string Account { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }

    public UserModel(string userName, string account, string password, string phone, string address)
    {
        UserName = userName;
        Account = account;
        Password = password;
        Phone = phone;
        Address = address;
    }

    public UserModel(string account, string password)
    {
        Account = account;
        Password = password;
    }
}