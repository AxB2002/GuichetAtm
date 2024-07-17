using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public class SavingsAccount : Account
    {
        public void ApplyInterest()
        {
            Balance *= 1.01m; // 1% interest
        }
    }
}
