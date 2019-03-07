using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TitanInformationSolutions.Models
{
    public class Section
    {
        public Section()
        {
            this.ChildSections = new HashSet<child_Section>();
            this.InstructorSections = new HashSet<instructor_Section>();
        }

        public int ID { get; set; }

        [ScaffoldColumn(false)]
        public DateTime Start { get; set; }

        [ScaffoldColumn(false)]
        public DateTime End { get; set; }

        public string Day
        {
            get
            {
                return Start.DayOfWeek.ToString();
            }
        }

        public string Time
        {
            get
            {
                return Start.ToShortTimeString();
            }
        }

        public string Duration
        {
            get
            {
                TimeSpan D = End - Start;
                return D.ToString();
            }
        }

        public string Location { get; set; }
        public virtual ICollection<child_Section> ChildSections { get; set; }

        public virtual ICollection<instructor_Section> InstructorSections { get; set; }
public int BGCProgramID { get; set; }

        [Display(Name = "Program")]

        public virtual BGCProgram BGCProgram { get; set; }
    }
}
