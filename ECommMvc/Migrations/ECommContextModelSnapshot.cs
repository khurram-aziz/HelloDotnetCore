using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ECommMvc.Models;

namespace ECommMvc.Migrations
{
    [DbContext(typeof(ECommContext))]
    partial class ECommContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("ECommMvc.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string[]>("ImageUrls");

                    b.Property<int>("Price");

                    b.Property<int>("Rating");

                    b.Property<int>("Title");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });
        }
    }
}
