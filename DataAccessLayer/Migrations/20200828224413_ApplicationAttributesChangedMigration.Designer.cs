﻿// <auto-generated />
using System;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(FPISContext))]
    [Migration("20200828224413_ApplicationAttributesChangedMigration")]
    partial class ApplicationAttributesChangedMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.Application", b =>
                {
                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<long>("ProjectID")
                        .HasColumnType("bigint");

                    b.Property<bool>("Accepted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("ExperienceInPreviousProjects")
                        .HasColumnType("bit");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("StudentID", "ProjectID");

                    b.HasIndex("ProjectID");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("Model.City", b =>
                {
                    b.Property<long>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityID");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Model.Company", b =>
                {
                    b.Property<long>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyUsername")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("CompanyID");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Model.Contact", b =>
                {
                    b.Property<long>("CompanyID")
                        .HasColumnType("bigint");

                    b.Property<long>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContactType")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyID", "ContactID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Model.Document", b =>
                {
                    b.Property<long>("ProjectID")
                        .HasColumnType("bigint");

                    b.Property<int>("DocumentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("ComposedByEmployeeID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateOfCompilation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectID", "DocumentID");

                    b.HasIndex("ComposedByEmployeeID");

                    b.ToTable("Documents");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Document");
                });

            modelBuilder.Entity("Model.Employee", b =>
                {
                    b.Property<long>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Model.EmployeePosition", b =>
                {
                    b.Property<long>("EmployeeID")
                        .HasColumnType("bigint");

                    b.Property<long>("PositionID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateTo")
                        .HasColumnType("datetime2");

                    b.HasKey("EmployeeID", "PositionID");

                    b.HasIndex("PositionID");

                    b.ToTable("EmployeePositions");
                });

            modelBuilder.Entity("Model.Engagement", b =>
                {
                    b.Property<long>("ProjectID")
                        .HasColumnType("bigint");

                    b.Property<int>("DocumentID")
                        .HasColumnType("int");

                    b.Property<int>("PhaseID")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectID", "DocumentID", "PhaseID", "StudentID");

                    b.HasIndex("StudentID");

                    b.ToTable("Engagements");
                });

            modelBuilder.Entity("Model.ExternalMentor", b =>
                {
                    b.Property<long>("CompanyID")
                        .HasColumnType("bigint");

                    b.Property<int>("MentorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyID", "MentorID");

                    b.ToTable("ExternalMentors");
                });

            modelBuilder.Entity("Model.ExternalMentorContact", b =>
                {
                    b.Property<long>("ExternalMentorCompanyID")
                        .HasColumnType("bigint");

                    b.Property<int>("ExternalMentorMentorID")
                        .HasColumnType("int");

                    b.Property<int>("SerialNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContactType")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExternalMentorCompanyID", "ExternalMentorMentorID", "SerialNumber");

                    b.ToTable("ExternalMentorContacts");
                });

            modelBuilder.Entity("Model.Location", b =>
                {
                    b.Property<long>("CityID")
                        .HasColumnType("bigint");

                    b.Property<long>("CompanyID")
                        .HasColumnType("bigint");

                    b.Property<string>("AppartmentNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Floor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityID", "CompanyID");

                    b.HasIndex("CompanyID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Model.Phase", b =>
                {
                    b.Property<long>("ProjectID")
                        .HasColumnType("bigint");

                    b.Property<int>("DocumentID")
                        .HasColumnType("int");

                    b.Property<int>("PhaseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProjectID", "DocumentID", "PhaseID");

                    b.ToTable("Phases");
                });

            modelBuilder.Entity("Model.Position", b =>
                {
                    b.Property<long>("PositionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PositionID");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("Model.Project", b =>
                {
                    b.Property<long>("ProjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AdoptionDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DecisionMakerEmployeeID")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("InternalMentorEmployeeID")
                        .HasColumnType("bigint");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ProjectProposalID")
                        .HasColumnType("bigint");

                    b.HasKey("ProjectID");

                    b.HasIndex("DecisionMakerEmployeeID");

                    b.HasIndex("InternalMentorEmployeeID");

                    b.HasIndex("ProjectProposalID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Model.ProjectContract", b =>
                {
                    b.Property<long>("ProjectContractID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanySigner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("InternalSignerEmployeeID")
                        .HasColumnType("bigint");

                    b.Property<long?>("ProjectID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("SigningDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProjectContractID");

                    b.HasIndex("InternalSignerEmployeeID");

                    b.HasIndex("ProjectID");

                    b.ToTable("ProjectContracts");
                });

            modelBuilder.Entity("Model.ProjectCoveringSubject", b =>
                {
                    b.Property<long>("ProjectProposalID")
                        .HasColumnType("bigint");

                    b.Property<long>("ProjectCoveringSubjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ScientificAreaID")
                        .HasColumnType("bigint");

                    b.HasKey("ProjectProposalID", "ProjectCoveringSubjectID");

                    b.HasIndex("ScientificAreaID");

                    b.ToTable("ProjectCoveringSubjects");
                });

            modelBuilder.Entity("Model.ProjectProposal", b =>
                {
                    b.Property<long>("ProjectProposalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Activities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("CompanyID")
                        .HasColumnType("bigint");

                    b.Property<int>("DaysDuration")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ExternalMentorCompanyID")
                        .HasColumnType("bigint");

                    b.Property<int?>("ExternalMentorMentorID")
                        .HasColumnType("int");

                    b.Property<string>("Goal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ProposalDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDateProjectProposal")
                        .HasColumnType("datetime2");

                    b.HasKey("ProjectProposalID");

                    b.HasIndex("CompanyID");

                    b.HasIndex("ExternalMentorCompanyID", "ExternalMentorMentorID");

                    b.ToTable("ProjectProposals");
                });

            modelBuilder.Entity("Model.ScientificArea", b =>
                {
                    b.Property<long>("ScientificAreaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ScientificAreaID");

                    b.ToTable("ScientificAreas");
                });

            modelBuilder.Entity("Model.Skill", b =>
                {
                    b.Property<long>("ProjectID")
                        .HasColumnType("bigint");

                    b.Property<int>("DocumentID")
                        .HasColumnType("int");

                    b.Property<int>("PhaseID")
                        .HasColumnType("int");

                    b.Property<int>("SkillID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectID", "DocumentID", "PhaseID", "SkillID");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Model.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Index")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YearOfStudy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Model.ChangesReport", b =>
                {
                    b.HasBaseType("Model.Document");

                    b.Property<string>("Explanation")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ChangesReport");
                });

            modelBuilder.Entity("Model.ProgressReport", b =>
                {
                    b.HasBaseType("Model.Document");

                    b.Property<string>("ActivityDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PhaseDocumentID")
                        .HasColumnType("int");

                    b.Property<int?>("PhaseID")
                        .HasColumnType("int");

                    b.Property<long?>("PhaseProjectID")
                        .HasColumnType("bigint");

                    b.HasIndex("PhaseProjectID", "PhaseDocumentID", "PhaseID");

                    b.HasDiscriminator().HasValue("ProgressReport");
                });

            modelBuilder.Entity("Model.ProjectPlan", b =>
                {
                    b.HasBaseType("Model.Document");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<DateTime>("EstimatedStartDate")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("ProjectPlan");
                });

            modelBuilder.Entity("Model.Application", b =>
                {
                    b.HasOne("Model.Project", "Project")
                        .WithMany("Applications")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Contact", b =>
                {
                    b.HasOne("Model.Company", null)
                        .WithMany("Contacts")
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Document", b =>
                {
                    b.HasOne("Model.Employee", "ComposedBy")
                        .WithMany()
                        .HasForeignKey("ComposedByEmployeeID");

                    b.HasOne("Model.Project", null)
                        .WithMany("Documents")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.EmployeePosition", b =>
                {
                    b.HasOne("Model.Employee", "Employee")
                        .WithMany("Positions")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Engagement", b =>
                {
                    b.HasOne("Model.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Phase", "Phase")
                        .WithMany("Engagements")
                        .HasForeignKey("ProjectID", "DocumentID", "PhaseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.ExternalMentor", b =>
                {
                    b.HasOne("Model.Company", null)
                        .WithMany("Mentors")
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.ExternalMentorContact", b =>
                {
                    b.HasOne("Model.ExternalMentor", null)
                        .WithMany("Contacts")
                        .HasForeignKey("ExternalMentorCompanyID", "ExternalMentorMentorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Location", b =>
                {
                    b.HasOne("Model.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Company", "Company")
                        .WithMany("Locations")
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Phase", b =>
                {
                    b.HasOne("Model.ProjectPlan", "ProjectPlan")
                        .WithMany("Phases")
                        .HasForeignKey("ProjectID", "DocumentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Project", b =>
                {
                    b.HasOne("Model.Employee", "DecisionMaker")
                        .WithMany()
                        .HasForeignKey("DecisionMakerEmployeeID");

                    b.HasOne("Model.Employee", "InternalMentor")
                        .WithMany()
                        .HasForeignKey("InternalMentorEmployeeID");

                    b.HasOne("Model.ProjectProposal", "ProjectProposal")
                        .WithMany()
                        .HasForeignKey("ProjectProposalID");
                });

            modelBuilder.Entity("Model.ProjectContract", b =>
                {
                    b.HasOne("Model.Employee", "InternalSigner")
                        .WithMany()
                        .HasForeignKey("InternalSignerEmployeeID");

                    b.HasOne("Model.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectID");
                });

            modelBuilder.Entity("Model.ProjectCoveringSubject", b =>
                {
                    b.HasOne("Model.ProjectProposal", null)
                        .WithMany("Subjects")
                        .HasForeignKey("ProjectProposalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.ScientificArea", "ScientificArea")
                        .WithMany()
                        .HasForeignKey("ScientificAreaID");
                });

            modelBuilder.Entity("Model.ProjectProposal", b =>
                {
                    b.HasOne("Model.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyID");

                    b.HasOne("Model.ExternalMentor", "ExternalMentor")
                        .WithMany()
                        .HasForeignKey("ExternalMentorCompanyID", "ExternalMentorMentorID");
                });

            modelBuilder.Entity("Model.Skill", b =>
                {
                    b.HasOne("Model.Phase", "Phase")
                        .WithMany("RequiredSkills")
                        .HasForeignKey("ProjectID", "DocumentID", "PhaseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.ProgressReport", b =>
                {
                    b.HasOne("Model.Phase", "Phase")
                        .WithMany()
                        .HasForeignKey("PhaseProjectID", "PhaseDocumentID", "PhaseID");
                });
#pragma warning restore 612, 618
        }
    }
}
