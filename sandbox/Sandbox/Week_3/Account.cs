using System;

namespace Week_3
{
    public class Account
    {
        private List<int> _transactions = new List<int>();

        private int _balance;

        public void Deposit(int amount)
        {
            _transactions.Add(amount);
            // _balance = _balance + amount;
        }

        public void SetBalance()
        {
            _balance = balance;
        }

        public int GetBalance()
        {
            return SetBalance;
        }
    }
}