namespace DesignPatterns.Strategy
{
    public class QuackSplash : QuackBehavior
    {
        public void Quack()
        {
            System.Console.WriteLine("sQuack pssss");
        }
    }
}