using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace _06.StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            List<Box> boxes = new List<Box>();
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if(command[0]=="end")
                {
                    
                    break;
                }
                string serialNumber = command[0];
                string itemName = command[1];
                int itemQuantity = int.Parse(command[2]);
                decimal itemPrice = decimal.Parse(command[3]);
                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNumber,item, itemQuantity);
                boxes.Add(box);
            }
            foreach (Box box in boxes.OrderByDescending(x => x.PriceOfBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceOfBox:f2}");
            }
        }
    }
    class Item
    {
        public Item(string itemName, decimal itemPrice)
        {
            Name = itemName;
            Price = itemPrice;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {
        public Box(string serialNumber, Item item, int itemQuantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceOfBox
        {
            get => Item.Price * ItemQuantity;
        }
    }
}
