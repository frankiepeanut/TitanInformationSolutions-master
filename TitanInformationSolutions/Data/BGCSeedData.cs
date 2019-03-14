using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TitanInformationSolutions.Models;
using TitanInformationSolutions.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace TitanInformationSolutions.Data
{
	public static class BGCSeedData
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{

			using (var context = new TitanInformationSolutionsContext(
				serviceProvider.GetRequiredService<DbContextOptions<TitanInformationSolutionsContext>>()))
			{

                if (!context.Instructors.Any())
                {
                    context.Instructors.AddRange(
                     new Instructor
                     {
                         firstName = "Jiminy",
                         lastName = "Cricket",
                         email = "jcricket@outlook.com"
                     },

                     new Instructor
                     {
                         firstName = "Carole",
                         lastName = "Haines",
                         email = "chaines@outlook.com"
                     },
                     new Instructor
                     {
                         firstName = "Robert",
                         lastName = "Fripp",
                         email = "rfripp@outlook.com"
                     }
                );
                    context.SaveChanges();
                }
                if (!context.Parents.Any())
				{
					context.Parents.AddRange(
					new Parent
					{
						firstName = "Wilma",
						lastName = "Flintstone",
						email = "wflintstone@outlook.com",
						phone = 1234567889,
						privNote = true,
						feedNote = false
					},
					new Parent
					{
						firstName = "George",
						lastName = "Jetson",
						email = "Gjetson@gmail.com",
						phone = 2345678912,
						privNote = true,
						feedNote = true

					},
					new Parent
					{
						firstName = "Homer",
						lastName = "Simpson",
						email = "hsimpson@yahoo.com",
						phone = 1234567889,
						privNote = true,
						feedNote = true
					});
					context.SaveChanges();
				}

				if (!context.Children.Any())
				{
					context.Children.AddRange(
						new Child
						{
							firstName = "Elroy",
							lastName = "Jetson",
							ParentID = context.Parents.FirstOrDefault(d => d.firstName == "George" && d.lastName == "Jetson").ID
						},
						new Child
						{
							firstName = "Judy",
							lastName = "Jetson",
							ParentID = context.Parents.FirstOrDefault(d => d.firstName == "George" && d.lastName == "Jetson").ID
						},
						new Child
						{
							firstName = "Pebbles",
							lastName = "Flintstone",
							ParentID = context.Parents.FirstOrDefault(d => d.firstName == "Wilma" && d.lastName == "Flintstone").ID
						},
						new Child
						{
							firstName = "Bart",
							lastName = "Simpson",
							ParentID = context.Parents.FirstOrDefault(d => d.firstName == "Homer" && d.lastName == "Simpson").ID
						});
					context.SaveChanges();

				}

                if (!context.BGCPrograms.Any())
                {
                    context.BGCPrograms.AddRange(
                        new BGCProgram
                        {
                            Name = "Aquatics",
                            desc = "Teach your kid to swim!"
                        },
                        new BGCProgram
                        {
                            Name = "Child Care",
                            desc = "Our daycare centre"
                        },
                        new BGCProgram
                        {
                            Name = "Soccer",
                            desc = "Have fun and get outside!"
                        }
                        );
                    context.SaveChanges();

                }

               // if (!context.Sections.Any())
				//{
					context.Sections.AddRange(
						new Section
						{
							Start = DateTime.Parse("02/13/2019,12:0:0"),
							End = DateTime.Parse("02/13/2019,14:0:0"),
							Location = "Burgoyne Woods Swimming Pool",
							//BGCProgramID = context.BGCPrograms.FirstOrDefault(d => d.Name == "Aquatics").ID
						},
						new Section
						{
							Start = DateTime.Parse("02/14/2019,12:0:0"),
							End = DateTime.Parse("02/14/2019,14:0:0"),
							Location = "Burgoyne Woods Swimming Pool",
							//BGCProgramID = context.BGCPrograms.FirstOrDefault(d => d.Name == "Aquatics").ID
						},
						new Section
						{
							Start = DateTime.Parse("02/12/2019,9:0:0"),
							End = DateTime.Parse("02/12/2019,18:0:0"),
							Location = "St Catharines Centre",
							//BGCProgramID = context.BGCPrograms.FirstOrDefault(d => d.Name == "Child Care").ID
						},
						new Section
						{
							Start = DateTime.Parse("02/13/2019,15:0:0"),
							End = DateTime.Parse("02/13/2019,16:0:0"),
							Location = "Lancaster Park",
							BGCProgramID = context.BGCPrograms.FirstOrDefault(d => d.Name == "Soccer").ID
						});
					context.SaveChanges();

				//}		

				if (!context.child_Sections.Any())
				{
					context.child_Sections.AddRange(
						new child_Section
						{
							ChildID = context.Children.FirstOrDefault(c => c.firstName == "Elroy").ID,
							SectionID = context.Sections.FirstOrDefault(p => p.BGCProgram.Name == "Soccer").ID
						},
						new child_Section
						{
							ChildID = context.Children.FirstOrDefault(c => c.firstName == "Judy").ID,
							SectionID = context.Sections.FirstOrDefault(p => p.BGCProgram.Name == "Soccer").ID
						},
						new child_Section
						{
							ChildID = context.Children.FirstOrDefault(c => c.firstName == "Bam-Bam").ID,
							SectionID = context.Sections.FirstOrDefault(p => p.BGCProgram.Name == "Child Care").ID
						},
						new child_Section
						{
							ChildID = context.Children.FirstOrDefault(c => c.firstName == "Bart").ID,
							SectionID = context.Sections.FirstOrDefault(p => p.BGCProgram.Name == "Aquatics").ID
						}
						);
					context.SaveChanges();
				}
				if (!context.instructor_Sections.Any())
				{
					context.instructor_Sections.AddRange(
						new instructor_Section
						{
							instructorID = context.Instructors.FirstOrDefault(c => c.firstName == "Jiminy").ID,
							SectionID = context.Sections.FirstOrDefault(p => p.BGCProgram.Name == "Aquatics").ID
						},
						new instructor_Section
						{
							instructorID = context.Instructors.FirstOrDefault(c => c.firstName == "Robert").ID,
							SectionID = context.Sections.FirstOrDefault(p => p.BGCProgram.Name == "Child Care").ID
						},
						new instructor_Section
						{
							instructorID = context.Instructors.FirstOrDefault(c => c.firstName == "Carole").ID,
							SectionID = context.Sections.FirstOrDefault(p => p.BGCProgram.Name == "Haines").ID
						});
					context.SaveChanges();
				}

				if (!context.Posts.Any())
				{
					context.Posts.AddRange(
						 new Posts
						 {
							 firstName = "Carole",
							 lastName = "Haines",
							 Post = "Bring spare clothes!",
							 ParentID = context.Parents.FirstOrDefault(c => c.firstName == "George").ID
						 },
					   new Posts
					   {
						   firstName = "Jiminy",
						   lastName = "Cricket",
						   ParentID = context.Parents.FirstOrDefault(c => c.firstName == "Homer").ID,
						   Post = "Late start today"
					   },
					   new Posts
					   {
						   firstName = "Robert",
						   lastName = "Fripp",
						   ParentID = context.Parents.FirstOrDefault(c => c.firstName == "Wilma").ID,
						   Post = "We are learning how to paint today, so come prepared to make a mess!"
					   });
					context.SaveChanges();
				}


			}
		}
	}
}
