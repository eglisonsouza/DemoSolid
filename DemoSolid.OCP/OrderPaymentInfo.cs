namespace DemoSolid.OCP
{
    public class OrderPaymentInfo
    {
        public Guid OrderId { get; set; }
        public decimal TotalPrice { get; set; }
        public PaymentType Type { get; set; }
    }

    public enum PaymentType
    {
        Credit = 0,
        Debit = 1,
        LoyaltyPoints = 2
    }
}
