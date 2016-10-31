using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Phuket.Models
{
    public class MediaItem
    {
        public int MediaItemID { get; set; }
        public string MediaItemURL { get; set; }
        public bool MediaItemActive { get; set; }
        public int MediaItemHeight { get; set; }
        public int MediaItemWidth { get; set; }
        public string MediaItemShortDescription { get; set; }
        public string MediaItemLongDescription { get; set; }
        public int MediaCategoryID { get; set; }

        public virtual ICollection<ContentBlock> ContentBlocks { get; set; }
        public virtual MediaCategory MediaCategories { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}