using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.BehaviouralPatterns.VisitorExample.Shapes
{
    public class Rectangle : IShape
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Rectangle(double x, double y) {
            X = x;
            Y = y;
        }

        public void Accept(IShapeVisitor shapeVisitor) {
            shapeVisitor.Visit(this);
        }
    }
}
