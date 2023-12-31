﻿// <auto-generated />
using System;
using AddSegmentsToYandexMetrika.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AddSegmentsToYandexMetrika.Migrations
{
    [DbContext(typeof(YandexMetrikaSegmentsContext))]
    partial class YandexMetrikaSegmentsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");

            modelBuilder.Entity("AddSegmentsToYandexMetrika.AddLog", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("id");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date_created");

                    b.Property<string>("Logs")
                        .HasColumnType("text")
                        .HasColumnName("log");

                    b.Property<string>("SegmentName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("segment_name");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("status_added");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "SegmentName" }, "segment_error")
                        .IsUnique();

                    b.HasIndex(new[] { "SegmentName" }, "segment_name")
                        .IsUnique();

                    b.ToTable("success_log", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
