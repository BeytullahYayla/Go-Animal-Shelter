using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Pet:IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Animal Category")]
        public int AnimalCategoryId { get; set; }

        [Required]
        [DisplayName("Species")]
        public int speciesId { get; set; }

        [Required]
        [DisplayName("Pet Owner")]
        public int PetOwnerId { get; set; }

        [Required]
        
        public string Name { get; set; }
        [Required]
        
        public int Age { get; set; }
        [Required]
        public string Description { get; set; }
        [AllowNull]
        public string ImagePath { get; set; }


        public AnimalCategory animalCategory { get; set; }

        public Species species { get; set; }

        public PetOwner petOwner { get; set; }
    }
}
