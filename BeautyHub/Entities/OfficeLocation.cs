using System.ComponentModel.DataAnnotations;

namespace BeautyHub.Entities
{
    public class OfficeLocation
    {
        public int Id { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string MapLink { get; set; }
        [Required]
        public byte[] Image { get; set; }
    }
}