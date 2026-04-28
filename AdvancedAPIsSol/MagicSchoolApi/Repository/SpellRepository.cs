using MagicSchoolApi.Model;
using System.Text.Json;

namespace MagicSchoolApi.Repository
{
    public interface ISpellRepository
    {
        public List<Spell> FetchAllSpells();
    }
    public class SpellRepository : ISpellRepository
    {
        public List<Spell> FetchAllSpells()
        {
            var jsonSpells = File.ReadAllText("Resources\\spells.json");
            var spells = JsonSerializer.Deserialize<List<Spell>>(jsonSpells);
            return spells; 
        }
    }
}
