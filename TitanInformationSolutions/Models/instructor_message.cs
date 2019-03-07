using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TitanInformationSolutions.Models
{
    public class instructor_message :Auditable
    {
        public int ID { get; set; }
        //make combination of child and activity ID in dataset
        public int instructorID { get; set; }
        public int messageID { get; set; }

        public virtual Message message { get; set; }
        public virtual Instructor Instructor { get; set; }


    }
}