using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace hw11
{
    [BsonIgnoreExtraElements]
    public class PhoneBookRecord
    {        
        public string Name { get; set; }

        public string Phone { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class PhoneBook
    {
        public List<PhoneBookRecord> Book { get; set; } = new List<PhoneBookRecord>();
    }
}
