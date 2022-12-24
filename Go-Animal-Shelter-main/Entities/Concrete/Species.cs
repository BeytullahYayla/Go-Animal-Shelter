using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Species:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Pet> pets { get; set; }
    }
}
