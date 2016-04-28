using LAB10_03_2016.BattleField;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB10_03_2016.BattleField
{
    class ColoredFieldDrawer : IFieldDrawer
    {
        IField _field;
        string _error;

        public string DrawField() {
            if (_field != null)
            {
                CompileImage();
                return _field.Image;
            }
            return string.Empty;
        }

        public string GetError() {
            if (_field != null)
                _error += _field.GetError();
            else
                _error += "Field is not valid\n";

            return _error;
        }

        public void SetField(IField field) {
            if (field != null)
                _field = field;
            else
                _error += "Field is not valid\n";
        }

        /// <summary>
        /// Create a string image from IField
        /// </summary>
        private void CompileImage() {
            var sb = new StringBuilder();

            var padding = (_field.Width - _field.Word.Length) / 2;



            for (int i = 0; i < _field.Hight; i++)
            {
                /*switch (i)
                {
                    case 0:
                    case _field.Hight - 1:
                        sb.Append(new String(_field.BorderSybol, _field.Widh));
                        sb.AppendLine();
                        break;
                }*/
                if ((i == 0) || (i == _field.Hight - 1))
                {
                    sb.Append(new String(_field.BorderSybol, _field.Width));
                    sb.AppendLine();
                } else if (i == (_field.Hight / 2))
                {
                    sb.Append(_field.BorderSybol);
                    sb.Append(new String(' ', padding-1));
                    sb.Append(_field.Word);
                    sb.Append(new String(' ', padding));
                    sb.Append(_field.BorderSybol);
                    sb.AppendLine();
                } else
                {
                    sb.Append(_field.BorderSybol);
                    sb.Append(new String(' ', _field.Width - 2));
                    sb.Append(_field.BorderSybol);
                    sb.AppendLine();
                }
            }


            _field.Image = sb.ToString();
        }
    }
}
