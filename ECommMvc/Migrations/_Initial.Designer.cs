using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ECommMvc.Models;

namespace ECommMvc.Migrations
{
    [DbContext(typeof(ECommContext))]
    [Migration("_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Title");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });
        }
    }
}
