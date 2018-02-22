﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SamWeb.API.Data;
using System;

namespace SamWeb.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("SamWeb.API.Models.Journal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Journals");
                });

            modelBuilder.Entity("SamWeb.API.Models.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("ClosedDate");

                    b.Property<DateTime?>("LastUpdated");

                    b.Property<int?>("LogEnderId");

                    b.Property<int?>("LogStarterId");

                    b.Property<string>("Name");

                    b.Property<DateTime?>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("LogEnderId");

                    b.HasIndex("LogStarterId");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("SamWeb.API.Models.LogLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Caption");

                    b.Property<DateTime?>("CreateTime");

                    b.Property<int?>("CreatorId");

                    b.Property<DateTime?>("EndTime");

                    b.Property<int?>("JournalId");

                    b.Property<int?>("LogId");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("JournalId");

                    b.HasIndex("LogId");

                    b.ToTable("LogLines");
                });

            modelBuilder.Entity("SamWeb.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FullName");

                    b.Property<string>("Initials");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SamWeb.API.Models.Log", b =>
                {
                    b.HasOne("SamWeb.API.Models.User", "LogEnder")
                        .WithMany()
                        .HasForeignKey("LogEnderId");

                    b.HasOne("SamWeb.API.Models.User", "LogStarter")
                        .WithMany()
                        .HasForeignKey("LogStarterId");
                });

            modelBuilder.Entity("SamWeb.API.Models.LogLine", b =>
                {
                    b.HasOne("SamWeb.API.Models.User", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.HasOne("SamWeb.API.Models.Journal", "Journal")
                        .WithMany()
                        .HasForeignKey("JournalId");

                    b.HasOne("SamWeb.API.Models.Log")
                        .WithMany("LogLines")
                        .HasForeignKey("LogId");
                });
#pragma warning restore 612, 618
        }
    }
}
