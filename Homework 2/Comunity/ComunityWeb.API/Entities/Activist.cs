using System;
using System.Collections.Generic;

namespace ComunityWeb.API.Entities
{
    public class Activist
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime JoinDate { get; set; } = DateTime.UtcNow;
        public List<string> Causes { get; set; } = new();
        public bool IsActive { get; set; } = true;
        public string Role { get; set; } = "Activist";
        public string ProfilePictureUrl { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string SocialMediaLinks { get; set; } = string.Empty;
        public string Bio { get; set; } = string.Empty;
    }
}
