using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string nameOfClass, params string[] namesOfFields)
        {
            Type typeOfClass=Type.GetType(nameOfClass);
            FieldInfo[] fieldsInfo = typeOfClass.GetFields(BindingFlags.Static | BindingFlags.Public |BindingFlags.NonPublic |BindingFlags.Instance);
            //takes all public,static,nonpublic fields and instances
            Object classInstance=Activator.CreateInstance(typeOfClass);
            //object because we don't know the type of the field
            //and Activator.CreateInstance method creates an dynamic instance which later on we can take it's value(like in the foreach loop)
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Class under investigation: {nameOfClass}");
            foreach (FieldInfo field in fieldsInfo.Where(f => namesOfFields.Contains(f.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }
            return sb.ToString().Trim();
        }
    }
}
