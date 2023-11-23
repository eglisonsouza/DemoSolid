namespace DemoSolid.OCP
{
    public class CreditCardMethod : IOrderPaymentMethod
    {
        public CreditCardMethod(CreditCardInfo cardPaymentInfo)
        {
        }

        public void Process()
        {
            throw new NotImplementedException();
        }
    }

    public class CreditCardInfo
    {
    }
}
