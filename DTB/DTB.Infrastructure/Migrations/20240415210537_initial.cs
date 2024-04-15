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
                    { "0d8c7ffe-ce9a-44c6-95bb-afcbed821363", null, "Administrator", "ADMINISTRATOR" },
                    { "593db2b7-d37f-4664-8a34-a0eeb8fc543d", null, "Company", "COMPANY" },
                    { "622f1450-f901-4095-9dc3-f3fd7e43da3c", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ChatId", "ConcurrencyStamp", "DateOfBirth", "Description", "Discriminator", "Email", "EmailConfirmed", "FirstName", "JobAdId", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfessionId", "ProfilePicture", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cad23a9b-e215-45e8-823f-87207f8c2b71", 0, null, "2bd95cb4-4acf-42a0-b46e-d3c2f5cca845", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "User", "test@abv.bg", false, "Test", null, "Testov", false, null, "Testov", null, "test@abv.bg", "6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b", null, false, null, null, "709d1d95-e7c3-4827-92f0-ea5f94ba7903", 0, false, "test" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DateOfCreation", "Name", "PictureUrl" },
                values: new object[,]
                {
                    { "0676aec9-89f5-4511-b642-6d0fe86e404a", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(3441), "Real-estate", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_realestate_dkhhfe.png" },
                    { "07a32cf2-3c7a-4ab0-ab70-9952c0966f30", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(3391), "Restaurants, Bars, Hotels, Tourism", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824823/icon_restaurant_ee4ubg.png" },
                    { "16bf1012-a018-453d-97f2-d9682a3588f1", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(3435), "Education, Courses, Translators", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_education_kdsm7z.png" },
                    { "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(3448), "Aviation, Airport & Airline", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_airline_bgvmiu.png" },
                    { "221e3547-3c78-41f9-9634-d7571a615fb8", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(3451), "Auto Service", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824819/icon_autoservice_iabxkj.png" },
                    { "265bc199-91e3-4eba-9886-bce0a19e6ce2", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(3454), "Retail, Wholesale", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824824/icon_retail_pgicm9.png" },
                    { "38b5eb73-7829-497b-a207-9bcf3fef3b1b", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(3394), "Engineers and Technicians", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_engineer_wzjia1.png" },
                    { "3c1fda93-5ef8-4db2-97f7-25f163fbca67", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(3408), "Media, Publishing", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_media_mpzkez.png" },
                    { "3ea25504-1598-4608-a362-84d82b1b2fce", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(3432), "Telecommunications - engineers and technicians", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_telecoms_sbsq5u.png" },
                    { "438c1389-c017-43b8-a34a-46b8c64f5e1d", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(3405), "Human Resources", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_hr_jbc5jn.png" },
                    { "6859c0a0-98d0-49c5-b017-17d2a64d3342", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(3460), "Research and development", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824822/icon_research_mdrafi.png" },
                    { "71eb6b38-7552-425e-bf09-ee22d23855bb", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(3427), "Office and Business activities", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_office_xkdjih.png" },
                    { "80bb3283-c810-4b9c-9d42-da03e17b2ddf", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(3312), "Architecture, Construction", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_architecture_gqdlbl.png" },
                    { "8910967e-2a14-4a1a-a3f5-d16cc78a4b32", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(3438), "Security", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_security_c4fjq0.png" },
                    { "a732a432-ef4f-4407-9dba-71f904d0ea6e", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(3382), "Health and Pharmacy", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_health_nhktmm.png" },
                    { "b89927d7-b1fd-4703-98df-a4681ce2db88", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(3387), "Drivers, Couriers", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_derivers_q8g7p3.png" },
                    { "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(3424), "Marketing, Advertising, PR", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_hr_jbc5jn.png" },
                    { "c468efd1-09cf-4e6c-9245-2e837e500968", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(3415), "Customer support", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_customersupport_fbvie5.png" },
                    { "c4dd9eea-1569-402f-a5b8-8473f48437a1", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(3411), "Logistics, Spedition", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_logistic_ktvoqa.png" },
                    { "dc8214a6-79cf-436c-bae1-7387b82a3bce", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(3462), "Accouting, Audit, Finance", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_finance_r5bftt.png" },
                    { "ec4b3c64-1f2f-455d-a6e4-75b525625371", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(3445), "Legal", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_legal_ofzofx.png" },
                    { "f239ac3f-856e-494c-95df-2521a3269a6b", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(3429), "Energy, Water and Sewage, Utilities", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_energy_kznsrc.png" },
                    { "fd71ecf5-cb6d-4e3c-ad4e-84358bdfa328", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(3457), "Technical Support", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_techsupport_zph0mx.png" },
                    { "ff13d479-760d-4387-8843-c882ad150609", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(3420), "Banking, Lending, Insurance", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_banking_dkgjma.png" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "012bd457-ba34-4515-b938-0bfd8169054f", "Burgas" },
                    { "0ed63908-13f4-48e3-8f0f-852e4fd9959b", "Plovdiv" },
                    { "30662405-2acc-4f02-aef5-0999696ce061", "Varna" },
                    { "57538c25-de61-42b1-83a7-a5b88d762433", "Elhovo" },
                    { "7048b303-6fcc-4fb7-b4d9-8114383246a9", "Ruse" },
                    { "8da1107c-3695-49b6-bbd4-d394ed154b57", "Yambol" },
                    { "a39e2b5a-260a-4432-b84f-e9831bec567b", "Blagoevgrad" },
                    { "beacc94c-4d40-4147-a2d6-6b6800efa8f6", "Dimitrovgrad" },
                    { "cad1dfd9-c7da-47bd-905a-8a03646e8809", "Sofia" },
                    { "ee9682df-bc29-428f-98f4-6388b8a5ffb1", "Sliven" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "AuthorId", "Content", "DateOfCreation", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { "06409423-8302-44df-88e9-ce22e529e72e", "cad23a9b-e215-45e8-823f-87207f8c2b71", "In today's competitive job market, finding top talent is more challenging than ever. With companies vying for the same pool of qualified candidates, mastering the art of candidate sourcing has become essential for recruitment success. Effective sourcing strategies not only help in attracting the right candidates but also ensure a streamlined and efficient hiring process. Here are some key strategies to consider when sourcing candidates:\r\n1. Utilize Multiple Sourcing Channels:\r\n\r\n\r\n\r\nGone are the days when job postings on a single platform were sufficient to attract qualified candidates. Today, recruiters must leverage a variety of sourcing channels to reach a diverse pool of talent. This includes job boards, social media platforms, professional networking sites, industry-specific forums, and even employee referrals. By casting a wide net across different channels, recruiters can increase their chances of finding the ideal candidate.\r\n2. Implement Advanced Search Techniques:\r\n\r\n\r\n\r\nWith the abundance of information available online, recruiters can use advanced search techniques to narrow down their candidate search. Boolean search strings, for example, allow recruiters to combine keywords and phrases to find candidates with specific skills and experience. Moreover, utilizing filters and advanced search options on job boards and professional networking sites can further refine the candidate pool based on location, experience level, education, and other criteria.\r\n3. Build and Nurture Talent Pipelines:\r\n\r\n\r\n\r\nBuilding a talent pipeline involves proactively sourcing and engaging with potential candidates, even if there are no immediate job openings. By continuously networking and maintaining relationships with passive candidates, recruiters can create a pool of qualified individuals who can be tapped into when relevant opportunities arise. This not only reduces time-to-hire but also ensures a steady stream of talent for future hiring needs.\r\n4. Develop Employer Branding Initiatives:\r\n\r\n\r\n\r\nA strong employer brand can significantly impact an organization's ability to attract top talent. Therefore, it's essential to invest in employer branding initiatives that showcase the company culture, values, and opportunities for growth. This can include creating engaging content for social media, highlighting employee testimonials and success stories, and actively participating in industry events and networking activities. A positive employer brand not only attracts candidates but also helps in retaining and engaging existing employees.\r\n5. Leverage Technology and Automation:\r\n\r\n\r\n\r\nIn today's digital age, technology plays a crucial role in candidate sourcing and recruitment. Recruiters can leverage Applicant Tracking Systems (ATS), AI-powered sourcing tools, and automation software to streamline the sourcing process, manage candidate pipelines, and analyze data for insights. These technologies not only save time and effort but also enable recruiters to identify and engage with candidates more effectively.\r\n6. Foster Diversity and Inclusion:\r\n\r\n\r\n\r\nDiversity and inclusion should be integral components of any candidate sourcing strategy. Actively seeking out candidates from diverse backgrounds not only enhances creativity and innovation within the organization but also reflects a commitment to creating an inclusive workplace culture. Recruiters should proactively reach out to underrepresented groups, participate in diversity-focused events and initiatives, and ensure that job postings are inclusive and free from bias.\r\n7. Measure and Optimize Performance:\r\n\r\n\r\n\r\nContinuous improvement is key to success in candidate sourcing. Recruiters should regularly monitor and measure the performance of their sourcing efforts, analyzing metrics such as time-to-fill, cost-per-hire, and quality-of-hire. By identifying areas for improvement and optimizing sourcing strategies based on data-driven insights, recruiters can enhance their effectiveness and achieve better recruitment outcomes over time.\r\nConclusion\r\n\r\n\r\n\r\nIn conclusion, mastering the art of candidate sourcing requires a combination of creativity, strategic thinking, and leveraging the right tools and techniques. By adopting a multi-channel approach, utilizing advanced search techniques, building talent pipelines, investing in employer branding, leveraging technology, fostering diversity and inclusion, and continuously measuring and optimizing performance, recruiters can enhance their recruitment success and attract top alent to their organizations.\r\n\r\n\r\n\r\n\r\nGeorgi Ivanov is a seasoned HR professional with over a decade of experience in talent acquisition and recruitment strategy. He is passionate about helping organizations build high-performing teams through effective sourcing and talent management practices.\r\n", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(4251), "https://res.cloudinary.com/dftfu5p0r/image/upload/v1711995437/property-06_fkugqv.png", "Mastering The Art Of Candidate Sourcing: Effective Strategies For Recruitment Success" },
                    { "2349b11a-589f-4b7a-b84c-e50d194c2ff1", "cad23a9b-e215-45e8-823f-87207f8c2b71", "In today's rapidly evolving global landscape, fostering diversity and inclusion (D&I) in the workplace is not just a moral imperative; it's also a strategic advantage. Companies that embrace diversity and inclusion tend to be more innovative, productive, and resilient. However, achieving true diversity and inclusion requires a concerted effort, particularly in the hiring process, where biases can often inadvertently creep in. In this article, we'll explore some best practices for navigating diversity and inclusion in hiring to build a truly inclusive workforce.\r\n1. Foster a Culture of Inclusion from the Top Down:\r\n\r\n\r\n\r\nTLeadership plays a crucial role in shaping organizational culture. It's essential for top executives and managers to actively champion diversity and inclusion initiatives and lead by example. When leaders prioritize D&I efforts, it sends a clear message throughout the organization that diversity is valued and integral to the company's success.\r\n2. Implement Unbiased Hiring Practices:\r\n\r\n\r\n\r\nUnconscious biases can influence hiring decisions, leading to homogeneity rather than diversity in the workforce. To combat this, companies should implement strategies to mitigate bias in the hiring process. This may include using structured interviews, blind resume reviews, diverse hiring panels, and standardized evaluation criteria to ensure that candidates are assessed based on their skills, qualifications, and potential rather than extraneous factors.\r\n3. Expand Outreach and Recruitment Efforts:\r\n\r\n\r\n\r\nTo attract diverse talent pools, companies should broaden their outreach and recruitment efforts. This may involve partnering with organizations that specialize in diverse talent pipelines, attending job fairs and networking events targeted at underrepresented groups, and leveraging social media platforms to reach a diverse audience. Additionally, creating inclusive job descriptions and ensuring that job postings are accessible to all can help attract a more diverse applicant pool.\r\n4. Provide Diversity and Inclusion Training:\r\n\r\n\r\n\r\nOffering training on diversity and inclusion to hiring managers and employees can increase awareness of unconscious biases and promote inclusive behaviors. Training sessions can cover topics such as cultural competency, empathy, inclusive language, and strategies for creating equitable opportunities for all candidates. By investing in education and awareness-building, companies can foster a more inclusive hiring environment.\r\n5. Prioritize Diversity in Talent Acquisition:\r\n\r\n\r\n\r\nMake diversity and inclusion integral components of your talent acquisition strategy. Set specific diversity goals and metrics to track progress over time. Establishing accountability mechanisms and regularly reviewing hiring practices and outcomes can help ensure that diversity and inclusion remain top priorities throughout the recruitment process.\r\n6. Create a Supportive Onboarding Experience:\r\n\r\n\r\n\r\nOnce diverse candidates are hired, it's crucial to provide them with a supportive onboarding experience. This includes offering mentorship programs, affinity groups, and cultural integration initiatives to help new hires feel welcomed and valued within the organization. By fostering a sense of belonging from the outset, companies can improve retention rates and cultivate a more diverse and inclusive workplace culture.\r\nConclusion\r\n\r\n\r\n\r\nBuilding a diverse and inclusive workforce requires a multifaceted approach that starts with the hiring process. By fostering a culture of inclusion, implementing unbiased hiring practices, expanding outreach efforts, providing training, prioritizing diversity in talent acquisition, and creating a supportive onboarding experience, companies can attract and retain diverse talent that drives innovation and success. Embracing diversity and inclusion isn't just the right thing to do—it's also a strategic imperative for building stronger, more resilient organizations in today's interconnected world.\r\n\r\n\r\n\r\n\r\nMaria Dimitrova is a dedicated advocate for diversity and inclusion (D&I) in the workplace, with a passion for fostering inclusive environments where every individual feels valued and empowered to thrive. With a background in human resources and talent management, Maria has extensive experience navigating the complexities of diversity and inclusion in hiring processes and organizational culture.\r\n", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(4241), "https://res.cloudinary.com/dftfu5p0r/image/upload/v1711995437/property-03_ednnld.png", "Navigating Diversity And Inclusion In Hiring: Best Practices For Building An Inclusive Workforce" },
                    { "29ed6c51-2eed-49f3-a0df-a8849eeaf340", "cad23a9b-e215-45e8-823f-87207f8c2b71", "In the dynamic landscape of today's job market, success isn't just about possessing the right qualifications or technical skills; it's about embodying a unique set of traits that set top performers apart from the rest. Whether you're a seasoned professional or a recent graduate, understanding and cultivating these essential traits can be the key to unlocking your full potential and achieving success in your career. Let's explore some of the fundamental traits that top performers exhibit in today's competitive job market.\r\n1. Adaptability and Resilience:\r\n\r\n\r\n\r\nIn a rapidly evolving work environment, adaptability is paramount. Top performers demonstrate the ability to quickly adjust to changes, whether it's new technology, shifting priorities, or unforeseen challenges. They approach setbacks as opportunities for growth and bounce back from adversity with resilience, maintaining a positive attitude and a forward-thinking mindset.\r\n2. Continuous Learning and Growth:\r\n\r\n\r\n\r\nThe pursuit of knowledge and personal development is a hallmark of top performers. They understand that learning doesn't end with formal education but is an ongoing process. Whether through formal training programs, self-study, or seeking mentorship, they are committed to expanding their skills and expertise to stay ahead of the curve in their respective fields.\r\n3. Strong Communication Skills:\r\n\r\n\r\n\r\nEffective communication is essential for success in any role. Top performers excel not only in articulating their ideas clearly but also in listening actively and empathetically. They can communicate across various mediums and tailor their message to different audiences, fostering collaboration and building strong relationships with colleagues, clients, and stakeholders.\r\n4. Proactive Problem-Solving Abilities:\r\n\r\n\r\n\r\nTop performers possess strong problem-solving skills and a proactive approach to tackling challenges. Rather than waiting for problems to arise, they anticipate potential issues and take preemptive action to address them. They analyze situations critically, think creatively, and implement innovative solutions, demonstrating resourcefulness and initiative in their work.\r\n5. Emotional Intelligence and Empathy:\r\n\r\n\r\n\r\nEmotional intelligence, including self-awareness, self-regulation, social awareness, and relationship management, is a critical trait of top performers. They understand their own emotions and motivations, allowing them to navigate complex interpersonal dynamics effectively. Moreover, they demonstrate empathy and understanding towards others, fostering a positive work environment and building trust and rapport with colleagues.\r\n6. Goal-Oriented and Results-Driven:\r\n\r\n\r\n\r\nTop performers are driven by a strong sense of purpose and are laser-focused on achieving their goals. They set ambitious yet achievable objectives, develop actionable plans to attain them, and consistently track their progress. They are outcome-oriented, measuring success not only by their individual achievements but also by their contributions to the overall success of their team and organization.\r\n7. Adaptability to Remote Work and Digital Skills:\r\n\r\n\r\n\r\nIn the wake of the COVID-19 pandemic, remote work has become increasingly prevalent. Top performers exhibit adaptability to this new work model, leveraging technology to collaborate effectively, stay organized, and maintain productivity. They are proficient in digital tools and platforms relevant to their roles, allowing them to thrive in virtual environments and stay connected with their teams and clients.\r\nConclusion\r\n\r\n\r\n\r\nIn conclusion, success in today's job market requires more than just technical expertise; it demands a diverse range of essential traits that enable individuals to navigate challenges, seize opportunities, and excel in their careers. By cultivating adaptability, continuous learning, strong communication, proactive problem-solving, emotional intelligence, goal orientation, and adaptability to remote work, individuals can position themselves as top performers in their respective fields, unlocking their full potential and achieving lasting success in today's dynamic work landscape.\r\n\r\n\r\n\r\n\r\nDimitar Genov is a seasoned professional with extensive experience in talent development and organizational leadership. He is passionate about empowering individuals to unleash their full potential and thrive in today's competitive job market.\r\n", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(4261), "https://res.cloudinary.com/dftfu5p0r/image/upload/v1711995451/unlockingsuccess_nhuhe2.jpg", "Unlocking Success: The Essential Traits Of Top Performers In Today's Job Market\r\n" },
                    { "7e6d9619-35a1-438e-a67e-bff6289139ac", "cad23a9b-e215-45e8-823f-87207f8c2b71", "In the wake of the COVID-19 pandemic, the traditional office-centric model of work has undergone a seismic shift. Remote work has become the new norm for many organizations, accelerating the adoption of digital technologies and fundamentally reshaping the way we approach talent acquisition. In this article, we'll explore strategies for navigating the digital talent landscape and effectively hiring in a remote-first world.:\r\nEmbrace Remote Work as the New Reality::\r\n\r\n\r\n\r\nThe first step in adapting to the remote-first world is to embrace it as the new reality. Recognize that remote work offers numerous benefits, including access to a broader talent pool, increased flexibility for employees, and reduced overhead costs for organizations. By embracing remote work, companies can tap into a diverse range of talent from around the globe and leverage digital tools to facilitate seamless collaboration across distributed teams.\r\nLeverage Digital Platforms for Recruitment:\r\n\r\n\r\n\r\nIn a remote-first world, traditional recruitment methods such as in-person interviews and job fairs may no longer be feasible. Instead, organizations must leverage digital platforms and technologies to connect with and attract top talent. This may include utilizing online job boards, social media platforms, and professional networking sites to advertise job openings and engage with potential candidates. Additionally, consider leveraging video interviewing platforms and virtual recruitment events to conduct remote interviews and assess candidates' skills and fit for the role.\r\nPrioritize Communication and Collaboration:\r\n\r\n\r\n\r\nEffective communication and collaboration are essential for success in a remote work environment. When hiring for remote positions, prioritize candidates who demonstrate strong communication skills, self-motivation, and the ability to work independently. Additionally, ensure that your organization has robust communication tools and practices in place to facilitate seamless collaboration among remote teams. This may include utilizing messaging apps, video conferencing software, and project management tools to keep teams connected and aligned.\r\nFocus on Results and Outcomes:\r\n\r\n\r\n\r\nIn a remote-first world, it's essential to focus on results and outcomes rather than hours worked or physical presence. When evaluating candidates, prioritize those who have a track record of delivering results in a remote or distributed work environment. Look for candidates who are self-directed, results-oriented, and able to thrive in a virtual setting. Additionally, consider implementing performance metrics and goals that emphasize outcomes rather than activities, empowering employees to focus on achieving measurable results regardless of their physical location.\r\nProvide Support and Resources for Remote Employees:\r\n\r\n\r\n\r\nRemote work can present unique challenges for employees, including feelings of isolation, difficulty maintaining work-life balance, and technological barriers. To support remote employees and ensure their success, provide access to resources and support services tailored to their needs. This may include offering remote onboarding and training programs, providing access to remote work tools and technology, and fostering a culture of inclusivity and support for remote employees.\r\nConclusion\r\n\r\n\r\n\r\nINavigating the digital talent landscape requires a shift in mindset and approach to hiring in a remote-first world. By embracing remote work as the new reality, leveraging digital platforms for recruitment, prioritizing communication and collaboration, focusing on results and outcomes, and providing support and resources for remote employees, organizations can effectively navigate the challenges and opportunities of hiring in a remote-first world. By embracing these strategies, companies can build diverse, high-performing teams that drive innovation and success in the digital age.\r\n\r\n\r\n\r\n\r\nMilena Koleva is a seasoned HR professional with a passion for talent acquisition and organizational development. With a focus on leveraging digital technologies and remote work strategies, Milena helps organizations navigate the complexities of hiring in a remote-first world. Through her expertise and dedication, Milena empowers companies to build diverse, resilient teams that thrive in today's digital landscape.\r\n", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(4271), "https://res.cloudinary.com/dftfu5p0r/image/upload/v1711995437/remoteworking_o1rphp.jpg", "Navigating The Digital Talent Landscape: Strategies For Hiring In A Remote-First World" },
                    { "a7b0446e-ce93-4b85-ae2c-1592f0431c28", "cad23a9b-e215-45e8-823f-87207f8c2b71", "In the dynamic landscape of modern workplaces, diversity and inclusion (D&I) have emerged as critical components of organizational success. Beyond just fulfilling ethical obligations, companies that prioritize D&I enjoy a myriad of benefits, including enhanced innovation, stronger employee engagement, and improved financial performance. However, achieving a truly diverse and inclusive workforce requires deliberate efforts at every stage of the employee lifecycle, from recruitment to retention. In this article, we'll explore some best practices for both recruitment and retention that can help organizations build and maintain a diverse and inclusive workforce.\r\nRecruitment Best Practices:\r\n\r\n\r\n\r\n1. Expand Outreach Efforts: To attract a diverse pool of candidates, it's crucial to broaden recruitment efforts beyond traditional channels. This may involve collaborating with diversity-focused organizations, attending events tailored to underrepresented groups, and utilizing targeted advertising on social media platforms. By proactively seeking out diverse talent, organizations can ensure a more inclusive recruitment process.\r\n2. Review Job Descriptions: Job descriptions should be crafted with inclusivity in mind. Avoid using biased language or requirements that may unintentionally deter certain candidates. Focus on the essential skills and qualifications needed for the role, rather than unnecessary criteria that may exclude qualified candidates from diverse backgrounds.\r\n3.Implement Blind Screening: Unconscious biases can influence hiring decisions, even unintentionally. Implementing blind screening processes, where personal information such as name, gender, and ethnicity is removed from resumes during the initial review, can help mitigate bias and ensure fair evaluation based solely on qualifications and experience.\r\n4. Diverse Interview Panels: Including diverse perspectives in the interview process is essential for promoting inclusivity. Consider assembling interview panels that reflect the diversity of your workforce and the broader community. This can help mitigate biases and ensure that candidates are evaluated fairly.\r\nRetention Best Practices:\r\n\r\n\r\n\r\n1. Promote Inclusive Culture: Creating a culture of inclusivity starts from the top. Leaders should actively champion D&I initiatives and foster an environment where all employees feel valued and respected. Encourage open dialogue, celebrate diversity, and address any instances of discrimination or bias promptly and effectively.\r\n2. Offer Development Opportunities: Provide opportunities for professional development and career advancement for all employees. Offer mentorship programs, training workshops, and leadership development initiatives that support the growth and progression of diverse talent within the organization.\r\n3.Establish Support Networks: Employee resource groups (ERGs) can provide a valuable support network for employees from underrepresented backgrounds. Encourage the formation of ERGs based on common identities or interests and provide resources and support to help them thrive.\r\n4. Regularly Review Policies: Periodically review HR policies and practices to ensure they are inclusive and equitable. Solicit feedback from employees and make necessary adjustments to address any gaps or areas for improvement.\r\nConclusion\r\n\r\n\r\n\r\nBuilding a diverse and inclusive workforce is not only the right thing to do—it's also a strategic imperative for organizations seeking to thrive in today's global marketplace. By implementing best practices for recruitment and retention, organizations can create environments where every individual feels valued, respected, and empowered to contribute their unique perspectives and talents. Through intentional efforts and proactive strategies, we can build a more equitable and inclusive future where diversity is celebrated and embraced as a source of strength and innovation.\r\n\r\n\r\n\r\n\r\nNikolai Ivanov is a seasoned HR professional with a deep commitment to building diverse and inclusive workplaces. With a wealth of experience in recruitment, talent development, and organizational culture, Nikolai understands the importance of creating environments where every individual feels valued, respected, and empowered to contribute their unique perspectives and talents.\r\n", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(4281), "https://res.cloudinary.com/dftfu5p0r/image/upload/v1711995700/article6_yhytju.jpg", "Building A Diverse And Inclusive Workforce: Best Practices For Recruitment And Retention" },
                    { "a81dcb8b-c525-475e-93bc-84493ad10ee5", "cad23a9b-e215-45e8-823f-87207f8c2b71", "In the ever-evolving landscape of recruitment, the integration of technology has proven to be a game-changer. Gone are the days of sifting through stacks of resumes or conducting endless rounds of interviews. Today, forward-thinking companies are embracing innovative technological solutions to streamline their hiring processes and find t he best talent efficiently.\r\nThe Traditional Hiring Conundrum\r\n\r\n\r\n\r\nTraditional recruitment methods often posed significant challenges for both employers and candidates alike. Employers grappled with time-consuming tasks such as manually reviewing resumes, scheduling interviews, and coordinating feedback among hiring teams. On the other hand, candidates faced lengthy application processes and prolonged wait times for responses, leading to frustration and disengagement.\r\nThe Rise of Technological Solutions\r\n\r\n\r\n\r\nATS platforms have become indispensable tools for modern recruiters. These systems automate the process of collecting, sorting, and managing applicant data, allowing recruiters to streamline their workflow and focus on engaging with top candidates. ATS platforms also offer features such as resume parsing, candidate scoring, and automated communication, enabling recruiters to identify the most qualified candidates efficiently.\r\nApplicant Tracking Systems (ATS)\r\n\r\n\r\n\r\nRecognizing the need for a more efficient approach, recruitment professionals turned to technology to revolutionize the hiring process. From applicant tracking systems (ATS) to artificial intelligence (AI)-powered tools, a myriad of solutions emerged to address the pain points of traditional recruitment methods.\r\nAI-Powered Recruitment Tools\r\n\r\n\r\n\r\nArtificial intelligence has transformed the recruitment landscape by offering advanced capabilities for candidate sourcing, screening, and assessment. AI-powered tools leverage machine learning algorithms to analyze vast amounts of data and identify patterns that match candidates with job requirements. These tools can source candidates from various channels, assess their skills and qualifications, and even predict their likelihood of success in specific roles. By harnessing the power of AI, recruiters can significantly reduce time-to-hire, improve candidate quality, and make more data-driven hiring decisions.\r\nVideo Interviewing Platforms\r\n\r\n\r\n\r\nWith the rise of remote work and distributed teams, video interviewing platforms have gained popularity as an essential tool for modern recruitment. These platforms enable recruiters to conduct virtual interviews with candidates from anywhere in the world, eliminating the need for costly and time-consuming travel. Video interviews also offer additional benefits such as asynchronous interviewing, interview recording, and integration with other recruitment software, making the hiring process more efficient and flexible for both recruiters and candidates.\r\nThe Future of Recruitment\r\n\r\n\r\n\r\nAs technology continues to evolve, the future of recruitment holds immense promise for further innovation. Emerging technologies such as augmented reality (AR), virtual reality (VR), and predictive analytics are poised to reshape the recruitment landscape in unprecedented ways. These technologies offer exciting possibilities for immersive candidate experiences, data-driven decision-making, and predictive talent analytics, paving the way for a more efficient, inclusive, and transparent recruitment process.\r\nConclusion\r\n\r\n\r\n\r\nIn the fast-paced world of recruitment, staying ahead of the curve is essential for attracting top talent and driving organizational success. By embracing technology and leveraging innovative solutions, recruiters can revolutionize the hiring process, streamline workflows, and make more informed decisions. As we continue to harness the power of technology, the future of recruitment is brighter than ever, offering boundless opportunities for companies to build diverse, high-performing teams that drive innovation and growth.\r\n\r\n\r\n\r\n\r\nIvan Petrov is a visionary leader in the field of recruitment, with a passion for leveraging technology to drive innovation and efficiency in the hiring process. With years of experience in talent acquisition and human resources, Ivan has witnessed firsthand the challenges faced by both employers and candidates in traditional recruitment methods. Motivated by a desire to revolutionize the industry, Ivan has dedicated his career to exploring and implementing cutting-edge technological solutions that transform the way companies identify and attract top talent.\r\n", new DateTime(2024, 4, 16, 0, 5, 36, 647, DateTimeKind.Local).AddTicks(4230), "https://res.cloudinary.com/dftfu5p0r/image/upload/v1711995437/property-01_mkg5z5.jpg", "Revolutionizing Recruitment: Leveraging Technology To Streamline The Hiring Process" }
                });

            migrationBuilder.InsertData(
                table: "Professions",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { "02be3e7a-3beb-4f1f-a23c-05a6282e0f0b", "a732a432-ef4f-4407-9dba-71f904d0ea6e", "Pharmacist" },
                    { "034511f3-67ce-4f55-99eb-3568b944f3ae", "fd71ecf5-cb6d-4e3c-ad4e-84358bdfa328", "Customer Support Engineer" },
                    { "048e727e-0ad6-400d-bc79-5579d454db38", "b89927d7-b1fd-4703-98df-a4681ce2db88", "Taxi Driver" },
                    { "050ac9d3-ac51-448a-b1e4-4f42456f5f20", "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c", "Co-pilot/First Officer" },
                    { "05176258-1280-4bc1-9192-6e7e886c710d", "438c1389-c017-43b8-a34a-46b8c64f5e1d", "Talent Acquisition Specialist/Recruiter" },
                    { "059b2e2a-a0bb-4aef-8a36-1ab583658d01", "71eb6b38-7552-425e-bf09-ee22d23855bb", "Data Entry Clerk" },
                    { "05e0a46c-181f-4e9e-9c2a-a888ba1c3e7b", "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb", "Advertising Executive" },
                    { "06e5a49d-3949-4827-9b05-459aadb0ac58", "8910967e-2a14-4a1a-a3f5-d16cc78a4b32", "Security Supervisor" },
                    { "08731b78-d451-4108-a711-f3d88a0b450b", "265bc199-91e3-4eba-9886-bce0a19e6ce2", "Customer Service Representative" },
                    { "0b86802b-8054-42ea-88ee-af6b970c637d", "fd71ecf5-cb6d-4e3c-ad4e-84358bdfa328", "IT Support Engineer" },
                    { "0d0aeb1c-4302-4916-8e4f-e95e38a7b136", "71eb6b38-7552-425e-bf09-ee22d23855bb", "Administrative Assistant" },
                    { "0d1aace7-ae73-4aa6-be19-0abcd9a38126", "3ea25504-1598-4608-a362-84d82b1b2fce", "Network Engineer" },
                    { "0f371117-e4e8-491b-a5b3-86eaa2bebc2c", "265bc199-91e3-4eba-9886-bce0a19e6ce2", "Retail Merchandiser" },
                    { "10501dee-9197-4df1-a3ff-f542e626cc1e", "c4dd9eea-1569-402f-a5b8-8473f48437a1", "Freight Forwarder" },
                    { "10f1dff4-dadc-446c-a591-5cea7f3791a7", "6859c0a0-98d0-49c5-b017-17d2a64d3342", "R&D Engineer" },
                    { "11b150d8-cad5-4911-a422-5d7968e3afbf", "dc8214a6-79cf-436c-bae1-7387b82a3bce", "Bookkeeper" },
                    { "145a0ae6-310d-4f28-9196-186264de0181", "38b5eb73-7829-497b-a207-9bcf3fef3b1b", "Mechanical Engineer" },
                    { "14dd7001-d9b2-4db4-8d07-8661f6035dfe", "b89927d7-b1fd-4703-98df-a4681ce2db88", "Van Driver" },
                    { "15e9eb6f-e7c7-4d1c-bfe7-9309a283541f", "71eb6b38-7552-425e-bf09-ee22d23855bb", "Office Administrator" },
                    { "17a6b69d-8b00-4ed5-af42-93d6b6875b1a", "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c", "Aircraft Maintenance Technician" },
                    { "1a2ed841-69f5-46da-a655-0b74d609073d", "0676aec9-89f5-4511-b642-6d0fe86e404a", "Property Manager" },
                    { "1cb0fbe5-13cb-4091-aaa2-2dc4d8604117", "16bf1012-a018-453d-97f2-d9682a3588f1", "Teacher" },
                    { "1cfcec36-fde1-4e06-9c53-efe703e0272b", "8910967e-2a14-4a1a-a3f5-d16cc78a4b32", "Bodyguard" },
                    { "1d42484d-55d2-4c8c-977e-e58ae6e7ee3c", "07a32cf2-3c7a-4ab0-ab70-9952c0966f30", "Bartender" },
                    { "1f42365e-ce27-4e00-a8dc-2d669e4f20b6", "b89927d7-b1fd-4703-98df-a4681ce2db88", "Truck Driver" },
                    { "2000efee-5d6f-44a4-b43e-d0a7aa4f7a12", "3ea25504-1598-4608-a362-84d82b1b2fce", "RF Engineer (Radio Frequency)" },
                    { "20f75e9a-fb41-4c68-9c1a-7a5522257bb2", "fd71ecf5-cb6d-4e3c-ad4e-84358bdfa328", "Technical Support Specialist" },
                    { "22a63c49-f68a-4dcc-b7c7-3c3d06aae66f", "6859c0a0-98d0-49c5-b017-17d2a64d3342", "Data Scientist" },
                    { "2397710f-b1b0-4486-9a48-64aa8611d218", "221e3547-3c78-41f9-9634-d7571a615fb8", "Auto Body Repair Technician" },
                    { "24344455-3d11-4a36-b23d-3d2b3739c65b", "f239ac3f-856e-494c-95df-2521a3269a6b", "Energy Analyst" },
                    { "245035c0-30a6-4820-b578-47a6993f848d", "221e3547-3c78-41f9-9634-d7571a615fb8", "Transmission Technician" },
                    { "26548567-f97e-4505-a163-bbc6942262be", "b89927d7-b1fd-4703-98df-a4681ce2db88", "Courier" },
                    { "29573caf-9e1b-4996-909a-d1ea50639eec", "fd71ecf5-cb6d-4e3c-ad4e-84358bdfa328", "Help Desk Technician" },
                    { "2ba54fe4-4ec1-443a-bc07-6857dd5fe830", "38b5eb73-7829-497b-a207-9bcf3fef3b1b", "Software Engineer" },
                    { "2c22f787-d93d-4030-930d-22668c929278", "a732a432-ef4f-4407-9dba-71f904d0ea6e", "Nurse" },
                    { "2c5b98be-3eae-490d-96ed-602a2d34446f", "ff13d479-760d-4387-8843-c882ad150609", "Loan Officer" },
                    { "2dc89507-d182-4032-8b18-42d6bf03245d", "71eb6b38-7552-425e-bf09-ee22d23855bb", "Executive Assistant" },
                    { "2df8d8b4-44ce-459e-9f03-01438c3008e0", "ec4b3c64-1f2f-455d-a6e4-75b525625371", "Judge" },
                    { "2e838421-32a7-4c70-af86-551dfaef72e2", "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb", "Public Relations Specialist" },
                    { "2f2ac025-bfeb-4364-904e-d0697b0b6f53", "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c", "Aircraft Dispatcher" },
                    { "2f4179da-7810-45f7-b8c2-0a23db90dfd3", "ff13d479-760d-4387-8843-c882ad150609", "Mortgage Broker" },
                    { "2f833572-ef7f-4d05-8d35-02eb7bc743ff", "6859c0a0-98d0-49c5-b017-17d2a64d3342", "Research Scientist" },
                    { "338ba2ff-a1dd-421b-b34c-cc74ddffcef3", "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb", "Marketing Manager" },
                    { "34c3e30e-74e0-4c2b-85a2-4996802461d4", "0676aec9-89f5-4511-b642-6d0fe86e404a", "Leasing Consultant" },
                    { "356615be-6a3f-4de1-9d4e-a3b2cdca8080", "07a32cf2-3c7a-4ab0-ab70-9952c0966f30", "Waiter/Waitress" },
                    { "3a4a0790-9d34-4d71-bd96-3d01b97ca981", "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c", "Pilot" },
                    { "3c2a4a45-8c1f-4a5c-840d-f6e5df97a804", "3c1fda93-5ef8-4db2-97f7-25f163fbca67", "Copy Editor" },
                    { "405c7736-db1f-4542-9ab8-bbb67780037c", "c468efd1-09cf-4e6c-9245-2e837e500968", "Help Desk Analyst" },
                    { "441fb5bb-d32f-46ff-9080-ef0ee60866f7", "8910967e-2a14-4a1a-a3f5-d16cc78a4b32", "Private Investigator" },
                    { "4678fd8b-1142-4412-bd9a-3a1f188447e2", "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c", "Air Traffic Controller" },
                    { "517c4797-9a02-46fc-839a-85620b0c929e", "c4dd9eea-1569-402f-a5b8-8473f48437a1", "Transportation Planner" },
                    { "52688025-4242-4bfa-b580-80119b011a11", "0676aec9-89f5-4511-b642-6d0fe86e404a", "Realtor" },
                    { "5637a422-4878-4a9c-9ba4-390ca88f689c", "38b5eb73-7829-497b-a207-9bcf3fef3b1b", "Electrical Engineer" },
                    { "5670c0cb-e3d6-4a25-a49c-48810142e29c", "221e3547-3c78-41f9-9634-d7571a615fb8", "Automotive Technician/Mechanic" },
                    { "59fc3628-aacd-401a-9ed9-b9380f3f20fb", "07a32cf2-3c7a-4ab0-ab70-9952c0966f30", "Concierge" },
                    { "60f34046-e85a-4ae8-ac45-894a137ff2a3", "438c1389-c017-43b8-a34a-46b8c64f5e1d", "Training and Development Specialist" },
                    { "626f8df9-1bd1-4421-af0b-ddf0d1426753", "f239ac3f-856e-494c-95df-2521a3269a6b", "Power Plant Operator" },
                    { "62d88616-99bf-4ecb-865a-231b08c4bc0a", "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb", "Digital Marketing Specialist" },
                    { "63fd0952-dfc2-4c65-9f2f-f901b2345730", "ff13d479-760d-4387-8843-c882ad150609", "Bank Teller" },
                    { "641c6252-64f1-4561-97bc-7a3fb6d6e402", "80bb3283-c810-4b9c-9d42-da03e17b2ddf", "Landscape Architect" },
                    { "66063fa7-e9c7-4bc6-9faa-e33a4abb736a", "221e3547-3c78-41f9-9634-d7571a615fb8", "Automotive Service Advisor" },
                    { "6625559f-54ab-47be-a715-5bdf682b1b9e", "a732a432-ef4f-4407-9dba-71f904d0ea6e", "Clinical Research Associate" },
                    { "696d0bd8-e510-4c5d-ae35-78cad1181a8f", "80bb3283-c810-4b9c-9d42-da03e17b2ddf", "Urban Planner" },
                    { "69f24ec2-e557-4878-88b4-bb9b33c6611f", "c4dd9eea-1569-402f-a5b8-8473f48437a1", "Logistics Coordinator" },
                    { "6c77266f-f45e-48c2-b360-c08a87a8bb6a", "07a32cf2-3c7a-4ab0-ab70-9952c0966f30", "Restaurant Manager" },
                    { "6f925444-b148-494c-bd53-bbd344ee6662", "16bf1012-a018-453d-97f2-d9682a3588f1", "Curriculum Developer" },
                    { "72a2a3fc-e1ec-44a0-9177-fc5b05c5a457", "438c1389-c017-43b8-a34a-46b8c64f5e1d", "HR Coordinator" },
                    { "74ba1775-6bbb-49dd-99c8-653e7dd3bd76", "80bb3283-c810-4b9c-9d42-da03e17b2ddf", "Architect" },
                    { "750d03b0-2791-4ea1-8df8-ab3442b5d3d4", "3ea25504-1598-4608-a362-84d82b1b2fce", "Telecommunications Engineer" },
                    { "78f564de-cdee-48b4-915a-27f0ed3b1dbb", "221e3547-3c78-41f9-9634-d7571a615fb8", "Automotive Electrician" },
                    { "78fbc6e9-f210-4242-b652-8b4145f14bff", "16bf1012-a018-453d-97f2-d9682a3588f1", "Instructor" },
                    { "7b4c1102-2baf-49db-a2a9-25c23d06fb7f", "fd71ecf5-cb6d-4e3c-ad4e-84358bdfa328", "Desktop Support Technician" },
                    { "7bfc2fed-4f46-479e-99fc-0622d3295768", "265bc199-91e3-4eba-9886-bce0a19e6ce2", "Assistant Store Manager" },
                    { "82243ee7-2335-4c60-978d-89d30cd6a14d", "8910967e-2a14-4a1a-a3f5-d16cc78a4b32", "Security Manager" },
                    { "83cb70cb-8fcc-4789-b6c8-1a57ec09d557", "ec4b3c64-1f2f-455d-a6e4-75b525625371", "Paralegal" },
                    { "85989a1d-f326-4526-8988-d6df70265a8d", "07a32cf2-3c7a-4ab0-ab70-9952c0966f30", "Hotel Manager" },
                    { "860f8264-7b75-4953-a085-9d8c877062af", "0676aec9-89f5-4511-b642-6d0fe86e404a", "Real Estate Appraiser" },
                    { "868a2331-bd33-4de7-bac0-3df433239856", "ff13d479-760d-4387-8843-c882ad150609", "Branch Manager" },
                    { "86d0722c-b0f6-4dd6-8a86-99cbfb57155a", "71eb6b38-7552-425e-bf09-ee22d23855bb", "Office Manager" },
                    { "8c915124-7f7b-422d-b253-ed7aae84405e", "c468efd1-09cf-4e6c-9245-2e837e500968", "Customer Success Manager" },
                    { "91377f46-b237-47b4-95f1-8579269ca86e", "c468efd1-09cf-4e6c-9245-2e837e500968", "Technical Support Specialist" },
                    { "917233e9-66b4-4544-a699-7ea0cb85797a", "265bc199-91e3-4eba-9886-bce0a19e6ce2", "Cashier" },
                    { "92da4b72-ba6e-4c65-a606-6b2b1620751b", "38b5eb73-7829-497b-a207-9bcf3fef3b1b", "Chemical Engineer" },
                    { "94fa9352-09f5-4e70-9db7-bec6b496e631", "0676aec9-89f5-4511-b642-6d0fe86e404a", "Real Estate Broker" },
                    { "95a77fcf-cbbd-4572-89fc-9cb367afc8e8", "438c1389-c017-43b8-a34a-46b8c64f5e1d", "Compensation and Benefits Manager" },
                    { "960d8810-21c4-4959-8494-72e66ba523c1", "dc8214a6-79cf-436c-bae1-7387b82a3bce", "Tax Accountant" },
                    { "967843e8-aa9b-4561-816c-932e0c2872d8", "3ea25504-1598-4608-a362-84d82b1b2fce", "Telecom Systems Engineer" },
                    { "97896d13-b13c-4c76-ac6c-d46c4898ee09", "c468efd1-09cf-4e6c-9245-2e837e500968", "Technical Support Specialist" },
                    { "97b485bb-323e-4f16-be6b-b2933fb67665", "3c1fda93-5ef8-4db2-97f7-25f163fbca67", "Publisher" },
                    { "99e7fefc-aab0-4872-bd70-ec096e91788a", "16bf1012-a018-453d-97f2-d9682a3588f1", "Educational Consultant" },
                    { "99fab28e-9dfc-4a92-a339-815b60926258", "38b5eb73-7829-497b-a207-9bcf3fef3b1b", "Computer Engineer" },
                    { "99ff55b3-6726-417e-848b-7f20f7c21b85", "438c1389-c017-43b8-a34a-46b8c64f5e1d", "HR Manager" },
                    { "9af916ad-afdf-4648-8bb3-8d18e3dc54d1", "16bf1012-a018-453d-97f2-d9682a3588f1", "Professor" },
                    { "9cdb9f77-ca97-4541-ada4-6450311ae0f5", "dc8214a6-79cf-436c-bae1-7387b82a3bce", "Certified Public Accountant (CPA)" },
                    { "a0e1166f-c2e3-457d-8d67-7e41a9566af1", "c4dd9eea-1569-402f-a5b8-8473f48437a1", "Distribution Manager" },
                    { "a180378d-013a-460f-a193-dffc8e604d74", "3ea25504-1598-4608-a362-84d82b1b2fce", "VoIP Engineer (Voice over Internet Protocol)" },
                    { "a1a00e9b-91f5-4f02-a059-755efe612359", "f239ac3f-856e-494c-95df-2521a3269a6b", "Mechanical Engineer" },
                    { "a1e58aef-0cb1-464b-aa09-2d6c49e85f17", "f239ac3f-856e-494c-95df-2521a3269a6b", "Renewable Energy Specialist" },
                    { "a44a38a3-3a98-4b41-9fb4-d2a8c3f2ebc9", "a732a432-ef4f-4407-9dba-71f904d0ea6e", "Pharmaceutical Scientist" },
                    { "a4a68e54-d607-45b0-8aed-e6bb47ed1dac", "b89927d7-b1fd-4703-98df-a4681ce2db88", "Bus Driver" },
                    { "a7f4190f-357b-4d7d-a3e1-9a32b596a829", "f239ac3f-856e-494c-95df-2521a3269a6b", "Electrical Engineer" },
                    { "a8019116-a9fd-425a-8ad0-4b5222538af4", "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c", "Flight Attendant" },
                    { "a94e989f-a232-47b7-8bef-948e9e460ed9", "8910967e-2a14-4a1a-a3f5-d16cc78a4b32", "Security Officer" },
                    { "b0fb83ea-722d-43be-8263-82af00b1dc65", "b89927d7-b1fd-4703-98df-a4681ce2db88", "Delivery Driver" },
                    { "b3650ac4-b942-4e60-bf67-9c7d8b8dada9", "a732a432-ef4f-4407-9dba-71f904d0ea6e", "Doctor" },
                    { "c0d83ba4-d544-48d0-9ffc-3b4ef3eb503a", "dc8214a6-79cf-436c-bae1-7387b82a3bce", "Financial Analyst" },
                    { "c1c71fdf-7510-4df2-bb7d-1d0b02d98286", "f239ac3f-856e-494c-95df-2521a3269a6b", "Utility Technician" },
                    { "c25c8960-9173-49e2-b889-c79e8ca38fa6", "dc8214a6-79cf-436c-bae1-7387b82a3bce", "Accountant" },
                    { "c5ef38e9-4b40-4819-8520-70e01059dee9", "dc8214a6-79cf-436c-bae1-7387b82a3bce", "Auditor" },
                    { "c950cec2-1f98-4810-8471-59be6e411799", "ff13d479-760d-4387-8843-c882ad150609", "Credit Analyst" },
                    { "cb09e6b7-8891-4b5b-93af-13037da85399", "c4dd9eea-1569-402f-a5b8-8473f48437a1", "Supply Chain Manager" },
                    { "cc4bd5c3-c241-47e1-8871-20ccb50d8459", "16bf1012-a018-453d-97f2-d9682a3588f1", "Tutor" },
                    { "cdbe3f5b-09f3-48d9-baa9-c94ec3e4cfee", "07a32cf2-3c7a-4ab0-ab70-9952c0966f30", "Chef" },
                    { "d1c580ca-f825-42c4-b727-42272b250094", "c468efd1-09cf-4e6c-9245-2e837e500968", "Client Support Specialist" },
                    { "d76d948b-5354-47d8-b4b7-3581577ffcf3", "fd71ecf5-cb6d-4e3c-ad4e-84358bdfa328", "Network Support Technician" },
                    { "d87f47c0-629b-472b-aa11-bf05c0b39632", "6859c0a0-98d0-49c5-b017-17d2a64d3342", "Research Associate" },
                    { "d90c05d7-b195-4651-b3fe-864ee7441f1b", "ec4b3c64-1f2f-455d-a6e4-75b525625371", "Legal Assistant" },
                    { "dcb461c9-a03c-495a-b683-77bf1a0777a0", "8910967e-2a14-4a1a-a3f5-d16cc78a4b32", "Security Guard" },
                    { "dcefec07-21f6-4e31-946f-0c93d4cda413", "38b5eb73-7829-497b-a207-9bcf3fef3b1b", "Civil Engineer" },
                    { "df03fabc-1996-4f90-bcb0-85cef7d91596", "6859c0a0-98d0-49c5-b017-17d2a64d3342", "Product Development Manager" },
                    { "df3d7970-d07c-4d6c-8a24-f0b9db999d83", "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb", "Brand Manager" },
                    { "dfb3d439-fd7b-449c-ae65-892f1f92028c", "ec4b3c64-1f2f-455d-a6e4-75b525625371", "Lawyer/Attorney" },
                    { "e19823ed-79fd-45a1-a1c3-fad35ff4a367", "c4dd9eea-1569-402f-a5b8-8473f48437a1", "Warehouse Manager" },
                    { "e229f146-0877-48bb-82a0-19bce751797a", "ec4b3c64-1f2f-455d-a6e4-75b525625371", "Legal Secretary" },
                    { "e38ce0c4-9812-42b7-8f26-8ec836f907bc", "3c1fda93-5ef8-4db2-97f7-25f163fbca67", "Reporter" },
                    { "e846f3fd-3a83-49bc-a8ab-00de75daff1a", "a732a432-ef4f-4407-9dba-71f904d0ea6e", "Pharmacy Technician" },
                    { "ea376b62-fabb-40e9-9dfc-097456ed6eae", "221e3547-3c78-41f9-9634-d7571a615fb8", "Brake Technician" },
                    { "eb1866fb-9cec-4928-af0c-9d7f714b1b29", "3c1fda93-5ef8-4db2-97f7-25f163fbca67", "Journalist" },
                    { "ec7d32c6-df6a-4014-b932-3d2f8bd315a7", "3c1fda93-5ef8-4db2-97f7-25f163fbca67", "Writer" },
                    { "ef07ec8a-569d-4709-a070-4f3c8e73f71c", "0676aec9-89f5-4511-b642-6d0fe86e404a", "Real Estate Agent" },
                    { "f2b910cd-8649-42cd-ba4a-911e80e72b33", "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb", "Social Media Manager" },
                    { "f413ddf7-49aa-4baf-be09-44ee85d955ad", "265bc199-91e3-4eba-9886-bce0a19e6ce2", "Retail Sales Associate" },
                    { "f41fb9a5-4783-4eb9-be5a-5af08270b5c0", "ec4b3c64-1f2f-455d-a6e4-75b525625371", "Legal Consultant" },
                    { "f67a3a36-2281-4c1c-ae05-0004669cfb0b", "265bc199-91e3-4eba-9886-bce0a19e6ce2", "Store Manager" },
                    { "f713de92-f0e7-413f-a34c-79e8334c8977", "ff13d479-760d-4387-8843-c882ad150609", "Financial Advisor" },
                    { "f8463622-9bc8-4896-a538-5288ff1ac729", "71eb6b38-7552-425e-bf09-ee22d23855bb", "Receptionist" },
                    { "f921af7b-3dca-4a5b-888c-c3ec015c7b8a", "c468efd1-09cf-4e6c-9245-2e837e500968", "Customer Service Representative" },
                    { "f9d6f062-72cc-44bc-b245-01320e38fa26", "6859c0a0-98d0-49c5-b017-17d2a64d3342", "Laboratory Technician" },
                    { "fa8d8eef-7f87-47bd-affe-b8ef8ae2efd9", "80bb3283-c810-4b9c-9d42-da03e17b2ddf", "Interior Designer" },
                    { "fcaf42cf-4f06-4764-bd44-fce5d065a66f", "3ea25504-1598-4608-a362-84d82b1b2fce", "Optical Network Engineer" },
                    { "ff34812f-0c7e-4655-9995-8d82076656aa", "3c1fda93-5ef8-4db2-97f7-25f163fbca67", "Editor" }
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
