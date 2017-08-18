using System;

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

        }
    }
}
