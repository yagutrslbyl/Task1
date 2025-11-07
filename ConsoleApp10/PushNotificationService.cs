using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class PushNotificationService
    {
        public void SendPush(string message)
        {
            Console.WriteLine($"{message} gonderildi!");
        }
    }
}
