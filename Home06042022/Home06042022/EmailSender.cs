using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home06042022
{
    class EmailSender:MessageSender
    {
        public override void SendMessage()
        {
            string msg = Console.ReadLine();
            Console.WriteLine($"Gonderdiyiniz mesaj : {msg}");
        }
    }
}
