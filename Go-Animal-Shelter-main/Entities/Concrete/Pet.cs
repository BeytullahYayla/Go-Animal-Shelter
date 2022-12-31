using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Pet:IEntity
    {
        [Key]
        public int Id { get; set; }

        public int AnimalCategoryId { get; set; }

        public int AnimalSpeciesId { get; set; }

        public int PetOwnerId { get; set; }


        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }


        public AnimalCategory animalCategory { get; set; }

        public Species species { get; set; }

        public PetOwner petOwner { get; set; }
    }
}
