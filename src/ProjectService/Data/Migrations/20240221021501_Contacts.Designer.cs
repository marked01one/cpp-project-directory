﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ProjectService.Data;

#nullable disable

namespace ProjectService.Data.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    [Migration("20240221021501_Contacts")]
    partial class Contacts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ProjectService.Models.Entities.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Compensation")
                        .HasColumnType("integer");

                    b.Property<string>("ContactsDiscord")
                        .HasColumnType("text");

                    b.Property<string>("ContactsEmail")
                        .HasColumnType("text");

                    b.Property<string>("ContactsPhone")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int[]>("Majors")
                        .HasColumnType("integer[]");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Organization")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}