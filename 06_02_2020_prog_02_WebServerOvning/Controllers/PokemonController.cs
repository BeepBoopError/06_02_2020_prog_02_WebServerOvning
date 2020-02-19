using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _06_02_2020_prog_02_WebServerOvning.Controllers
{
    [Route("api/pokemon")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        public static List<Pokemon> pokemons = new List<Pokemon>()
        {
            new Pokemon() {Name = "Spicelord", strength = 100},
            new Pokemon() {Name = "Ricelord", strength = 69},
            new Pokemon() {Name = "Icelord", strength = 120}
        };




        [HttpGet]
        public ActionResult MyPokemonGet()
        {
            /*Pokemon p = new Pokemon();
            p.Name = "Ekans";*/

            return Ok(pokemons);
        }


    }
}