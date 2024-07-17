using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public class MortgageAccount : Account
    {
        public bool WithdrawFromMortgage(decimal amount)
        {
            return false;
        }
    }
}
