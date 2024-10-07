using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectA.Models
{
    public class SanPham
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double price { get; set; }
        public string? Describetion { get; set; }
        public string? ImageUrl { get; set; }
        [Required]
        
        [ForeignKey("TheLoai(Id)")]
        public TheLoai TheLoai { get; set; }
    }
}
