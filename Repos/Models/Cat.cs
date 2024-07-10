using Repos.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Models
{
    public class Cat : Animal, ICat
    {
        public int Id { get; set; }
        public string? ImageUrl { get; set; }
        public string? UID { get; set; }
    }
}
