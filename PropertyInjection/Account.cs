namespace DemoAccount;

public class Account
{
    public IAccount account { get; set; }
    
    public void PrintAccountInfo()
    {
        account.PrintInfo();
    }
}