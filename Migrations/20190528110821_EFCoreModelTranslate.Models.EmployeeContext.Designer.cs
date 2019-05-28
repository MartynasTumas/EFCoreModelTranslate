﻿// <auto-generated />
using System;
using EFCoreModelTranslate.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreModelTranslate.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20190528110821_EFCoreModelTranslate.Models.EmployeeContext")]
    partial class EFCoreModelTranslateModelsEmployeeContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCoreModelTranslate.Models.Employee", b =>
                {
                    b.Property<long>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EFCoreModelTranslate.Models.Pen", b =>
                {
                    b.Property<long>("PenId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand");

                    b.Property<string>("Color");

                    b.Property<long?>("EmployeeId");

                    b.HasKey("PenId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Pens");
                });

            modelBuilder.Entity("EFCoreModelTranslate.Models.Pen", b =>
                {
                    b.HasOne("EFCoreModelTranslate.Models.Employee")
                        .WithMany("pens")
                        .HasForeignKey("EmployeeId");
                });
#pragma warning restore 612, 618
        }
    }
}
