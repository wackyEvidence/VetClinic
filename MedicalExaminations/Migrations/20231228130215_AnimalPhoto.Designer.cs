﻿// <auto-generated />
using System;
using MedicalExaminations.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MedicalExaminations.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231228130215_AnimalPhoto")]
    partial class AnimalPhoto
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("AnimalOwnerSign", b =>
                {
                    b.Property<int>("AnimalsId")
                        .HasColumnType("integer");

                    b.Property<int>("OwnerSignsId")
                        .HasColumnType("integer");

                    b.HasKey("AnimalsId", "OwnerSignsId");

                    b.HasIndex("OwnerSignsId");

                    b.ToTable("AnimalOwnerSign");
                });

            modelBuilder.Entity("MedicalExaminations.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int>("AnimalCategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("BirthYear")
                        .HasColumnType("integer");

                    b.Property<int>("ChipNumber")
                        .HasColumnType("integer");

                    b.Property<string>("DistinguishingMarks")
                        .HasColumnType("text");

                    b.Property<int>("LocationId")
                        .HasColumnType("integer");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RegistrationNumber")
                        .HasColumnType("integer");

                    b.Property<char>("Sex")
                        .HasColumnType("character(1)");

                    b.HasKey("Id");

                    b.HasIndex("AnimalCategoryId");

                    b.HasIndex("LocationId");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("MedicalExaminations.Models.AnimalCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AnimalCategories");
                });

            modelBuilder.Entity("MedicalExaminations.Models.AnimalPhoto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int>("AnimalId")
                        .HasColumnType("integer");

                    b.Property<byte[]>("PhotoData")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.ToTable("AnimalPhotos");
                });

            modelBuilder.Entity("MedicalExaminations.Models.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("integer");

                    b.Property<int>("ExecutorId")
                        .HasColumnType("integer");

                    b.Property<int>("Number")
                        .HasColumnType("integer");

                    b.Property<DateTime>("SigningDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ValidUntil")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("ExecutorId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("MedicalExaminations.Models.ContractLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int>("ContractId")
                        .HasColumnType("integer");

                    b.Property<int>("ExaminationCost")
                        .HasColumnType("integer");

                    b.Property<int>("LocationId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.HasIndex("LocationId");

                    b.ToTable("ContractLocation");
                });

            modelBuilder.Entity("MedicalExaminations.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("MedicalExaminations.Models.MedicalExamination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("ActionsTaken")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AnimalCondition")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("AnimalId")
                        .HasColumnType("integer");

                    b.Property<string>("BehaviourFeatures")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("BodyTemperature")
                        .HasColumnType("double precision");

                    b.Property<int>("ContractId")
                        .HasColumnType("integer");

                    b.Property<string>("Diagnosis")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("EmergencyHelpRequired")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("ExaminationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Injuries")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SkinCovers")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TreatmentPrescribed")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("VetClinicId")
                        .HasColumnType("integer");

                    b.Property<string>("VeterinarianFullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("VeterinarianPosition")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("WoolCondition")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.HasIndex("ContractId");

                    b.HasIndex("VetClinicId");

                    b.ToTable("MedicalExaminations");
                });

            modelBuilder.Entity("MedicalExaminations.Models.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int>("HouseNumber")
                        .HasColumnType("integer");

                    b.Property<long>("INN")
                        .HasColumnType("bigint");

                    b.Property<long>("KPP")
                        .HasColumnType("bigint");

                    b.Property<int?>("LocationId")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("OrganizationAttributeId")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<int?>("OrganizationTypeId")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("OrganizationAttributeId");

                    b.HasIndex("OrganizationTypeId");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("MedicalExaminations.Models.OrganizationAttribute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("OrganizationAttributes");
                });

            modelBuilder.Entity("MedicalExaminations.Models.OrganizationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("OrganizationTypes");
                });

            modelBuilder.Entity("MedicalExaminations.Models.OwnerSign", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("OwnerSigns");
                });

            modelBuilder.Entity("MedicalExaminations.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("WorkplaceId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("WorkplaceId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MedicalExaminations.Models.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("AnimalOwnerSign", b =>
                {
                    b.HasOne("MedicalExaminations.Models.Animal", null)
                        .WithMany()
                        .HasForeignKey("AnimalsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MedicalExaminations.Models.OwnerSign", null)
                        .WithMany()
                        .HasForeignKey("OwnerSignsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MedicalExaminations.Models.Animal", b =>
                {
                    b.HasOne("MedicalExaminations.Models.AnimalCategory", "AnimalCategory")
                        .WithMany("Animals")
                        .HasForeignKey("AnimalCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MedicalExaminations.Models.Location", "Location")
                        .WithMany("Animals")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AnimalCategory");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("MedicalExaminations.Models.AnimalPhoto", b =>
                {
                    b.HasOne("MedicalExaminations.Models.Animal", "Animal")
                        .WithMany("AnimalPhotos")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");
                });

            modelBuilder.Entity("MedicalExaminations.Models.Contract", b =>
                {
                    b.HasOne("MedicalExaminations.Models.Organization", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MedicalExaminations.Models.Organization", "Executor")
                        .WithMany()
                        .HasForeignKey("ExecutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Executor");
                });

            modelBuilder.Entity("MedicalExaminations.Models.ContractLocation", b =>
                {
                    b.HasOne("MedicalExaminations.Models.Contract", "Contract")
                        .WithMany("ContractLocations")
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MedicalExaminations.Models.Location", "Location")
                        .WithMany("ContractLocations")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contract");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("MedicalExaminations.Models.MedicalExamination", b =>
                {
                    b.HasOne("MedicalExaminations.Models.Animal", "Animal")
                        .WithMany("MedicalExaminations")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MedicalExaminations.Models.Contract", "Contract")
                        .WithMany("MedicalExaminations")
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MedicalExaminations.Models.Organization", "VetClinic")
                        .WithMany("MedicalExaminations")
                        .HasForeignKey("VetClinicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("Contract");

                    b.Navigation("VetClinic");
                });

            modelBuilder.Entity("MedicalExaminations.Models.Organization", b =>
                {
                    b.HasOne("MedicalExaminations.Models.Location", "Location")
                        .WithMany("Organizations")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MedicalExaminations.Models.OrganizationAttribute", "OrganizationAttribute")
                        .WithMany("Organizations")
                        .HasForeignKey("OrganizationAttributeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MedicalExaminations.Models.OrganizationType", "OrganizationType")
                        .WithMany("Organizations")
                        .HasForeignKey("OrganizationTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("OrganizationAttribute");

                    b.Navigation("OrganizationType");
                });

            modelBuilder.Entity("MedicalExaminations.Models.User", b =>
                {
                    b.HasOne("MedicalExaminations.Models.UserRole", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MedicalExaminations.Models.Organization", "Workplace")
                        .WithMany("Users")
                        .HasForeignKey("WorkplaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("Workplace");
                });

            modelBuilder.Entity("MedicalExaminations.Models.Animal", b =>
                {
                    b.Navigation("AnimalPhotos");

                    b.Navigation("MedicalExaminations");
                });

            modelBuilder.Entity("MedicalExaminations.Models.AnimalCategory", b =>
                {
                    b.Navigation("Animals");
                });

            modelBuilder.Entity("MedicalExaminations.Models.Contract", b =>
                {
                    b.Navigation("ContractLocations");

                    b.Navigation("MedicalExaminations");
                });

            modelBuilder.Entity("MedicalExaminations.Models.Location", b =>
                {
                    b.Navigation("Animals");

                    b.Navigation("ContractLocations");

                    b.Navigation("Organizations");
                });

            modelBuilder.Entity("MedicalExaminations.Models.Organization", b =>
                {
                    b.Navigation("MedicalExaminations");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("MedicalExaminations.Models.OrganizationAttribute", b =>
                {
                    b.Navigation("Organizations");
                });

            modelBuilder.Entity("MedicalExaminations.Models.OrganizationType", b =>
                {
                    b.Navigation("Organizations");
                });

            modelBuilder.Entity("MedicalExaminations.Models.UserRole", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
