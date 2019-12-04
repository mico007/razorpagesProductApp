using System.ComponentModel.DataAnnotations;

namespace ProductsApp.Models
{
    public class Product
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Paste image Url")]
        public string Image { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string Category { get; set; }
    }
}