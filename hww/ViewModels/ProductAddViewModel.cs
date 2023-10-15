using Microsoft.AspNetCore.Mvc;

namespace hww.ViewModels
{
    public class ProductAddViewModel
    {
        public ProductAddViewModel()
        {
            CreatedAt = DateTime.Now;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }


        public DateTime CreatedAt { get; set; }
    }
}
