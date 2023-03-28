using DesignPatterns.Strategy;

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
    }
}