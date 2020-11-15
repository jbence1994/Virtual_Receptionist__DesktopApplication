namespace virtual_receptionist.Models
{
    public class BillingItem
    {
        public string Name { get; set; }
        public BillingItemCategory Category { get; set; }
        public double Price { get; set; }
    }
}
