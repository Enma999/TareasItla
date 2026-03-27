using System.ComponentModel.DataAnnotations;

namespace ComunityWeb.Infraestructure.Models
{
    public class CoordinatorModel
    {
        [Key]
        public int Id { get; set; }
        
        [Required, MaxLength(200)]
        public string Name { get; set; }
        
        [Required, MaxLength(200)]
        public string Description { get; set; }

        [Required, MaxLength(200)]
        public string Role { get; set; }
        
        [Required, MaxLength(200)]
        public string UserName { get; set; }
        
        [Required, MaxLength(200)]
        public string Email { get; set; }
        
        [Required, MaxLength(200)]
        public string PhoneNumber { get; set; }
        
        [Required, MaxLength(200)]
        public string Address { get; set; }

        [Required, MaxLength(200)]

        public List<CoordinatorModel> Coordinators { get; set; }
        public CoordinatorModel()
        {

        }
    }
}
