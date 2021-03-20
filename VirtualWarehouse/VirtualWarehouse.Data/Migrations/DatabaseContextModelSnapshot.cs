﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VirtualWarehouse.Data.Services;

namespace VirtualWarehouse.Data.Migrations
{
    [DbContext(typeof(DatabaseContextFactory))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VirtualWarehouse.Data.Models.Attributes.ThingAttribute", b =>
                {
                    b.Property<int>("ThingAttributeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AttributeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThingId")
                        .HasColumnType("int");

                    b.HasKey("ThingAttributeId");

                    b.HasIndex("ThingId");

                    b.ToTable("ThingAttribute");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ThingAttribute");
                });

            modelBuilder.Entity("VirtualWarehouse.Data.Models.Thing", b =>
                {
                    b.Property<int>("ThingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ThingId1")
                        .HasColumnType("int");

                    b.Property<string>("ThingName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ThingId");

                    b.HasIndex("ThingId1");

                    b.ToTable("Things");
                });

            modelBuilder.Entity("VirtualWarehouse.Data.Models.Attributes.Description", b =>
                {
                    b.HasBaseType("VirtualWarehouse.Data.Models.Attributes.ThingAttribute");

                    b.Property<string>("DescriptionContent")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Description");
                });

            modelBuilder.Entity("VirtualWarehouse.Data.Models.Attributes.Note", b =>
                {
                    b.HasBaseType("VirtualWarehouse.Data.Models.Attributes.ThingAttribute");

                    b.Property<string>("NoteContent")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Note");
                });

            modelBuilder.Entity("VirtualWarehouse.Data.Models.Attributes.ThingAttribute", b =>
                {
                    b.HasOne("VirtualWarehouse.Data.Models.Thing", "Thing")
                        .WithMany("Attributes")
                        .HasForeignKey("ThingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Thing");
                });

            modelBuilder.Entity("VirtualWarehouse.Data.Models.Thing", b =>
                {
                    b.HasOne("VirtualWarehouse.Data.Models.Thing", null)
                        .WithMany("AssociatedThings")
                        .HasForeignKey("ThingId1");
                });

            modelBuilder.Entity("VirtualWarehouse.Data.Models.Thing", b =>
                {
                    b.Navigation("AssociatedThings");

                    b.Navigation("Attributes");
                });
#pragma warning restore 612, 618
        }
    }
}
