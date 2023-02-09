using System.Text.Json.Serialization;

namespace OnetoManyRelationship.cs
{
    public class Character
    {
        public int id { get; set; }
        public string?  Name { get; set; }
        public string? HitPoints { get; set; }

        [JsonIgnore]
        public User user { get; set; }
        public int userid { get; set; }

    }
}