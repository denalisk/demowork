using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using GummyBear.Models;

namespace GummyBear.Migrations
{
    [DbContext(typeof(GummyBearDbContext))]
    [Migration("20170421004835_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GummyBear.Models.GummyBear", b =>
                {
                    b.Property<int>("GummyBearId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cost");

                    b.Property<string>("Country");

                    b.Property<string>("ImageAlt");

                    b.Property<string>("ImageSrc");

                    b.Property<string>("Name");

                    b.HasKey("GummyBearId");

                    b.ToTable("GummyBear");
                });
        }
    }
}
