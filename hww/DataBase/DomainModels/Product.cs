namespace hww.DataBase.DomainModels
{
    public class Product
    {
        public Product()
            : this(default, default, default, default, default)
        {

        }

        public Product(string name, string description, string color, string size, decimal price)
        {
            Id = ++DbContext._productId;
            Name = name;
            Description = description;
            Color = color;
            Size = size;            
            Price = price;
            CreatedAt = DateTime.Now;
        }

            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Color { get; set; }
            public string Size { get; set; }
            public decimal Price { get; set; }


        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
