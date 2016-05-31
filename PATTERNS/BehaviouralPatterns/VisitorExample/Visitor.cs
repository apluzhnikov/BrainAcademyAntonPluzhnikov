using PATTERNS.BehaviouralPatterns.VisitorExample.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PATTERNS.BehaviouralPatterns.VisitorExample.Exstensions;

namespace PATTERNS.BehaviouralPatterns.VisitorExample
{
    static class Visitor
    {
        public static void Run() {
            var circle = new Circle(10);
            var circleArea = circle.GetArea();

            var rectangle = new Rectangle(10, 30);
            var rectangleArea = rectangle.GetArea();

            Console.WriteLine($"circleArea: {circleArea}");
            Console.WriteLine($"rectangleArea: {rectangleArea}");
        }
    }
}
