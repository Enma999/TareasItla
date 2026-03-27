using ComunityWeb.API.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ComunityWeb.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChairmanController
    {
        List<ComunityWeb.API.Entities.Chairman> chairmen = new List<Entities.Chairman>()
        {
            new ComunityWeb.API.Entities.Chairman()
            {
                Id = 1,
                Name = "Juan",
                Description = "Presidente de la Comunidad",
                ChairmanId = 1,
            },

            new ComunityWeb.API.Entities.Chairman()
            {
                Id = 2,
                Name = "Maria",
                Description = "Jefa de la Comunidad",
                ChairmanId = 2,
            },

            new ComunityWeb.API.Entities.Chairman()
            {
                Id = 3,
                Name = "Adriel",
                Description = "Gobernador de la Comunidad",
                ChairmanId = 3,
            },

            new ComunityWeb.API.Entities.Chairman()
            {
                Id = 4,
                Name = "Jonathan",
                Description = "Jefe, Trabajador de la Comunidad",
                ChairmanId = 4,
            }
        };

        [HttpGet]
        public IActionResult GetChairman()
        {
            return new OkObjectResult(chairmen);
        }

        [HttpGet("{id}")]
        public IActionResult GetChairman(int Id)
        {
            var chairman = chairmen.FirstOrDefault(a => a.Id == Id);
            if (chairman == null)
            {
                return new NoContentResult();
            }
            return new OkObjectResult(chairman);
        }

        [HttpPost]
        public IActionResult CreateChaiman(ComunityWeb.API.Entities.Chairman chairman)
        {
            chairman.Id = chairmen.Max(a => a.Id) + 1;
            chairmen.Add(chairman);
            return new CreatedAtActionResult(nameof(GetChairman), "ChairmanController", new { Id = chairman.Id }, chairman);
        }

        [HttpPut]
        public IActionResult UpdateChairman(int Id, ComunityWeb.API.Entities.Chairman updatedChairman)
        {
            var chairman = chairmen.FirstOrDefault(c => c.Id == Id);
            if (chairman == null)
            {
                return new NoContentResult();
            }
            chairman.Name = updatedChairman.Name;
            chairman.Description = updatedChairman.Description;
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteChairman(int Id)
        {
            var chairman = chairmen.FirstOrDefault(c => c.Id == Id);
            if (chairman == null)
            {
                return new NoContentResult();
            }
            chairmen.Remove(chairman);
            return new NoContentResult();
        }
    }
}
