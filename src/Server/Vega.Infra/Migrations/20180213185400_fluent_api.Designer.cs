﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Vega.Infra.Data.Contexts;

namespace Vega.Infra.Migrations
{
    [DbContext(typeof(VegaContext))]
    [Migration("20180213185400_fluent_api")]
    partial class fluent_api
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Vega.Core.Models.Feature", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Features");
                });

            modelBuilder.Entity("Vega.Core.Models.Make", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Makes");
                });

            modelBuilder.Entity("Vega.Core.Models.Model", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<Guid>("MakeId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("MakeId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("Vega.Core.Models.Model", b =>
                {
                    b.HasOne("Vega.Core.Models.Make", "Make")
                        .WithMany("Models")
                        .HasForeignKey("MakeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
