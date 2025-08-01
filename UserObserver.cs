

public class UserObserver:IObserver
{
  public string Name{get;set;}
    public UserObserver(string name){
        Name=name;
    }
    public void Update(string message){
        Console.WriteLine($"user:{Name} received the :{message} ");
    }
}