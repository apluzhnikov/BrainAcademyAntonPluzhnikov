using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.AP.Examples
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public sealed class CsvAttribute : Attribute
    {
        readonly string _columnName;
        public CsvAttribute(string columnName) {
            _columnName = columnName;
        }

        public string ColumnName => _columnName;//property get; :))))))

        private string ColumnNamePrivate => _columnName;//property get; :))))))
    }


    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public sealed class CustomAttribute : Attribute
    {
        public string Update { get; set; }
        public string Encode { get; set; }
    }
}
