using ComunityWeb.API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ComunityWeb.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ActivistController
    {
        List<ComunityWeb.API.Entities.Activist> activists = new List<Entities.Activist>()
        {
            new ComunityWeb.API.Entities.Activist()
            {
                Id = Guid.NewGuid(),
                Name = "Maria Gonzalez",
                Description = "I like to read and create ideas for people.",
                Email = "mariagonzalez@gmail.com"
                },
            new ComunityWeb.API.Entities.Activist()
            {
                Id = Guid.NewGuid(),
                Name = "Luis Martinez",
                Description = "I like to help people and create ideas for the community.",
                Email = "luismartinez@gmail.com"
                },
            new ComunityWeb.API.Entities.Activist()
            {
                Id = Guid.NewGuid(),
                Name = "Ana Lopez",
                Description = "I like to organize events and create ideas for the community.",
                Email = "analopez@gmail.com"
                },
            new ComunityWeb.API.Entities.Activist()
            {
                Id = Guid.NewGuid(),
                Name = "Carlos Ramirez",
                Description = "I like to volunteer and create ideas for the community.",
                Email = "carlosramirez@gmail.com"
                },
        };

        [HttpGet]
        public IActionResult GetActivists()
        {
            return new OkObjectResult(activists);
        }
        [HttpGet("{id}")]
        public IActionResult GetActivist(Guid id)
        {
            var activist = activists.FirstOrDefault(a => a.Id == id);
            if (activist == null)
            {
                return new NotFoundResult();
            }
            return new OkObjectResult(activist);
        }
        [HttpPost]
        public IActionResult CreateActivist(ComunityWeb.API.Entities.Activist activist)
        {
            activist.Id = Guid.NewGuid();
            activists.Add(activist);
            return new CreatedAtActionResult(nameof(GetActivist), "ActivistController", new { id = activist.Id }, activist);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateActivist(Guid id, ComunityWeb.API.Entities.Activist updatedActivist)
        {
            var activist = activists.FirstOrDefault(a => a.Id == id);
            if (activist == null)
            {
                return new NotFoundResult();
            }
            activist.Name = updatedActivist.Name;
            activist.Description = updatedActivist.Description;
            activist.Email = updatedActivist.Email;
            activist.Causes = updatedActivist.Causes;
            activist.IsActive = updatedActivist.IsActive;
            activist.Role = updatedActivist.Role;
            activist.ProfilePictureUrl = updatedActivist.ProfilePictureUrl;
            activist.PhoneNumber = updatedActivist.PhoneNumber;
            activist.SocialMediaLinks = updatedActivist.SocialMediaLinks;
            activist.Bio = updatedActivist.Bio;
            return new NoContentResult();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteActivist(Guid id)
        {
            var activist = activists.FirstOrDefault(a => a.Id == id);
            if (activist == null)
            {
                return new NotFoundResult();
            }
            activists.Remove(activist);
            return new NoContentResult();
        }
    }
}
