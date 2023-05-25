
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Altic_Shaw_Net6_Api.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }

        public string? NameVn { get; set; }

        public string? Name { get; set; }

        public string? Image { get; set; }

        //public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
