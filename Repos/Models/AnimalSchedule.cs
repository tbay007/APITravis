using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Models
{
	public class AnimalSchedule
	{
		[Key]
		public int ScheduleId { get; set; }
		[ForeignKey("VaccinationId")]
		public int VaccinationId { get; set; }
		public bool Reoccurring { get; set; } = false;
		public AnimalSchedule() { }
		public bool Monday { get; set; } = false;
		public bool Tuesday { get; set; } = false;
		public bool Wednesday { get;set; } = false;
		public bool Thursday { get; set; } = false;
		public bool Friday { get; set; } = false;
		public bool Saturday { get; set; } = false;
		public bool Sunday { get; set; } = false;
		public bool EveryDay { get; set; } = false;
		public bool Monthly { get; set; } = false;
		public bool Yearly { get; set; } = false;

		public DateTime StartDateForSchedule { get; set; }
	}
}
