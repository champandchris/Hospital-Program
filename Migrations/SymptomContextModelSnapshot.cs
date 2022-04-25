﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hospital.Data;

#nullable disable

namespace hospital.Migrations
{
    [DbContext(typeof(SymptomContext))]
    partial class SymptomContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("hospital.Models.Symptom", b =>
                {
                    b.Property<int>("DiseaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Disease")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SymptomFive")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SymptomFour")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SymptomOne")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SymptomThree")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SymptomTwo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("DiseaseId");

                    b.ToTable("Symptoms");
                });
#pragma warning restore 612, 618
        }
    }
}
