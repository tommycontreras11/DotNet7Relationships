using System.Text.Json.Serialization;

namespace DotNet7Relationships.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int CharacterId { get; set; }
        [JsonIgnore]
        public Character Character { get; set; } = default!;
    }
}
