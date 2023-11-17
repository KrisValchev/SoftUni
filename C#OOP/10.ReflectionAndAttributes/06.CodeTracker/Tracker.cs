using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AuthorProblem
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            Type typeOfClass = typeof(StartUp);
            MethodInfo[] methods=typeOfClass.GetMethods(BindingFlags.Public | BindingFlags.Instance| BindingFlags.Static);
            foreach(var method in methods)
            {
                if(method.CustomAttributes.Any(n=>n.AttributeType==typeof(AuthorAttribute)))
                {
                   var attributes = method.GetCustomAttributes(false);
                    foreach(AuthorAttribute attr in attributes)
                    {
                        Console.WriteLine($"{method.Name} is written by {attr.Name}");
                    }
                }
            }
        }
    }
}
