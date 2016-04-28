
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB10_03_2016.BattleField
{
    /// <summary>
    /// 
    /// </summary>
    class PositiveField : IField
    {
        //char _borderSybol;
        int _hight;
        int _width;
        string _word;
        string _error;
        //ConsoleColor _color;

        public int Width {
            get {
                return _width;
            }

            set {
                if (value > 3)
                    _width = value;
                else
                    _error += "The width of current Field is less than 3\n";
            }
        }

        public int Hight {
            get {
                return _hight;
            }

            set {
                if (value > 3)
                    _hight = value;
                else
                    _error += "The hight of current Field is less than 3\n";
            }
        }

        public string Word {
            get {
                return _word;
            }

            set {
                if (value.Length < _width - 2)
                    _word = value;
                else
                    _error += "The word lenght is bigger than width of current Field\n";
            }
        }

        public char BorderSybol { get; set; }

        public ConsoleColor BorderColor { get; set; }

        public string Image { get; set; }

        public string GetError() {
            return _error;
        }

        public static IField Create() {
            return new PositiveField();
        }

    }
}
