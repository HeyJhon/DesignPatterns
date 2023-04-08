namespace DesignPatterns.Decorator
{
    public abstract class CondimentDecorator: Beverage
    {
        protected Beverage bebida;
        public CondimentDecorator(Beverage bebida)
        {
            this.bebida = bebida;
        }
        public override abstract string getDescripcion();
    }
}