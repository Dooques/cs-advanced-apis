using MagicSchoolApi.Models;
using MagicSchoolApi.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MagicSchoolApi.Controllers
{
    [Route("[controller]")]
    public class SpellController : ControllerBase
    {
        private readonly ISpellService _spellService;

        public SpellController(ISpellService spellService)
        {
            _spellService = spellService;
        }

        [Route("/")]
        public string Index()
        {
            return "Magic School API";
        }

        [HttpGet]
        public IActionResult GetAllSpells()
        {
            return Ok(_spellService.GetAllSpells()); 
        }
    }
}
