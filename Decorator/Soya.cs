namespace DesignPatterns.Decorator
{
   public class Soya : CondimentDecorator
   {
      public Soya(Beverage bebida):base(bebida)
      {
      }

      public override double cost()
      {
         return bebida.cost() + 0.15;
      }

      public override string getDescripcion()
      {
         return bebida.getDescripcion() + " ,Soya";
      }
   }
}