namespace DesignPatterns.Decorator
{
    public abstract class Beverage
    {
        protected string descripcion = "Sin descripción";
        public abstract double cost();
        public abstract string getDescripcion();
    }
}