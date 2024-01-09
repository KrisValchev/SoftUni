using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _03.ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<string> bagOfProducts;

        public List<string> BagOfProducts
        {
            get { return bagOfProducts; }
            set { bagOfProducts = value; }

        }
        public Person(string name,decimal money)
        {
                this.Name = name;
            this.Money = money;
            this.BagOfProducts = new List<string>();
        }

        public decimal Money
        {
            get { return money; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        public string Name
        {
            get { return name; }
           private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }
        public void BuyProduct(Product product)
        {
            if(this.Money>=product.Cost)
            {
                this.Money -= product.Cost;
                this.BagOfProducts.Add(product.Name);
                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
                
            }
        }

    }
}
