using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademy.Components.Pages
{
	public class Teachers
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int teacher_id { get; set; }
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
		public byte work_since { get; set; }
		[Required]
		public byte rate { get; set; }
	}
}
