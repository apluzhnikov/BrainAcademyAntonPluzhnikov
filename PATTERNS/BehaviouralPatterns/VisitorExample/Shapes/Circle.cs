using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.BehaviouralPatterns.VisitorExample.Shapes
{
    public class Circle : IShape
    {        

        public Circle(double radius) {
            Radius = radius;
        }
        public double Radius { get; private set; }

        public void Accept(IShapeVisitor shapeVisitor) {
            shapeVisitor.Visit(this);
        }
    }
}
