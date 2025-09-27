using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademy.Models
{
	public class Disciplines
	{
		[Key]
		//[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int discipline_id { get; set; }
		[Required]
		public string? discipline_name { get; set; }
		[Required]
		public int number_of_lessons { get; set; }
	}
}
