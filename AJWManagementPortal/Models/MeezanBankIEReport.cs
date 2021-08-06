using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class MeezanBankIEReport
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "تاریخ")]
        [Required]
        public DateTime ValueDate { get; set; }


        [Display(Name = "تفصیل")]
        [Required]
        public string Description { get; set; }


        [Display(Name = "c-No|D-slip|Oline")]
        [Required]
        public string CDO { get; set; }



        [Display(Name = " Debit")]
        [Required]
        public float Debit { get; set; }


        [Display(Name = "Cradit")]
        [Required]
        public float Cradit { get; set; }

        [Display(Name = "Balance")]
        [Required]
        public float Balance { get; set; }

        //sign img for CEO
       public string Imgceo { get; set; }

        //sign img for GM
        public string Imggm { get; set; }

        //sign img for DGM
        public string Imgdgm { get; set; }

        //sign img for Account mananger
        public string Imgam { get; set; }

     
    }
}
