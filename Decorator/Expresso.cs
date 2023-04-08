namespace DesignPatterns.Decorator
{
   public class Expresso : Beverage
   {
      public Expresso()
      {
        descripcion = "Cafe Expresso";
      }

      public override double cost()
      {
         return 1.99;
      }

      public override string getDescripcion()
      {
         return descripcion;
      }
   }
}