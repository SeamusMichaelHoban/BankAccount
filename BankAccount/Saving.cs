using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Saving : Account //Derived from Account
    {
        public double MinBal { get; set; } //Reqd property as per Pete
        

        public Saving(double bankBal, int acctType)
        {
            this.BankBal = bankBal;
            this.AcctType = acctType;
        }
        public Saving(string acctNum)
        {
            this.AcctNum = acctNum; 
        }
       



    }
}
