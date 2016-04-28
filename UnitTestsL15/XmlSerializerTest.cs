using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BA.Lesson15.AP;
using System.Xml.Linq;

namespace UnitTests
{
    [TestClass]
    public class XmlSerializerTest : SerializerTest
    {
        [TestMethod]
        public void SerrializeToXmlTest() {
            //arrange
            var flights = GetFlights();

            //act
            var xElement = BASerrializor.SerrializeToXml(flights);
            var elements = xElement.Descendants("Flight");

            var counter = 0;
            XAttribute attr = null;
            foreach(var item in elements)
            {
                counter++;
                attr = item.Attribute("Status");
            }

            //assert
            Assert.AreEqual(4, counter);
            Assert.IsTrue(attr.Value == "Arrived1");
        }
    }
}
