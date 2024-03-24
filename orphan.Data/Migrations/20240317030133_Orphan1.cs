using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace orphan.Data.Migrations
{
    /// <inheritdoc />
    public partial class Orphan1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Directorate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directorate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nationality",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationality", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Validity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Village",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Village", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NewOrphan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOrphan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrphanClassification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationalLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Classroom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: true),
                    InsideOrphanage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HousingType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberRoom = table.Column<int>(type: "int", nullable: true),
                    AmountRent = table.Column<double>(type: "float", nullable: true),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numberBrothers = table.Column<int>(type: "int", nullable: true),
                    numberSisters = table.Column<int>(type: "int", nullable: true),
                    OrphanStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    healthStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CausesDisease = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QualityHousing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrphanHobby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmountOfQuran = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClosestPlaceOtLive = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IamgeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherNationalNumber = table.Column<int>(type: "int", nullable: true),
                    DMotherWork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherNationalNumber = table.Column<int>(type: "int", nullable: true),
                    FatherWorkBeforeDeath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateFatherDeath = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuardianName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuardianWork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuardianNationalNumber = table.Column<int>(type: "int", nullable: true),
                    RelationshipWithOrphanhood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    DirectorateId = table.Column<int>(type: "int", nullable: false),
                    VillageId = table.Column<int>(type: "int", nullable: false),
                    NationalityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewOrphan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewOrphan_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NewOrphan_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NewOrphan_Directorate_DirectorateId",
                        column: x => x.DirectorateId,
                        principalTable: "Directorate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NewOrphan_Nationality_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Nationality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NewOrphan_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NewOrphan_Village_VillageId",
                        column: x => x.VillageId,
                        principalTable: "Village",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnnualReport",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Year = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ambitious = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewOrphanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnualReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnnualReport_NewOrphan_NewOrphanId",
                        column: x => x.NewOrphanId,
                        principalTable: "NewOrphan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Side = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewOrphanId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataReview_NewOrphan_NewOrphanId",
                        column: x => x.NewOrphanId,
                        principalTable: "NewOrphan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DataReview_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuardianAttachment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Document_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Document_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewOrphanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuardianAttachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GuardianAttachment_NewOrphan_NewOrphanId",
                        column: x => x.NewOrphanId,
                        principalTable: "NewOrphan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonthlyMovement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceivedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonthNumber = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewOrphanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyMovement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonthlyMovement_NewOrphan_NewOrphanId",
                        column: x => x.NewOrphanId,
                        principalTable: "NewOrphan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrphanAttachment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewOrphanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrphanAttachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrphanAttachment_NewOrphan_NewOrphanId",
                        column: x => x.NewOrphanId,
                        principalTable: "NewOrphan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnnualReport_NewOrphanId",
                table: "AnnualReport",
                column: "NewOrphanId");

            migrationBuilder.CreateIndex(
                name: "IX_DataReview_NewOrphanId",
                table: "DataReview",
                column: "NewOrphanId");

            migrationBuilder.CreateIndex(
                name: "IX_DataReview_UserId",
                table: "DataReview",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GuardianAttachment_NewOrphanId",
                table: "GuardianAttachment",
                column: "NewOrphanId");

            migrationBuilder.CreateIndex(
                name: "IX_MonthlyMovement_NewOrphanId",
                table: "MonthlyMovement",
                column: "NewOrphanId");

            migrationBuilder.CreateIndex(
                name: "IX_NewOrphan_CityId",
                table: "NewOrphan",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_NewOrphan_CountryId",
                table: "NewOrphan",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_NewOrphan_DirectorateId",
                table: "NewOrphan",
                column: "DirectorateId");

            migrationBuilder.CreateIndex(
                name: "IX_NewOrphan_NationalityId",
                table: "NewOrphan",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_NewOrphan_StatusId",
                table: "NewOrphan",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_NewOrphan_VillageId",
                table: "NewOrphan",
                column: "VillageId");

            migrationBuilder.CreateIndex(
                name: "IX_OrphanAttachment_NewOrphanId",
                table: "OrphanAttachment",
                column: "NewOrphanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnnualReport");

            migrationBuilder.DropTable(
                name: "DataReview");

            migrationBuilder.DropTable(
                name: "GuardianAttachment");

            migrationBuilder.DropTable(
                name: "MonthlyMovement");

            migrationBuilder.DropTable(
                name: "OrphanAttachment");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "NewOrphan");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Directorate");

            migrationBuilder.DropTable(
                name: "Nationality");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Village");
        }
    }
}
