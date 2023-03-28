namespace DesignPatterns.Strategy
{
    public class QuackMad : QuackBehavior
    {
        public void Quack()
        {
            System.Console.WriteLine("Quack i'm angry");
        }
    }
}