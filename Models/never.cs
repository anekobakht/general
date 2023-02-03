using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pishnahad.Models
{
    public class never
    {
        [Key]
        public Int64 id_never { get; set; }
        //**********************************************************************
        [Display(Name = "کد خطا")]
        [Required(ErrorMessage = "لطفا نام کاربری را وارد نمایید")]
        public Int64 num_khata { get; set; }
        //**********************************************************************
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا نام کاربری را وارد نمایید")]
        public Int64 id_user { get; set; }
        //**********************************************************************
        [Display(Name = "نام و نام خانوادگی بیمار")]
        [Required(ErrorMessage = "لطفا نام و نام خانوادگی بیمار را وارد نمایید")]
        public string demo_bimar_name_never { get; set; }
        //**********************************************************************
        [Display(Name = "جنسیت")]
        [Required(ErrorMessage = "لطفا جنسیت را وارد نمایید")]
        public string demo_jensiat_never { get; set; }
        //**********************************************************************
        [Display(Name = "سن بیمار")]
        [Required(ErrorMessage = "لطفا سن بیمار را وارد نمایید")]
        public Int64 demo_sen_never { get; set; }
        //**********************************************************************
        [Display(Name = "تاریخ مراجعه")]
        [Required(ErrorMessage = "لطفا تاریخ مراجعه را وارد نمایید")]
        public string demo_date_morajee_never { get; set; }
        //**********************************************************************
        [Display(Name = "تاریخ وقوع")]
        [Required(ErrorMessage = "لطفا تاریخ وقوع را وارد نمایید")]
        public string demo_date_voghu_never { get; set; }
        //**********************************************************************
        [Display(Name = "ساعت")]
        [Required(ErrorMessage = "لطفا ساعت را وارد نمایید")]
        public string demo_saat_never { get; set; }
        //**********************************************************************
        [Display(Name = "پیوست اول")]
        public byte[]? peyvast1_never { get; set; }
        //**********************************************************************
        [Display(Name = "نوع فایل پیوست اول")]
        public string? peyvast1_kind_never { get; set; }
        //**********************************************************************
        [Display(Name = "پیوست دوم")]
        public byte[]? peyvast2_never { get; set; }
        //**********************************************************************
        [Display(Name = "نوع فایل پیوست دوم")]
        public string? peyvast2_kind_never { get; set; }
        //**********************************************************************
        [Display(Name = "توضیحات")]
        public string? sharh_never { get; set; }
        //**********************************************************************








      



    }
}
