﻿// <auto-generated />
using BookProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookProject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231004114626_Add_more_data")]
    partial class Add_more_data
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookProject.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Greg",
                            LastName = "Martin"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "John",
                            LastName = "Doe"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Nima",
                            LastName = "Hariku"
                        });
                });

            modelBuilder.Entity("BookProject.Entities.Book", b =>
                {
                    b.Property<long>("ISBN")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ISBN"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ISBN");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            ISBN = 1L,
                            AuthorId = 1,
                            Description = "Lorem ipsum",
                            Genre = "Science Fiction",
                            Title = "On the way"
                        },
                        new
                        {
                            ISBN = 2L,
                            AuthorId = 1,
                            Description = "Lorem ipsum",
                            Genre = "Science Fiction",
                            Title = "On the way2"
                        },
                        new
                        {
                            ISBN = 3L,
                            AuthorId = 2,
                            Description = "Lorem ipsum",
                            Genre = "Science Fiction",
                            Title = "On the way3"
                        });
                });

            modelBuilder.Entity("BookProject.Entities.Book", b =>
                {
                    b.HasOne("BookProject.Entities.Author", null)
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookProject.Entities.Author", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}