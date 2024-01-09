using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CollectionHierarchy.Interfaces
{
    public interface IRemovable : IAddable
    {
        public string Remove();
    }
}
