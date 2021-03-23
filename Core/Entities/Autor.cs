using MongoDB.Bson.Serialization.Attributes;


namespace apis.Core.Entities
{
    public class Autor
    {   
        [BsonId]
        public string id { get; set; }
    }
}