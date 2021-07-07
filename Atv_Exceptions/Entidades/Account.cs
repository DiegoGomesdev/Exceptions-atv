using System;
using Atv_Exceptions.Entidades.Exceçoes;
namespace Atv_Exceptions.Entidades
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get;  private set; }
        public double withdrawLimit { get;  private set; }
        public Account()
        {

        }
        public Account(int number, string holder, double balance, double withdrawlimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            withdrawLimit = withdrawlimit;
        }

        public void deposit(double amount)
        {
            Balance += amount;
        }
        public void withdraw(double amount)
        {

            if (amount > withdrawLimit)
            {
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit");
            }
            else if (amount > Balance)
            {
                throw new DomainException("Withdraw error: Not enough balance");
            }
            
            Balance -= amount;
        }
    }
}
