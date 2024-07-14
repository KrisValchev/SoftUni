using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Data.Models
{
	public class Homework
		
	{
        public Homework()
        {
				
        }
        [Key]
		public int HomeworkId { get; set; }
		[Required]
		public string Content { get; set; } = null!;
		[Required]
		public ContentType ContentType { get; set; }
		[Required]
		public DateTime SubmissionTime {  get; set; }
		[Required]
		public int StudentId { get; set; }

		[ForeignKey(nameof(StudentId))] 
		public Student Student { get; set; } = null!;

		[Required]
		public int CourseId {  get; set; }
		[ForeignKey(nameof(CourseId))]	
		public Course Course { get; set; } = null!;
	}
}
