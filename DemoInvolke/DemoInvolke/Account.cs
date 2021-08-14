using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoInvolke
{
    class Account
    {
        public delegate void doEvent(float money);
        public float balance;
        public event doEvent deposit;
        public event doEvent withdrawal;
        public Account(float Balance)
        {
            this.balance = Balance;
        }
        public void setBalance(float money)
        {
            float amount = money - balance;
            balance = money;
            if (amount > 0)
            {
                deposit.Invoke(amount);
            }
            else if (amount < 0)
            {
                withdrawal.Invoke(-amount);
            }
        }
    }
}
