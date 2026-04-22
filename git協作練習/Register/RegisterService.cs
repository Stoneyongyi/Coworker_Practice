namespace git協作練習.Register;

public class RegisterService
{
    public bool UserRegist(RegistModel model)
    {
        UserModel userModel = new UserModel();
        userModel.Account = model.Account;
        userModel.Password = model.Password;
        return true;
    }
}