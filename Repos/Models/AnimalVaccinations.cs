using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Models
{
	public class AnimalVaccinations
	{
		[Key]
		public int Id { get; set; }
		public int AnimalId { get; set; }
		public AnimalVaccinations() { }
		public string? Title { get; set; }
		public string? Description { get; set; }
		public decimal? Price { get; set; }
		public AnimalSchedule Schedule { get; set; }
	}
}
