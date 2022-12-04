using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace runtimeClass
{
    
    class Listboxfill<T>
    {
        

        public List<PropertyInfo> Props { get; set;}
        public T instance { get; set; }
    }
}
