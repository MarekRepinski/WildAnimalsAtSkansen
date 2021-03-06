// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WildAnimalsAtSkansen.Entities;

#nullable disable

namespace WildAnimalsAtSkansen.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20211210142238_added_column_to_animal")]
    partial class added_column_to_animal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WildAnimalsAtSkansen.Entities.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AgeExpectancyYears")
                        .HasColumnType("int");

                    b.Property<int>("AnimalTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FamilyName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("HabitatId")
                        .HasColumnType("int");

                    b.Property<string>("LatinName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp(6)");

                    b.HasKey("AnimalId");

                    b.HasIndex("AnimalTypeId");

                    b.HasIndex("HabitatId");

                    b.ToTable("Animal");
                });

            modelBuilder.Entity("WildAnimalsAtSkansen.Entities.AnimalType", b =>
                {
                    b.Property<int>("AnimalTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp(6)");

                    b.HasKey("AnimalTypeId");

                    b.ToTable("AnimalType");
                });

            modelBuilder.Entity("WildAnimalsAtSkansen.Entities.Habitat", b =>
                {
                    b.Property<int>("HabitatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp(6)");

                    b.HasKey("HabitatId");

                    b.ToTable("Habitat");
                });

            modelBuilder.Entity("WildAnimalsAtSkansen.Entities.Animal", b =>
                {
                    b.HasOne("WildAnimalsAtSkansen.Entities.AnimalType", "animalType")
                        .WithMany("Animals")
                        .HasForeignKey("AnimalTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WildAnimalsAtSkansen.Entities.Habitat", "Habitat")
                        .WithMany("Animals")
                        .HasForeignKey("HabitatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Habitat");

                    b.Navigation("animalType");
                });

            modelBuilder.Entity("WildAnimalsAtSkansen.Entities.AnimalType", b =>
                {
                    b.Navigation("Animals");
                });

            modelBuilder.Entity("WildAnimalsAtSkansen.Entities.Habitat", b =>
                {
                    b.Navigation("Animals");
                });
#pragma warning restore 612, 618
        }
    }
}
