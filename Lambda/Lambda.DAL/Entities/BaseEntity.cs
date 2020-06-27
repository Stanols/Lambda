using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lambda.DAL.Entities
{
	public class BaseEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("Id", Order = 1, TypeName = "integer")]
		public int? Id { get; set; }
	}
}
