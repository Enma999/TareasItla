using System.ComponentModel.DataAnnotations;

namespace ComunityWeb.Infraestructure.Models
{
    public class ActivistModel
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(200)]
        public string Name { get; set; }
        
        [Required, MaxLength(200)]
        public string Description { get; set; }
        
        [Required, MaxLength(200)]
        public string Type { get; set; }
        
        [Required, MaxLength(200)]
        public string TypeDescription { get; set; }
        
        [Required, MaxLength(200)]
        public string ImageUrl { get; set; }
        
        [Required, MaxLength(200)]
        public string ContactInfo { get; set; }
        
        [Required, MaxLength(200)]
        public string Email { get; set; }

        [Required, MaxLength(200)]
        public string PhoneNumber { get; set; }

        [Required, MaxLength(200)]
        public string Address { get; set; }
        
        [Required, MaxLength(200)]
        
        public List<ActivistModel> Activists { get; set; }
        public ActivistModel()
        {
            
        }
    }
}
