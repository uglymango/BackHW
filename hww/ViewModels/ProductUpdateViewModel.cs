namespace hww.ViewModels
{
    public class ProductUpdateViewModel
    {
        public int Id { get; internal set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
    }
}
