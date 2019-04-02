using System;
using System.Collections.Generic;
using System.Text;
using ExeProExecptions.Entities.Exceptions;

namespace ExeProExecptions.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance = Balance += amount;
        }


        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new Exception("Withdraw error: The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new Exception("Withdraw error: Not enough balance");
            }

            Balance = Balance -= amount;
        }
    }
}
