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
    [DbContext(typeof(BookyDbContext))]
    [Migration("20231005123446_test")]
    partial class test
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
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            FirstName = "Greg",
                            LastName = "Martin"
                        },
                        new
                        {
                            AuthorId = 2,
                            FirstName = "John",
                            LastName = "Doe"
                        },
                        new
                        {
                            AuthorId = 3,
                            FirstName = "Nima",
                            LastName = "Hariku"
                        });
                });

            modelBuilder.Entity("BookProject.Entities.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ISBN")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            AuthorId = 1,
                            Description = "Lorem ipsum",
                            Genre = "Science Fiction",
                            ISBN = 1111111111L,
                            Title = "On the way"
                        },
                        new
                        {
                            BookId = 2,
                            AuthorId = 1,
                            Description = "Lorem ipsum",
                            Genre = "Science Fiction",
                            ISBN = 2222222222L,
                            Title = "On the way2"
                        },
                        new
                        {
                            BookId = 3,
                            AuthorId = 2,
                            Description = "Lorem ipsum",
                            Genre = "Science Fiction",
                            ISBN = 3333333333L,
                            Title = "On the way3"
                        });
                });

            modelBuilder.Entity("BookProject.Entities.Book", b =>
                {
                    b.HasOne("BookProject.Entities.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });
#pragma warning restore 612, 618
        }
    }
}
