using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class SMSService
    {
        public void SendSMS(string message)
        {
            Console.WriteLine($"{message} sms-i gonderildi!");
        }
    }
}
