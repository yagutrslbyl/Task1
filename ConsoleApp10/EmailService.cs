using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class EmailService
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"{message} emaili gonderildi!");
        }
    }
}
