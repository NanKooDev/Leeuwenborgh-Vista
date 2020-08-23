﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistratieApi.Data;

namespace RegistratieApi.Migrations
{
    [DbContext(typeof(RegistratieApiContext))]
    [Migration("20200220094440_Added registration")]
    partial class Addedregistration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RegistratieApi.Models.Registration", b =>
                {
                    b.Property<int>("RegistrationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("RegistrationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserOvNummer")
                        .HasColumnType("int");

                    b.HasKey("RegistrationId");

                    b.HasIndex("UserOvNummer");

                    b.ToTable("Registration");
                });

            modelBuilder.Entity("RegistratieApi.Models.User", b =>
                {
                    b.Property<int>("OvNummer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OvNummer");

                    b.ToTable("User");
                });

            modelBuilder.Entity("RegistratieApi.Models.Registration", b =>
                {
                    b.HasOne("RegistratieApi.Models.User", null)
                        .WithMany("Registrations")
                        .HasForeignKey("UserOvNummer");
                });
#pragma warning restore 612, 618
        }
    }
}
