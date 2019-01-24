using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var basket = new Basket();

            var tshirt = new TShirt();
            tshirt.Name = "DC Comics";
            tshirt.Size = 'l';
            basket.Shirts.Add(tshirt);

            Console.WriteLine($"Your total price is {basket.GetTotalPrice()}");
            Console.Read();

        }
    }
}
