using System;
using System.Collections.Generic;

namespace AJWManagementPortal.Models
{
    public class TransAndBank
    {
        public List<BankBalane> Bank1 = new List<BankBalane>();
        public List<MeezanBankIEReport> Bank2 = new List<MeezanBankIEReport>();
        public List<aDailyCash> aDailyCashes = new List<aDailyCash>();
        public DateTime date { get; set; }
        public bool hide { get; set; }
        public MeezanBankIEVoucher meezanVoucher = new MeezanBankIEVoucher();
    }
}
