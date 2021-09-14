using System;

namespace Bank
{
    public class BankAccount
    {
        public const string DebitAmountExceedsBalanceMessage = "Debit amount exceeds Balance";
        public const string DebitAmountLessThanZeroMessage = "Debit amount less than 0";

        private readonly string m_customerName;
        private double m_balance;
        private BankAccount() { }

        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }
        public string CustomerName
        {
            get { return m_customerName; }
        }

        public double Balance
        {
            get { return m_balance; }
        }
        public void Debit(double amount)
        {
            if(amount>m_balance)
            {
                throw new System.ArgumentOutOfRangeException("amount",amount,DebitAmountExceedsBalanceMessage);
            }
            if(amount<0)
            {
                throw new ArgumentOutOfRangeException("ammount",amount,DebitAmountLessThanZeroMessage);
            }
            m_balance -= amount;
        }
        public void Credit(double amount)
        {
            if(amount<0)
            {
                throw new ArgumentOutOfRangeException("ammount");
            }

        }
        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr. Bylan Walton", 11.99);
            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is  ${0}", ba.Balance);


        }
    }

}
