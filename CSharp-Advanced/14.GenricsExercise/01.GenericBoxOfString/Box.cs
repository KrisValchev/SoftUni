using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _01.GenericBoxOfString
{
    public class Box<T>
    {
        private T vAlue;
        public T Value
        {
            get
            {
                return vAlue;
            }
            set
            {
                vAlue = value;
            }
        }
        public Box(T vAlue)
        {
            Value= vAlue;
        }
        public override string ToString()
        {
            return $"{typeof(T)}: {Value}";
        }
    }
}
