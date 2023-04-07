namespace DesignPatterns.Observer
{
    public class NormalDisplay : Observer, Display
    {
        private int cantidadNormal;
        private string? descripcionNormal;
        Data data;
        public NormalDisplay(Data data)
        {
            this.data =  data;
        }
        public void DisplayInfo()
        {
            System.Console.WriteLine($"Cantidad Actual={this.cantidadNormal}, Descripcion Actual={this.descripcionNormal}") ;
        }
        public void update()
        {
            this.cantidadNormal = data.GetCantidad();
            this.descripcionNormal =data.GetDescripcion();
        }
    }
}