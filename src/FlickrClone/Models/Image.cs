using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlickrClone.Models
{
    [Table("Images")]
    public class Image
    {
        public int ImageId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateTaken { get; set; }
    }
}
