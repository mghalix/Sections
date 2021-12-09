using System;

namespace Assignment
{
    class Program
    {
        public static void Main(String[] args)
        {

            BankAccount account = new BankAccount(9,12,2021);
            account.AccountNo = 5556442137912941;
            account.AccountOwner = "Mohanad";
            account.Balance =100;
            account.Deposite(50);
            account.Withdraw(100);
            account.Display();

            Console.Read();


        }
    }
    class Date
    {
        int day;
        int month;
        int year;
        public int Day
        {
            get { return day; }
            set
            {
                if (value < 0 || value > 24)
                {
                    day = -1;
                }
                else
                    day = value;
            }
        }
        public int Month
        {
            get { return month; }
            set
            {
                if (value < 0 || value > 31)
                    month = -1;
                else
                    month = value; ;

            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (value < 0 || value > 2022)
                    year = -1;
                else
                    year = value;
            }
        }




        public void Display()
        {
            if (Month == -1 || Year == -1 || Day == -1)
            {
                Console.WriteLine("INVALID DATE");
            }
            else
            {
                Console.Write("{0:00}/{1:00}/{2:0000}",Day, Month, Year);
            }

        }

    }
    class BankAccount
    {
        private long accountNo;

        public long AccountNo
        {
            get { return accountNo; }
            set { accountNo = value; }
        }
        private string accountOwner;

        public string AccountOwner
        {
            get { return accountOwner; }
            set { accountOwner = value; }
        }
        private double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        Date openDate;
        public Date OpenDate
        {
            
            get { return openDate; }
            set { openDate = value; }
        }

        public BankAccount()
        {

        }
        public BankAccount(int day, int month, int year)
        {
            OpenDate = new Date();
            OpenDate.Year = year;
            OpenDate.Month = month;
            OpenDate.Day = day;
            
        }

        public double Deposite(int amount)
        {
            Balance += amount;

            return amount;
        }
        public double Withdraw(int amount)
        {
            Balance -= amount;

            return amount;
        }
        public void Display()
        {
            Console.Write($"Account Owner: {AccountOwner} \nAccount Number: {AccountNo:0000 0000 0000 0000} \nBalance: {Balance} \nOpen Date: ") ;
            OpenDate.Display();
        }
    }
}
