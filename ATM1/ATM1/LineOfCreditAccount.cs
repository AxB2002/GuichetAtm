using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public class LineOfCreditAccount : Account
    {
        public void IncreaseBalance(decimal amount)
        {
            Balance += amount;
        }
    }
}
