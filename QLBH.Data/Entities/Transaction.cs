using QLBH.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLBH.Data.Entities
{
    public class Transaction
    {
        public int Id  { set; get; }
        public DateTime TransactionDate { set; get; }
        public int ExternalTransactionId { set; get; }
        public decimal Amount { set; get; }
        public decimal fee { set; get; }
        public decimal Result { set; get; }
        public string Message { set; get; }
        public TransactionStatus Status { set; get; }
        public string Provider { get; set; }
    }
}
