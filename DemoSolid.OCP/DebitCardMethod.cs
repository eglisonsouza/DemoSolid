namespace DemoSolid.OCP
{
    public class DebitCardMethod : IOrderPaymentMethod
    {
        public DebitCardMethod(DebitCardInfo debitCardInfo)
        {
        }

        public void Process()
        {
            throw new NotImplementedException();
        }
    }

    public class DebitCardInfo
    {
    }
}
