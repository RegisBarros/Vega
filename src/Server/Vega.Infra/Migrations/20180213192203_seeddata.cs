using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Vega.Infra.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            Guid make1 = Guid.NewGuid();
            Guid make2 = Guid.NewGuid();
            Guid make3 = Guid.NewGuid();

            migrationBuilder.Sql($"INSERT INTO Makes (Id, Name) VALUES ('{make1}',  'Make1')");
            migrationBuilder.Sql($"INSERT INTO Makes (Id, Name) VALUES ('{make2}',  'Make2')");
            migrationBuilder.Sql($"INSERT INTO Makes (Id, Name) VALUES ('{make3}',  'Make3')");

            migrationBuilder.Sql($"INSERT INTO Models (MakeId, Name, Id) VALUES ('{make1}',  'Make1-ModelA', '{Guid.NewGuid()}')");
            migrationBuilder.Sql($"INSERT INTO Models (MakeId, Name, Id) VALUES ('{make1}',  'Make1-ModelB', '{Guid.NewGuid()}')");
            migrationBuilder.Sql($"INSERT INTO Models (MakeId, Name, Id) VALUES ('{make1}',  'Make1-ModelC', '{Guid.NewGuid()}')");
                                                                         
            migrationBuilder.Sql($"INSERT INTO Models (MakeId, Name, Id) VALUES ('{make2}',  'Make2-ModelA', '{Guid.NewGuid()}')");
            migrationBuilder.Sql($"INSERT INTO Models (MakeId, Name, Id) VALUES ('{make2}',  'Make2-ModelB', '{Guid.NewGuid()}')");
            migrationBuilder.Sql($"INSERT INTO Models (MakeId, Name, Id) VALUES ('{make2}',  'Make2-ModelC', '{Guid.NewGuid()}')");
                                                                         
            migrationBuilder.Sql($"INSERT INTO Models (MakeId, Name, Id) VALUES ('{make3}',  'Make3-ModelA', '{Guid.NewGuid()}')");
            migrationBuilder.Sql($"INSERT INTO Models (MakeId, Name, Id) VALUES ('{make3}',  'Make3-ModelB', '{Guid.NewGuid()}')");
            migrationBuilder.Sql($"INSERT INTO Models (MakeId, Name, Id) VALUES ('{make3}',  'Make3-ModelC', '{Guid.NewGuid()}')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Makes IN ('Make1', 'Make2', 'Make3')");
        }
    }
}
