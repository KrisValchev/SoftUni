using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Data.Models
{
	public class Course
	{
        public Course()
        {
			StudentsCourses = new HashSet<StudentCourse>();
			Homeworks=new HashSet<Homework>();
			Resources=new HashSet<Resource>();
		}
        [Key]	
		public int CourseId { get; set; }

		[Required]
		[MaxLength(80)]
		public string Name { get; set; } = null!;

		public string? Description  { get; set; }
		[Required]
		public DateTime StartDate { get; set; }
		[Required]
		public DateTime EndDate { get; set; }
		[Required]
		public decimal Price { get; set; }

		public ICollection<StudentCourse> StudentsCourses { get; set; }
		public ICollection<Homework> Homeworks { get; set; }
		public ICollection<Resource> Resources { get; set; }
	}
}
