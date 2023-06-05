using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PartRoleManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class PartRoleInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PartyRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Href = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValidFor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountRef",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PartyRoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReferredType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Href = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountRef", x => new { x.PartyRoleId, x.Id });
                    table.ForeignKey(
                        name: "FK_AccountRef_PartyRole_PartyRoleId",
                        column: x => x.PartyRoleId,
                        principalTable: "PartyRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AgreementRefs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PartyRoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReferredType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Href = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgreementRefs", x => new { x.PartyRoleId, x.Id });
                    table.ForeignKey(
                        name: "FK_AgreementRefs_PartyRole_PartyRoleId",
                        column: x => x.PartyRoleId,
                        principalTable: "PartyRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Characteristics",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PartyRoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValueType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characteristics", x => new { x.PartyRoleId, x.Id });
                    table.ForeignKey(
                        name: "FK_Characteristics_PartyRole_PartyRoleId",
                        column: x => x.PartyRoleId,
                        principalTable: "PartyRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContactMedia",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BaseType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchemaLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preferred = table.Column<bool>(type: "bit", nullable: true),
                    PartyRoleId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ValidFor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactMedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactMedia_PartyRole_PartyRoleId",
                        column: x => x.PartyRoleId,
                        principalTable: "PartyRole",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CreditProfiles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreditProfileDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditRiskRating = table.Column<long>(type: "bigint", nullable: false),
                    CreditScore = table.Column<long>(type: "bigint", nullable: false),
                    PartyRoleId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ValidFor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreditProfiles_PartyRole_PartyRoleId",
                        column: x => x.PartyRoleId,
                        principalTable: "PartyRole",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EngagedPartys",
                columns: table => new
                {
                    PartyRoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Href = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaseType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchemaLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferredType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngagedPartys", x => x.PartyRoleId);
                    table.ForeignKey(
                        name: "FK_EngagedPartys_PartyRole_PartyRoleId",
                        column: x => x.PartyRoleId,
                        principalTable: "PartyRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PartyRoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReferredType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Href = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => new { x.PartyRoleId, x.Id });
                    table.ForeignKey(
                        name: "FK_PaymentMethods_PartyRole_PartyRoleId",
                        column: x => x.PartyRoleId,
                        principalTable: "PartyRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RelatedPartys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PartyRoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Href = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaseType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchemaLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferredType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedPartys", x => new { x.PartyRoleId, x.Id });
                    table.ForeignKey(
                        name: "FK_RelatedPartys_PartyRole_PartyRoleId",
                        column: x => x.PartyRoleId,
                        principalTable: "PartyRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MediumCharacteristics",
                columns: table => new
                {
                    ContactMediumId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateOrProvince = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediumCharacteristics", x => x.ContactMediumId);
                    table.ForeignKey(
                        name: "FK_MediumCharacteristics_ContactMedia_ContactMediumId",
                        column: x => x.ContactMediumId,
                        principalTable: "ContactMedia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactMedia_PartyRoleId",
                table: "ContactMedia",
                column: "PartyRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditProfiles_PartyRoleId",
                table: "CreditProfiles",
                column: "PartyRoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountRef");

            migrationBuilder.DropTable(
                name: "AgreementRefs");

            migrationBuilder.DropTable(
                name: "Characteristics");

            migrationBuilder.DropTable(
                name: "CreditProfiles");

            migrationBuilder.DropTable(
                name: "EngagedPartys");

            migrationBuilder.DropTable(
                name: "MediumCharacteristics");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "RelatedPartys");

            migrationBuilder.DropTable(
                name: "ContactMedia");

            migrationBuilder.DropTable(
                name: "PartyRole");
        }
    }
}
