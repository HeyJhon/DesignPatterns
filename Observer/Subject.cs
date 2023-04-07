namespace DesignPatterns.Observer
{
    public interface Subject
    {
         public void registerObserver(Observer suscriptor);
         public void removeObserver(Observer suscriptor);
         public void notifyObserver();
    }
}