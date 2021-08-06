using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class MeezanBankIEVoucher
    {
        [Key]
        public int Id { get; set; }
        public DateTime dateTime { get; set; }
        public String checkNumber { get; set; }
        public String amount { get; set; }
        public String purpose { get; set; }

        public String description { get; set; }
    }
}
