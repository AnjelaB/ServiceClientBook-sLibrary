using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace BookLibrary
{
    [DataContract]
    class Book
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Auther { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public int Year { get; set; }
    }
}
