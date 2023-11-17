using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FoodShortage.Interfaces
{
    public interface IBuyer
    {
        public void BuyFood();
        public int Food { get; }
        public string Name { get; set; }
    }
}
