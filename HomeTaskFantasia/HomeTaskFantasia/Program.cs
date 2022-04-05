using System;

namespace HomeTaskFantasia
{
    class Program
    {
        public static void Main(string[] args)
        {
            Cars Urus = new Cars("Lamborghini" , "Urus" , 641 , 200);
            Cars Cullinan = new Cars("Rolls-Royce" , "Cullinan" , 563 , 350);
            Cars Gelik = new Cars("Mercedes-Benz" , "G63" , 577 , 120);
            Cars M8 = new Cars("BMW" , "M8" , 625 , 100);
            RentACar DiamondCars = new RentACar("DiamondCars" , Urus);
            DiamondCars.AddCar(Cullinan , Gelik , M8);
            DiamondCars.Rent(2 , 5);
            DiamondCars.Rent(2 , 3);
            DiamondCars.Rent(3 , 1);
            Console.WriteLine("\n" + DiamondCars[0]);
        }
    }
}