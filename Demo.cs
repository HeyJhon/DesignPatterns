using DesignPatterns.Strategy;
using DesignPatterns.Observer;
using DesignPatterns.Decorator;
namespace designpatterns.Demo
{
    public static class Demo
    {
        public static void Strategy(){
            Pato pato1= new Pato();
            QuackNorteno quackAjua = new QuackNorteno();
            pato1.setQuackBehavior(quackAjua);
            pato1.DoQuack();
        }
        public static void Observer(){
            Data datos = new Data();
            NormalDisplay observadorNormal = new NormalDisplay(datos);
            datos.registerObserver(observadorNormal);

            datos.SetCantidad(10);
            datos.SetDescripcion("Iniciando descripcion...1");
            observadorNormal.DisplayInfo();

            datos.SetCantidad(20);
            datos.SetDescripcion("Iniciando descripcion 2...");
            observadorNormal.DisplayInfo();

            datos.removeObserver(observadorNormal);
            datos.SetCantidad(30);
            datos.SetDescripcion("Iniciando descripcion 3...");
            observadorNormal.DisplayInfo();
        }

        public static void Decorator(){
            Beverage bebida = new Moca(new Expresso());           
            System.Console.WriteLine($"Expreso = {bebida.getDescripcion()} {bebida.cost()}");

            Beverage bebida2 = new DarkRoast();
            bebida2 = new Moca(bebida2);
            bebida2 = new Moca(bebida2);
            bebida2 = new Batido(bebida2);
            System.Console.WriteLine($"Cafe Tostado = {bebida2.getDescripcion()} {bebida2.cost()}");

            Beverage bebida3 = new HouseBlend();
            bebida3 = new Moca(bebida3);
            bebida3 = new Soya(bebida3);
            bebida3 = new Batido(bebida3);
            System.Console.WriteLine($"Cafe Mezclado = {bebida3.getDescripcion()} {bebida3.cost()}");
        }
    }
}