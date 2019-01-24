using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivsTest
{
    public class FormalPants : Pants
    {
        public override int GetDefaultPrice()
        {
            return base.GetDefaultPrice() + 30;
        }
    }
}
