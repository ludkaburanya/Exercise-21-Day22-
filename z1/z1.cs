using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    internal class z1
    {
        private static z1 uniqueInstance;
        public string Name { get; set; }
        private z1()
        {

        }
        public static z1 GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new z1();
            }
            return uniqueInstance;
        }
    }
}
