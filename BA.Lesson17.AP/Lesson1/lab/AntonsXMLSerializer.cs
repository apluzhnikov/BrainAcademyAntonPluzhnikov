using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BA.Lesson17.AP.Lesson1.lab
{
    class AntonsXMLSerializer : ISerializer
    {
        public void Deserialize(FileStream stream) {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            var person = xmlSerializer.Deserialize(stream) as Person;
            if (person != null && string.IsNullOrWhiteSpace(person.FirstName) && string.IsNullOrWhiteSpace(person.LastName))
                Console.WriteLine($"Name: {person.FirstName} {person.LastName}");
            else
                Console.WriteLine("Some parametres are empty"); 

        }

        public void Deserialize(string file) {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            using (var stream = File.Open(file, FileMode.OpenOrCreate))
            {
                var person = xmlSerializer.Deserialize(stream) as Person;
                if (person != null && string.IsNullOrWhiteSpace(person.FirstName) && string.IsNullOrWhiteSpace(person.LastName))
                    Console.WriteLine($"Name: {person.FirstName} {person.LastName}");
                else
                    Console.WriteLine("Some parametres are empty"); 
            }
        }

        public void Serialize(string file) {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            using (var stream = File.Open(file, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(stream, new Person { FirstName = "Anton", LastName = "Pluzhnikov" });
            }
        }
    }
}
