using System.Runtime.ConstrainedExecution;
namespace DesignPatterns.Decorator
{
   public class Moca : CondimentDecorator
   {
      public Moca(Beverage bebida):base(bebida)
      {
      }

      public override double cost()
      {
         return bebida.cost() + 0.20;
      }

      public override string getDescripcion()
      {
         return bebida.getDescripcion() + " ,Chocolate";
      }
   }
}