using System.ComponentModel.DataAnnotations;
namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name = "Urun Id")]
        public int ProductId { get; set; }
        [StringLength(100)]
        [Display(Name = "Urun Adi")]
        [Required(ErrorMessage = "Gerekli alani lütfen doldurun.")]
        public string Name { get; set; } = string.Empty;
        [Required]
        [Range(0, 100000)]
        [Display(Name = "Urun Fiyat")]
        public decimal? Price { get; set; }

        [Display(Name = "Urun Resim")]
        public string Image { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        [Display(Name = "Kategori")]
        [Required]
        public int? CategoryId { get; set; }
    }
}