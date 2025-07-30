using System.ComponentModel.DataAnnotations;

namespace ApiProjeKampi.WebApi.Entities
{
    public class Image
    {
        [Key]
        public int ImageId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
    }
}
