using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ValidationAttributes.Attributes;

namespace ValidationAttributes.Utils
{
    public static class Validator
    {
        public static bool IsValid(object value)
        {
            Type type = value.GetType();
            PropertyInfo[] propertyInfos = type
           .GetProperties()
           .Where(p => p.CustomAttributes
               .Any(ca => typeof(MyValidationAttribute).IsAssignableFrom(ca.AttributeType)))
           .ToArray();
            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                IEnumerable<MyValidationAttribute> attributes = propertyInfo
                    .GetCustomAttributes()
                    .Where(ca => typeof(MyValidationAttribute).IsAssignableFrom(ca.GetType()))
                    .Cast<MyValidationAttribute>();

                foreach (MyValidationAttribute attribute in attributes)
                {
                    if (!attribute.IsValid(propertyInfo.GetValue(value)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
