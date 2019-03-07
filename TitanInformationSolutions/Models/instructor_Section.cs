using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TitanInformationSolutions.Models
{
    public class instructor_Section
    {
        public int ID { get; set; }
//make combination of instructor and program ID's in dataset
        public int SectionID { get; set; }
        public int instructorID { get; set; }

        public virtual Instructor Instructor { get; set; }
        public virtual Section Section { get; set; }
    }
}