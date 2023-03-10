using System.ComponentModel.DataAnnotations;

namespace Entites.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public String? CategoryName { get; set; }

        // Ref : Collection navigation property
        //public ICollection<Book> Books { get; set; }
    }
}
