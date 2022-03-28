using System;

namespace ClassHomeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Isuzu = new Bus("Isuzu" , "62" , "White" , 150 , 16);
            Isuzu.Info();
            Car BMW = new Car("BMW", "528i", "Black", 260);
            BMW.Info();
            Bus Vito = new Bus("Mercedes" , "Vito" , "Silver" , 200 , 8);
            Vito.Info();

        }
    }
}