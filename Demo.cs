using DesignPatterns.Strategy;
using DesignPatterns.Observer;

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
    }
}