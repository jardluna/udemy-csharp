using _44Upcasting.Entities;

Account acc1 = new Account(1001, "Maria", 0.0);
SavingsAccount sacc1 = new SavingsAccount(1002, "Jose", 0.0, 0.01);

acc1.Deposito(500.0);
sacc1.Deposito(500.0);

acc1.Saque(50.0);
sacc1.Saque(50.0);

Console.WriteLine("Account: " + acc1.Saldo);
Console.WriteLine("Savings Account: " + sacc1.Saldo);