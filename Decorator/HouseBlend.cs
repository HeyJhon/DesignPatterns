namespace DesignPatterns.Decorator
{
   public class HouseBlend : Beverage
   {
      public HouseBlend()
      {
        descripcion = "Cafe House Blend";
      }

      public override double cost()
      {
         return 0.89;
      }

      public override string getDescripcion()
      {
         return descripcion;
      }
   }
}