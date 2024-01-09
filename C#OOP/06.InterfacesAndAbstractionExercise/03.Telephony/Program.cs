using _03.Telephony.Models;
using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;

namespace _03.Telephony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] websites = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < phoneNumbers.Length; i++)
            {
            Regex pattern = new Regex(@"^(?<PhoneNumber>)(([0-9]{10})|([0-9]{7}))$");
            Match match = pattern.Match(phoneNumbers[i]);
                if (match.Success)
                {
                    if(match.Value.Length==7)
                    {
                       StationaryPhone stationaryPhone=new StationaryPhone();
                        stationaryPhone.Call(match.Value);
                    }
                    else
                    {
                        Smartphone smartphone = new Smartphone();
                        smartphone.Call(match.Value);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }

            }
            for (int i = 0; i < websites.Length; i++)
            {
                Regex pattern = new Regex(@"^(?<Website>)([^\d]+)$");
                Match match = pattern.Match(websites[i]);
                if (match.Success)
                {
                    Smartphone smartphone = new Smartphone();
                    smartphone.SearchWebsite(match.Value);
                }
                else
                {
                    Console.WriteLine("Invalid URL!");
                }
            }
        }
    }
}