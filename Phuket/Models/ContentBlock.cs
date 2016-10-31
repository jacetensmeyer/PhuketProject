using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Phuket.Models
{
    public class ContentBlock
    {
        public int ContentBlockID { get; set; }
        public string ContentBlockHeaderTitle { get; set; }
        public string ContentBlockSummary { get; set; }
        public bool ContentBlockParentContentBlock { get; set; }
        public int? ParentContentBlockID { get; set; }

        public virtual Page Page { get; set; }
        public virtual ICollection<ContentBlock> ContentBlocks { get; set; }
        public virtual ICollection<MediaItem> MediaItems { get; set; }
    }
}