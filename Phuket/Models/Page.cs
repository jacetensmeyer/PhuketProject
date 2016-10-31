using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Phuket.Models
{
    public class Page
    {
        public int PageID { get; set; }
        public string PageTitle { get; set; }
        public string PageFileName { get; set; }
        public DateTime PageLastModified { get; set; }
        public string PageAuthor { get; set; }
        public bool PageActive { get; set; }
        public int? PageParentPageID { get; set; }
        public int SettingID { get; set; }


        public virtual Setting Setting { get; set; }
        public virtual ICollection<Page> Pages { get; set; }
        public virtual ICollection<ContentBlock> ContentBlocks { get; set; }
    }
}