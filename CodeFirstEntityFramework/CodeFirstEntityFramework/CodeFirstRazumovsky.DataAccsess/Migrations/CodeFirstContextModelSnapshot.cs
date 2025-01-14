﻿// <auto-generated />
using System;
using CodeFirstEntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CodeFirstEntityFramework.Migrations
{
    [DbContext(typeof(CodeFirstContext))]
    partial class CodeFirstContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("CodeFirstEntityFramework.Actor", b =>
                {
                    b.Property<int>("ActorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Firstname")
                        .HasColumnType("text");

                    b.Property<string>("Lastname")
                        .HasColumnType("text");

                    b.HasKey("ActorId");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            ActorId = 1,
                            Birthday = new DateTime(1947, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Arnold",
                            Lastname = "Schwarzenegger"
                        },
                        new
                        {
                            ActorId = 2,
                            Birthday = new DateTime(1946, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Anthony",
                            Lastname = "Daniels"
                        },
                        new
                        {
                            ActorId = 3,
                            Birthday = new DateTime(1942, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Harrison",
                            Lastname = "Ford"
                        },
                        new
                        {
                            ActorId = 4,
                            Birthday = new DateTime(1956, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Carrie",
                            Lastname = "Fisher"
                        },
                        new
                        {
                            ActorId = 5,
                            Birthday = new DateTime(1914, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Alec",
                            Lastname = "Guiness"
                        },
                        new
                        {
                            ActorId = 6,
                            Birthday = new DateTime(1913, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Peter",
                            Lastname = "Cushing"
                        },
                        new
                        {
                            ActorId = 7,
                            Birthday = new DateTime(1944, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "David",
                            Lastname = "Prowse"
                        },
                        new
                        {
                            ActorId = 8,
                            Birthday = new DateTime(1935, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Peter",
                            Lastname = "Mayhew"
                        },
                        new
                        {
                            ActorId = 9,
                            Birthday = new DateTime(1956, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Michael",
                            Lastname = "Biehn"
                        },
                        new
                        {
                            ActorId = 10,
                            Birthday = new DateTime(1956, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Linda",
                            Lastname = "Hamilton"
                        },
                        new
                        {
                            ActorId = 11,
                            Birthday = new DateTime(1950, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Bill",
                            Lastname = "Murray"
                        },
                        new
                        {
                            ActorId = 12,
                            Birthday = new DateTime(1952, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Dan",
                            Lastname = "Aykroyd"
                        },
                        new
                        {
                            ActorId = 13,
                            Birthday = new DateTime(1949, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Sigourney",
                            Lastname = "Weaver"
                        },
                        new
                        {
                            ActorId = 14,
                            Birthday = new DateTime(1943, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Robert",
                            Lastname = "De Niro"
                        },
                        new
                        {
                            ActorId = 15,
                            Birthday = new DateTime(1962, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Jodie",
                            Lastname = "Foster"
                        },
                        new
                        {
                            ActorId = 16,
                            Birthday = new DateTime(1939, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Harvey",
                            Lastname = "Keitel"
                        },
                        new
                        {
                            ActorId = 17,
                            Birthday = new DateTime(1950, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Cybill",
                            Lastname = "Shepherd"
                        },
                        new
                        {
                            ActorId = 18,
                            Birthday = new DateTime(1949, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Tom",
                            Lastname = "Berenger"
                        },
                        new
                        {
                            ActorId = 19,
                            Birthday = new DateTime(1955, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Willem",
                            Lastname = "Dafoe"
                        },
                        new
                        {
                            ActorId = 20,
                            Birthday = new DateTime(1965, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Charlie",
                            Lastname = "Sheen"
                        },
                        new
                        {
                            ActorId = 21,
                            Birthday = new DateTime(1942, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Harrison",
                            Lastname = "Ford"
                        },
                        new
                        {
                            ActorId = 22,
                            Birthday = new DateTime(1966, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Emmanuelle",
                            Lastname = "Seigner"
                        },
                        new
                        {
                            ActorId = 23,
                            Birthday = new DateTime(1948, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Jean",
                            Lastname = "Reno"
                        },
                        new
                        {
                            ActorId = 24,
                            Birthday = new DateTime(1948, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Billy",
                            Lastname = "Crystal"
                        },
                        new
                        {
                            ActorId = 25,
                            Birthday = new DateTime(1963, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Lisa",
                            Lastname = "Kudrow"
                        },
                        new
                        {
                            ActorId = 26,
                            Birthday = new DateTime(1958, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Gary",
                            Lastname = "Oldman"
                        },
                        new
                        {
                            ActorId = 27,
                            Birthday = new DateTime(1981, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Natalie",
                            Lastname = "Portman"
                        },
                        new
                        {
                            ActorId = 28,
                            Birthday = new DateTime(1962, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Tom",
                            Lastname = "Cruise"
                        });
                });

            modelBuilder.Entity("CodeFirstEntityFramework.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Firstname")
                        .HasColumnType("text");

                    b.Property<string>("Lastname")
                        .HasColumnType("text");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            ClientId = 1,
                            Birthday = new DateTime(1954, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Hank",
                            Lastname = "Hill"
                        },
                        new
                        {
                            ClientId = 2,
                            Birthday = new DateTime(2011, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Brian",
                            Lastname = "Griffin"
                        },
                        new
                        {
                            ClientId = 3,
                            Birthday = new DateTime(1989, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Gary",
                            Lastname = "Goodspeed"
                        },
                        new
                        {
                            ClientId = 4,
                            Birthday = new DateTime(1977, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Bob",
                            Lastname = "Belcher"
                        },
                        new
                        {
                            ClientId = 5,
                            Birthday = new DateTime(2012, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Lisa",
                            Lastname = "Simpson"
                        },
                        new
                        {
                            ClientId = 6,
                            Birthday = new DateTime(1965, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Rick",
                            Lastname = "Sanchez"
                        });
                });

            modelBuilder.Entity("CodeFirstEntityFramework.Copy", b =>
                {
                    b.Property<int>("CopyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Available")
                        .HasColumnType("boolean");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer");

                    b.HasKey("CopyId");

                    b.HasIndex("MovieId");

                    b.ToTable("Copies");

                    b.HasData(
                        new
                        {
                            CopyId = 1,
                            Available = true,
                            MovieId = 1
                        },
                        new
                        {
                            CopyId = 2,
                            Available = false,
                            MovieId = 1
                        },
                        new
                        {
                            CopyId = 3,
                            Available = true,
                            MovieId = 2
                        },
                        new
                        {
                            CopyId = 4,
                            Available = true,
                            MovieId = 3
                        },
                        new
                        {
                            CopyId = 5,
                            Available = false,
                            MovieId = 3
                        },
                        new
                        {
                            CopyId = 6,
                            Available = true,
                            MovieId = 3
                        },
                        new
                        {
                            CopyId = 7,
                            Available = true,
                            MovieId = 4
                        },
                        new
                        {
                            CopyId = 8,
                            Available = false,
                            MovieId = 5
                        },
                        new
                        {
                            CopyId = 9,
                            Available = true,
                            MovieId = 6
                        },
                        new
                        {
                            CopyId = 10,
                            Available = false,
                            MovieId = 6
                        },
                        new
                        {
                            CopyId = 11,
                            Available = true,
                            MovieId = 6
                        },
                        new
                        {
                            CopyId = 12,
                            Available = true,
                            MovieId = 7
                        },
                        new
                        {
                            CopyId = 13,
                            Available = true,
                            MovieId = 7
                        },
                        new
                        {
                            CopyId = 14,
                            Available = false,
                            MovieId = 8
                        },
                        new
                        {
                            CopyId = 15,
                            Available = true,
                            MovieId = 9
                        },
                        new
                        {
                            CopyId = 16,
                            Available = true,
                            MovieId = 10
                        },
                        new
                        {
                            CopyId = 17,
                            Available = false,
                            MovieId = 10
                        },
                        new
                        {
                            CopyId = 18,
                            Available = true,
                            MovieId = 10
                        },
                        new
                        {
                            CopyId = 19,
                            Available = true,
                            MovieId = 10
                        },
                        new
                        {
                            CopyId = 20,
                            Available = true,
                            MovieId = 10
                        });
                });

            modelBuilder.Entity("CodeFirstEntityFramework.Employee", b =>
                {
                    b.Property<string>("Firstname")
                        .HasColumnType("text");

                    b.Property<string>("Lastname")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<float>("Salary")
                        .HasColumnType("real");

                    b.HasKey("Firstname", "Lastname");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Firstname = "John",
                            Lastname = "Smith",
                            City = "New York",
                            EmployeeId = 1,
                            Salary = 150f
                        },
                        new
                        {
                            Firstname = "Ben",
                            Lastname = "Johnson",
                            City = "New York",
                            EmployeeId = 2,
                            Salary = 250f
                        },
                        new
                        {
                            Firstname = "Louis",
                            Lastname = "Armstrong",
                            City = "New Orleans",
                            EmployeeId = 3,
                            Salary = 75f
                        },
                        new
                        {
                            Firstname = "John",
                            Lastname = "Lennon",
                            City = "London",
                            EmployeeId = 4,
                            Salary = 300f
                        },
                        new
                        {
                            Firstname = "Peter",
                            Lastname = "Gabriel",
                            City = "London",
                            EmployeeId = 5,
                            Salary = 150f
                        });
                });

            modelBuilder.Entity("CodeFirstEntityFramework.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AgeRestriction")
                        .HasColumnType("integer");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            AgeRestriction = 12,
                            Price = 10f,
                            Title = "Star Wars Episode IV: A New Hope",
                            Year = 1979
                        },
                        new
                        {
                            MovieId = 2,
                            AgeRestriction = 12,
                            Price = 5.5f,
                            Title = "Ghostbusters",
                            Year = 1984
                        },
                        new
                        {
                            MovieId = 3,
                            AgeRestriction = 15,
                            Price = 8.5f,
                            Title = "Terminator",
                            Year = 1984
                        },
                        new
                        {
                            MovieId = 4,
                            AgeRestriction = 17,
                            Price = 5f,
                            Title = "Taxi Driver",
                            Year = 1976
                        },
                        new
                        {
                            MovieId = 5,
                            AgeRestriction = 18,
                            Price = 5f,
                            Title = "Platoon",
                            Year = 1986
                        },
                        new
                        {
                            MovieId = 6,
                            AgeRestriction = 15,
                            Price = 8.5f,
                            Title = "Frantic",
                            Year = 1988
                        },
                        new
                        {
                            MovieId = 7,
                            AgeRestriction = 13,
                            Price = 9.5f,
                            Title = "Ronin",
                            Year = 1998
                        },
                        new
                        {
                            MovieId = 8,
                            AgeRestriction = 16,
                            Price = 10.5f,
                            Title = "Analyze This",
                            Year = 1999
                        },
                        new
                        {
                            MovieId = 9,
                            AgeRestriction = 16,
                            Price = 8.5f,
                            Title = "Leon: the Professional",
                            Year = 1994
                        },
                        new
                        {
                            MovieId = 10,
                            AgeRestriction = 13,
                            Price = 8.5f,
                            Title = "Mission Impossible",
                            Year = 1996
                        });
                });

            modelBuilder.Entity("CodeFirstEntityFramework.Rental", b =>
                {
                    b.Property<int>("CopyId")
                        .HasColumnType("integer");

                    b.Property<int>("ClientId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("DateOfRental")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateOfReturn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("CopyId", "ClientId");

                    b.HasIndex("ClientId");

                    b.ToTable("Rentals");

                    b.HasData(
                        new
                        {
                            CopyId = 1,
                            ClientId = 1,
                            DateOfRental = new DateTime(2005, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfReturn = new DateTime(2005, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CopyId = 6,
                            ClientId = 1,
                            DateOfRental = new DateTime(2005, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfReturn = new DateTime(2005, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CopyId = 3,
                            ClientId = 2,
                            DateOfRental = new DateTime(2005, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfReturn = new DateTime(2005, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CopyId = 5,
                            ClientId = 2,
                            DateOfRental = new DateTime(2005, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfReturn = new DateTime(2005, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CopyId = 7,
                            ClientId = 2,
                            DateOfRental = new DateTime(2005, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfReturn = new DateTime(2005, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CopyId = 12,
                            ClientId = 3,
                            DateOfRental = new DateTime(2005, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfReturn = new DateTime(2005, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CopyId = 20,
                            ClientId = 3,
                            DateOfRental = new DateTime(2005, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfReturn = new DateTime(2005, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CopyId = 3,
                            ClientId = 3,
                            DateOfRental = new DateTime(2005, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfReturn = new DateTime(2005, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CopyId = 7,
                            ClientId = 3,
                            DateOfRental = new DateTime(2005, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfReturn = new DateTime(2005, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CopyId = 13,
                            ClientId = 4,
                            DateOfRental = new DateTime(2005, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfReturn = new DateTime(2005, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CopyId = 11,
                            ClientId = 5,
                            DateOfRental = new DateTime(2005, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfReturn = new DateTime(2005, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CopyId = 1,
                            ClientId = 6,
                            DateOfRental = new DateTime(2005, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfReturn = new DateTime(2005, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CopyId = 7,
                            ClientId = 6,
                            DateOfRental = new DateTime(2005, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfReturn = new DateTime(2005, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CopyId = 19,
                            ClientId = 6,
                            DateOfRental = new DateTime(2005, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfReturn = new DateTime(2005, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("CodeFirstEntityFramework.Starring", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("integer");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer");

                    b.HasKey("ActorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("Starring");

                    b.HasData(
                        new
                        {
                            ActorId = 3,
                            MovieId = 1
                        },
                        new
                        {
                            ActorId = 4,
                            MovieId = 1
                        },
                        new
                        {
                            ActorId = 5,
                            MovieId = 1
                        },
                        new
                        {
                            ActorId = 6,
                            MovieId = 1
                        },
                        new
                        {
                            ActorId = 7,
                            MovieId = 1
                        },
                        new
                        {
                            ActorId = 8,
                            MovieId = 1
                        },
                        new
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new
                        {
                            ActorId = 9,
                            MovieId = 3
                        },
                        new
                        {
                            ActorId = 10,
                            MovieId = 3
                        },
                        new
                        {
                            ActorId = 11,
                            MovieId = 2
                        },
                        new
                        {
                            ActorId = 12,
                            MovieId = 2
                        },
                        new
                        {
                            ActorId = 13,
                            MovieId = 2
                        },
                        new
                        {
                            ActorId = 14,
                            MovieId = 4
                        },
                        new
                        {
                            ActorId = 15,
                            MovieId = 4
                        },
                        new
                        {
                            ActorId = 16,
                            MovieId = 4
                        },
                        new
                        {
                            ActorId = 17,
                            MovieId = 4
                        },
                        new
                        {
                            ActorId = 18,
                            MovieId = 5
                        },
                        new
                        {
                            ActorId = 19,
                            MovieId = 5
                        },
                        new
                        {
                            ActorId = 20,
                            MovieId = 5
                        },
                        new
                        {
                            ActorId = 21,
                            MovieId = 6
                        },
                        new
                        {
                            ActorId = 22,
                            MovieId = 6
                        },
                        new
                        {
                            ActorId = 14,
                            MovieId = 7
                        },
                        new
                        {
                            ActorId = 23,
                            MovieId = 7
                        },
                        new
                        {
                            ActorId = 14,
                            MovieId = 8
                        },
                        new
                        {
                            ActorId = 24,
                            MovieId = 8
                        },
                        new
                        {
                            ActorId = 25,
                            MovieId = 8
                        },
                        new
                        {
                            ActorId = 23,
                            MovieId = 9
                        },
                        new
                        {
                            ActorId = 27,
                            MovieId = 9
                        },
                        new
                        {
                            ActorId = 23,
                            MovieId = 10
                        },
                        new
                        {
                            ActorId = 28,
                            MovieId = 10
                        });
                });

            modelBuilder.Entity("CodeFirstEntityFramework.Copy", b =>
                {
                    b.HasOne("CodeFirstEntityFramework.Movie", "Movie")
                        .WithMany("Copies")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("CodeFirstEntityFramework.Rental", b =>
                {
                    b.HasOne("CodeFirstEntityFramework.Client", "Client")
                        .WithMany("Rentals")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstEntityFramework.Copy", "Copy")
                        .WithMany("Rentals")
                        .HasForeignKey("CopyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Copy");
                });

            modelBuilder.Entity("CodeFirstEntityFramework.Starring", b =>
                {
                    b.HasOne("CodeFirstEntityFramework.Actor", "Actor")
                        .WithMany("Starring")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstEntityFramework.Movie", "Movie")
                        .WithMany("Starring")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("CodeFirstEntityFramework.Actor", b =>
                {
                    b.Navigation("Starring");
                });

            modelBuilder.Entity("CodeFirstEntityFramework.Client", b =>
                {
                    b.Navigation("Rentals");
                });

            modelBuilder.Entity("CodeFirstEntityFramework.Copy", b =>
                {
                    b.Navigation("Rentals");
                });

            modelBuilder.Entity("CodeFirstEntityFramework.Movie", b =>
                {
                    b.Navigation("Copies");

                    b.Navigation("Starring");
                });
#pragma warning restore 612, 618
        }
    }
}
