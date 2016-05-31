using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.BehaviouralPatterns.VisitorExample.Shapes
{
    public interface IShapeVisitor
    {
        void Visit(Circle circle);
        void Visit(Rectangle rectangle);
    }
}
