﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Data.Models
{
	public class Resource
	{
        public Resource()
        {
            
        }
        [Key]
        public int ResourceId { get; set; }

		[Required]
		[MaxLength(50)]
		public string Name { get; set; } = null!;
		[Required]
		public string Url { get; set; } = null!;
		[Required]
		public ResourceType ResourceType { get; set; }
		[Required]
		public int CourseId { get; set; }
		[ForeignKey(nameof(CourseId))]
		public Course Course { get; set; } = null!;

	}
}
