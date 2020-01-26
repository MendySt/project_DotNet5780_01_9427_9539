using System.Reflection;
using System;

namespace DalObject
{ 
    public static class Cloning
    {
        public static T Clone<T>(this T original)
        {
            T result = (T)Activator.CreateInstance(original.GetType()); // New instance of original object

            foreach (PropertyInfo prop in result.GetType().GetProperties())
            {
                prop.SetValue(result, original.GetType().GetProperty(prop.Name).GetValue(original, null));
            } // Iterate all fields in new result instance, and set value from original object

            return result;
        }
    }
}
