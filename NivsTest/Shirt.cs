using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivsTest
{
    public class Shirt : Product
    {
        public override int GetDefaultPrice()
        {
            switch (base.Size)
            {
                case 's':
                    return 10;
                case 'm':
                    return 20;
                case 'l':
                    return 30;
                default:
                    return 0;
            }
        }
    }
}
