namespace PenTrade.Models
{
    public class CurrentStock
    {
        public int Id { get; set; }
        public int MerchandiseId { get; set; }
        public Merchandise Merchandise { get; set; }
        public double AmountOfMerchandise { get; set; }


        public int CompanyId { get; set; }
        public Company Company { get; set; }

    }
}
