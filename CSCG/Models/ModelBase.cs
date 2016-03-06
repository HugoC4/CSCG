using System;
using System.Collections;
using System.Reflection;

namespace CSCG.Models
{
    public class ModelBase
    {
        public ModelBase()
        {
            // Get a list of all public [static] properties
            PropertyInfo[] properties = GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

            // Loop through them
            foreach (PropertyInfo property in properties)
            {
                // Check if they're a typeof(List)
                if(typeof(ICollection).IsAssignableFrom(property.PropertyType))
                {
                    // Instantiate property with a new List<T>
                    property.SetValue(this, Activator.CreateInstance(property.PropertyType.GetGenericTypeDefinition().MakeGenericType(property.PropertyType.GenericTypeArguments)));
                }
            }
        }
    }
}
