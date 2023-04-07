namespace DesignPatterns.Observer
{
    public class Data : Subject
    {
        private int cantidad;
        private string descripcion;
        private List<Observer> Suscriptores;
        public Data()
        {
            Suscriptores = new List<Observer>();
        }

        public int GetCantidad(){
            return cantidad;
        }
        public void SetCantidad(int cantidad){
            this.cantidad = cantidad;
            notifyObserver();
        }

        public string GetDescripcion(){
            return descripcion;
        }
        public void SetDescripcion(string descripcion){
            this.descripcion = descripcion;
            notifyObserver();
        }
        public void notifyObserver()
        {
            foreach (var item in Suscriptores)
            {
                item.update();
            }
        }

        public void registerObserver(Observer suscriptor)
        {
            Suscriptores.Add(suscriptor);
        }

        public void removeObserver(Observer suscriptor)
        {
            Suscriptores.Remove(suscriptor);
        }
    }
}