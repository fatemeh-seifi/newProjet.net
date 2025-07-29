public class PaymentAdapter:INewPaymentSystem{
    private readonly OldPaymentSystem _OldPaymentSystem;
    public PaymentAdapter(OldPaymentSystem oldPaymentSystem){
        _OldPaymentSystem=oldPaymentSystem;
    }
     public void Pay(string name,double amount){
       _OldPaymentSystem.ProcessPayment(name,amount);
    }
}