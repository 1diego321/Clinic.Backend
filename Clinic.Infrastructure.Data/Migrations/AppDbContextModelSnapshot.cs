﻿// <auto-generated />
using System;
using Clinic.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Clinic.Infrastructure.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Clinic.Core.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EntityStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SMToken")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("AppUser");
                });

            modelBuilder.Entity("Clinic.Core.Entities.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AppointmentStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdMedic")
                        .HasColumnType("int");

                    b.Property<int>("IdMedicAttentionHour")
                        .HasColumnType("int");

                    b.Property<int>("IdPacient")
                        .HasColumnType("int");

                    b.Property<int?>("MedicAttentionHourId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdMedic");

                    b.HasIndex("IdPacient");

                    b.HasIndex("MedicAttentionHourId");

                    b.ToTable("Appointment");
                });

            modelBuilder.Entity("Clinic.Core.Entities.ClinicalHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 7, 25, 19, 30, 8, 647, DateTimeKind.Local).AddTicks(3545));

                    b.Property<int>("IdPatient")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdPatient")
                        .IsUnique();

                    b.ToTable("ClinicalHistory");
                });

            modelBuilder.Entity("Clinic.Core.Entities.ConsultingRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EntityStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameIdentifier")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("NameIdentifier")
                        .IsUnique();

                    b.ToTable("ConsultingRoom");
                });

            modelBuilder.Entity("Clinic.Core.Entities.Diagnostic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 7, 25, 19, 30, 8, 664, DateTimeKind.Local).AddTicks(2210));

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("EntityStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdClinicalHistory")
                        .HasColumnType("int");

                    b.Property<string>("Observations")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("IdClinicalHistory");

                    b.ToTable("Diagnostic");
                });

            modelBuilder.Entity("Clinic.Core.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployeeRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdAppUser")
                        .HasColumnType("int");

                    b.Property<int>("IdPerson")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdAppUser")
                        .IsUnique();

                    b.HasIndex("IdPerson")
                        .IsUnique();

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Clinic.Core.Entities.Medic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdConsultingRoom")
                        .HasColumnType("int");

                    b.Property<int>("IdEmployee")
                        .HasColumnType("int");

                    b.Property<int>("IdMedicalSpecialty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdConsultingRoom");

                    b.HasIndex("IdEmployee")
                        .IsUnique();

                    b.HasIndex("IdMedicalSpecialty");

                    b.ToTable("Medic");
                });

            modelBuilder.Entity("Clinic.Core.Entities.MedicAttentionHour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EntityStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hour")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<int>("IdMedicalSchedule")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdMedicalSchedule");

                    b.ToTable("AttentionHour");
                });

            modelBuilder.Entity("Clinic.Core.Entities.MedicalSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DayOfWeek")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EntityStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdMedic")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdMedic");

                    b.ToTable("MedicalSchedule");
                });

            modelBuilder.Entity("Clinic.Core.Entities.MedicalSpecialty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EntityStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("MedicalSpecialty");
                });

            modelBuilder.Entity("Clinic.Core.Entities.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EntityStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdPerson")
                        .HasColumnType("int");

                    b.Property<string>("PatientStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdPerson")
                        .IsUnique();

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("Clinic.Core.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Identification")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Names")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("Surnames")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Identification")
                        .IsUnique();

                    b.HasIndex("PhoneNumber")
                        .IsUnique();

                    b.ToTable("Person");
                });

            modelBuilder.Entity("Clinic.Core.Entities.Appointment", b =>
                {
                    b.HasOne("Clinic.Core.Entities.Medic", "Medic")
                        .WithMany("Appointments")
                        .HasForeignKey("IdMedic")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Clinic.Core.Entities.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("IdPacient")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Clinic.Core.Entities.MedicAttentionHour", "MedicAttentionHour")
                        .WithMany()
                        .HasForeignKey("MedicAttentionHourId");

                    b.Navigation("Medic");

                    b.Navigation("MedicAttentionHour");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Clinic.Core.Entities.ClinicalHistory", b =>
                {
                    b.HasOne("Clinic.Core.Entities.Patient", "Patient")
                        .WithOne("ClinicalHistory")
                        .HasForeignKey("Clinic.Core.Entities.ClinicalHistory", "IdPatient")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Clinic.Core.Entities.Diagnostic", b =>
                {
                    b.HasOne("Clinic.Core.Entities.ClinicalHistory", "ClinicalHistory")
                        .WithMany("Diagnostics")
                        .HasForeignKey("IdClinicalHistory")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ClinicalHistory");
                });

            modelBuilder.Entity("Clinic.Core.Entities.Employee", b =>
                {
                    b.HasOne("Clinic.Core.Entities.AppUser", "AppUser")
                        .WithOne("Employee")
                        .HasForeignKey("Clinic.Core.Entities.Employee", "IdAppUser")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Clinic.Core.Entities.Person", "Person")
                        .WithOne("Employee")
                        .HasForeignKey("Clinic.Core.Entities.Employee", "IdPerson")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Clinic.Core.Entities.Medic", b =>
                {
                    b.HasOne("Clinic.Core.Entities.ConsultingRoom", "ConsultingRoom")
                        .WithMany("Medics")
                        .HasForeignKey("IdConsultingRoom")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Clinic.Core.Entities.Employee", "Employee")
                        .WithOne("Medic")
                        .HasForeignKey("Clinic.Core.Entities.Medic", "IdEmployee")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Clinic.Core.Entities.MedicalSpecialty", "MedicalSpecialty")
                        .WithMany("Medics")
                        .HasForeignKey("IdMedicalSpecialty")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ConsultingRoom");

                    b.Navigation("Employee");

                    b.Navigation("MedicalSpecialty");
                });

            modelBuilder.Entity("Clinic.Core.Entities.MedicAttentionHour", b =>
                {
                    b.HasOne("Clinic.Core.Entities.MedicalSchedule", "MedicalSchedule")
                        .WithMany("MedicAttentionHours")
                        .HasForeignKey("IdMedicalSchedule")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("MedicalSchedule");
                });

            modelBuilder.Entity("Clinic.Core.Entities.MedicalSchedule", b =>
                {
                    b.HasOne("Clinic.Core.Entities.Medic", "Medic")
                        .WithMany("MedicalSchedules")
                        .HasForeignKey("IdMedic")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Medic");
                });

            modelBuilder.Entity("Clinic.Core.Entities.Patient", b =>
                {
                    b.HasOne("Clinic.Core.Entities.Person", "Person")
                        .WithOne("Patient")
                        .HasForeignKey("Clinic.Core.Entities.Patient", "IdPerson")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Clinic.Core.Entities.AppUser", b =>
                {
                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Clinic.Core.Entities.ClinicalHistory", b =>
                {
                    b.Navigation("Diagnostics");
                });

            modelBuilder.Entity("Clinic.Core.Entities.ConsultingRoom", b =>
                {
                    b.Navigation("Medics");
                });

            modelBuilder.Entity("Clinic.Core.Entities.Employee", b =>
                {
                    b.Navigation("Medic");
                });

            modelBuilder.Entity("Clinic.Core.Entities.Medic", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("MedicalSchedules");
                });

            modelBuilder.Entity("Clinic.Core.Entities.MedicalSchedule", b =>
                {
                    b.Navigation("MedicAttentionHours");
                });

            modelBuilder.Entity("Clinic.Core.Entities.MedicalSpecialty", b =>
                {
                    b.Navigation("Medics");
                });

            modelBuilder.Entity("Clinic.Core.Entities.Patient", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("ClinicalHistory");
                });

            modelBuilder.Entity("Clinic.Core.Entities.Person", b =>
                {
                    b.Navigation("Employee");

                    b.Navigation("Patient");
                });
#pragma warning restore 612, 618
        }
    }
}
