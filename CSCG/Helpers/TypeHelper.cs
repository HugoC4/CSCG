using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCG.Helpers
{
    public class TypeHelper
    {
        private static Dictionary<string, List<Type>> _cacheDictionary;
        public static Dictionary<string, List<Type>> GetClasses(bool flush = false)
        {
            if(_cacheDictionary.Any() && !flush)
                return _cacheDictionary;
            if(_cacheDictionary.Any())
                _cacheDictionary = new Dictionary<string, List<Type>>();
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
                foreach (var cls in assembly.GetTypes().Where(t => t.IsClass && t.Namespace != null && !t.Namespace.StartsWith("CSCG")))
                    if (_cacheDictionary.ContainsKey(cls.Namespace))
                        _cacheDictionary[cls.Namespace].Add(cls);
                    else
                        _cacheDictionary[cls.Namespace] = new List<Type>() { cls };
            return _cacheDictionary;
        }
    }
}
