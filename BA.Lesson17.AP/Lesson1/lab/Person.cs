using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson17.AP.Lesson1.lab
{
    [Serializable]
    [DataContract]
    class Person
    {
        [DataMember(Name ="firstName")]
        //[DataMember]
        public string FirstName { get; set; }
        [DataMember(Name = "lastName")]
        //[DataMember]
        public string LastName { get; set; }
    }
}
