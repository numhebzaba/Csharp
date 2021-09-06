using System;

namespace Class_sesion1
{
    class Panda {

        public string name;

        private int population;

        public Panda(string nameValue) {
            name = nameValue;
            population = population + 1;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Panda namePanda1 = new Panda("Nong");
            Panda namePanda2 = new Panda("Asdas");
        }
    }
}
