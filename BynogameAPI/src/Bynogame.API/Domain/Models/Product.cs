namespace BYNOGAME.API.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short Fiyat { get; set; }
        public EKaliteturu Kaliteturu { get; set; }
        public int CategoryId { get; set; }
        public string URL { get; set; }
        public Category Category { get; set; }

    }
}