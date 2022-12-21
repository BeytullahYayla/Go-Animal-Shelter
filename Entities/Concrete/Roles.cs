using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Roles:IEntity
    {
        [Key]
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; }
        public int Password { get; set; }

        public List<User> users { get; set; }
    }
}
