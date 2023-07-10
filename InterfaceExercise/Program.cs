using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;

            
            //Creatively display and organize their values

            Car myCar = new Car();
            myCar.FuelGrade = "premium";
            myCar.IsCovertible = true;
            myCar.Logo = "Rounde1";
            myCar.Slogan = "Lexus = Luxury at it's Finest";
            myCar.NumberOfWheels = 4;

            Truck myTruck = new Truck()
            {
                FuelGrade = "unleaded",
                IsCommercial = false,
                Logo = "Ford - F150",
                Slogan = "Built Ford Tough"
            };

            SUV mySUV = new SUV()
            {
                FourWheelDrive = true,
                HasHeadLights = true,
                HasTailLights = true,
                Logo = "Olympic Ensign",
                Slogan = "Being Ahead Of Technology",
                FuelGrade = "premium unleaded"
            };

            List<IVehicle> vehicleList = new List<IVehicle>();
            vehicleList.Add(myCar);
            vehicleList.Add(myTruck);
            vehicleList.Add(mySUV);

            foreach (IVehicle item in vehicleList)
            {
                Console.WriteLine($"Number of wheels: {item.NumberOfWheels}");
                Console.WriteLine($"Has Tail Lights: {item.HasTailLights}");
                Console.WriteLine($"Fuel Grade: {item.FuelGrade}");
                Console.WriteLine($"Slogan: {item.Slogan}");
                Console.WriteLine($"Logo: {item.Logo}");
                item.HonkNoise();
                Console.WriteLine();

            }


        }
    }
}
