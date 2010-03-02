using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {

            var programmer = new Programmer();
            programmer.Builder = new WinformsSoftwareBuilder();
            programmer.BuildSoftware();
            DisplaySoftware(programmer.Software);


            programmer.Builder = new WebSoftwareBuilder();
            programmer.BuildSoftware();
            DisplaySoftware(programmer.Software);

            //PizzaExample();

            //CarfactoryExample();

            Console.Read();
        }

        private static void DisplaySoftware(Software software)
        {
            var msg = string.Format("Software: {0} \n Interface:{1} \n Database:{2}",
                                        software.Name,
                                        software.GraphicalInterface,
                                        software.Database);

            Console.WriteLine(msg);
        }

        private static void CarfactoryExample()
        {
            var factory = new CarFactory();
            factory.Builder = new OpelBuilder();
            factory.BuildCar();

            DisplayCar(factory.Car);
        }

        private static void DisplayCar(Car car)
        {
            var msg = string.Format("Car Name:{0} \n Engine:{1} \n Shape:{2}",
                                    car.Name,
                                    car.Engine,
                                    car.Shape);

            Console.WriteLine(msg);
        }

        private static void PizzaExample()
        {
            var cook = new Cook();
            cook.Builder = new DiavoloPizzaBuilder();
            cook.BuildPizza();

            DisplayPizza(cook.Pizza);

            cook.Builder = new HawaiianPizzaBuilder();
            cook.BuildPizza();

            DisplayPizza(cook.Pizza);
        }

        private static void DisplayPizza(Pizza pizza)
        {
            string msg = string.Format("Pizza: {0} \n Compozitie: {1} \n Blat: {2}",
                                        pizza.Denumire,
                                        pizza.Compozitie,
                                        pizza.Blat);
            Console.WriteLine(msg  );
        }
    }
}
