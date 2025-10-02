using _44Upcasting.Entities;

Console.WriteLine("----------------------------------------------------------------");

Account acc = new Account(1001, "Alex", 0.0);
BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);
SavingsAccount sacc = new SavingsAccount(1003, "Theo", 0.0, 0.02);

//UPCASTING
Account acc1 = bacc;
Account acc2 = sacc;
Account acc3 = new BusinessAccount(1004, "Bob", 0.0, 200.0);
Account acc4 = new SavingsAccount(1005, "Lucas", 0.0, 0.01);

//DOWNCASTING
BusinessAccount bacc1 = acc3 as BusinessAccount; //Ou BusinessAccount bacc1 = (BusinessAccount)acc3; -> Ambas formas de fazer um Casting
bacc1.Emprestimo(100.0);

SavingsAccount sacc1 = acc4 as SavingsAccount; //Ou SavingsAccount sacc1 = (SavingsAccount)acc4; -> Ambas formas de fazer um Casting
sacc1.AtualizarSaldo();

//Testa se o acc4 é um BusinessAccount -> FALSE
if (acc4 is BusinessAccount)
{
    BusinessAccount bacc2 = (BusinessAccount)acc4;
}

//Testa se o acc3 é um SavingsAccount -> FALSE
if (acc3 is SavingsAccount)
{
    SavingsAccount sacc2 = (SavingsAccount)acc3;
}

//Testa se o acc4 é um SavingsAccount -> TRUE
if (acc4 is SavingsAccount)
{
    SavingsAccount sacc2 = (SavingsAccount)acc4;
    sacc2.AtualizarSaldo();
    Console.WriteLine("Saldo Atualizado!");
}

//Testa se o acc3 é um BusinessAccount -> TRUE
if (acc3 is BusinessAccount)
{
    BusinessAccount bacc2 = (BusinessAccount)acc3;
    bacc2.Emprestimo(200.0);
    Console.WriteLine(bacc2.Saldo);
}

Console.WriteLine("----------------------------------------------------------------");