using Microsoft.AspNetCore.Mvc;

namespace ComunityWeb.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MemberController : ControllerBase
    {
        List<ComunityWeb.API.Entities.Member> members = new List<Entities.Member>()
        {     new ComunityWeb.API.Entities.Member()
            {
                Id = 1,
                Name = "John Doe",
                Email = "johndoe@gmail.com"
            },
            new ComunityWeb.API.Entities.Member()
            {
                Id = 2,
                Name = "Jane Smith",
                Email = "janesmith@gmail.com"
                }
            };

        [HttpGet]
        public IActionResult GetMembers()
        {
            return Ok(members);
        }

        [HttpGet("{id}")]

        public IActionResult GetMember(int id)
        {
            var member = members.FirstOrDefault(m => m.Id == id);
            if (member == null)
            {
                return NotFound();
            }
            return Ok(member);
        }

        [HttpPost]
        public IActionResult CreateMember(ComunityWeb.API.Entities.Member member)
        {
            member.Id = members.Max(m => m.Id) + 1;
            members.Add(member);
            return CreatedAtAction(nameof(GetMember), new { id = member.Id }, member);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateMember(int id, ComunityWeb.API.Entities.Member updatedMember)
        {
            var member = members.FirstOrDefault(m => m.Id == id);
            if (member == null)
            {
                return NotFound();
            }
            member.Name = updatedMember.Name;
            member.Email = updatedMember.Email;
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMember(int id)
        {
            var member = members.FirstOrDefault(m => m.Id == id);
            if (member == null)
            {
                return NotFound();
            }
            members.Remove(member);
            return NoContent();
        }
        }
    }