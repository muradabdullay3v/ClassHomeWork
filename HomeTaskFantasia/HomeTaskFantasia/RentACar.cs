using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskFantasia
{
    class RentACar
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != "" || value != " ")
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Adin formati duzgun deyil!");
                }
            }
        }
        public int MaxCarNumber { get; set; }
        private double _rentTimeHours { get; set; }
        public double RentTimeHours
        {
            get
            {
                return _rentTimeHours;
            }
            set
            {
                if (value > 0)
                {
                    _rentTimeHours = value;
                }
                else
                {
                    Console.WriteLine("Bu vaxt arenda ucun nezerde tutlmayib!");
                }
            }
        }

        private Cars[] Car;
        public Cars this[int index]
        {
            get
            {
                if (index >= 0 && index < Car.Length)
                {
                    return Car[index];
                }
                throw new OutOfIndexException("Indexden qiraga cixdi!");
            }
            set
            {
                if (index >= 0 && index < Car.Length)
                {
                    Car[index] = value;
                }
            }
        }

        public void AddCar(params Cars[] masin)
        {
            int arrayslength = Car.Length;
            Array.Resize(ref Car, Car.Length + masin.Length);
            int temp = 0;
            for (int i = arrayslength; i < Car.Length; i++)
            {
                Car[i] = masin[temp];
                temp++;
            }
            foreach (var item in Car)
            {
                Console.WriteLine($"Brand : {item.Brand}\nModel : {item.Model}\nHP : {item.HorsePower}\n");
            }
        }

        public RentACar(string Name, params Cars[] Car)
        {
            this.Name = Name;
            this.Car = Car;
        }

        public void Rent(int? CarId, double RentTimeHours)
        {
            bool IsId = false;
            foreach (var item in Car)
            {
                if (item != null)
                {
                    if (item.Id == CarId)
                    {
                        IsId = true;
                        if (item.isAvailable)
                        {
                            Console.WriteLine($"{item.Brand} {item.Model} {item.Id} Id - li mashin {RentTimeHours*item.RentPrice} odenishden sonra {RentTimeHours} saatliq arendaya goturuldu!");
                            item.isAvailable = false;

                        }
                        else
                        {
                            Console.WriteLine($"{item.Brand} {item.Model} {item.Id} Id - li mashin arendaya goturulub!");
                        }
                    }
                }
                else
                {
                    throw new NullReferenceException("Elemntlerden biri null - dur!");
                }
            }
            if (!IsId)
            {
                Console.WriteLine("Bu Id - e uygun element tapilmadi!");
            }
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
