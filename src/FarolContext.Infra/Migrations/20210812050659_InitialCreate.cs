using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FarolContext.Infra.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Church",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(120)", nullable: false),
                    Cnpj = table.Column<string>(type: "varchar(14)", nullable: false),
                    DocumentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "varchar(150)", nullable: false),
                    Cellphone = table.Column<string>(type: "varchar(12)", nullable: true),
                    Telephone = table.Column<string>(type: "varchar(12)", nullable: true),
                    Street = table.Column<string>(type: "varchar(150)", nullable: true),
                    Number = table.Column<string>(type: "varchar(150)", nullable: true),
                    Neighborhood = table.Column<string>(type: "varchar(150)", nullable: true),
                    City = table.Column<string>(type: "varchar(150)", nullable: true),
                    State = table.Column<string>(type: "varchar(150)", nullable: true),
                    Country = table.Column<string>(type: "varchar(150)", nullable: true),
                    ZipCode = table.Column<string>(type: "varchar(150)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Church", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cell",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(120)", nullable: false),
                    ChurchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cell", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cell_Church_ChurchId",
                        column: x => x.ChurchId,
                        principalTable: "Church",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ministry",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(120)", nullable: false),
                    ChurchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ministry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ministry_Church_ChurchId",
                        column: x => x.ChurchId,
                        principalTable: "Church",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(150)", nullable: false),
                    LastName = table.Column<string>(type: "varchar(150)", nullable: false),
                    Age = table.Column<DateTime>(type: "datetime", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cpf = table.Column<string>(type: "varchar(11)", nullable: false),
                    DocumentType = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "varchar(150)", nullable: false),
                    Cellphone = table.Column<string>(type: "varchar(12)", nullable: true),
                    Telephone = table.Column<string>(type: "varchar(12)", nullable: true),
                    Street = table.Column<string>(type: "varchar(150)", nullable: true),
                    Number = table.Column<string>(type: "varchar(150)", nullable: true),
                    Neighborhood = table.Column<string>(type: "varchar(150)", nullable: true),
                    City = table.Column<string>(type: "varchar(150)", nullable: true),
                    State = table.Column<string>(type: "varchar(150)", nullable: true),
                    Country = table.Column<string>(type: "varchar(150)", nullable: true),
                    ZipCode = table.Column<string>(type: "varchar(150)", nullable: true),
                    MemberType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChurchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CellId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MinistryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Member_Cell_CellId",
                        column: x => x.CellId,
                        principalTable: "Cell",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Member_Church_ChurchId",
                        column: x => x.ChurchId,
                        principalTable: "Church",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Member_Ministry_MinistryId",
                        column: x => x.MinistryId,
                        principalTable: "Ministry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Visitor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(150)", nullable: true),
                    LastName = table.Column<string>(type: "varchar(150)", nullable: true),
                    Age = table.Column<DateTime>(type: "datetime", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cpf = table.Column<string>(type: "varchar(11)", nullable: true),
                    DocumentType = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "varchar(150)", nullable: true),
                    Cellphone = table.Column<string>(type: "varchar(12)", nullable: true),
                    Telephone = table.Column<string>(type: "varchar(12)", nullable: true),
                    Street = table.Column<string>(type: "varchar(150)", nullable: true),
                    Number = table.Column<string>(type: "varchar(150)", nullable: true),
                    Neighborhood = table.Column<string>(type: "varchar(150)", nullable: true),
                    City = table.Column<string>(type: "varchar(150)", nullable: true),
                    State = table.Column<string>(type: "varchar(150)", nullable: true),
                    Country = table.Column<string>(type: "varchar(150)", nullable: true),
                    ZipCode = table.Column<string>(type: "varchar(150)", nullable: true),
                    VisitDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    MemberInvitedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ChurchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visitor_Church_ChurchId",
                        column: x => x.ChurchId,
                        principalTable: "Church",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Visitor_Member_MemberInvitedId",
                        column: x => x.MemberInvitedId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cell_ChurchId",
                table: "Cell",
                column: "ChurchId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_CellId",
                table: "Member",
                column: "CellId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_ChurchId",
                table: "Member",
                column: "ChurchId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_MinistryId",
                table: "Member",
                column: "MinistryId");

            migrationBuilder.CreateIndex(
                name: "IX_Ministry_ChurchId",
                table: "Ministry",
                column: "ChurchId");

            migrationBuilder.CreateIndex(
                name: "IX_Visitor_ChurchId",
                table: "Visitor",
                column: "ChurchId");

            migrationBuilder.CreateIndex(
                name: "IX_Visitor_MemberInvitedId",
                table: "Visitor",
                column: "MemberInvitedId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visitor");

            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "Cell");

            migrationBuilder.DropTable(
                name: "Ministry");

            migrationBuilder.DropTable(
                name: "Church");
        }
    }
}
