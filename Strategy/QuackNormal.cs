namespace DesignPatterns.Strategy
{
    public class QuackNormal : QuackBehavior
    {
        public void Quack()
        {
            System.Console.WriteLine("Cuack Cuack");
        }
    }
}