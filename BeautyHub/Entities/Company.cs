using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeautyHub.Entities
{
    public class Company
    {
        public Company()
        {
            SocialLink = new List<SocialLink>();
        }
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public byte[] Logo { get; set; }

        public List<SocialLink> SocialLink { get; set; }


    }
}