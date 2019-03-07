using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TitanInformationSolutions.Models
{
	public class Parent
	{

		public Parent()
		{
			this.childSections = new HashSet<child_Section>();
			this.Children = new HashSet<Child>();
			//messenger
			Subs = new HashSet<Sub>();
		}

		public int ID { get; set; }

		[StringLength(30)]
		public String firstName { get; set; }

		[StringLength(30)]
		public String lastName { get; set; }

		[StringLength(100)]
		public String email { get; set; }

		[RegularExpression("^\\d{10}$", ErrorMessage = "Please enter a valid 10-digit phone number (no spaces).")]
		[DataType(DataType.PhoneNumber)]
		[DisplayFormat(DataFormatString = "{0:(###) ###-####}", ApplyFormatInEditMode = false)]
		public Int64 phone { get; set; }

		public bool privNote { get; set; }
		public bool feedNote { get; set; }
		public virtual ICollection<child_Section> childSections { get; set; }
		public virtual ICollection<Parent_Message> Parent_Messages { get; set; }
		public virtual ICollection<Child> Children { get; set; }
		//messenger
		public ICollection<Sub> Subs { get; set; }
	}
}