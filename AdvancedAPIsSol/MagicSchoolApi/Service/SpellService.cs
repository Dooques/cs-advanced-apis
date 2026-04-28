using System;
using MagicSchoolApi.Model;
using MagicSchoolApi.Repository;

namespace MagicSchoolApi.Service
{

    public interface ISpellService
    {
        public List<Spell> GetAllSpells();
    }
    public class SpellService : ISpellService
    {
        private readonly ISpellRepository _spellRepository;
        public SpellService(ISpellRepository spellRepository)
        {
            _spellRepository = spellRepository;
        }
        public List<Spell> GetAllSpells()
        {
            return _spellRepository.FetchAllSpells();

        }
    }
}
