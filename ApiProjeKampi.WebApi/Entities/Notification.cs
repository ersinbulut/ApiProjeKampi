using System.ComponentModel.DataAnnotations;

namespace ApiProjeKampi.WebApi.Entities
{
    public class Notification
    {
        [Key]
        public int NotificationId { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
        public DateTime NotificationDate { get; set; }
        public bool IsRead { get; set; }
    }
}
