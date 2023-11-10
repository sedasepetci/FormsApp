using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Category
    {
        [Display(Name = "Kategori Id")]
        public int CategoryId { get; set; }
        [Display(Name = "Kategori Adi")]
        public string Name { get; set; } = string.Empty;
    }
}