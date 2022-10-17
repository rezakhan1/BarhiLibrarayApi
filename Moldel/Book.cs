namespace BarhiLibrarayApi.Moldel
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Book
    {
        public string id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public object author_firstname { get; set; }
        public string author_lastname { get; set; }
        public string author_middlename { get; set; }
        public string categories { get; set; }
        public string volume { get; set; }
        public string year { get; set; }
        public string edition { get; set; }
        public string language { get; set; }
        public string extension { get; set; }
        public string pages { get; set; }
        public string filesize { get; set; }
        public string md5 { get; set; }
        public string series { get; set; }
        public string periodical { get; set; }
        public string file_extension { get; set; }
        public string url { get; set; }
        public ConvertTo convertTo { get; set; }
        public string description { get; set; }
        public string cover { get; set; }
    }

    public class ConvertTo
    {
        public string epub { get; set; }
        public string fb2 { get; set; }
        public string mobi { get; set; }
        public string txt { get; set; }
        public string rtf { get; set; }
    }

    public class Root
    {
        public List<Book> books { get; set; }
    }


}
