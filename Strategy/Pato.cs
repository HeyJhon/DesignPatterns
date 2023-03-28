namespace DesignPatterns.Strategy
{
    public class Pato
    {
       public QuackBehavior? comportamiento { get; set; }

       public void setQuackBehavior(QuackBehavior comportamiento){
        this.comportamiento = comportamiento;
       }

       public void DoQuack(){
        comportamiento?.Quack();
       }
    
    }
}