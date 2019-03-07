using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TitanInformationSolutions.Models
{
    public class Instructor
    {
        public Instructor()
        {
            this.Instructor_Sections = new HashSet<instructor_Section>();
            this.Instructor_Messages = new HashSet<instructor_message>();
        }


        public int ID { get; set; }

        [StringLength(30)]
        public string firstName { get; set; }

        [StringLength(30)]
        public string lastName { get; set; }

        public string FullName
        {
            get
            {
                return firstName + " " + lastName;
            }
        }
        public virtual ICollection<instructor_Section> Instructor_Sections { get; set; }
        public virtual ICollection<instructor_message> Instructor_Messages { get; set; }
    }
}