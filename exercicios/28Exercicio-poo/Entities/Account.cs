using _28Exercicio_poo.Entities.Exceptions;
using System.Globalization;

namespace _28Exercicio_poo.Entities
{
    public class Account
    {
        public int Number { get; private set; }
        public string? Holder { get; private set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }

        public Account() { }
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            if (withdrawLimit > balance) {
                throw new DomainException ("The withdraw limit cannot exceed the initial balance.");
            }

            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }
            Balance -= amount;
        }

        public override string ToString()
        {
            return "New balance: $" + Balance.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
