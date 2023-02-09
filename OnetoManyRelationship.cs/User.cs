namespace OnetoManyRelationship.cs
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Character> characters { get; set; }

    }
}
