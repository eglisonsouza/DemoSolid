namespace DemoSolid.OCP
{
    public class PaymentService
    {
        public void Process(IOrderPaymentMethod paymentMethod)
        {
            paymentMethod.Process();
        }
    }    
}
