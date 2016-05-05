using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson17.AP.Lesson1.lab
{
    class AntonsJsonSerializer : ISerializer
    {
        public void Deserialize(FileStream stream) {
            //DataContractSerializer sdas = null;
            
            //JavaScriptSerializer asdfad
            DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(typeof(Person));
            var person = dataContractJsonSerializer.ReadObject(stream) as Person;
            if (person != null && string.IsNullOrWhiteSpace(person.FirstName) && string.IsNullOrWhiteSpace(person.LastName))
                Console.WriteLine($"Name: {person.FirstName} {person.LastName}");
            else
                Console.WriteLine("Some parametres are empty");
        }

        public void Deserialize(string file) {
            using (var stream = File.Open(file, FileMode.OpenOrCreate))
            {
                DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(typeof(Person));
                var person = dataContractJsonSerializer.ReadObject(stream) as Person;
                if (person != null && string.IsNullOrWhiteSpace(person.FirstName) && string.IsNullOrWhiteSpace(person.LastName))
                    Console.WriteLine($"Name: {person.FirstName} {person.LastName}");
                else
                    Console.WriteLine("Some parametres are empty");

            }
        }

        public void Serialize(string file) {
            using (var stream = File.Open(file, FileMode.OpenOrCreate))
            {
                DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(typeof(Person));
                dataContractJsonSerializer.WriteObject(stream, new Person { FirstName = "Anton", LastName = "Pluzhnikov" });
            }
        }
    }
}
