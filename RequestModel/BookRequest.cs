using MongoDB.Bson.Serialization.Attributes;

namespace BarhiLibrarayApi.RequestModel
{
    public class BookRequest
    {
        
        [BsonElement("DonatedDate")]
        public string? DonatedDate { get; set; }

        [BsonElement("donarId")]
        public string? DonarId { get; set; }

        [BsonElement("title")]
        public string Title { get; set; }

        [BsonElement("author")]
        public string Author { get; set; }

        [BsonElement("categories")] 
        public string Categories { get; set; }

        [BsonElement("volume")]
        public string Volume { get; set; }

        [BsonElement("year")]
        public string Year { get; set; }


        [BsonElement("edition")]
        public string Edition { get; set; }

        [BsonElement("language")]
        public string Language { get; set; }


        [BsonElement("extension")]
        public string Extension { get; set; }


        [BsonElement("pages")]
        public string Pages { get; set; }


        [BsonElement("filesize")]
        public string Filesize { get; set; }

        [BsonElement("series")]
        public string Series { get; set; }


        [BsonElement("description")]  
        public string Description { get; set; }

        [BsonElement("cover")]
        public string Cover { get; set; }
    }
}
