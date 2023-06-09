﻿using System;

namespace _01.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases={
                "Excellent product.", 
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.", 
                "Exceptional product.", 
                "I can't live without this product."
            };
            string[] events={
                "Now I feel good.",
                "I have succeeded with this product.", 
                "Makes miracles.I am happy of the results!", 
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", 
                "I feel great!"
            };
            string[] authors = {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };
            string[] cities ={
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };
            int numOfMessages = int.Parse(Console.ReadLine());
            Random message = new Random();
            for (int i = 0; i < numOfMessages; i++)
            {
                Console.WriteLine($"{phrases[message.Next(0,phrases.Length)]} {events[message.Next(0, events.Length)]} {authors[message.Next(0, authors.Length)]} – {cities[message.Next(0, cities.Length)]}.");
            }
        }
    }
}
