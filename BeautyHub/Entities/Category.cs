using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeautyHub.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public byte[] Image { get; set; }

        public List<Service> Services { get; set; }
    }
}