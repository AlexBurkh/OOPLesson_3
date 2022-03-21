using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount1 = new BankAccount(3000);
            BankAccount bankAccount2 = new BankAccount();
            bankAccount2.TopUpBalanceFromAnotherAccount(bankAccount1, 1000);
        }
    }
}
