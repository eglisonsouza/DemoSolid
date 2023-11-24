namespace DemoSolid.OCP
{
    public class PaymentMethodController
    {
        public readonly PaymentService paymentService;

        public PaymentMethodController()
        {
            paymentService = new PaymentService();
        }

        public void PayCreditMethod(CreditCardInfo creditCardInfo)
        {
            paymentService.Process(new CreditCardMethod(creditCardInfo));
        }

        public void PayDebitMethod(DebitCardInfo debitCardInfo)
        {
            paymentService.Process(new DebitCardMethod(debitCardInfo));
        }

        public void PayLoyaltyPointstMethod(OrderPaymentInfo paymentInfo)
        {
            paymentService.Process(new LoyaltyPointsMethod(paymentInfo));
        }
    }
}
