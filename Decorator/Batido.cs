namespace DesignPatterns.Decorator
{
   public class Batido : CondimentDecorator
   {
      public Batido(Beverage bebida):base(bebida)
      {
      }
      public override double cost()
      {
        return bebida.cost() + 0.10;
      }

      public override string getDescripcion()
      {
         return bebida.getDescripcion() + ", Crema Batida";
      }

     
   }

}