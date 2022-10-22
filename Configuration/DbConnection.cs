namespace BarhiLibrarayApi.Configuration
{
    public class DbConnection : IDbConnection
    {
        
        public string GetDbConnection()
        {
            return @"mongodb+srv://reza:reza@cluster0.atmfiax.mongodb.net/?retryWrites=true&w=majority";
        }

       
    }
}
