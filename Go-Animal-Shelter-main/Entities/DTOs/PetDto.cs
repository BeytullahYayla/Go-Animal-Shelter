using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class PetDto:IDto
    {
        public int PetId { get; set; }
        public int AnimalCategoryId { get; set; }

        public int SpeciesId { get; set; }
        public string PetName { get; set;}

        public string PetOwnerName { get; set; }
        public string AnimalCategoryName { get; set; }
        public string SpeciesName { get; set;}
        public int Age { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
    }
}
