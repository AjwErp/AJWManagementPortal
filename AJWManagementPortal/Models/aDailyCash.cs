using System;
using System.ComponentModel.DataAnnotations;

namespace AJWManagementPortal.Models
{
    public class aDailyCash
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "اکاؤنٹ اقسام")]
        [Required]
        public string Name { get; set; }



        [Display(Name = "تفصیل")]
        [Required]
        public string Description { get; set; }


        [Display(Name = "تاریخ")]
        [Required]
        public DateTime ValueDate { get; set; }

        [Display(Name = " رقم ادا")]
        [Required]
        public float paidAmount { get; set; }
       
        
        [Display(Name = "کلیریڈ رقم")]
        [Required]
        public float clearedAmount { get; set; }

        [Display(Name = "  انکلیریڈ رقم")]
        [Required]
        public float lnClearedAmount { get; set; }

        [Display(Name = "بقایا رقم")]
        [Required]
        public float remainingGained { get; set; }

        [Display(Name = "سرپلس")]
        [Required]
        public float surplus { get; set; }

        [Display(Name = "پرچيسز ر")]
        [Required]
        public string purchaser { get; set; }

        [Display(Name = "آمدن")]
        [Required]
        public float income { get; set; }

        [Display(Name = "آن لائن")]
        [Required]
        public float pOrder { get; set; }

        [Display(Name = "پرچيز آرڈر")]
        [Required]
        public float online { get; set; }

        [Display(Name = "اکاؤنٹنٹ")]
        [Required]
        public float accountant { get; set; }
    }
}
