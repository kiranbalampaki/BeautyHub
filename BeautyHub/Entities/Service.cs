using System.ComponentModel.DataAnnotations;

namespace BeautyHub.Entities
{
    public class Service
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public byte[] Image { get; set; }



        public Category Category { get; set; }
        public int CategoryId { get; set; }

    }
}