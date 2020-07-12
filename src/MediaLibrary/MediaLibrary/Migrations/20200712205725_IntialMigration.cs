using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaLibrary.Migrations
{
    public partial class IntialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookGenre",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGenre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieGenre",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieGenre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MusicGenre",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicGenre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    MediaType = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    AuthorId = table.Column<int>(nullable: true),
                    PageCount = table.Column<int>(nullable: true),
                    ChapterCount = table.Column<int>(nullable: true),
                    GenreId = table.Column<int>(nullable: true),
                    Director = table.Column<string>(nullable: true),
                    Length = table.Column<DateTime>(nullable: true),
                    Movie_GenreId = table.Column<int>(nullable: true),
                    ArtistId = table.Column<int>(nullable: true),
                    Music_GenreId = table.Column<int>(nullable: true),
                    Music_Length = table.Column<DateTime>(nullable: true),
                    Series_GenreId = table.Column<int>(nullable: true),
                    SeasonCount = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Media_BookGenre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "BookGenre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Media_MovieGenre_Movie_GenreId",
                        column: x => x.Movie_GenreId,
                        principalTable: "MovieGenre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Media_MusicGenre_Music_GenreId",
                        column: x => x.Music_GenreId,
                        principalTable: "MusicGenre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Media_MovieGenre_Series_GenreId",
                        column: x => x.Series_GenreId,
                        principalTable: "MovieGenre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    MovieId = table.Column<int>(nullable: true),
                    SeriesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Artists_Media_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Media",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Artists_Media_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Media",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artists_MovieId",
                table: "Artists",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Artists_SeriesId",
                table: "Artists",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_AuthorId",
                table: "Media",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_GenreId",
                table: "Media",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_Movie_GenreId",
                table: "Media",
                column: "Movie_GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_ArtistId",
                table: "Media",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_Music_GenreId",
                table: "Media",
                column: "Music_GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_Series_GenreId",
                table: "Media",
                column: "Series_GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Media_Artists_AuthorId",
                table: "Media",
                column: "AuthorId",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Media_Artists_ArtistId",
                table: "Media",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artists_Media_MovieId",
                table: "Artists");

            migrationBuilder.DropForeignKey(
                name: "FK_Artists_Media_SeriesId",
                table: "Artists");

            migrationBuilder.DropTable(
                name: "Media");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "BookGenre");

            migrationBuilder.DropTable(
                name: "MovieGenre");

            migrationBuilder.DropTable(
                name: "MusicGenre");
        }
    }
}
