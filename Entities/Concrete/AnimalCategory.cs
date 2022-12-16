using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class AnimalCategory:IEntity
	{
		[Key]
		public int AnimalCategoryId { get; set; }
		public string Name { get; set; }
	}
}
