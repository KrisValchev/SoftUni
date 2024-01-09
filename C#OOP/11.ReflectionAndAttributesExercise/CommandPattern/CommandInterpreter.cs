using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string command=args.Split(' ',StringSplitOptions.RemoveEmptyEntries).First();
            Type type = Assembly.GetEntryAssembly().GetTypes().FirstOrDefault(t=>t.Name==command+"Command");
            string result=" ";
            if(type != null )
            {
                ICommand instanceOfCommand=Activator.CreateInstance(type) as ICommand;

                result = instanceOfCommand.Execute(args.Split(" ", StringSplitOptions.RemoveEmptyEntries).Skip(1).ToArray());
            }
            else
            {
                throw new InvalidOperationException("Command not found.");
            }
            return result;
        }
    }
}
