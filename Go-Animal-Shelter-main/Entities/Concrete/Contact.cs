using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Contact:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
    }
}
