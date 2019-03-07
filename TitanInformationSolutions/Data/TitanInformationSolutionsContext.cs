using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TitanInformationSolutions.Models;

namespace TitanInformationSolutions.Data
{
    public class TitanInformationSolutionsContext : DbContext
    {
        public TitanInformationSolutionsContext (DbContextOptions<TitanInformationSolutionsContext> options)
            : base(options)
        {
        }

        public DbSet<TitanInformationSolutions.Models.Child> Child { get; set; }

        public DbSet<TitanInformationSolutions.Models.Instructor> Instructor { get; set; }

        public DbSet<TitanInformationSolutions.Models.Message> Message { get; set; }

        public DbSet<TitanInformationSolutions.Models.Parent> Parent { get; set; }

        public DbSet<TitanInformationSolutions.Models.BGCPrograms> BGCPrograms { get; set; }

        public DbSet<TitanInformationSolutions.Models.child_Section> child_Sections { get; set; }

        public DbSet<TitanInformationSolutions.Models.instructor_message> Instructor_Message { get; set; }

        public DbSet<TitanInformationSolutions.Models.instructor_Section> instructor_Sections { get; set; }
        
        public DbSet<TitanInformationSolutions.Models.Parent_Message> Parent_Message { get; set; }
        
        public DbSet<TitanInformationSolutions.Models.BGCProgram> BGCProgram { get; set; }
        
        public DbSet<TitanInformationSolutions.Models.Section> Section { get; set; }
        
        public DbSet<TitanInformationSolutions.Models.Posts> Posts { get; set; }

		public DbSet<TitanInformationSolutions.Models.Sub> Subs { get; set; }

		public object Parents { get; internal set; }


		/*protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {

        }*/
	}
}
