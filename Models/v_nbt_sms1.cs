using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pishnahad.Models
{
    public class v_nbt_sms1
    {
        //**********************************************************************
        [Display(Name = "بخش")]
        public string bakhsh { get; set; }
        //**********************************************************************
        [Display(Name = "نام بیمار")]
        public string f_name { get; set; }
        //**********************************************************************
        [Display(Name = "نام خانوادگی بیمار")]
        public string l_name { get; set; }
        //**********************************************************************
        [Display(Name = "تاریخ بستری")]
        public string date_bastari { get; set; }
        //**********************************************************************
        [Display(Name = "شناسه")]
        public int id { get; set; }
        //**********************************************************************
        [Key]
        [Display(Name = "کد برگه")]
        public int adm_code { get; set; }
        //**********************************************************************
    }
}
