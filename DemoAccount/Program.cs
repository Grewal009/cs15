using DemoAccount;

Account a1 = new Account(new CurrentAccount());
a1.PrintAccountInfo();

Account a2 = new Account(new SavingAccount());
a2.PrintAccountInfo();