using hww.DataBase.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace hww.DataBase
{
    public class DbContext
    {
        public static int _productId;
        public static int _sliderId;

        public static List<Product> _products = new List<Product>
        {
            new Product("American Marigold", "asd", "white", "L", 23.45M),
            new Product("Black Eyed Susan", "asd", "white", "L", 25.45M),
            new Product("Bleeding Heart", "asd", "white", "L", 30.45M),
            new Product("Bloody Cranesbill", "asd", "white", "L", 45.00M)
        };


        public static List<Slider> _slider = new List<Slider>
        {
            new Slider("Pronia", "With 100% Natural, Organic Plant Shop", 2),
            new Slider("Pronia", "With 100% Natural, Organic Plant Shop", 2),


        };
    }
}
