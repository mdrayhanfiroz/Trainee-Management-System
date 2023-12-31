﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using work_01.Models;

#nullable disable

namespace work_01.Migrations
{
    [DbContext(typeof(TraineeDbContext))]
    [Migration("20231022001054_ScriptB")]
    partial class ScriptB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("work_01.Models.Batch", b =>
                {
                    b.Property<int>("BatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BatchId"));

                    b.Property<string>("BatchCode")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("BatchId");

                    b.ToTable("Batches");

                    b.HasData(
                        new
                        {
                            BatchId = 1,
                            BatchCode = "WADA/PNTL-A/56/01"
                        },
                        new
                        {
                            BatchId = 2,
                            BatchCode = "NSA/PNTL-M/48/01"
                        },
                        new
                        {
                            BatchId = 3,
                            BatchCode = "ESAD-CS/PNTL-A/51/01"
                        });
                });

            modelBuilder.Entity("work_01.Models.Trainee", b =>
                {
                    b.Property<int>("TraineeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TraineeId"));

                    b.Property<int>("BatchId")
                        .HasColumnType("int");

                    b.Property<string>("TraineeContact")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("TraineeEmail")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("TraineeName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("TraineeId");

                    b.HasIndex("BatchId");

                    b.ToTable("Trainees");
                });

            modelBuilder.Entity("work_01.Models.Trainee", b =>
                {
                    b.HasOne("work_01.Models.Batch", "Batch")
                        .WithMany("Trainees")
                        .HasForeignKey("BatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Batch");
                });

            modelBuilder.Entity("work_01.Models.Batch", b =>
                {
                    b.Navigation("Trainees");
                });
#pragma warning restore 612, 618
        }
    }
}
