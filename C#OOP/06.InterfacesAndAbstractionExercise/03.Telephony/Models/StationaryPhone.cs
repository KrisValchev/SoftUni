using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.Telephony.Interfaces;

namespace _03.Telephony.Models
{
    public class StationaryPhone : ICallable
    {
        public void Call(string phoneNumber)
        {
            Console.WriteLine($"Dialing... {phoneNumber}");
        }
    }
}
