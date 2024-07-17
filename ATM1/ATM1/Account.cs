using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public abstract class Account
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }


        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public virtual void Withdraw(decimal amount)
        {
			Balance -= amount;
		}

        public decimal GetBalance()
        {
            return Balance;
        }
    }

}
