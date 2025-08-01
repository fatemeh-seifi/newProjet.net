using System;
public class News:ISubject
{
   private List<IObserver> observers=new List<IObserver>();
   private string _NewsMessage;
   public void Add(IObserver observer){
        observers.Add(observer);
   }
   public void Remove(IObserver observer){
        observers.Remove(observer);
   }
   public void Notify(){
        foreach (var item in observers)
        {
            item.Update(_NewsMessage);
        }
   }
   public void AddNews(string news){
          _NewsMessage=news;
          Notify();
   }


}