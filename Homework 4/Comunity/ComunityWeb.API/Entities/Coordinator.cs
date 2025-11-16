namespace ComunityWeb.API.Entities
{
    public class Coordinator
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Role { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public List<Activist> Coordinators { get; set; }
        public Coordinator()
        {
            
        }

    }
}
