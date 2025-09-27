using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using BlazorAcademy.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorAcademy.Components.Pages
{
	public class Teachers:Human
	{
		//[Key]
		//[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		//public int teacher_id { get; set; }
		//[Required]
		//public string last_name { get; set; }
		//[Required]
		//public string first_name { get; set; }
		//[Required]
		//public string middle_name { get; set; }
		//[Required]
		//[DataType(DataType.Date)]
		//public byte birth_date { get; set; }
		//[Required]
		//public string email { get; set; }
		//public byte phone { get; set; }
		//public byte photo { get; set; }
		//public byte work_since { get; set; }
		//[Required]
		//public decimal rate { get; set; }

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public short teacher_id { get; set; }
		[Required]
		public DateOnly work_since { get; set; } 
		[Required]
		public decimal rate { get; set; }
	}
}