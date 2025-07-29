public interface INewPaymentSystem
{
     void Pay(string name,double amount){
        Console.WriteLine($"Pay {name}:{amount}");
    }
}