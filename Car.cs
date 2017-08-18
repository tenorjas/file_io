using System;

namespace file_io
{
    public class Car
    {
        public int ModelYear { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Doors { get; set; }
        public int Miles { get; set; }

        public Car()
        {

        }

        public Car(string[] data)
        {
            ModelYear = int.Parse(data[0]);
            Make = data[1];
            Model = data[2];
            Doors = int.Parse(data[3]);
            Miles = int.Parse(data[4]);
        }

    }
}