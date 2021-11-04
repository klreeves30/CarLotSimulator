using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()


            //The methods should take one string parameter: the respective noise property




            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

        


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            /// First instanciation
            var charlesCar = new Car();
            charlesCar.Make = "Honda";
            charlesCar.Model = "Accord";
            charlesCar.Year = 2004;
            charlesCar.EngineNoise = "vroom";
            charlesCar.HonkNoise = "beep";
            charlesCar.IsDriveable = false;

            /// Second instanciation
            Car mikesCar = new Car() { Year = 2020, Make = "Cadillac", Model = "Escalade", EngineNoise = "vroom vrrom", HonkNoise = "beep beep", IsDriveable = true };

            ///Third instanciation
            Car amysCar = new Car("GMC", "Yukon", "vroom vrrom", "beep beep", true, 2017);


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of car
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            //foreach iterates through and prints Year Make MOdel


            var carList = new CarLot();
            carList.ParkingLot = new List<Car>() { charlesCar, mikesCar, amysCar };
            foreach (var car in carList.ParkingLot)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
            }
           
        }
    }
}
