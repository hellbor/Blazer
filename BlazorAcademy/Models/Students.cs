using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademy.Models
{
	public class Students
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int stud_id { get; set; }
		[Required]
		public string last_name { get; set; }
		[Required]
		public string first_name { get; set; }
		[Required]
		public string middle_name { get; set; }
		[Required]
		public byte birth_date { get; set; }
		[Required]
		[DataType(DataType.Date)]
		public string email { get; set; }
		[Required]
		public byte phone { get; set; }
		[Required]
		public byte photo { get; set; }
		[Required]
		public int group { get; set; }
	}
}
