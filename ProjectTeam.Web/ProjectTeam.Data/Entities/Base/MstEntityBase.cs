using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTeam.Data.Entities.Base
{
	public abstract class MstEntityBase
	{
		public int Id { get; set; }
		public int? DisplayOrder { get; set; }
		public DateTime? CreatedDate { get; set; }
		public DateTime? DeletedDate { get; set; }
	}
}
