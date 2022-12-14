using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class Service:IEntity
	{
		public int ServiceId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
	}
}
