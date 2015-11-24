using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2_errorhandlingAndObjects
{
    class Program
    {
        public class BankAccount
        {
            public string accountName;
            private int balance;

            public int GetBalance()
            {
                return balance;
            }

            public void setBalance(int mBalance)
            {
                balance = mBalance;
            }
        }
        static void Main(string[] args)
        {
            BankAccount bank = new BankAccount();
            bank.accountName = "Student saver";
            bank.setBalance(5);
			System.Console.WriteLine(5.GetType()) //print out Int
            System.Console.WriteLine(bank.GetBalance());
            System.Console.ReadLine();

        }
    }
}
