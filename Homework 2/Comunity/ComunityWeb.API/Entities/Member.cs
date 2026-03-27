using System;
using System.Collections.Generic;

namespace ComunityWeb.API.Entities
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime JoinDate { get; set; } = DateTime.UtcNow;
        public List<string> Interests { get; set; } = new();
        public bool IsActive { get; set; } = true;
        public string Role { get; set; } = "Member";
        public string ProfilePictureUrl { get; set; } = string.Empty;
    }
}
