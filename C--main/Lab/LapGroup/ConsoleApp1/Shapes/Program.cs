using Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            var radius = Convert.ToInt32(Console.ReadLine());
            IDrawable circle = new Circle(radius);
            circle.Draw();


            Console.Write("Enter width: ");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter height: ");
            var height = Convert.ToInt32(Console.ReadLine());
            IDrawable rect = new Rectangle(width, height);
            rect.Draw();

        }
    }
}
