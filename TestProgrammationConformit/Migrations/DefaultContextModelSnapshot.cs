﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TestProgrammationConformit.Models;

namespace TestProgrammationConformit.Migrations
{
    [DbContext(typeof(DefaultContext))]
    partial class DefaultContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("TestProgrammationConformit.Models.Commentaire", b =>
                {
                    b.Property<int>("CommentaireId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("EventId")
                        .HasColumnType("integer");

                    b.Property<int?>("evenementEvent")
                        .HasColumnType("integer");

                    b.HasKey("CommentaireId");

                    b.HasIndex("evenementEvent");

                    b.ToTable("commentaires");
                });

            modelBuilder.Entity("TestProgrammationConformit.Models.Evenement", b =>
                {
                    b.Property<int>("Event")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Personne")
                        .HasColumnType("text");

                    b.Property<string>("Titre")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Event");

                    b.ToTable("evenements");
                });

            modelBuilder.Entity("TestProgrammationConformit.Models.Commentaire", b =>
                {
                    b.HasOne("TestProgrammationConformit.Models.Evenement", "evenement")
                        .WithMany("commentaires")
                        .HasForeignKey("evenementEvent");

                    b.Navigation("evenement");
                });

            modelBuilder.Entity("TestProgrammationConformit.Models.Evenement", b =>
                {
                    b.Navigation("commentaires");
                });
#pragma warning restore 612, 618
        }
    }
}
