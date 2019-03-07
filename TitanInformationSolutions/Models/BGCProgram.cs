using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TitanInformationSolutions.Models
{
    public class BGCProgram
    {

        public BGCProgram()
        {
            this.Sections = new HashSet<Section>();
        }
        public int ID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [ScaffoldColumn(false)]
        public string desc { get; set; }

        public virtual ICollection<Section> Sections { get; set; }
    }
}
