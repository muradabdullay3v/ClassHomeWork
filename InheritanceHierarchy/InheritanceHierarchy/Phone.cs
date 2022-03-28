using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHierarchy
{
    class Phone
    {
        public int buttonsCount;
        public string Material;
        public string Brand;
        public string Model;
        public int maya_price;

        public Phone()
        {
            Console.WriteLine("Telephone created bip bup bop...");
        }
        public Phone(string Brand , string Model ,int buttonsCount, string Material, int maya_price):this()
        {
            this.buttonsCount = buttonsCount;
            this.Material = Material;
            this.Brand = Brand;
            this.Model = Model;
            this.maya_price = maya_price;
        }

    public virtual void Info()
        {
            Console.WriteLine($"Brand : {Brand}\nModel : {Model}\nMaterial : {Material}\nNumber of Buttons : {buttonsCount}\n" +
                $"Price : {maya_price}\n");
        }

    public void Sell(int count,int sellcount , int sellprice)
        {
            int income = 0;
            if (count>0)
            {
                count -= sellcount;
                income = sellcount * (sellprice-maya_price);
                Console.WriteLine($"Qalan say : {count}\nGelir : {income}\n");
            }
            else
            {
                Console.WriteLine("Sold. Number : 0 \n");
            }
        }
    }
}
