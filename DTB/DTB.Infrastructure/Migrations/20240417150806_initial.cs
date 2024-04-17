using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DTB.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactFormSubmissions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactFormSubmissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Professions_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChatId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProfessionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    JobAdId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Professions_ProfessionId",
                        column: x => x.ProfessionId,
                        principalTable: "Professions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ArticleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CompanyLocation",
                columns: table => new
                {
                    CompaniesId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LocationsId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyLocation", x => new { x.CompaniesId, x.LocationsId });
                    table.ForeignKey(
                        name: "FK_CompanyLocation_AspNetUsers_CompaniesId",
                        column: x => x.CompaniesId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyLocation_Locations_LocationsId",
                        column: x => x.LocationsId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Files_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JobAds",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProfessionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Experience = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LocationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobAds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobAds_AspNetUsers_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobAds_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobAds_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobAds_Professions_ProfessionId",
                        column: x => x.ProfessionId,
                        principalTable: "Professions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SenderId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ReceiverId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ChatId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Messages_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6530f828-f8af-41fd-b651-94a1392793e9", null, "User", "USER" },
                    { "a98655fe-8cf3-43d7-9f14-6e54222f3240", null, "Company", "COMPANY" },
                    { "e1dfafac-528a-43f9-b350-048ac84639a3", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ChatId", "ConcurrencyStamp", "DateOfBirth", "Description", "Discriminator", "Email", "EmailConfirmed", "FirstName", "JobAdId", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfessionId", "ProfilePicture", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cad23a9b-e215-45e8-823f-87207f8c2b71", 0, null, "19e1efb2-93ff-4d17-b0dd-ce5902cc3cbf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "User", "test@abv.bg", false, "Test", null, "Testov", false, null, "Testov", null, "test@abv.bg", "6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b", null, false, null, null, "a7658f0c-125a-4dc6-be75-ce62805ce513", 0, false, "test" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DateOfCreation", "Name", "PictureUrl" },
                values: new object[,]
                {
                    { "0676aec9-89f5-4511-b642-6d0fe86e404a", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(698), "Real-estate", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_realestate_dkhhfe.png" },
                    { "07a32cf2-3c7a-4ab0-ab70-9952c0966f30", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(673), "Restaurants, Bars, Hotels, Tourism", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824823/icon_restaurant_ee4ubg.png" },
                    { "16bf1012-a018-453d-97f2-d9682a3588f1", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(695), "Education, Courses, Translators", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_education_kdsm7z.png" },
                    { "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(702), "Aviation, Airport & Airline", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_airline_bgvmiu.png" },
                    { "221e3547-3c78-41f9-9634-d7571a615fb8", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(704), "Auto Service", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824819/icon_autoservice_iabxkj.png" },
                    { "265bc199-91e3-4eba-9886-bce0a19e6ce2", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(706), "Retail, Wholesale", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824824/icon_retail_pgicm9.png" },
                    { "38b5eb73-7829-497b-a207-9bcf3fef3b1b", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(675), "Engineers and Technicians", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_engineer_wzjia1.png" },
                    { "3c1fda93-5ef8-4db2-97f7-25f163fbca67", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(681), "Media, Publishing", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_media_mpzkez.png" },
                    { "3ea25504-1598-4608-a362-84d82b1b2fce", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(693), "Telecommunications - engineers and technicians", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_telecoms_sbsq5u.png" },
                    { "438c1389-c017-43b8-a34a-46b8c64f5e1d", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(679), "Human Resources", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_hr_jbc5jn.png" },
                    { "6859c0a0-98d0-49c5-b017-17d2a64d3342", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(723), "Research and development", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824822/icon_research_mdrafi.png" },
                    { "71eb6b38-7552-425e-bf09-ee22d23855bb", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(690), "Office and Business activities", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_office_xkdjih.png" },
                    { "80bb3283-c810-4b9c-9d42-da03e17b2ddf", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(626), "Architecture, Construction", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_architecture_gqdlbl.png" },
                    { "8910967e-2a14-4a1a-a3f5-d16cc78a4b32", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(697), "Security", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_security_c4fjq0.png" },
                    { "a732a432-ef4f-4407-9dba-71f904d0ea6e", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(669), "Health and Pharmacy", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_health_nhktmm.png" },
                    { "b89927d7-b1fd-4703-98df-a4681ce2db88", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(671), "Drivers, Couriers", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_derivers_q8g7p3.png" },
                    { "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(689), "Marketing, Advertising, PR", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_hr_jbc5jn.png" },
                    { "c468efd1-09cf-4e6c-9245-2e837e500968", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(684), "Customer support", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_customersupport_fbvie5.png" },
                    { "c4dd9eea-1569-402f-a5b8-8473f48437a1", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(683), "Logistics, Spedition", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_logistic_ktvoqa.png" },
                    { "dc8214a6-79cf-436c-bae1-7387b82a3bce", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(725), "Accouting, Audit, Finance", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_finance_r5bftt.png" },
                    { "ec4b3c64-1f2f-455d-a6e4-75b525625371", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(701), "Legal", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_legal_ofzofx.png" },
                    { "f239ac3f-856e-494c-95df-2521a3269a6b", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(692), "Energy, Water and Sewage, Utilities", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_energy_kznsrc.png" },
                    { "fd71ecf5-cb6d-4e3c-ad4e-84358bdfa328", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(707), "Technical Support", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_techsupport_zph0mx.png" },
                    { "ff13d479-760d-4387-8843-c882ad150609", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(687), "Banking, Lending, Insurance", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_banking_dkgjma.png" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "0212d51d-5cc7-41c6-91b4-8b7237882442", "Blagoevgrad" },
                    { "1dbfe0e6-d4cb-46e8-a6cc-0a0c1f60f6de", "Dimitrovgrad" },
                    { "271f8045-12b1-4042-b930-d95cb98b687d", "Plovdiv" },
                    { "2dafea3b-3d3a-46da-a2d4-3a1ad7ab953a", "Elhovo" },
                    { "79f47c1b-0975-42e7-8b94-12e3e3bbd319", "Ruse" },
                    { "9b51ab5b-59a6-4e02-b883-27e2085e5ad3", "Sofia" },
                    { "be267067-1415-4d9c-9d45-ef62b1588c58", "Sliven" },
                    { "bedffed3-610d-4b60-8ac4-b35bc1707f4f", "Yambol" },
                    { "f83622f2-b418-4a1a-9dcb-24d0e79c9b7b", "Burgas" },
                    { "fdcd7e7e-eb16-4ef3-bfbf-164340f6a0d3", "Varna" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "AuthorId", "Content", "DateOfCreation", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { "3c589efc-ae59-439f-93f6-29f162d04e1c", "cad23a9b-e215-45e8-823f-87207f8c2b71", "In the dynamic landscape of modern workplaces, diversity and inclusion (D&I) have emerged as critical components of organizational success. Beyond just fulfilling ethical obligations, companies that prioritize D&I enjoy a myriad of benefits, including enhanced innovation, stronger employee engagement, and improved financial performance. However, achieving a truly diverse and inclusive workforce requires deliberate efforts at every stage of the employee lifecycle, from recruitment to retention. In this article, we'll explore some best practices for both recruitment and retention that can help organizations build and maintain a diverse and inclusive workforce.\r\nRecruitment Best Practices:\r\n\r\n\r\n\r\n1. Expand Outreach Efforts: To attract a diverse pool of candidates, it's crucial to broaden recruitment efforts beyond traditional channels. This may involve collaborating with diversity-focused organizations, attending events tailored to underrepresented groups, and utilizing targeted advertising on social media platforms. By proactively seeking out diverse talent, organizations can ensure a more inclusive recruitment process.\r\n2. Review Job Descriptions: Job descriptions should be crafted with inclusivity in mind. Avoid using biased language or requirements that may unintentionally deter certain candidates. Focus on the essential skills and qualifications needed for the role, rather than unnecessary criteria that may exclude qualified candidates from diverse backgrounds.\r\n3.Implement Blind Screening: Unconscious biases can influence hiring decisions, even unintentionally. Implementing blind screening processes, where personal information such as name, gender, and ethnicity is removed from resumes during the initial review, can help mitigate bias and ensure fair evaluation based solely on qualifications and experience.\r\n4. Diverse Interview Panels: Including diverse perspectives in the interview process is essential for promoting inclusivity. Consider assembling interview panels that reflect the diversity of your workforce and the broader community. This can help mitigate biases and ensure that candidates are evaluated fairly.\r\nRetention Best Practices:\r\n\r\n\r\n\r\n1. Promote Inclusive Culture: Creating a culture of inclusivity starts from the top. Leaders should actively champion D&I initiatives and foster an environment where all employees feel valued and respected. Encourage open dialogue, celebrate diversity, and address any instances of discrimination or bias promptly and effectively.\r\n2. Offer Development Opportunities: Provide opportunities for professional development and career advancement for all employees. Offer mentorship programs, training workshops, and leadership development initiatives that support the growth and progression of diverse talent within the organization.\r\n3.Establish Support Networks: Employee resource groups (ERGs) can provide a valuable support network for employees from underrepresented backgrounds. Encourage the formation of ERGs based on common identities or interests and provide resources and support to help them thrive.\r\n4. Regularly Review Policies: Periodically review HR policies and practices to ensure they are inclusive and equitable. Solicit feedback from employees and make necessary adjustments to address any gaps or areas for improvement.\r\nConclusion\r\n\r\n\r\n\r\nBuilding a diverse and inclusive workforce is not only the right thing to do—it's also a strategic imperative for organizations seeking to thrive in today's global marketplace. By implementing best practices for recruitment and retention, organizations can create environments where every individual feels valued, respected, and empowered to contribute their unique perspectives and talents. Through intentional efforts and proactive strategies, we can build a more equitable and inclusive future where diversity is celebrated and embraced as a source of strength and innovation.\r\n\r\n\r\n\r\n\r\nNikolai Ivanov is a seasoned HR professional with a deep commitment to building diverse and inclusive workplaces. With a wealth of experience in recruitment, talent development, and organizational culture, Nikolai understands the importance of creating environments where every individual feels valued, respected, and empowered to contribute their unique perspectives and talents.\r\n", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(1091), "https://res.cloudinary.com/dftfu5p0r/image/upload/v1711995700/article6_yhytju.jpg", "Building A Diverse And Inclusive Workforce: Best Practices For Recruitment And Retention" },
                    { "56244357-a6b0-46ba-ab93-3b236b653219", "cad23a9b-e215-45e8-823f-87207f8c2b71", "In the wake of the COVID-19 pandemic, the traditional office-centric model of work has undergone a seismic shift. Remote work has become the new norm for many organizations, accelerating the adoption of digital technologies and fundamentally reshaping the way we approach talent acquisition. In this article, we'll explore strategies for navigating the digital talent landscape and effectively hiring in a remote-first world.:\r\nEmbrace Remote Work as the New Reality::\r\n\r\n\r\n\r\nThe first step in adapting to the remote-first world is to embrace it as the new reality. Recognize that remote work offers numerous benefits, including access to a broader talent pool, increased flexibility for employees, and reduced overhead costs for organizations. By embracing remote work, companies can tap into a diverse range of talent from around the globe and leverage digital tools to facilitate seamless collaboration across distributed teams.\r\nLeverage Digital Platforms for Recruitment:\r\n\r\n\r\n\r\nIn a remote-first world, traditional recruitment methods such as in-person interviews and job fairs may no longer be feasible. Instead, organizations must leverage digital platforms and technologies to connect with and attract top talent. This may include utilizing online job boards, social media platforms, and professional networking sites to advertise job openings and engage with potential candidates. Additionally, consider leveraging video interviewing platforms and virtual recruitment events to conduct remote interviews and assess candidates' skills and fit for the role.\r\nPrioritize Communication and Collaboration:\r\n\r\n\r\n\r\nEffective communication and collaboration are essential for success in a remote work environment. When hiring for remote positions, prioritize candidates who demonstrate strong communication skills, self-motivation, and the ability to work independently. Additionally, ensure that your organization has robust communication tools and practices in place to facilitate seamless collaboration among remote teams. This may include utilizing messaging apps, video conferencing software, and project management tools to keep teams connected and aligned.\r\nFocus on Results and Outcomes:\r\n\r\n\r\n\r\nIn a remote-first world, it's essential to focus on results and outcomes rather than hours worked or physical presence. When evaluating candidates, prioritize those who have a track record of delivering results in a remote or distributed work environment. Look for candidates who are self-directed, results-oriented, and able to thrive in a virtual setting. Additionally, consider implementing performance metrics and goals that emphasize outcomes rather than activities, empowering employees to focus on achieving measurable results regardless of their physical location.\r\nProvide Support and Resources for Remote Employees:\r\n\r\n\r\n\r\nRemote work can present unique challenges for employees, including feelings of isolation, difficulty maintaining work-life balance, and technological barriers. To support remote employees and ensure their success, provide access to resources and support services tailored to their needs. This may include offering remote onboarding and training programs, providing access to remote work tools and technology, and fostering a culture of inclusivity and support for remote employees.\r\nConclusion\r\n\r\n\r\n\r\nINavigating the digital talent landscape requires a shift in mindset and approach to hiring in a remote-first world. By embracing remote work as the new reality, leveraging digital platforms for recruitment, prioritizing communication and collaboration, focusing on results and outcomes, and providing support and resources for remote employees, organizations can effectively navigate the challenges and opportunities of hiring in a remote-first world. By embracing these strategies, companies can build diverse, high-performing teams that drive innovation and success in the digital age.\r\n\r\n\r\n\r\n\r\nMilena Koleva is a seasoned HR professional with a passion for talent acquisition and organizational development. With a focus on leveraging digital technologies and remote work strategies, Milena helps organizations navigate the complexities of hiring in a remote-first world. Through her expertise and dedication, Milena empowers companies to build diverse, resilient teams that thrive in today's digital landscape.\r\n", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(1084), "https://res.cloudinary.com/dftfu5p0r/image/upload/v1711995437/remoteworking_o1rphp.jpg", "Navigating The Digital Talent Landscape: Strategies For Hiring In A Remote-First World" },
                    { "6216dc15-4e99-4aed-bd09-f86c074806a3", "cad23a9b-e215-45e8-823f-87207f8c2b71", "In the dynamic landscape of today's job market, success isn't just about possessing the right qualifications or technical skills; it's about embodying a unique set of traits that set top performers apart from the rest. Whether you're a seasoned professional or a recent graduate, understanding and cultivating these essential traits can be the key to unlocking your full potential and achieving success in your career. Let's explore some of the fundamental traits that top performers exhibit in today's competitive job market.\r\n1. Adaptability and Resilience:\r\n\r\n\r\n\r\nIn a rapidly evolving work environment, adaptability is paramount. Top performers demonstrate the ability to quickly adjust to changes, whether it's new technology, shifting priorities, or unforeseen challenges. They approach setbacks as opportunities for growth and bounce back from adversity with resilience, maintaining a positive attitude and a forward-thinking mindset.\r\n2. Continuous Learning and Growth:\r\n\r\n\r\n\r\nThe pursuit of knowledge and personal development is a hallmark of top performers. They understand that learning doesn't end with formal education but is an ongoing process. Whether through formal training programs, self-study, or seeking mentorship, they are committed to expanding their skills and expertise to stay ahead of the curve in their respective fields.\r\n3. Strong Communication Skills:\r\n\r\n\r\n\r\nEffective communication is essential for success in any role. Top performers excel not only in articulating their ideas clearly but also in listening actively and empathetically. They can communicate across various mediums and tailor their message to different audiences, fostering collaboration and building strong relationships with colleagues, clients, and stakeholders.\r\n4. Proactive Problem-Solving Abilities:\r\n\r\n\r\n\r\nTop performers possess strong problem-solving skills and a proactive approach to tackling challenges. Rather than waiting for problems to arise, they anticipate potential issues and take preemptive action to address them. They analyze situations critically, think creatively, and implement innovative solutions, demonstrating resourcefulness and initiative in their work.\r\n5. Emotional Intelligence and Empathy:\r\n\r\n\r\n\r\nEmotional intelligence, including self-awareness, self-regulation, social awareness, and relationship management, is a critical trait of top performers. They understand their own emotions and motivations, allowing them to navigate complex interpersonal dynamics effectively. Moreover, they demonstrate empathy and understanding towards others, fostering a positive work environment and building trust and rapport with colleagues.\r\n6. Goal-Oriented and Results-Driven:\r\n\r\n\r\n\r\nTop performers are driven by a strong sense of purpose and are laser-focused on achieving their goals. They set ambitious yet achievable objectives, develop actionable plans to attain them, and consistently track their progress. They are outcome-oriented, measuring success not only by their individual achievements but also by their contributions to the overall success of their team and organization.\r\n7. Adaptability to Remote Work and Digital Skills:\r\n\r\n\r\n\r\nIn the wake of the COVID-19 pandemic, remote work has become increasingly prevalent. Top performers exhibit adaptability to this new work model, leveraging technology to collaborate effectively, stay organized, and maintain productivity. They are proficient in digital tools and platforms relevant to their roles, allowing them to thrive in virtual environments and stay connected with their teams and clients.\r\nConclusion\r\n\r\n\r\n\r\nIn conclusion, success in today's job market requires more than just technical expertise; it demands a diverse range of essential traits that enable individuals to navigate challenges, seize opportunities, and excel in their careers. By cultivating adaptability, continuous learning, strong communication, proactive problem-solving, emotional intelligence, goal orientation, and adaptability to remote work, individuals can position themselves as top performers in their respective fields, unlocking their full potential and achieving lasting success in today's dynamic work landscape.\r\n\r\n\r\n\r\n\r\nDimitar Genov is a seasoned professional with extensive experience in talent development and organizational leadership. He is passionate about empowering individuals to unleash their full potential and thrive in today's competitive job market.\r\n", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(1078), "https://res.cloudinary.com/dftfu5p0r/image/upload/v1711995451/unlockingsuccess_nhuhe2.jpg", "Unlocking Success: The Essential Traits Of Top Performers In Today's Job Market\r\n" },
                    { "d3e5db84-5696-48a3-8b04-b256674be601", "cad23a9b-e215-45e8-823f-87207f8c2b71", "In the ever-evolving landscape of recruitment, the integration of technology has proven to be a game-changer. Gone are the days of sifting through stacks of resumes or conducting endless rounds of interviews. Today, forward-thinking companies are embracing innovative technological solutions to streamline their hiring processes and find t he best talent efficiently.\r\nThe Traditional Hiring Conundrum\r\n\r\n\r\n\r\nTraditional recruitment methods often posed significant challenges for both employers and candidates alike. Employers grappled with time-consuming tasks such as manually reviewing resumes, scheduling interviews, and coordinating feedback among hiring teams. On the other hand, candidates faced lengthy application processes and prolonged wait times for responses, leading to frustration and disengagement.\r\nThe Rise of Technological Solutions\r\n\r\n\r\n\r\nATS platforms have become indispensable tools for modern recruiters. These systems automate the process of collecting, sorting, and managing applicant data, allowing recruiters to streamline their workflow and focus on engaging with top candidates. ATS platforms also offer features such as resume parsing, candidate scoring, and automated communication, enabling recruiters to identify the most qualified candidates efficiently.\r\nApplicant Tracking Systems (ATS)\r\n\r\n\r\n\r\nRecognizing the need for a more efficient approach, recruitment professionals turned to technology to revolutionize the hiring process. From applicant tracking systems (ATS) to artificial intelligence (AI)-powered tools, a myriad of solutions emerged to address the pain points of traditional recruitment methods.\r\nAI-Powered Recruitment Tools\r\n\r\n\r\n\r\nArtificial intelligence has transformed the recruitment landscape by offering advanced capabilities for candidate sourcing, screening, and assessment. AI-powered tools leverage machine learning algorithms to analyze vast amounts of data and identify patterns that match candidates with job requirements. These tools can source candidates from various channels, assess their skills and qualifications, and even predict their likelihood of success in specific roles. By harnessing the power of AI, recruiters can significantly reduce time-to-hire, improve candidate quality, and make more data-driven hiring decisions.\r\nVideo Interviewing Platforms\r\n\r\n\r\n\r\nWith the rise of remote work and distributed teams, video interviewing platforms have gained popularity as an essential tool for modern recruitment. These platforms enable recruiters to conduct virtual interviews with candidates from anywhere in the world, eliminating the need for costly and time-consuming travel. Video interviews also offer additional benefits such as asynchronous interviewing, interview recording, and integration with other recruitment software, making the hiring process more efficient and flexible for both recruiters and candidates.\r\nThe Future of Recruitment\r\n\r\n\r\n\r\nAs technology continues to evolve, the future of recruitment holds immense promise for further innovation. Emerging technologies such as augmented reality (AR), virtual reality (VR), and predictive analytics are poised to reshape the recruitment landscape in unprecedented ways. These technologies offer exciting possibilities for immersive candidate experiences, data-driven decision-making, and predictive talent analytics, paving the way for a more efficient, inclusive, and transparent recruitment process.\r\nConclusion\r\n\r\n\r\n\r\nIn the fast-paced world of recruitment, staying ahead of the curve is essential for attracting top talent and driving organizational success. By embracing technology and leveraging innovative solutions, recruiters can revolutionize the hiring process, streamline workflows, and make more informed decisions. As we continue to harness the power of technology, the future of recruitment is brighter than ever, offering boundless opportunities for companies to build diverse, high-performing teams that drive innovation and growth.\r\n\r\n\r\n\r\n\r\nIvan Petrov is a visionary leader in the field of recruitment, with a passion for leveraging technology to drive innovation and efficiency in the hiring process. With years of experience in talent acquisition and human resources, Ivan has witnessed firsthand the challenges faced by both employers and candidates in traditional recruitment methods. Motivated by a desire to revolutionize the industry, Ivan has dedicated his career to exploring and implementing cutting-edge technological solutions that transform the way companies identify and attract top talent.\r\n", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(1060), "https://res.cloudinary.com/dftfu5p0r/image/upload/v1711995437/property-01_mkg5z5.jpg", "Revolutionizing Recruitment: Leveraging Technology To Streamline The Hiring Process" },
                    { "e9ba7661-d0ad-4b81-8c84-2962d1319622", "cad23a9b-e215-45e8-823f-87207f8c2b71", "In today's competitive job market, finding top talent is more challenging than ever. With companies vying for the same pool of qualified candidates, mastering the art of candidate sourcing has become essential for recruitment success. Effective sourcing strategies not only help in attracting the right candidates but also ensure a streamlined and efficient hiring process. Here are some key strategies to consider when sourcing candidates:\r\n1. Utilize Multiple Sourcing Channels:\r\n\r\n\r\n\r\nGone are the days when job postings on a single platform were sufficient to attract qualified candidates. Today, recruiters must leverage a variety of sourcing channels to reach a diverse pool of talent. This includes job boards, social media platforms, professional networking sites, industry-specific forums, and even employee referrals. By casting a wide net across different channels, recruiters can increase their chances of finding the ideal candidate.\r\n2. Implement Advanced Search Techniques:\r\n\r\n\r\n\r\nWith the abundance of information available online, recruiters can use advanced search techniques to narrow down their candidate search. Boolean search strings, for example, allow recruiters to combine keywords and phrases to find candidates with specific skills and experience. Moreover, utilizing filters and advanced search options on job boards and professional networking sites can further refine the candidate pool based on location, experience level, education, and other criteria.\r\n3. Build and Nurture Talent Pipelines:\r\n\r\n\r\n\r\nBuilding a talent pipeline involves proactively sourcing and engaging with potential candidates, even if there are no immediate job openings. By continuously networking and maintaining relationships with passive candidates, recruiters can create a pool of qualified individuals who can be tapped into when relevant opportunities arise. This not only reduces time-to-hire but also ensures a steady stream of talent for future hiring needs.\r\n4. Develop Employer Branding Initiatives:\r\n\r\n\r\n\r\nA strong employer brand can significantly impact an organization's ability to attract top talent. Therefore, it's essential to invest in employer branding initiatives that showcase the company culture, values, and opportunities for growth. This can include creating engaging content for social media, highlighting employee testimonials and success stories, and actively participating in industry events and networking activities. A positive employer brand not only attracts candidates but also helps in retaining and engaging existing employees.\r\n5. Leverage Technology and Automation:\r\n\r\n\r\n\r\nIn today's digital age, technology plays a crucial role in candidate sourcing and recruitment. Recruiters can leverage Applicant Tracking Systems (ATS), AI-powered sourcing tools, and automation software to streamline the sourcing process, manage candidate pipelines, and analyze data for insights. These technologies not only save time and effort but also enable recruiters to identify and engage with candidates more effectively.\r\n6. Foster Diversity and Inclusion:\r\n\r\n\r\n\r\nDiversity and inclusion should be integral components of any candidate sourcing strategy. Actively seeking out candidates from diverse backgrounds not only enhances creativity and innovation within the organization but also reflects a commitment to creating an inclusive workplace culture. Recruiters should proactively reach out to underrepresented groups, participate in diversity-focused events and initiatives, and ensure that job postings are inclusive and free from bias.\r\n7. Measure and Optimize Performance:\r\n\r\n\r\n\r\nContinuous improvement is key to success in candidate sourcing. Recruiters should regularly monitor and measure the performance of their sourcing efforts, analyzing metrics such as time-to-fill, cost-per-hire, and quality-of-hire. By identifying areas for improvement and optimizing sourcing strategies based on data-driven insights, recruiters can enhance their effectiveness and achieve better recruitment outcomes over time.\r\nConclusion\r\n\r\n\r\n\r\nIn conclusion, mastering the art of candidate sourcing requires a combination of creativity, strategic thinking, and leveraging the right tools and techniques. By adopting a multi-channel approach, utilizing advanced search techniques, building talent pipelines, investing in employer branding, leveraging technology, fostering diversity and inclusion, and continuously measuring and optimizing performance, recruiters can enhance their recruitment success and attract top alent to their organizations.\r\n\r\n\r\n\r\n\r\nGeorgi Ivanov is a seasoned HR professional with over a decade of experience in talent acquisition and recruitment strategy. He is passionate about helping organizations build high-performing teams through effective sourcing and talent management practices.\r\n", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(1073), "https://res.cloudinary.com/dftfu5p0r/image/upload/v1711995437/property-06_fkugqv.png", "Mastering The Art Of Candidate Sourcing: Effective Strategies For Recruitment Success" },
                    { "ef06c27d-3ca3-4d32-a474-d94b943c324f", "cad23a9b-e215-45e8-823f-87207f8c2b71", "In today's rapidly evolving global landscape, fostering diversity and inclusion (D&I) in the workplace is not just a moral imperative; it's also a strategic advantage. Companies that embrace diversity and inclusion tend to be more innovative, productive, and resilient. However, achieving true diversity and inclusion requires a concerted effort, particularly in the hiring process, where biases can often inadvertently creep in. In this article, we'll explore some best practices for navigating diversity and inclusion in hiring to build a truly inclusive workforce.\r\n1. Foster a Culture of Inclusion from the Top Down:\r\n\r\n\r\n\r\nTLeadership plays a crucial role in shaping organizational culture. It's essential for top executives and managers to actively champion diversity and inclusion initiatives and lead by example. When leaders prioritize D&I efforts, it sends a clear message throughout the organization that diversity is valued and integral to the company's success.\r\n2. Implement Unbiased Hiring Practices:\r\n\r\n\r\n\r\nUnconscious biases can influence hiring decisions, leading to homogeneity rather than diversity in the workforce. To combat this, companies should implement strategies to mitigate bias in the hiring process. This may include using structured interviews, blind resume reviews, diverse hiring panels, and standardized evaluation criteria to ensure that candidates are assessed based on their skills, qualifications, and potential rather than extraneous factors.\r\n3. Expand Outreach and Recruitment Efforts:\r\n\r\n\r\n\r\nTo attract diverse talent pools, companies should broaden their outreach and recruitment efforts. This may involve partnering with organizations that specialize in diverse talent pipelines, attending job fairs and networking events targeted at underrepresented groups, and leveraging social media platforms to reach a diverse audience. Additionally, creating inclusive job descriptions and ensuring that job postings are accessible to all can help attract a more diverse applicant pool.\r\n4. Provide Diversity and Inclusion Training:\r\n\r\n\r\n\r\nOffering training on diversity and inclusion to hiring managers and employees can increase awareness of unconscious biases and promote inclusive behaviors. Training sessions can cover topics such as cultural competency, empathy, inclusive language, and strategies for creating equitable opportunities for all candidates. By investing in education and awareness-building, companies can foster a more inclusive hiring environment.\r\n5. Prioritize Diversity in Talent Acquisition:\r\n\r\n\r\n\r\nMake diversity and inclusion integral components of your talent acquisition strategy. Set specific diversity goals and metrics to track progress over time. Establishing accountability mechanisms and regularly reviewing hiring practices and outcomes can help ensure that diversity and inclusion remain top priorities throughout the recruitment process.\r\n6. Create a Supportive Onboarding Experience:\r\n\r\n\r\n\r\nOnce diverse candidates are hired, it's crucial to provide them with a supportive onboarding experience. This includes offering mentorship programs, affinity groups, and cultural integration initiatives to help new hires feel welcomed and valued within the organization. By fostering a sense of belonging from the outset, companies can improve retention rates and cultivate a more diverse and inclusive workplace culture.\r\nConclusion\r\n\r\n\r\n\r\nBuilding a diverse and inclusive workforce requires a multifaceted approach that starts with the hiring process. By fostering a culture of inclusion, implementing unbiased hiring practices, expanding outreach efforts, providing training, prioritizing diversity in talent acquisition, and creating a supportive onboarding experience, companies can attract and retain diverse talent that drives innovation and success. Embracing diversity and inclusion isn't just the right thing to do—it's also a strategic imperative for building stronger, more resilient organizations in today's interconnected world.\r\n\r\n\r\n\r\n\r\nMaria Dimitrova is a dedicated advocate for diversity and inclusion (D&I) in the workplace, with a passion for fostering inclusive environments where every individual feels valued and empowered to thrive. With a background in human resources and talent management, Maria has extensive experience navigating the complexities of diversity and inclusion in hiring processes and organizational culture.\r\n", new DateTime(2024, 4, 17, 18, 8, 5, 842, DateTimeKind.Local).AddTicks(1067), "https://res.cloudinary.com/dftfu5p0r/image/upload/v1711995437/property-03_ednnld.png", "Navigating Diversity And Inclusion In Hiring: Best Practices For Building An Inclusive Workforce" }
                });

            migrationBuilder.InsertData(
                table: "Professions",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { "00b088f2-b24d-4d42-8d80-5d50b4ae02ab", "8910967e-2a14-4a1a-a3f5-d16cc78a4b32", "Security Manager" },
                    { "05a4867c-c86e-43da-9c63-f09753e5d7d8", "ff13d479-760d-4387-8843-c882ad150609", "Loan Officer" },
                    { "0a4b6a5d-4dc2-4376-9b8d-f218e1e6e68b", "16bf1012-a018-453d-97f2-d9682a3588f1", "Tutor" },
                    { "0c6c6421-2a35-4c70-b8a1-14eef62286ee", "a732a432-ef4f-4407-9dba-71f904d0ea6e", "Pharmaceutical Scientist" },
                    { "0cfa84cc-0c1f-4729-a60a-36ab826a1a06", "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c", "Co-pilot/First Officer" },
                    { "0d199b44-7e67-42f8-b9d1-15f6666993d7", "265bc199-91e3-4eba-9886-bce0a19e6ce2", "Customer Service Representative" },
                    { "143f3523-11c2-4a0b-ba63-bc5d6f19255a", "16bf1012-a018-453d-97f2-d9682a3588f1", "Curriculum Developer" },
                    { "15a7dcd2-6c3b-4585-bce2-0270241f7d6e", "07a32cf2-3c7a-4ab0-ab70-9952c0966f30", "Hotel Manager" },
                    { "15f1df94-291d-4f8a-92c0-3f2f4fe0e6c8", "ff13d479-760d-4387-8843-c882ad150609", "Financial Advisor" },
                    { "160c1c89-af8c-49e0-9c85-3968fb465b55", "8910967e-2a14-4a1a-a3f5-d16cc78a4b32", "Security Supervisor" },
                    { "181aa1e7-0053-4b99-80ee-88f173ba2f12", "8910967e-2a14-4a1a-a3f5-d16cc78a4b32", "Private Investigator" },
                    { "1a1e2c1a-91b1-456f-b23a-27d1e12e35ec", "c468efd1-09cf-4e6c-9245-2e837e500968", "Customer Success Manager" },
                    { "1ac27ba5-49d7-4c09-b4ac-10d376a8b198", "0676aec9-89f5-4511-b642-6d0fe86e404a", "Real Estate Broker" },
                    { "1d38807e-52d1-4f21-8a92-4aeecda64838", "16bf1012-a018-453d-97f2-d9682a3588f1", "Educational Consultant" },
                    { "1d865eb6-af2e-4485-8d1a-6c684e02dc1b", "71eb6b38-7552-425e-bf09-ee22d23855bb", "Executive Assistant" },
                    { "20c1e62b-46cd-47b6-880f-fdd12aa89a1d", "3ea25504-1598-4608-a362-84d82b1b2fce", "RF Engineer (Radio Frequency)" },
                    { "27f6e1e3-c567-48af-92c4-d9f7ccdf90b2", "265bc199-91e3-4eba-9886-bce0a19e6ce2", "Cashier" },
                    { "289cb58e-b29d-4c64-8201-dfde7ff59c1a", "6859c0a0-98d0-49c5-b017-17d2a64d3342", "Research Associate" },
                    { "28c92c7c-f39f-47a3-b79d-b6e0a9f08e88", "07a32cf2-3c7a-4ab0-ab70-9952c0966f30", "Bartender" },
                    { "28d90df0-7592-4d33-915d-dba1b3cd95e5", "fd71ecf5-cb6d-4e3c-ad4e-84358bdfa328", "Help Desk Technician" },
                    { "2d6a8b5e-b6d8-4f68-b7c2-5ed7d1065a54", "265bc199-91e3-4eba-9886-bce0a19e6ce2", "Retail Merchandiser" },
                    { "2dbdb1b6-7e1c-46b4-a51a-d5d27a1e56ff", "fd71ecf5-cb6d-4e3c-ad4e-84358bdfa328", "Desktop Support Technician" },
                    { "3a8e6162-67b3-45bc-aade-f57cb0147581", "71eb6b38-7552-425e-bf09-ee22d23855bb", "Office Administrator" },
                    { "3ad80bfa-1de4-4a3e-9d80-78b1e4f38138", "fd71ecf5-cb6d-4e3c-ad4e-84358bdfa328", "Technical Support Specialist" },
                    { "3b64b94a-0518-4796-9c4b-71aaf89e0f46", "dc8214a6-79cf-436c-bae1-7387b82a3bce", "Auditor" },
                    { "3debb73d-325f-47cc-8499-b2c9f8ed2045", "ff13d479-760d-4387-8843-c882ad150609", "Credit Analyst" },
                    { "3df00e70-7a0e-4a1a-bded-9b83799c8181", "3ea25504-1598-4608-a362-84d82b1b2fce", "Telecom Systems Engineer" },
                    { "3f0f3cd7-d7f7-49e6-95ee-43a536e49e8d", "221e3547-3c78-41f9-9634-d7571a615fb8", "Automotive Electrician" },
                    { "4c87148f-52c8-45d6-801e-6663bc2b9615", "b89927d7-b1fd-4703-98df-a4681ce2db88", "Van Driver" },
                    { "4df73c30-0951-4a41-8db1-19742ed4206a", "221e3547-3c78-41f9-9634-d7571a615fb8", "Automotive Technician/Mechanic" },
                    { "53242ed3-c78e-4fa9-ae5c-d880c8e506b2", "a732a432-ef4f-4407-9dba-71f904d0ea6e", "Nurse" },
                    { "548d12ac-837a-4c13-b7fc-b77c15d36ff9", "221e3547-3c78-41f9-9634-d7571a615fb8", "Auto Body Repair Technician" },
                    { "59dc7d4a-52d0-4ebd-80fc-59dbb5f05b4f", "a732a432-ef4f-4407-9dba-71f904d0ea6e", "Pharmacy Technician" },
                    { "5a83ff30-17c1-4484-bb0e-3b8470cc1870", "c4dd9eea-1569-402f-a5b8-8473f48437a1", "Transportation Planner" },
                    { "5b3fd229-c3b3-4cc7-84cf-7d4807927c88", "c4dd9eea-1569-402f-a5b8-8473f48437a1", "Logistics Coordinator" },
                    { "5b4417b5-29a4-41e2-813a-8953730341f5", "ec4b3c64-1f2f-455d-a6e4-75b525625371", "Paralegal" },
                    { "5c2e8e13-03a9-4f71-bfc2-f713620ef86d", "c468efd1-09cf-4e6c-9245-2e837e500968", "Technical Support Specialist" },
                    { "5e8f79b5-c176-4a85-86a5-3998adcc6822", "07a32cf2-3c7a-4ab0-ab70-9952c0966f30", "Restaurant Manager" },
                    { "5fc255cf-3993-46a8-a307-1c1ef4248e08", "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb", "Social Media Manager" },
                    { "64a522d8-6f5a-4d50-8e43-d7d5ad135b65", "38b5eb73-7829-497b-a207-9bcf3fef3b1b", "Mechanical Engineer" },
                    { "6518d38b-34d8-418d-bb9a-786f560e2314", "16bf1012-a018-453d-97f2-d9682a3588f1", "Teacher" },
                    { "6b9519a7-d540-4d54-9ef3-271c5c2e7f1d", "ec4b3c64-1f2f-455d-a6e4-75b525625371", "Legal Secretary" },
                    { "6d42145c-0cd9-4ee5-a4f1-c39dc6e464a1", "265bc199-91e3-4eba-9886-bce0a19e6ce2", "Store Manager" },
                    { "6ecaa7c5-c11f-44aa-bad8-842af947e55f", "fd71ecf5-cb6d-4e3c-ad4e-84358bdfa328", "Customer Support Engineer" },
                    { "73de6a98-fc71-4144-8154-20778c34e93b", "b89927d7-b1fd-4703-98df-a4681ce2db88", "Bus Driver" },
                    { "746fa7c6-bb09-4e8d-89a5-4a9403e6fd91", "c4dd9eea-1569-402f-a5b8-8473f48437a1", "Warehouse Manager" },
                    { "768442d1-47f4-44e3-8863-c2d45060f1e7", "3c1fda93-5ef8-4db2-97f7-25f163fbca67", "Journalist" },
                    { "77f2a9d9-3c90-4439-bf2a-38f326a731c4", "a732a432-ef4f-4407-9dba-71f904d0ea6e", "Pharmacist" },
                    { "7a0c7a11-57db-4be8-8b7e-9c28c4c33085", "3ea25504-1598-4608-a362-84d82b1b2fce", "Network Engineer" },
                    { "7ad9df7e-29f8-4b95-aa6e-f78d5c32d8c2", "fd71ecf5-cb6d-4e3c-ad4e-84358bdfa328", "IT Support Engineer" },
                    { "7db1c426-0e26-43f6-95b2-3a4c9a0e60fb", "f239ac3f-856e-494c-95df-2521a3269a6b", "Energy Analyst" },
                    { "81c74767-f1b5-4599-84f0-7ae382448d8d", "3c1fda93-5ef8-4db2-97f7-25f163fbca67", "Writer" },
                    { "85e233cf-85a2-4d5c-b0b3-9ef7a7a3523d", "38b5eb73-7829-497b-a207-9bcf3fef3b1b", "Civil Engineer" },
                    { "88e2c320-3b99-4cfc-8b4e-8a0b0f6899ef", "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c", "Aircraft Dispatcher" },
                    { "8a1b9ba4-d9e1-4d80-8617-13e607f1722c", "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb", "Advertising Executive" },
                    { "8c23f6cf-916d-41c7-8f35-5d3e5c4e8d6d", "221e3547-3c78-41f9-9634-d7571a615fb8", "Transmission Technician" },
                    { "8e238be6-32ac-48e5-89d0-d43f7c7b1be5", "c468efd1-09cf-4e6c-9245-2e837e500968", "Customer Service Representative" },
                    { "8e8a09b2-3033-4866-8f9f-f896bfc5eb6a", "dc8214a6-79cf-436c-bae1-7387b82a3bce", "Financial Analyst" },
                    { "8ef0979d-2b57-49c2-aa41-7582fd88161c", "80bb3283-c810-4b9c-9d42-da03e17b2ddf", "Urban Planner" },
                    { "8f527e14-11a0-468e-bb29-918a5a90cb3e", "f239ac3f-856e-494c-95df-2521a3269a6b", "Power Plant Operator" },
                    { "92b5b7f7-2d8e-4f9b-8049-14fb6dab160f", "f239ac3f-856e-494c-95df-2521a3269a6b", "Utility Technician" },
                    { "92f7c3e1-2d18-47a6-ae12-7cc146c0d4fd", "221e3547-3c78-41f9-9634-d7571a615fb8", "Automotive Service Advisor" },
                    { "93a1ec1e-af3e-4bc4-8048-62e69f6acdf2", "265bc199-91e3-4eba-9886-bce0a19e6ce2", "Assistant Store Manager" },
                    { "98ee0c64-b2cd-4c31-8561-d86c96c405c4", "3ea25504-1598-4608-a362-84d82b1b2fce", "Telecommunications Engineer" },
                    { "9b7e1554-b94e-4c2a-91cf-af2465d93c09", "07a32cf2-3c7a-4ab0-ab70-9952c0966f30", "Concierge" },
                    { "9e8b4cb4-c9fb-4c54-8935-22eac0d69b6e", "38b5eb73-7829-497b-a207-9bcf3fef3b1b", "Chemical Engineer" },
                    { "a1e8fe6a-9027-4f9d-8532-0f44c569c810", "c468efd1-09cf-4e6c-9245-2e837e500968", "Client Support Specialist" },
                    { "a2a21176-84b5-4537-85d2-c0c30058b7e2", "ec4b3c64-1f2f-455d-a6e4-75b525625371", "Legal Assistant" },
                    { "a3f9fd8e-021c-4d7a-b2b7-b808b163bc83", "71eb6b38-7552-425e-bf09-ee22d23855bb", "Receptionist" },
                    { "a61fcb21-3ed7-4392-a0aa-6741862c65d3", "a732a432-ef4f-4407-9dba-71f904d0ea6e", "Clinical Research Associate" },
                    { "a7597cd2-3dcf-4d56-b36a-00e8a20cf8ef", "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c", "Air Traffic Controller" },
                    { "a7b254d2-6a12-40ad-9885-b86814a5a4b2", "ff13d479-760d-4387-8843-c882ad150609", "Mortgage Broker" },
                    { "a8b7a34b-f7d7-4c4a-9297-49e93b09ecb6", "438c1389-c017-43b8-a34a-46b8c64f5e1d", "Talent Acquisition Specialist/Recruiter" },
                    { "a9815f4f-d85d-48e0-896b-258d89f82884", "16bf1012-a018-453d-97f2-d9682a3588f1", "Instructor" },
                    { "a9dd6d86-2270-4b05-975d-816a14cfbe63", "8910967e-2a14-4a1a-a3f5-d16cc78a4b32", "Bodyguard" },
                    { "ac60f725-8a5a-4453-b76b-50c0b1f204a1", "ec4b3c64-1f2f-455d-a6e4-75b525625371", "Lawyer/Attorney" },
                    { "ac8937b8-cd1b-4846-80cc-4c8e79dc9786", "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb", "Public Relations Specialist" },
                    { "ae791c2d-0d5f-44d8-86b1-6d7ad46e4de9", "ff13d479-760d-4387-8843-c882ad150609", "Bank Teller" },
                    { "af0a0565-51c2-4969-9757-937d0cc8f35e", "a732a432-ef4f-4407-9dba-71f904d0ea6e", "Doctor" },
                    { "b1b5008b-50b0-48c3-9f0c-44e7eb31567f", "0676aec9-89f5-4511-b642-6d0fe86e404a", "Real Estate Agent" },
                    { "b1b6a016-5e24-4515-b4d8-1e7b97836b28", "dc8214a6-79cf-436c-bae1-7387b82a3bce", "Bookkeeper" },
                    { "b2db03c1-3c7c-44bb-bf82-8e35c212a7e1", "38b5eb73-7829-497b-a207-9bcf3fef3b1b", "Electrical Engineer" },
                    { "b2f68861-f6c8-4484-bf80-99fc9349d53a", "6859c0a0-98d0-49c5-b017-17d2a64d3342", "Product Development Manager" },
                    { "b3cf2977-d04d-44d3-b1d6-ecf6240db0d6", "c4dd9eea-1569-402f-a5b8-8473f48437a1", "Distribution Manager" },
                    { "b4749a27-2c91-4d42-b271-8f272e78dd82", "0676aec9-89f5-4511-b642-6d0fe86e404a", "Leasing Consultant" },
                    { "b4858ff4-2dd3-4bc8-9aae-49c6a8c8fd06", "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c", "Flight Attendant" },
                    { "b4b07136-27d4-4a1f-b9fc-97e03c1b448f", "8910967e-2a14-4a1a-a3f5-d16cc78a4b32", "Security Guard" },
                    { "b66e4d92-5c30-48b0-92ac-f4b0fe2879e2", "b89927d7-b1fd-4703-98df-a4681ce2db88", "Courier" },
                    { "b6d002cb-d10f-40e7-9867-7e60f972a8a2", "6859c0a0-98d0-49c5-b017-17d2a64d3342", "Data Scientist" },
                    { "b6e83eb5-8d9a-40d5-9891-4c19117a09ed", "6859c0a0-98d0-49c5-b017-17d2a64d3342", "R&D Engineer" },
                    { "b7cc4e9b-0624-4e8d-ba19-9266d90e20cb", "71eb6b38-7552-425e-bf09-ee22d23855bb", "Office Manager" },
                    { "b8ef7c1c-7408-4956-83f0-1cb9b3284416", "3c1fda93-5ef8-4db2-97f7-25f163fbca67", "Editor" },
                    { "ba2d8ad0-130d-4cf5-b508-1e5f61ef056a", "8910967e-2a14-4a1a-a3f5-d16cc78a4b32", "Security Officer" },
                    { "baf35a3f-daf9-4b1f-a746-d75da4fcad9b", "438c1389-c017-43b8-a34a-46b8c64f5e1d", "Training and Development Specialist" },
                    { "bd3a10e8-8835-4dd9-9168-9f935c9a1b85", "80bb3283-c810-4b9c-9d42-da03e17b2ddf", "Landscape Architect" },
                    { "be73dbb1-f6b5-4be1-881d-289a0435a176", "f239ac3f-856e-494c-95df-2521a3269a6b", "Electrical Engineer" },
                    { "be76b792-9e0e-4c42-a7fd-514b2ec04f20", "ec4b3c64-1f2f-455d-a6e4-75b525625371", "Judge" },
                    { "c1f48fb3-6e0d-45ef-a95c-268f441b8403", "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb", "Marketing Manager" },
                    { "c22b89de-97c8-4dc8-a2a7-2ad7eb61ec5e", "c4dd9eea-1569-402f-a5b8-8473f48437a1", "Supply Chain Manager" },
                    { "c47607b0-606e-48ee-b3cf-5df0f6a69e9e", "38b5eb73-7829-497b-a207-9bcf3fef3b1b", "Software Engineer" },
                    { "c4a3549f-2dd3-48e3-bd41-43d101baa24e", "b89927d7-b1fd-4703-98df-a4681ce2db88", "Taxi Driver" },
                    { "c6b32d99-681b-47f6-93c6-7c318fe8b3c8", "438c1389-c017-43b8-a34a-46b8c64f5e1d", "HR Coordinator" },
                    { "c7514c88-0a16-4d54-b2c0-cb79916a494b", "265bc199-91e3-4eba-9886-bce0a19e6ce2", "Retail Sales Associate" },
                    { "ccd5fc90-b3f1-45fc-89bc-28c5f0cb1d42", "dc8214a6-79cf-436c-bae1-7387b82a3bce", "Certified Public Accountant (CPA)" },
                    { "ce81a194-2ec1-4b5c-a7aa-524cc11b06a6", "6859c0a0-98d0-49c5-b017-17d2a64d3342", "Research Scientist" },
                    { "cf8e2882-5683-4eb3-9687-43897f28a27e", "ff13d479-760d-4387-8843-c882ad150609", "Branch Manager" },
                    { "d0494fe0-06f8-4f01-81fd-937df723d203", "b89927d7-b1fd-4703-98df-a4681ce2db88", "Truck Driver" },
                    { "d1e2ab06-08a0-439a-a05a-b7dd93cb1876", "c4dd9eea-1569-402f-a5b8-8473f48437a1", "Freight Forwarder" },
                    { "d2f9bca5-e3d8-41a4-8179-58d960850c21", "80bb3283-c810-4b9c-9d42-da03e17b2ddf", "Interior Designer" },
                    { "d38e1340-4e35-47f4-a4e2-d2d8d07a9b4e", "3c1fda93-5ef8-4db2-97f7-25f163fbca67", "Publisher" },
                    { "d571f77c-8c1f-48df-8a8f-cce98a3180b2", "0676aec9-89f5-4511-b642-6d0fe86e404a", "Realtor" },
                    { "d65e1d14-d0cf-4815-83e7-73f22dd6d21e", "f239ac3f-856e-494c-95df-2521a3269a6b", "Mechanical Engineer" },
                    { "d6b43e8f-9068-41c1-818a-0d9e3541fe86", "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb", "Brand Manager" },
                    { "d77c3684-9ab9-4b51-85a4-45790c16d1ae", "438c1389-c017-43b8-a34a-46b8c64f5e1d", "HR Manager" },
                    { "d7e1f951-b436-4e07-98d7-71571c55e90a", "dc8214a6-79cf-436c-bae1-7387b82a3bce", "Accountant" },
                    { "d9160ad9-dc8e-4097-9b5e-5a39985f7d69", "0676aec9-89f5-4511-b642-6d0fe86e404a", "Real Estate Appraiser" },
                    { "da7d57e3-334d-4e2a-8496-3e2c0e740a48", "dc8214a6-79cf-436c-bae1-7387b82a3bce", "Tax Accountant" },
                    { "db083e3f-67a2-4c92-92d6-8b6e1dfdc48e", "07a32cf2-3c7a-4ab0-ab70-9952c0966f30", "Waiter/Waitress" },
                    { "dc31dd20-d5f7-4f26-b611-8b0427b2ee32", "3c1fda93-5ef8-4db2-97f7-25f163fbca67", "Reporter" },
                    { "dc5f6828-d7d7-458a-9d18-d25fb61d02af", "71eb6b38-7552-425e-bf09-ee22d23855bb", "Administrative Assistant" },
                    { "de08f21c-1d36-42f7-9ec8-f37907988e91", "ec4b3c64-1f2f-455d-a6e4-75b525625371", "Legal Consultant" },
                    { "e0b6c971-9122-4042-8d43-2a0ee17b2dd7", "3c1fda93-5ef8-4db2-97f7-25f163fbca67", "Copy Editor" },
                    { "e5b34805-13f5-42ad-ba77-85ed67cbf5a5", "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c", "Pilot" },
                    { "e607518e-f7dc-4e35-9f4d-0a16dd69d3db", "c468efd1-09cf-4e6c-9245-2e837e500968", "Technical Support Specialist" },
                    { "e61546d8-5258-479f-8d6c-ecf52bbf40e8", "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb", "Digital Marketing Specialist" },
                    { "e6a1ecf2-5d8d-4b39-8305-f5b75dd13a01", "f239ac3f-856e-494c-95df-2521a3269a6b", "Renewable Energy Specialist" },
                    { "e876ba3a-16aa-4d27-bd80-fa9ed78e84db", "0676aec9-89f5-4511-b642-6d0fe86e404a", "Property Manager" },
                    { "ee53b8de-2ac9-4d7c-a5bc-7d1f6d9a90c0", "71eb6b38-7552-425e-bf09-ee22d23855bb", "Data Entry Clerk" },
                    { "ee54b64a-76bc-47ff-81a3-02a4ac6c0d35", "438c1389-c017-43b8-a34a-46b8c64f5e1d", "Compensation and Benefits Manager" },
                    { "f04259e9-3cf1-4c45-897d-f6c1e6c3df61", "80bb3283-c810-4b9c-9d42-da03e17b2ddf", "Architect" },
                    { "f293b5f6-f7d0-4dc5-b072-0d5268a2530c", "3ea25504-1598-4608-a362-84d82b1b2fce", "Optical Network Engineer" },
                    { "f30e12fb-05cc-4153-8a4a-2d31f3d9b2c8", "38b5eb73-7829-497b-a207-9bcf3fef3b1b", "Computer Engineer" },
                    { "f446f50a-7021-4d5a-9fc7-d59dcfe54f6e", "b89927d7-b1fd-4703-98df-a4681ce2db88", "Delivery Driver" },
                    { "f4d21aa6-868e-4744-8275-b15b84f36e3e", "3ea25504-1598-4608-a362-84d82b1b2fce", "VoIP Engineer (Voice over Internet Protocol)" },
                    { "f5bda051-7b47-418e-a4a7-68cfae8b5eef", "c468efd1-09cf-4e6c-9245-2e837e500968", "Help Desk Analyst" },
                    { "f60cf3fb-5dd8-4b09-b46f-1e357e468fcc", "16bf1012-a018-453d-97f2-d9682a3588f1", "Professor" },
                    { "f65d013a-854a-4a13-8d15-fce80b63e156", "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c", "Aircraft Maintenance Technician" },
                    { "f70d41ab-46c7-4d97-b6c2-7fd61b0549b2", "221e3547-3c78-41f9-9634-d7571a615fb8", "Brake Technician" },
                    { "f7ed1254-7005-4568-bf02-02e1e37aa2bb", "fd71ecf5-cb6d-4e3c-ad4e-84358bdfa328", "Network Support Technician" },
                    { "f8a0cb10-8c65-4640-9954-80f0c9eeed0b", "6859c0a0-98d0-49c5-b017-17d2a64d3342", "Laboratory Technician" },
                    { "fda9d7e2-471f-4b5a-8ad7-0e849cbb7f6c", "07a32cf2-3c7a-4ab0-ab70-9952c0966f30", "Chef" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_AuthorId",
                table: "Articles",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CategoryId",
                table: "AspNetUsers",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ChatId",
                table: "AspNetUsers",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_JobAdId",
                table: "AspNetUsers",
                column: "JobAdId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ProfessionId",
                table: "AspNetUsers",
                column: "ProfessionId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticleId",
                table: "Comments",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AuthorId",
                table: "Comments",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyLocation_LocationsId",
                table: "CompanyLocation",
                column: "LocationsId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_UserId",
                table: "Files",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_JobAds_CategoryId",
                table: "JobAds",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_JobAds_CompanyId",
                table: "JobAds",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobAds_LocationId",
                table: "JobAds",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_JobAds_ProfessionId",
                table: "JobAds",
                column: "ProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ChatId",
                table: "Messages",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReceiverId",
                table: "Messages",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                table: "Messages",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Professions_CategoryId",
                table: "Professions",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_AspNetUsers_AuthorId",
                table: "Articles",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_JobAds_JobAdId",
                table: "AspNetUsers",
                column: "JobAdId",
                principalTable: "JobAds",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobAds_AspNetUsers_CompanyId",
                table: "JobAds");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "CompanyLocation");

            migrationBuilder.DropTable(
                name: "ContactFormSubmissions");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "JobAds");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Professions");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
