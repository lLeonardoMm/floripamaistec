﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nascimento.Context;

#nullable disable

namespace bercario.Migrations
{
    [DbContext(typeof(BercarioContext))]
    partial class BercarioContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("bercario.Models.Bebe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Altura")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDeNascimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDeMae")
                        .HasColumnType("int");

                    b.Property<int>("IdDoParto")
                        .HasColumnType("int");

                    b.Property<decimal>("PesoDeNascimento")
                        .HasPrecision(4, 3)
                        .HasColumnType("decimal(4,3)");

                    b.HasKey("Id");

                    b.HasIndex("IdDeMae");

                    b.HasIndex("IdDoParto");

                    b.ToTable("Bebe", (string)null);
                });

            modelBuilder.Entity("bercario.Models.Mae", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataDeNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Mae", (string)null);
                });

            modelBuilder.Entity("bercario.Models.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CRM")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("Celular")
                        .HasColumnType("int");

                    b.Property<string>("Especialidade")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Medico", (string)null);
                });

            modelBuilder.Entity("bercario.Models.Parto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataDoParto")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HorarioDoParto")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDoMedico")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdDoMedico");

                    b.ToTable("Partos");
                });

            modelBuilder.Entity("bercario.Models.Bebe", b =>
                {
                    b.HasOne("bercario.Models.Mae", "MaeBebe")
                        .WithMany("Bebes")
                        .HasForeignKey("IdDeMae")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Bebe_Mae");

                    b.HasOne("bercario.Models.Parto", "PartoBebe")
                        .WithMany("Bebes")
                        .HasForeignKey("IdDoParto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Bebe_Parto");

                    b.Navigation("MaeBebe");

                    b.Navigation("PartoBebe");
                });

            modelBuilder.Entity("bercario.Models.Parto", b =>
                {
                    b.HasOne("bercario.Models.Medico", "MedicoParto")
                        .WithMany("Partos")
                        .HasForeignKey("IdDoMedico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Parto_Medico");

                    b.Navigation("MedicoParto");
                });

            modelBuilder.Entity("bercario.Models.Mae", b =>
                {
                    b.Navigation("Bebes");
                });

            modelBuilder.Entity("bercario.Models.Medico", b =>
                {
                    b.Navigation("Partos");
                });

            modelBuilder.Entity("bercario.Models.Parto", b =>
                {
                    b.Navigation("Bebes");
                });
#pragma warning restore 612, 618
        }
    }
}
