namespace DemoAccount;

public class Account
{
    private IAccount account;

    public Account(IAccount account)
    {
        this.account = account;
    }

    public void PrintAccountInfo()
    {
        account.PrintInfo();
    }
}