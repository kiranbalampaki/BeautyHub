using System;
using System.ComponentModel.DataAnnotations;

namespace BeautyHub.Entities
{
    public class ServiceTime
    {
        public int Id { get; set; }
        [Required]
        public DateTime Time { get; set; }
    }
}