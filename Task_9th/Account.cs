using System;
using System.Collections.Generic;
using System.Text;

namespace Task_9th
{
    class Account
    {
       

            private string accName;
            private string acid;
            private int balance;

            public string AccName
            {
                get { return accName; }
                set { accName = value; }

            }
            public string Acid
            {
                get { return acid; }
                set { acid = value; }
            }

            public int Balance
            {
                get { return balance; }
                set { balance = value; }
            }


            public void Deposit(int amount)
            {
                balance += amount;
            }
            public void WithDraw(int amount)
            {
                balance -= amount;
            }
            public void Transfer(int amount)
            {
                balance += amount;
            }
            public Account()
            {
                accName = "Adittya Chakraborty";
                acid = "18-386939";
                balance = 1000;
            }
            public Account(string accName, string acid, int balance)
            {
                this.accName = accName;
                this.acid = acid;
                this.balance = balance;
            }
        
    }
}
