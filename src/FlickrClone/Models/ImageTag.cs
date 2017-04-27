using System.ComponentModel.DataAnnotations.Schema;

namespace FlickrClone.Models
{
    public class ImageTag
    {
        [ForeignKey("Image")]
        public int ImageId { get; set; }
        public Image Image { get; set; }

        [ForeignKey("Tag")]
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}