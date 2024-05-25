using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PesekarFutbolLiqasi.DAL.Migrations
{
    /// <inheritdoc />
    public partial class initialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Komandalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KomandaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QaliblikSayi = table.Column<int>(type: "int", nullable: false),
                    BeraberlikSayi = table.Column<int>(type: "int", nullable: false),
                    MeglubiyyetSayi = table.Column<int>(type: "int", nullable: false),
                    AtdigiQolSayi = table.Column<int>(type: "int", nullable: false),
                    YediyiQolSayi = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komandalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Futbolcular",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormaNomresi = table.Column<int>(type: "int", nullable: false),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AtdigiQolSayi = table.Column<int>(type: "int", nullable: false),
                    KomandaId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Futbolcular", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Futbolcular_Komandalar_KomandaId",
                        column: x => x.KomandaId,
                        principalTable: "Komandalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Oyunlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HefteNomresi = table.Column<int>(type: "int", nullable: false),
                    EvSahibiId = table.Column<int>(type: "int", nullable: false),
                    QonaqId = table.Column<int>(type: "int", nullable: false),
                    EvSahibiQolSayı = table.Column<int>(type: "int", nullable: false),
                    QonaqQolSayı = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oyunlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Oyunlar_Komandalar_EvSahibiId",
                        column: x => x.EvSahibiId,
                        principalTable: "Komandalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Oyunlar_Komandalar_QonaqId",
                        column: x => x.QonaqId,
                        principalTable: "Komandalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Futbolcular_KomandaId",
                table: "Futbolcular",
                column: "KomandaId");

            migrationBuilder.CreateIndex(
                name: "IX_Oyunlar_EvSahibiId",
                table: "Oyunlar",
                column: "EvSahibiId");

            migrationBuilder.CreateIndex(
                name: "IX_Oyunlar_QonaqId",
                table: "Oyunlar",
                column: "QonaqId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Futbolcular");

            migrationBuilder.DropTable(
                name: "Oyunlar");

            migrationBuilder.DropTable(
                name: "Komandalar");
        }
    }
}
