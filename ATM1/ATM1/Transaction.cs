using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public string CustomerCode { get; set; }
        public string AccountNumber { get; set; }
        public string TransactionType { get; set; }
        public decimal Amount { get; set; }
        public DateTime Timestamp { get; set; }

        public void SaveTransaction()
        {
            // save the transaction to database
        }
    }
}
