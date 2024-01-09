using _07.MilitaryElite.Core.Interfaces;
using _07.MilitaryElite.Core;
using _07.MilitaryElite.Interfaces;

namespace _07.MilitaryElite
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }

    }
}