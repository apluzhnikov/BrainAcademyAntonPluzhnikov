using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.BehaviouralPatterns.VisitorExample.Shapes
{
    public interface IShape
    {
        void Accept(IShapeVisitor shapeVisitor);
    }
}
