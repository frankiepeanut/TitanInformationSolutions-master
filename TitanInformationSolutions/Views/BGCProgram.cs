using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TitanInformationSolutions.Models
{
    public class BGCPrograms
    {

        public BGCPrograms()
        {
            this.Child_Programs = new HashSet<child_Section>();
        }
        public int ID { get; set; }

        public string Name { get; set; }

        [ScaffoldColumn(false)]
        public string desc { get; set; }

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
        public virtual ICollection<child_Section> Child_Programs { get; set; }

    }
}
