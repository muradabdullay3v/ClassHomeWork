using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHomeTask
{
    class Bus:Car
    {
        public int PassengerCount;

        public Bus()
        {

        }
        public Bus(string Brand, string Model, string Color, int MaxSpeed , int PassengerCount):base(Brand , Model , Color , MaxSpeed)
        {
            this.PassengerCount = PassengerCount;
        }
        
        public override void Info()
        {
            Console.WriteLine($"Brand : {Brand} " +
                $"Model : {Model} " +
                $"Color : {Color} " +
                $"Max Speed : {MaxSpeed} " +
                $"Passenger capacity : {PassengerCount}");
        }
    }
}
