namespace DotNet7Relationships.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Backpack Backpack { get; set; } = default!;
        public List<Weapon> Weapons { get; set; }
        public List<Faction> Factions { get; set; }
    }
}
