using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoInvolke
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Account a = new Account(1000);
            a.deposit += p.doDeposit;
            a.withdrawal += p.doWithdrawal;
            while (true)
            {
                Console.WriteLine("Enter money: ");
                float money = float.Parse(Console.ReadLine());
                a.setBalance(money);
            }
        }
        //call back
        public void doDeposit(float money)
        {
            Console.WriteLine("Deposit money to bank:" + money);
        }
        public void doWithdrawal(float money)
        {
            Console.WriteLine("Withdrawal money from bank:" + money);
        }
    }
}
