using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
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
        public string AnalyzeAccessModifiers(string className)
        {
            Type typeOfClass= Type.GetType(className);
            FieldInfo[] fields = typeOfClass.GetFields(BindingFlags.Public);
            MethodInfo[] privateMethods = typeOfClass.GetMethods(BindingFlags.NonPublic);
            MethodInfo[] publicMethods = typeOfClass.GetMethods(BindingFlags.Public);
            StringBuilder sb = new StringBuilder();
            foreach (var field in fields.Where(f=>f.IsPrivate))
            {
                sb.AppendLine($"{field.Name} must be private");
            }

            foreach (var getter in privateMethods.Where(m=>m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{getter.Name} must be private");
            }
            foreach (var setter in publicMethods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{setter.Name} must be private");
            }
            return sb.ToString().Trim();
        }
        public string RevealPrivateMethods(string className)
        {
            Type typeOfClass= Type.GetType(className);
            MethodInfo[] privateMethods = typeOfClass.GetMethods(BindingFlags.NonPublic);
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(className);
            stringBuilder.AppendLine(typeOfClass.BaseType.Name);
            foreach (var method in privateMethods)
            {
                stringBuilder.AppendLine(method.Name);
            }
            return stringBuilder.ToString().Trim();
        }
        public string CollectGettersAndSetters(string className)
        {
            Type typeOfClass = Type.GetType(className);
            MethodInfo[] methods = typeOfClass.GetMethods(BindingFlags.NonPublic| BindingFlags.Public);

            StringBuilder sb = new StringBuilder();

            foreach (var getter in methods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{getter.Name} will return {getter.ReturnParameter}");
            }
            foreach (var setter in methods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{setter.Name} will set field of {setter.ReturnParameter}");
            }
            return sb.ToString().Trim();
        }
    }
}
