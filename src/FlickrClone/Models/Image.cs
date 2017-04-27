using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace FlickrClone.Models
{
    [Table("Images")]
    public class Image
    {
        [Key]
        public int ImageId { get; set; }
        public string URL { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime Today { get; set; } = DateTime.Now;
        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<ImageTag> ImageTags { get; set; }
    }
}
