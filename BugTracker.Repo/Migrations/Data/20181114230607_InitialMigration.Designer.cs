﻿// <auto-generated />
using System;
using BugTracker.Repo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BugTracker.Repo.Migrations.Data
{
    [DbContext(typeof(DataContext))]
    [Migration("20181114230607_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("BugTracker.Data.Entities.Bug", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Bugs");
                });
#pragma warning restore 612, 618
        }
    }
}
