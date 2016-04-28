using LAB10_03_2016.BattleField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB10_03_2016
{
    class Program
    {
        
        static void Main(string[] args) {

            IField field = PositiveField.Create();
            IFieldDrawer fieldDrawer = new ColoredFieldDrawer();


            FillFieldInfo(field);

            fieldDrawer.SetField(field);
            string error = fieldDrawer.GetError();
            if (string.IsNullOrWhiteSpace(error))
                Console.WriteLine(fieldDrawer.DrawField());
            else
                Console.WriteLine(error);

            Console.ReadLine();
        }

        private static void FillFieldInfo(IField field) {
            Console.WriteLine("Please enter a width:");
            int width = new int();
            int.TryParse(Console.ReadLine(), out width);
            field.Width = width;

            Console.WriteLine("Please enter a hight:");
            int height = new int();
            int.TryParse(Console.ReadLine(), out height);
            field.Hight = height;

            Console.WriteLine("Please enter a border symbol:");
            field.BorderSybol = Console.ReadLine()[0];

            Console.WriteLine("Please enter a name of field:");
            field.Word = Console.ReadLine();
        }
    }
}
