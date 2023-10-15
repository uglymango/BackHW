namespace hww.DataBase.DomainModels
{
    public class Slider
    {
        public Slider (string title, string description, int order)
        {
            Id = ++DbContext._sliderId;
            Title = title; 
            Description = description; Order = order;
        }
        
        
        public int Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public int Order { get; set; }
         public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        
    }
}
