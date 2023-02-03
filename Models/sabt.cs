using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace general.Models
{
    public class sabt
    {
        [Key]
        public Int64 id { get; set; }
        //**********************************************************************
        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا نام را مشخص نمایید")]
        public string fname { get; set; }
        //**********************************************************************
        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "لطفا نام خانوادگی را وارد نمایید")]
        public string lname { get; set; }
        //**********************************************************************
        [Display(Name = "کد ملی")]
        [Required(ErrorMessage = "لطفا کد ملی را وارد نمایید")]
        public string meli { get; set; }
        //**********************************************************************
        [Display(Name = "شماره تماس")]
        [Required(ErrorMessage = "لطفا کلمه عبور را وارد نمایید")]
        public string phone { get; set; }
        //**********************************************************************
        [Display(Name = "شرح پیشنهاد")]
        [Required(ErrorMessage = "لطفا شرح پیشنهاد را وارد نمایید")]
        public string matn { get; set; }
        //**********************************************************************


    }
}
