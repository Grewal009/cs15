using DemoAccount;

Account ac = new Account();
ac.account = new SavingAccount();
ac.PrintAccountInfo();

ac.account = new CurrentAccount();
ac.PrintAccountInfo();