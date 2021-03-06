﻿// <auto-generated />
using System;
using DotnetSpider.Portal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DotnetSpider.Portal.Migrations
{
    [DbContext(typeof(PortalDbContext))]
    [Migration("20190409091555_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DotnetSpider.Portal.Entity.DockerImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<int>("DockerImageRepositoryId");

                    b.Property<string>("Repository")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("Repository")
                        .IsUnique();

                    b.ToTable("DockerImages");
                });

            modelBuilder.Entity("DotnetSpider.Portal.Entity.DockerImageRepository", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("Registry")
                        .HasMaxLength(255);

                    b.Property<string>("Repository")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("CreationTime");

                    b.HasIndex("LastModificationTime");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("Repository")
                        .IsUnique();

                    b.ToTable("DockerImageRepositories");
                });
#pragma warning restore 612, 618
        }
    }
}
