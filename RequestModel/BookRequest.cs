using MongoDB.Bson.Serialization.Attributes;

namespace BarhiLibrarayApi.RequestModel
{
    public class BookRequest
    {

      
        public string? DonatedDate { get; set; }

      
        public string? DonarId { get; set; }

        
        public string Title { get; set; }

    
        public string? Author { get; set; }

       
        public string? Categories { get; set; }

      
        public string? Volume { get; set; }

     
        public string? Year { get; set; }


      
        public string? Edition { get; set; }

      
        public string? Language { get; set; }


        public string? Extension { get; set; }


        
        public string? Pages { get; set; }


       
        public string? Filesize { get; set; }

       
        public string? Series { get; set; }


         
        public string? Description { get; set; }

         
        public string? Cover { get; set; }
    }
}
