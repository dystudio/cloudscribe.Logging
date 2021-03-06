﻿// <auto-generated />
using cloudscribe.Logging.EFCore.SQLite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace cloudscribe.Logging.EFCore.SQLite.Migrations
{
    [DbContext(typeof(LoggingDbContext))]
    [Migration("20171221171611_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                ;

            modelBuilder.Entity("cloudscribe.Logging.Web.LogItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Culture")
                        .HasMaxLength(10);

                    b.Property<int>("EventId");

                    b.Property<string>("IpAddress")
                        .HasMaxLength(50);

                    b.Property<DateTime>("LogDateUtc")
                        .HasColumnName("LogDate");

                    b.Property<string>("LogLevel")
                        .HasMaxLength(20);

                    b.Property<string>("Logger")
                        .HasMaxLength(255);

                    b.Property<string>("Message");

                    b.Property<string>("ShortUrl")
                        .HasMaxLength(255);

                    b.Property<string>("StateJson");

                    b.Property<string>("Thread")
                        .HasMaxLength(255);

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("cs_SystemLog");
                });
#pragma warning restore 612, 618
        }
    }
}
