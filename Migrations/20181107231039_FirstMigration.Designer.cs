﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using crudelicious.Models;

namespace crudelicious.Migrations
{
    [DbContext(typeof(CrudContext))]
    [Migration("20181107231039_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("crudelicious.Models.Dish", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Calories");

                    b.Property<string>("Chef")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Tastiness");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("id");

                    b.ToTable("Dishes");
                });
#pragma warning restore 612, 618
        }
    }
}