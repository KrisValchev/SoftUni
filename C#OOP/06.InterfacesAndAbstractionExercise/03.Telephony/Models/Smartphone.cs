using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using _03.Telephony.Interfaces;

namespace _03.Telephony.Models
{
    public class Smartphone :ICallable,IBrowsable
    {
        
        public void Call(string phoneNumber)
        {
            Console.WriteLine($"Calling... {phoneNumber}");
        }
       public void SearchWebsite(string URL)
        {
            Console.WriteLine($"Browsing: {URL}!");
        }
    }
}
