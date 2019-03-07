using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TitanInformationSolutions.Models
{
    public class child_Section
    {
        
        //make combination of child and activity ID in dataset
        public int ID { get; set; }
        

        public int ChildID { get; set; }
        public virtual Child child { get; set; }
        public int SectionID { get; set; }
        public virtual Section Section { get; set; }


    }
}