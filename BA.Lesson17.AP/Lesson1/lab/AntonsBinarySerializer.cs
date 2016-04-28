using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson17.AP.Lesson1.lab
{
    class AntonsBinarySerializer : ISerializer
    {
        public void Deserialize(FileStream stream) {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            var person = binaryFormatter.Deserialize(stream) as Person;
            if (person != null && string.IsNullOrWhiteSpace(person.FirstName) && string.IsNullOrWhiteSpace(person.LastName))
                Console.WriteLine($"Name: {person.FirstName} {person.LastName}");
            else
                Console.WriteLine("Some parametres are empty");
        }

        public void Deserialize(string file) {
            using (var stream = File.Open(file, FileMode.OpenOrCreate))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                var person = binaryFormatter.Deserialize(stream) as Person;
                if (person != null && string.IsNullOrWhiteSpace(person.FirstName) && string.IsNullOrWhiteSpace(person.LastName))
                    Console.WriteLine($"Name: {person.FirstName} {person.LastName}");
                else
                    Console.WriteLine("Some parametres are empty");
            }
        }

        public void Serialize(string file) {
            using (var stream = File.Open(file, FileMode.OpenOrCreate))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, new Person { FirstName = "Anton", LastName = "Pluzhnikov" });
            }
        }
    }
}
