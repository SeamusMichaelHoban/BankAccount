using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public abstract class Account
    {
        public string AcctNum { get; set; }
        public double BankBal { get; set; }
        public int AcctType { get; set; }
        public double IntrestRate { get; set; }
        public double AddMoney { get; set; }
        public double MinusMoney { get; set; }
        public int Counter { get; set; }

        public Account()
        {
            //Default Ctor
        }

        public double Deposit() //Deposit Method
        {
            BankBal = BankBal + AddMoney;
            return BankBal;
        }

        public double Withdrawl() //Withdrawl Method
        {
            BankBal = BankBal - MinusMoney;
            return BankBal;
        }

        public int GetCounter()
        {
            if (Counter < 3)
            {
                Counter++;
                return Counter;
            }
            else
            {
                Counter = 1;
                return Counter;
            }
        }

        public virtual void SetInterest(int acctType)
        {
            GetCounter();
            if (acctType == 1 && Counter == 3)
            {
                BankBal = BankBal * (1 + .05);
                //Console.WriteLine("interest paid");
            }
            else if (acctType == 2 && Counter == 3)
            {
                BankBal = BankBal * (1 + .10);
                //Console.WriteLine("interest paid");
            }


        }
    }       
}
