using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class PetImage:IEntity
    {
        public int PetImageId { get; set; }
        public int PetId { get; set; }
        public string ImagePath { get; set; }
    }
}
