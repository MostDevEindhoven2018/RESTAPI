﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPI
{
    public class Movie
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public double DurationSeconds { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
