using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskFantasia
{
    public class Cars
    {
        private string _brand;
        private string _model;
        public bool isAvailable { get; set; } = true;
        private static int _id;
        public int Id { get; }
        private double _rentprice;
        public double RentPrice
        {
            get
            {
                return _rentprice;
            }
            set
            {
                if (value > 0)
                {
                    _rentprice = value;
                }
                else
                {
                    Console.WriteLine("Bu qiymete 07 goturursen ala?!");
                }
            }
        }
        public string Brand {
            get 
            { 
                return _brand; 
            } 
            set {
                if (value != "" || value != " ")
                {
                    _brand = value;
                }
                else
                {
                    Console.WriteLine("Brandin formati duzgun deyil!!");
                }
            } 
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                if (value != "" || value != " ")
                {
                    _model = value;
                }
                else
                {
                    Console.WriteLine("Modelin Formati duzgun deyil!");
                }
            }
        }
        public int HorsePower { get; set; }

        public Cars(string Brand , string Model , int HorsePower , double RentPrice)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.HorsePower = HorsePower;
            this.RentPrice = RentPrice;
            Id = _id++;
        }

        public override string ToString()
        {
            return Brand + " " + Model;
        }
    }
}
