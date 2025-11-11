using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunityWeb.Infraestructure.Models
{
    public class MemberModel
    {
        [Key]
        public int Id { get; set; }
        
        [Required, MaxLength(200)]
        public string Name { get; set; }
        
        [Required, MaxLength(200)]
        public string Email { get; set; }
        
        [Required, MaxLength(200)]
        public string Phone { get; set; }

        [Required, MaxLength(200)]
        public string Address { get; set; }

        [Required, MaxLength(200)]
        public string City { get; set; }
        
        [Required, MaxLength(200)]
        public string Region { get; set; }

        [Required, MaxLength(200)]
        public string PostalCode { get; set; }
        
        [Required, MaxLength(200)]
        public string Country { get; set; }

        [Required, MaxLength(200)]
        public string PhoneNumber { get; set; }
        
        [Required, MaxLength(200)]
        public string Role { get; set; }

        [Required, MaxLength(200)]

        public List<MemberModel> Members { get; set; }
        public MemberModel()
        {
            
        }
    }
}
