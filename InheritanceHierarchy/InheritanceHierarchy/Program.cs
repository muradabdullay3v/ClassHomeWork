using System;

namespace InheritanceHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Phone IPhone  = new Phone("Apple", "13 Pro Max", 3 , "Steel" , 2900);
            IPhone.Info();
            IPhone.Sell(10, 4, 6220);
            SmartPhone Galaxy = new SmartPhone("Samsung" , "Galaxy S22" , 3 , "Aluminium" , 2500 , "QuadHD", 108 , 120 , 652852 , true , true);
            Galaxy.Info();
            Galaxy.Sell(5 , 1 , 5000);
            Phone Xiaomi = new SmartPhone("Xiaomi", "Redmi Note 11 Lite", 3, "Aluminium", 1200, "FullHD+", 32, 90, 276852, false , true);
            Xiaomi.Info();
            Xiaomi.Sell(4 , 1 , 2500);
        }
    }
}