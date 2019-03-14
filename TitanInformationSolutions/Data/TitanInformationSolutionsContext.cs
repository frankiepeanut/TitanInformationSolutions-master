using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using TitanInformationSolutions.Models;

namespace TitanInformationSolutions.Data
{
    public class TitanInformationSolutionsContext : DbContext
    {

        public TitanInformationSolutionsContext(DbContextOptions<TitanInformationSolutionsContext> options)
            : base(options)
        {
            UserName = "SeedData";
        }

        public TitanInformationSolutionsContext(DbContextOptions<TitanInformationSolutionsContext> options, IHttpContextAccessor httpContextAccessor)
            : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
            UserName = _httpContextAccessor.HttpContext?.User.Identity.Name;
            UserName = (UserName == null) ? "Unknown" : UserName;
        }

        private readonly IHttpContextAccessor _httpContextAccessor;

        public string UserName
        {
            get; private set;
        }

        public DbSet<Child> Children { get; set; }

        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Parent> Parents { get; set; }

        public DbSet<BGCProgram> BGCPrograms { get; set; }

        public DbSet<child_Section> child_Sections { get; set; }

        public DbSet<instructor_message> Instructor_Messages { get; set; }

        public DbSet<instructor_Section> instructor_Sections { get; set; }
        
        public DbSet<Parent_Message> Parent_Messages { get; set; }
        
        public DbSet<Section> Sections { get; set; }
        
        public DbSet<Posts> Posts { get; set; }

		public DbSet<Sub> Subs { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //}
    }
}
