using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Toyota')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Lexus')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Volkswagen')");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Carmy', (SELECT ID FROM Makes WHERE Name = 'Toyota'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Yaris', (SELECT ID FROM Makes WHERE Name = 'Toyota'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Rav', (SELECT ID FROM Makes WHERE Name = 'Toyota'))");
            
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('LX', (SELECT ID FROM Makes WHERE Name = 'Lexus'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('NX', (SELECT ID FROM Makes WHERE Name = 'Lexus'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('RX', (SELECT ID FROM Makes WHERE Name = 'Lexus'))");
            
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Golf', (SELECT ID FROM Makes WHERE Name = 'Volkswagen'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Pool', (SELECT ID FROM Makes WHERE Name = 'Volkswagen'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Tiguan', (SELECT ID FROM Makes WHERE Name = 'Volkswagen'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Makes WHERE Name IN ('Toyota', 'Lexus', 'Volkswagen')");
            // migrationBuilder.Sql("TRUNCATE TABLE Models");
        }
    }
}
