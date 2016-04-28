using BA.Lesson15.AP;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class CSVSerializerTest : SerializerTest
    {
        [TestMethod]
        public void SerrializeToCsvTest() {
            var flights = GetFlights();

            var text = BASerrializor.SerrializeToCsv(flights, ";");
            var title = string.Empty;
            var firstRow = string.Empty;
            using (StringReader stringReader = new StringReader(text))
            {
                title = stringReader.ReadLine();
                firstRow = stringReader.ReadLine();
            }

            Assert.AreEqual("CsvCity;CsvNumber;CsvStatus", title);
            Assert.AreEqual("London;1;Unknown", firstRow, "my message");
        }

    }
}
