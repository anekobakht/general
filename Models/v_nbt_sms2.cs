using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pishnahad.Models
{
    public class v_nbt_sms2
    {

        //**********************************************************************
        [Display(Name = "تعداد")]
        public Int32 count { get; set; }
        //**********************************************************************
        
        [Display(Name = "پزشک")]
        public string? dr_name { get; set; }
        //**********************************************************************
        [Display(Name = "شماره همراه")]
        public string? dr_mobile { get; set; }
        //**********************************************************************
        [Key]
        [Display(Name = "شناسه")]
        public int id { get; set; }
        //**********************************************************************


    }
}
