namespace test.Models
{
    using MongoDB.Bson.Serialization.Attributes;
    using MongoDB.Driver;
    
    public class User
    {
        [BsonId]
        public string Id { get; set; }
        
        public string UserName { get; set; } = "";

        public string FirstName { get; set; } = "";

        public string LastName { get; set; } = "";

        public string Password { get; set; }
    }
}