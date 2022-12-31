using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class PetOwnerDto:IDto
    {
        public int Id { get; set; }
        public string PetOwnerName { get; set; }

        public string PetOwnerSurname { get; set; }
        public string PetOwnerEmail { get; set; }
        public string PetOwnerPhone { get; set; }

        public string PetName { get; set; }
    }
}
