using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public delegate void NotificationHandler(string text);
    internal class Notifier
    {
        public void SendNotification(NotificationHandler op, string text)
        {
            op(text);
           
        }
    }
}
