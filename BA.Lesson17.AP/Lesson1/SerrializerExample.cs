using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson17.AP.Lesson1
{
    [Serializable]
    [DataContract]
    class Address
    {
        [DataMember(Name = "country")]
        public string Country { get; set; }
        [DataMember(Name = "language")]
        public string Language { get; set; }
        [DataMember(Name = "phone")]
        public string PhoneCode { get; set; }
    }

    static class SerrializerExample
    {
        static private Address[] addresses = new Address[]
        {
            new Address(){Language = "UKR", Country="Ukraine", PhoneCode="+38"},
            new Address(){Language = "EN", Country="England", PhoneCode="+44"},
            new Address(){Language = "EN", Country="Ireland", PhoneCode="+35"}
        };

        internal static void DeSerrializeToJson() {
            using (var stream = File.Open("data.json", FileMode.OpenOrCreate))
            {
                DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(typeof(Address[]));
                var newaddresses = dataContractJsonSerializer.ReadObject(stream) as Address[];
                foreach (var address in addresses)
                {
                    Console.WriteLine($"country: {address.PhoneCode}");
                }
            }
        }

        static public void SerrializeToJson() {
            using (var stream = File.Open("data.json", FileMode.OpenOrCreate))
            {
                DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(typeof(Address[]));
                dataContractJsonSerializer.WriteObject(stream, addresses);
            }
        }


        static public void SerrializeToBinary() {
            using (var stream = File.Open("data.dat", FileMode.OpenOrCreate))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, addresses);
            }
        }

        static public void DeSerrializeToObj() {
            using (var stream = File.Open("data.dat", FileMode.OpenOrCreate))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                var newaddresses = binaryFormatter.Deserialize(stream) as Address[];
                foreach (var address in addresses)
                {
                    Console.WriteLine($"country: {address.Country}");
                }
            }


        }
    }
}
