using Microsoft.VisualBasic;
using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();
            
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            var firstCar= new Car();
            
            firstCar.Year = 2010;
            firstCar.Make = "Honda";
            firstCar.Model = "Accord";
            firstCar.EngineNoise = "rattle";
            firstCar.HonkNoise = "beep";
            firstCar.IsDriveable = true;

            lot.CarList.Add(firstCar);

            var secondCar = new Car()
            {
                Year = 2015,
                Make = "Chevrolet",
                Model = "Malibu",
                EngineNoise = "ticking",
                HonkNoise = "honk",
                IsDriveable = true

            };
            lot.CarList.Add(secondCar);


            var thirdCar = new Car("Ford", "Mustang", 2020, "vroom", "BAROOGA", true);
            lot.CarList.Add(thirdCar);
            
            //Call each of the methods for each car
            
            Console.WriteLine($"The {firstCar.Model}'s engine makes a {firstCar.EngineNoise} noise.");

            Console.WriteLine($"The {secondCar.Model}'s engine makes a {secondCar.EngineNoise} noise.");


            Console.WriteLine($"The {thirdCar.Year} {thirdCar.Make} {thirdCar.Model}'s horn makes a {thirdCar.HonkNoise} noise.");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach( var car in lot.CarList ) 
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
            }
            Console.WriteLine($"Number of Cars: {CarLot.numberOfCars}");
        }
    }
}
