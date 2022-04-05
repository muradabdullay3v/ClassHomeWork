using System;

namespace Home06042022
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Menu : ");
            Console.WriteLine("1. Send message by email");
            Console.WriteLine("2. Send message by sms");
            Console.WriteLine("0. Quit");
            int value = int.Parse(Console.ReadLine());
            EmailSender email = new EmailSender();
            SmsSender sms = new SmsSender();
            switch (value)
            {
                case 0: 
                    Console.WriteLine("Proqram sona catdi!");
                    break;
                case 1: 
                    Console.WriteLine("Emaile mesaj yazin : ");
                    email.SendMessage();
                    break;
                case 2:
                    Console.WriteLine("Sms daxil edin");
                    sms.SendMessage();
                    break;
                default:
                    Console.WriteLine("Bele opsiya yoxdu!");
                    break;
            }
        }
    } 
}