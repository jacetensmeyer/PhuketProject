using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Phuket.Models
{
    public class Setting
    {
        public int SettingID { get; set; }
        public string SettingSharedLayout { get; set; }
        public string SettingPageType { get; set; }


        public virtual ICollection<Page> Pages { get; set; }
    }
}