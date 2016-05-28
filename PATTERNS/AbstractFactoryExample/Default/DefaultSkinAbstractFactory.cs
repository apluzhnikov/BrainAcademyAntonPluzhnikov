using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.AbstractFactoryExample.Default
{
    class DefaultSkinAbstractFactory : ISkinAbstractFactory
    {
        public IButton CreateButton() {
            return new DefaultButton();
        }

        public ITextBox CreateTextBox() {
            return new DefaultTextBox();
        }
    }
}
