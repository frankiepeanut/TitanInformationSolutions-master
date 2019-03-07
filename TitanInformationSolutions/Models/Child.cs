using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TitanInformationSolutions.Models
{
    public class Child
    {
        public Child()
        {
            this.ChildSections = new HashSet<child_Section>();
        }


        public int ID { get; set; }

        [StringLength(30)]
        public string firstName { get; set; }

        [StringLength(30)]
        public string lastName { get; set; }

        public DateTime DoB { get; set; }
        public TimeSpan age { get { return DateTime.Today - DoB; } }

        public int ParentID { get; set; }
        public virtual Parent Parent {get;set;}
        public virtual ICollection<child_Section> ChildSections { get; set; }
    }
}