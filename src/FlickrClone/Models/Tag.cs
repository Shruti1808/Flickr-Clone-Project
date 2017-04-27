using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlickrClone.Models
{
    [Table("Tags")]
    public class Tag
    {

        [Key]
        public int TagId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ImageTag> ImageTags { get; set; }

        public virtual ApplicationUser User { get; set; }

    }
}
