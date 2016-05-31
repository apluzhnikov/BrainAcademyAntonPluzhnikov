using PATTERNS.BehaviouralPatterns.VisitorExample.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.BehaviouralPatterns.VisitorExample
{
    class AreaCalculationVisitor : IShapeVisitor
    {
        public double Area { get; private set; }
        public void Visit(Rectangle rectangle) {
            Area = rectangle.X * rectangle.Y;
        }

        public void Visit(Circle circle) {
            Area = Math.PI * Math.Pow(circle.Radius, 2);
        }
    }
}
