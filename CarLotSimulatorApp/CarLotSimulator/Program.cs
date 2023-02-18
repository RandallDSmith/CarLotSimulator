using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

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

            var honda = new Car();
            honda.Year = 2020;
            honda.Make = "Honda";
            honda.Model = "Accord";
            honda.EngineNoise = "Hum";
            honda.HonkNoise = "Beep";
            honda.IsDriveable= true;

            var toyota = new Car() { Year = 2021, Make = "Toyota", Model = "Tundra", EngineNoise = "Rumble", HonkNoise = "Beep", IsDriveable= true };

            var vw = new Car();
            vw.Year = 2024;
            vw.Make = "Volkswagon";
            vw.Model = "Rabit";
            vw.EngineNoise = "Putt Putt";
            vw.HonkNoise = "Honk";
            vw.IsDriveable= true;

            var carList = new List<Car>();
            carList.Add(toyota);
            carList.Add(vw);
            carList.Add(honda);

            foreach (var car in carList)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model} {car.IsDriveable}");
                Car.MakeEngineNoise(car.EngineNoise);
                Car.MakeHonkNoise(car.HonkNoise);
                Console.WriteLine("---------------------------------------------");

            }



            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            var ford = new Car();
            ford.Year = 2019;
            ford.Make = "Ford";
            ford.Model = "Mustang";
            ford.EngineNoise = "Vroom";
            ford.HonkNoise = "Honk";
            ford.IsDriveable= true;

            var chevy = new Car() { Year = 2018, Make = "Chevy", Model = "Bolt", EngineNoise = "Humm", HonkNoise = "Beep Beep", IsDriveable= true };

            var buick = new Car()
            {
                Year = 2020,
                Make = "Buick",
                Model = "Envoy",
                EngineNoise = "clunk",
                HonkNoise = "Honk",
                IsDriveable = true
            };



            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            var jeep = new CarLot();
            jeep.Year = 2021;
            jeep.Make = "Jeep";
            jeep.Model = "Wrangler";

            Console.WriteLine($"{jeep.Model} is car number {CarLot.numberOfCars} created");

            var scion = new CarLot();
            scion.Year = 2016;
            scion.Make = "Scion";
            scion.Model = "XB";

            Console.WriteLine($"{scion.Model} is car number {CarLot.numberOfCars} created");

            var pontiac = new CarLot() { Year = 2012, Make = "Pontiac", Model = "Firebird" };

            Console.WriteLine($"{pontiac.Model} is car number {CarLot.numberOfCars} created");

            var newCarList = new List<CarLot>();
            newCarList.Add(jeep);
            newCarList.Add(pontiac);
            newCarList.Add(scion);

            Console.WriteLine("------------------------");

            foreach (var car in newCarList)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
                
                Console.WriteLine("--------------------------");
            }


        }
    }
}
