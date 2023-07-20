namespace DotNet7Relationships.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int BackpackId { get; set; }
        public Backpack Backpack { get; set; }
    }
}
