﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TitanInformationSolutions.Data;

namespace TitanInformationSolutions.Migrations.ApplicationDb
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("TitanInformationSolutions.Models.BGCProgram", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<string>("desc");

                    b.HasKey("ID");

                    b.ToTable("BGCProgram");
                });

            modelBuilder.Entity("TitanInformationSolutions.Models.Child", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DoB");

                    b.Property<int>("ParentID");

                    b.Property<string>("firstName")
                        .HasMaxLength(30);

                    b.Property<string>("lastName")
                        .HasMaxLength(30);

                    b.HasKey("ID");

                    b.HasIndex("ParentID");

                    b.ToTable("Child");
                });

            modelBuilder.Entity("TitanInformationSolutions.Models.child_Section", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ChildID");

                    b.Property<int?>("ParentID");

                    b.Property<int>("SectionID");

                    b.HasKey("ID");

                    b.HasIndex("ChildID");

                    b.HasIndex("ParentID");

                    b.HasIndex("SectionID");

                    b.ToTable("child_Section");
                });

            modelBuilder.Entity("TitanInformationSolutions.Models.Instructor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email");

                    b.Property<string>("firstName")
                        .HasMaxLength(30);

                    b.Property<string>("lastName")
                        .HasMaxLength(30);

                    b.HasKey("ID");

                    b.ToTable("Instructor");
                });

            modelBuilder.Entity("TitanInformationSolutions.Models.instructor_message", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("UpdatedOn");

                    b.Property<int>("instructorID");

                    b.Property<int>("messageID");

                    b.HasKey("ID");

                    b.HasIndex("instructorID");

                    b.HasIndex("messageID");

                    b.ToTable("instructor_message");
                });

            modelBuilder.Entity("TitanInformationSolutions.Models.instructor_Section", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SectionID");

                    b.Property<int>("instructorID");

                    b.HasKey("ID");

                    b.HasIndex("SectionID");

                    b.HasIndex("instructorID");

                    b.ToTable("instructor_Section");
                });

            modelBuilder.Entity("TitanInformationSolutions.Models.Message", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body");

                    b.Property<string>("From");

                    b.Property<string>("To");

                    b.HasKey("ID");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("TitanInformationSolutions.Models.Parent", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasMaxLength(100);

                    b.Property<bool>("feedNote");

                    b.Property<string>("firstName")
                        .HasMaxLength(30);

                    b.Property<string>("lastName")
                        .HasMaxLength(30);

                    b.Property<long>("phone");

                    b.Property<bool>("privNote");

                    b.HasKey("ID");

                    b.ToTable("Parent");
                });

            modelBuilder.Entity("TitanInformationSolutions.Models.Parent_Message", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("UpdatedOn");

                    b.Property<int>("messageID");

                    b.Property<int>("parentID");

                    b.HasKey("ID");

                    b.HasIndex("messageID");

                    b.HasIndex("parentID");

                    b.ToTable("Parent_Message");
                });

            modelBuilder.Entity("TitanInformationSolutions.Models.Section", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BGCProgramID");

                    b.Property<DateTime>("End");

                    b.Property<string>("Location");

                    b.Property<DateTime>("Start");

                    b.HasKey("ID");

                    b.HasIndex("BGCProgramID");

                    b.ToTable("Section");
                });

            modelBuilder.Entity("TitanInformationSolutions.Models.Sub", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(127);

                    b.Property<int>("ParentID");

                    b.Property<string>("PushAuth")
                        .HasMaxLength(512);

                    b.Property<string>("PushEndpoint")
                        .HasMaxLength(512);

                    b.Property<string>("PushP256DH")
                        .HasMaxLength(512);

                    b.HasKey("ID");

                    b.HasIndex("ParentID");

                    b.ToTable("Sub");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TitanInformationSolutions.Models.Child", b =>
                {
                    b.HasOne("TitanInformationSolutions.Models.Parent", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TitanInformationSolutions.Models.child_Section", b =>
                {
                    b.HasOne("TitanInformationSolutions.Models.Child", "child")
                        .WithMany("ChildSections")
                        .HasForeignKey("ChildID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TitanInformationSolutions.Models.Parent")
                        .WithMany("childSections")
                        .HasForeignKey("ParentID");

                    b.HasOne("TitanInformationSolutions.Models.Section", "Section")
                        .WithMany("ChildSections")
                        .HasForeignKey("SectionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TitanInformationSolutions.Models.instructor_message", b =>
                {
                    b.HasOne("TitanInformationSolutions.Models.Instructor", "Instructor")
                        .WithMany("Instructor_Messages")
                        .HasForeignKey("instructorID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TitanInformationSolutions.Models.Message", "message")
                        .WithMany()
                        .HasForeignKey("messageID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TitanInformationSolutions.Models.instructor_Section", b =>
                {
                    b.HasOne("TitanInformationSolutions.Models.Section", "Section")
                        .WithMany("InstructorSections")
                        .HasForeignKey("SectionID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TitanInformationSolutions.Models.Instructor", "Instructor")
                        .WithMany("Instructor_Sections")
                        .HasForeignKey("instructorID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TitanInformationSolutions.Models.Parent_Message", b =>
                {
                    b.HasOne("TitanInformationSolutions.Models.Message", "message")
                        .WithMany()
                        .HasForeignKey("messageID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TitanInformationSolutions.Models.Parent", "Parent")
                        .WithMany("Parent_Messages")
                        .HasForeignKey("parentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TitanInformationSolutions.Models.Section", b =>
                {
                    b.HasOne("TitanInformationSolutions.Models.BGCProgram", "BGCProgram")
                        .WithMany("Sections")
                        .HasForeignKey("BGCProgramID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TitanInformationSolutions.Models.Sub", b =>
                {
                    b.HasOne("TitanInformationSolutions.Models.Parent", "Parent")
                        .WithMany("Subs")
                        .HasForeignKey("ParentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
