using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BA.AP.Examples
{
    internal class CsvSerrializer
    {
        readonly string _columnSeparator;
        PropertyInfo[] propertyInfoArray;

        public CsvSerrializer(Type type, string columnSeparator) {
            _columnSeparator = columnSeparator;
            propertyInfoArray = type.GetProperties();
        }

        public string Serrialize<T>(IEnumerable<T> array) {
            StringBuilder sb = new StringBuilder();

            string title = GetTitle();
            sb.AppendLine(title);

            foreach (var element in array)
            {
                string line = GetLine(element);
                sb.AppendLine(line);
            }

            return sb.ToString();
        }

        private string GetLine<T>(T obj) {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < propertyInfoArray.Length; i++)
            {
                var value = propertyInfoArray[i].GetValue(obj);
                if (value != null)
                    sb.Append(value);

                if (i < propertyInfoArray.Length - 1)
                    sb.Append(_columnSeparator);
            }
            return sb.ToString();
        }

        private string GetTitle() {
            //return propertyInfoArray.Select(arg=>arg.Name).

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < propertyInfoArray.Length; i++)
            {
                var propertyAttribute = propertyInfoArray[i].GetCustomAttribute<CsvAttribute>();
                if (propertyAttribute != null)
                    sb.Append(propertyAttribute.ColumnName);

                if (i < propertyInfoArray.Length - 1)
                    sb.Append(_columnSeparator);
            }

            return sb.ToString();
        }
    }
}
