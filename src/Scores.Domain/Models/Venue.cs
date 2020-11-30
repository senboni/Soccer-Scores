﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scores.Domain.Models
{
    public class Venue
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        public int Capacity { get; set; }
        public int YearOpened { get; set; }

        public City City { get; set; }
    }
}