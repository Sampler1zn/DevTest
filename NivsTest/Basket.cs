using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivsTest
{
    public class Basket
    {
        public Basket()
        {
            Shirts = new List<Shirt>();
            Pants = new List<Pants>();
        }

        public List<Shirt> Shirts { get; set; }
        public List<Pants> Pants { get; set; }

        public int GetTotalPrice()
        {
            var total = 0;

            if (Shirts.Count != 0)
            {
                foreach (var Shirt in Shirts)
                {
                    total += Shirt.GetDefaultPrice();
                }
            }

            if (Pants.Count != 0)
            {
                foreach (var Item in Pants)
                {
                    total += Item.GetDefaultPrice();
                }
            }

            return total;
        }
    }
}
