using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Pet:IEntity
    {
        public int PetId { get; set; }
        public int AnimalCategoryId { get; set; }
        public int SpeciesId { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Image { get; set; }
    }
}
