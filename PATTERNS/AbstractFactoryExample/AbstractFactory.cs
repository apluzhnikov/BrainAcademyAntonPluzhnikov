using PATTERNS.AbstractFactoryExample.Default;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.AbstractFactoryExample
{
    static class AbstractFactory
    {
        public static void Run() {
            ISkinAbstractFactory skinFactory = new DefaultSkinAbstractFactory();

            IButton button = skinFactory.CreateButton();
            ITextBox textBox = skinFactory.CreateTextBox();

            button.Draw();
            textBox.Draw();
        }
    }
}

