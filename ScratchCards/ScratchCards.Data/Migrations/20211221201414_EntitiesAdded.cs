using Microsoft.EntityFrameworkCore.Migrations;

namespace ScratchCards.Data.Migrations
{
    public partial class EntitiesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BackgroundImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AutoplayButtons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameNameId = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: true),
                    Font = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FontColor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Background = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ButtonIconPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RenderPositionX = table.Column<int>(type: "int", nullable: false),
                    RenderPositionY = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Heigth = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoplayButtons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AutoplayButtons_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BalanceContainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    IconPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    Font = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FontColor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Background = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RenderPositionX = table.Column<int>(type: "int", nullable: false),
                    RenderPositionY = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Heigth = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BalanceContainers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BalanceContainers_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BetContainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    IconPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Font = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FontColor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Background = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RenderPositionX = table.Column<int>(type: "int", nullable: false),
                    RenderPositionY = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Heigth = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BetContainers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BetContainers_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InfoButtons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    InfoText = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    Font = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FontColor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Background = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ButtonIconPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RenderPositionX = table.Column<int>(type: "int", nullable: false),
                    RenderPositionY = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Heigth = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoButtons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InfoButtons_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JackpotContainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    Font = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FontColor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Background = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RenderPositionX = table.Column<int>(type: "int", nullable: false),
                    RenderPositionY = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Heigth = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JackpotContainers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JackpotContainers_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayButtons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    Font = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FontColor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Background = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ButtonIconPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RenderPositionX = table.Column<int>(type: "int", nullable: false),
                    RenderPositionY = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Heigth = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayButtons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayButtons_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SoundButtons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    Font = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FontColor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Background = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ButtonIconPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RenderPositionX = table.Column<int>(type: "int", nullable: false),
                    RenderPositionY = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Heigth = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoundButtons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SoundButtons_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WinSymbolsContainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SymbolsCount = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    Font = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FontColor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Background = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RenderPositionX = table.Column<int>(type: "int", nullable: false),
                    RenderPositionY = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Heigth = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WinSymbolsContainers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WinSymbolsContainers_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YourSymbolsContainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SymbolsCount = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    Font = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FontColor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Background = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RenderPositionX = table.Column<int>(type: "int", nullable: false),
                    RenderPositionY = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Heigth = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YourSymbolsContainers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YourSymbolsContainers_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BonusGameContainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameNameId = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    GameTypeId = table.Column<int>(type: "int", nullable: true),
                    RenderPositionX = table.Column<int>(type: "int", nullable: false),
                    RenderPositionY = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Heigth = table.Column<int>(type: "int", nullable: false),
                    Font = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FontColor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Background = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SymbolsCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BonusGameContainers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BonusGameContainers_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BonusGameContainers_GameTypes_GameTypeId",
                        column: x => x.GameTypeId,
                        principalTable: "GameTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SuperBonusGameContainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    GameTypeId = table.Column<int>(type: "int", nullable: false),
                    RenderPositionX = table.Column<int>(type: "int", nullable: false),
                    RenderPositionY = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Heigth = table.Column<int>(type: "int", nullable: false),
                    Font = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FontColor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Background = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SymbolsCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperBonusGameContainers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SuperBonusGameContainers_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SuperBonusGameContainers_GameTypes_GameTypeId",
                        column: x => x.GameTypeId,
                        principalTable: "GameTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Symbols",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    UnrevealdPicturePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    GameTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Symbols", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Symbols_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Symbols_GameTypes_GameTypeId",
                        column: x => x.GameTypeId,
                        principalTable: "GameTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutoplayButtons_GameId",
                table: "AutoplayButtons",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_BalanceContainers_GameId",
                table: "BalanceContainers",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_BetContainers_GameId",
                table: "BetContainers",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_BonusGameContainers_GameId",
                table: "BonusGameContainers",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_BonusGameContainers_GameTypeId",
                table: "BonusGameContainers",
                column: "GameTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_InfoButtons_GameId",
                table: "InfoButtons",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_JackpotContainers_GameId",
                table: "JackpotContainers",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayButtons_GameId",
                table: "PlayButtons",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_SoundButtons_GameId",
                table: "SoundButtons",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_SuperBonusGameContainers_GameId",
                table: "SuperBonusGameContainers",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_SuperBonusGameContainers_GameTypeId",
                table: "SuperBonusGameContainers",
                column: "GameTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Symbols_GameId",
                table: "Symbols",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Symbols_GameTypeId",
                table: "Symbols",
                column: "GameTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WinSymbolsContainers_GameId",
                table: "WinSymbolsContainers",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_YourSymbolsContainers_GameId",
                table: "YourSymbolsContainers",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutoplayButtons");

            migrationBuilder.DropTable(
                name: "BalanceContainers");

            migrationBuilder.DropTable(
                name: "BetContainers");

            migrationBuilder.DropTable(
                name: "BonusGameContainers");

            migrationBuilder.DropTable(
                name: "InfoButtons");

            migrationBuilder.DropTable(
                name: "JackpotContainers");

            migrationBuilder.DropTable(
                name: "PlayButtons");

            migrationBuilder.DropTable(
                name: "SoundButtons");

            migrationBuilder.DropTable(
                name: "SuperBonusGameContainers");

            migrationBuilder.DropTable(
                name: "Symbols");

            migrationBuilder.DropTable(
                name: "WinSymbolsContainers");

            migrationBuilder.DropTable(
                name: "YourSymbolsContainers");

            migrationBuilder.DropTable(
                name: "GameTypes");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
