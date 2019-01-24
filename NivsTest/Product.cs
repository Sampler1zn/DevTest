using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivsTest
{
    public abstract class Product
    {
        public string Name { get; set; }
        public char Size { get; set; }

        public abstract int GetDefaultPrice();
    }
}
