using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ExplicitInterfaces
{
    public interface IResident
    {
        string Name { get; }
        string Country { get; }
        public void GetName();
    }
}
