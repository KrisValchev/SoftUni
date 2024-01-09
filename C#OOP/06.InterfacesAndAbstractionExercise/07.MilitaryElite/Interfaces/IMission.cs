using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07.MilitaryElite.Enums;
using _07.MilitaryElite.Models;

namespace _07.MilitaryElite.Interfaces
{
    public interface IMission
    {
        string CodeName { get; }
        State State { get; }
        public void CompleteMission();
    }
}
