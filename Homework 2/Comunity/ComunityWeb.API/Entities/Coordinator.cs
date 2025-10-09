namespace ComunityWeb.API.Entities
{
    public class Coordinator
    {
        public Coordinator() { }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime AssignedDate { get; set; } = DateTime.UtcNow;
        public string Department { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public string Role { get; set; } = "Coordinator";
        public string ProfilePictureUrl { get; set; } = string.Empty;
        public string ProfileImageUrl { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string OfficeLocation { get; set; } = string.Empty;
        public string Bio { get; set; } = string.Empty;
    }
}
