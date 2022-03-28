using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHomeTask
{
    class Car
    {
        public string Brand;
        public string Model;
        public string Color;
        public int MaxSpeed;

        public Car()
        {
            Console.WriteLine("Car Created");
        }

        public Car(string Brand , string Model):this()
        {
           this.Brand = Brand;
           this.Model = Model;
        }
        public Car(string Brand , string Model , string Color , int MaxSpeed):this(Brand , Model)
        {
            this.Color = Color;
            this.MaxSpeed = MaxSpeed;
        }
        public virtual void Info()
        {
            Console.WriteLine($"Brand : {Brand} " +
                $"Model : {Model} " +
                $"Color : {Color} " +
                $"Max Speed : {MaxSpeed}");
        }
    }
}
