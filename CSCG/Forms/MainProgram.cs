using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCG.Forms
{
    public partial class MainProgram : Form
    {
        public MainProgram()
        {
            InitializeComponent();
            var classes = GetClasses();
            foreach (var cls in classes)
            {
                Console.WriteLine(cls.Key);
            }
        }

        static Dictionary<string, List<Type>> GetClasses()
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            Dictionary<string, List<Type>> result = new Dictionary<string, List<Type>>();
            foreach (var assembly in assemblies)
            {
                var classes = assembly.GetTypes().Where(t => t.IsClass && t.Namespace != null && !t.Namespace.StartsWith("CSCG"));
                foreach (var cls in classes)
                    if(result.ContainsKey(cls.Namespace))
                        result[cls.Namespace].Add(cls);
                    else
                        result[cls.Namespace] = new List<Type>() {cls};
                
            }

            return result;
        }
    }
}
