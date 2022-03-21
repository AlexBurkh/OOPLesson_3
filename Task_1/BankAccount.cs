using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class BankAccount
    {
        public BankAccount() : this(BankAccountType.debit, default(int)) { }
        public BankAccount(int balance) : this(BankAccountType.debit, balance) { }
        public BankAccount(BankAccountType type) : this(type, default(int)) { }
        public BankAccount(BankAccountType type, int balance)
        {
            _accountNumber = BankAccount.GenerateAccountNumber();
            _accountType = type;
            _balance = balance;
        }


        private static int _lastNumber = 0;
        private int _accountNumber;
        private int _balance;
        private BankAccountType _accountType;

        internal int Number { get { return _accountNumber; } }
        internal int Balance { get { return _balance; } private set { _balance = value; } }
        internal BankAccountType Type
        {
            get
            {
                return _accountType;
            }
            set
            {
                _accountType = value;
            }
        }

        private static int GenerateAccountNumber()
        {
            int num = _lastNumber;
            _lastNumber += 1;
            return num;
        }
        public void AddToBalance(int sum) { Balance += sum; }
        public void TakeFromBalance(int sum)
        {
            if (Balance >= sum)
            {
                Balance -= sum;
            }
        }
    }
}