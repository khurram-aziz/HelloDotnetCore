using System;
using System.Collections.Generic;
using ECommMvc.Models;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommMvc.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            using(var db = new ECommContext())
            {
                db.Products.AddRange(
                    new Product() { Title = "iPhone", Price = 800, Rating = 5 },
                    new Product() { Title = "Pixel", Price = 700, Rating = 4 }
                );
                db.SaveChanges();
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
