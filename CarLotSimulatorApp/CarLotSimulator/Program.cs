using System;
using System.Collections.Generic;


namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {


            CarLot carLot = new CarLot();

            


            Car car1 = new Car() { Year = 2014, Make = "GMC", Model = "1500", EngineNoise = "Roar", HonkNoise = "Loud", IsDriveable = true};

            carLot.ListOfCars.Add(car1);



            Car car2 = new Car() { Year = 2022, Make = "Chevrolet", Model = "Colorado", EngineNoise = "Purrr", HonkNoise = "Stout", IsDriveable = true };

            carLot.ListOfCars.Add(car2);



            Car car3 = new Car() { Year = 1997, Make = "Ford", Model = "Explorer", EngineNoise = "None", HonkNoise = "Dead", IsDriveable = false };
        
            carLot.ListOfCars.Add(car3);


            foreach (var car in carLot.ListOfCars) 
            {
                Console.WriteLine($"Year {car.Year} Make {car.Make} Model {car.Model}");
                car.MakeEngineNoise(car.EngineNoise);
                car.MakeHonkNoise(car.HonkNoise);
                Console.WriteLine();
                Console.WriteLine();
                    

            }





            List <int> list = new List <int> ();
            list.Add(5);

            //TODO

            //Create a seperate class file called Car-DONE
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable-DONE
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
