using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Models
{
	public class AnimalVaccinations
	{
		[Key]
		public int VaccinationsId { get; set; }
		[ForeignKey("AnimalId")]
		public int AnimalId { get; set; }
		public AnimalVaccinations() 
		{ 
			Schedule = new AnimalSchedule();
		}
		public string? Title { get; set; }
		public string? Description { get; set; }
		public decimal? Price { get; set; }
		public AnimalSchedule Schedule { get; set; }
	}
}
