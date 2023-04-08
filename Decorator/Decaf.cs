namespace DesignPatterns.Decorator
{
    public class Decaf: Beverage
    {
        public Decaf()
        {
            descripcion ="Cafe Descafeinado";
        }

        public override double cost(){
            return 1.05;
        }

      public override string getDescripcion()
      {
         return descripcion;
      }
   }
}