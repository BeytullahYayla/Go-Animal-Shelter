using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class PetOwner:IEntity
    {
        [Key]
        public int PetOwnerId { get; set; }


        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Tel { get; set; }
        public int PetId { get; set; }

        public List<Pet> pets { get; set; }
    }
}
