using Microsoft.AspNetCore.Mvc;

namespace ComunityWeb.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoordinatorControllers
    {
        List<ComunityWeb.API.Entities.Coordinator> coordinators = new List<Entities.Coordinator>()
        {
            new ComunityWeb.API.Entities.Coordinator()
            {
                Id = 1,
                Name = "Alice Diaz Montero",
                Email = "alicediazmontero@gmail.com"
                },
            new ComunityWeb.API.Entities.Coordinator()
            {
                Id = 2,
                Name = "Bob Johnson",
                Email = "bobjohnson@gmail.com"
                },
            new ComunityWeb.API.Entities.Coordinator()
            {
                Id = 3,
                Name = "Charlie Brown",
                Email = "charliebrown@gmail.com"
            },
            new Entities.Coordinator()
            {
                Id = 4,
                Name = "Alexa Genesis",
                Email = "alexagenesis@gmail.com"
            },
            };

        [HttpGet]
        public IActionResult GetCoordinators()
        {
            return new OkObjectResult(coordinators);
        }

        [HttpGet("{id}")]
        public IActionResult GetCoordinator(int id)
        {
            var coordinator = coordinators.FirstOrDefault(c => c.Id == id);
            if (coordinator == null)
            {
                return new NotFoundResult();
            }
            return new OkObjectResult(coordinator);
        }
        [HttpPost]
        public IActionResult CreateCoordinator(ComunityWeb.API.Entities.Coordinator coordinator)
        {
            coordinator.Id = coordinators.Max(c => c.Id) + 1;
            coordinators.Add(coordinator);
            return new CreatedAtActionResult(nameof(GetCoordinator), "CoordinatorControllers", new { id = coordinator.Id }, coordinator);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateCoordinator(int id, ComunityWeb.API.Entities.Coordinator updatedCoordinator)
        {
            var coordinator = coordinators.FirstOrDefault(c => c.Id == id);
            if (coordinator == null)
            {
                return new NotFoundResult();
            }
            coordinator.Name = updatedCoordinator.Name;
            coordinator.Email = updatedCoordinator.Email;
            return new NoContentResult();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCoordinator(int id)
        {
            var coordinator = coordinators.FirstOrDefault(c => c.Id == id);
            if (coordinator == null)
            {
                return new NotFoundResult();
            }
            coordinators.Remove(coordinator);
            return new NoContentResult();
        }
    }
}