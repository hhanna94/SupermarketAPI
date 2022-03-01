using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SupermarketAPI.Domain.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        
        public IList<Product> Products { get; set; } = new List<Product>();
    }
}