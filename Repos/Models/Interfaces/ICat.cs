﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Models.Interfaces
{
    public interface ICat
    {
        int Id { get; set; }
        string? ImageUrl { get; set; }
        string? UID { get; set; }
    }
}
