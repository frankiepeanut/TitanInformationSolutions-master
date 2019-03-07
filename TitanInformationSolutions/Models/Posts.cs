using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TitanInformationSolutions.Models
{
    public class Posts
    {
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

        public string Post { get; set; }

		public int ParentID { get; set; }

    }
}
