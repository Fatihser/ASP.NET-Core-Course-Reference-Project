﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositoryDesignPatternProjectWeb.Data.Context;

namespace RepositoryDesignPatternProjectWeb.Data.Migrations
{
    [DbContext(typeof(BankContext))]
    [Migration("20221206205222_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("RepositoryDesignPatternProjectWeb.Data.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AccountNumber")
                        .HasColumnType("int");

                    b.Property<int>("ApplicationUserId")
                        .HasColumnType("int");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("RepositoryDesignPatternProjectWeb.Data.Entities.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUsers");
                });

            modelBuilder.Entity("RepositoryDesignPatternProjectWeb.Data.Entities.Account", b =>
                {
                    b.HasOne("RepositoryDesignPatternProjectWeb.Data.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("Accounts")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("RepositoryDesignPatternProjectWeb.Data.Entities.ApplicationUser", b =>
                {
                    b.Navigation("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}