using System;
using System.Collections.Generic;
using System.IO;

namespace file_io
{
    class Program
    {
        static void Main(string[] args)
        {
            var corolla = new Car() { ModelYear = 2015, Make = "Toyota", Model = "Corolla", Doors = 4, Miles = 23595 };

            var civic = new Car() { ModelYear = 2004, Make = "Honda", Model = "Civic", Doors = 4, Miles = 186274 };

            var camaro = new Car() { ModelYear = 2010, Make = "Chevrolet", Model = "Camaro", Doors = 2, Miles = 96837 };

            var altima = new Car() { ModelYear = 2014, Make = "Nissan", Model = "Altima", Doors = 4, Miles = 36489 };

            var fusion = new Car() { ModelYear = 2017, Make = "Ford", Model = "Fusion", Doors = 4, Miles = 1024 };

            // variable for writing to a file
            var carList = new List<Car> { corolla, civic, camaro, altima, fusion };

            // open file for writing
            using (var writer = new StreamWriter(File.Open("cars.csv", FileMode.OpenOrCreate)))
            {
                // write all the cars to a file
                carList.ForEach(car => writer.WriteLine(car));
            }

            // variable for reading from a file
            var carsFromFile = new List<Car>();

            // read from a file
            using (var reader = new StreamReader(File.Open("cars.csv", FileMode.OpenOrCreate)))
            {
                // read all the cars from the file
                while (reader.Peek() >= 0)
                {
                    var carFromFile = reader.ReadLine();
                    var data = carFromFile.Split(',');
                    carsFromFile.Add(new Car(data));
                }
            }

            carsFromFile.ForEach(car => Console.WriteLine(car));

        }
    }
}
