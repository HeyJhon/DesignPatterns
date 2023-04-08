namespace DesignPatterns.Decorator
{
   public class DarkRoast : Beverage
   {
    public DarkRoast()
    {
        descripcion = "Cafe Tostado Oscuro";
    }
   public override double cost()
   {
      return 0.99;
   }

   public override string getDescripcion()
   {
      return descripcion;
   }
   }
}