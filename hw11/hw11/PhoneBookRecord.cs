using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace hw11
{
    /// <summary>
    /// A separate record in a phone book -- a document in data base.
    /// </summary>
    [BsonIgnoreExtraElements]
    public class PhoneBookRecord
    {        
        public string Name { get; set; }

        public string Phone { get; set; }
    }
}
