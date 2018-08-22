using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Checking : Account//Derived from Account
    {
        public Checking(double bankBal, int acctType)
        {
            this.BankBal = bankBal;
            this.AcctType = acctType;
        }

        public Checking(string AcctNum)
        {
            this.AcctNum = AcctNum;
        }

    }
}
