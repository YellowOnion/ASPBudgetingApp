﻿// <auto-generated />
using ASPBudgetingApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace ASPBudgetingApp.Migrations
{
    [DbContext(typeof(BudgetContext))]
    [Migration("20171219011747_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("ASPBudgetingApp.Models.Budget", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Cost");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("BudgetSet");
                });
#pragma warning restore 612, 618
        }
    }
}
