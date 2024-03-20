using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DTB.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewTableContactFormSubmission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "0a37e6b1-9fa5-44e1-98cf-df2c1e7caa96");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "22b99f66-26c5-47b2-8aa2-1f501eb39497");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "2610c618-5115-4afc-8f80-5aa8e194ad6e");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "2d14f66c-7a80-45b8-a401-7b4495e446c0");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "3bc071f6-3097-4437-b5f9-2d83edad8436");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "45467b4f-9e51-4fa4-956b-4cda82a33e4c");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "4f7000d8-5e7c-47a0-aac2-634c36fcc064");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "56a3582b-575f-43c4-8240-a0b6abbf81f6");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "5730f17a-acb1-4a1c-9f6d-b5c97e82eafa");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "5b2b0f74-0757-4105-912d-74a3b10ef836");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "5fa7c120-146b-4670-a195-dbb91ed043d6");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "7325646d-702d-46f9-85b5-e82cda53d52d");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "7743323e-8664-4a34-8da6-1d6509278f6b");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "96c8d7e8-371e-4bdc-9c96-2ea0b74a4394");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "b319e51e-40bb-4d5e-a91e-05ff932b44f8");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "c22b9b10-3d4b-4dfd-b6ec-d6685c7ef3d3");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "c3286ba7-824e-44c0-bfee-b59e0fe19224");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "c8b6c121-2dbf-4867-92cf-2b1c740a3059");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "c988a75e-e75a-4eee-893b-b823672d3f16");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "d662caef-0fb3-4789-ac33-a8b33bebb4cc");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "e01b0819-4b78-4c9a-925b-8c4e70f3d3ea");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "e4326162-3d3d-4150-99f5-9b929b12ac2c");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "f9fa459e-d513-4d77-878b-0c40aed1d950");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "ff634f7f-1056-4008-a247-f8079751833d");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "04ae6924-e107-456e-b235-4545ab6cca27");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "0d321f77-eb4d-48ca-9180-7b9f97c5fbf1");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "1a5a55f2-e219-41b3-bd6c-6f8f916fd904");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "2abb2b92-8a02-4704-9c56-0d4943c4eb34");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "2cf5544e-b4a4-4260-b7e5-5e2432c9b543");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "4ec6d58c-04a4-462e-aea1-3a0445df0c3f");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "8d6615de-db1e-4794-9a51-7d0260c0f060");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "a9f313a1-fc58-49fa-a865-71360315e724");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "adda0d37-4f23-4d5a-954a-c46170ffdfa2");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "c7298e8e-aef7-42c9-ab42-aee212e44980");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DateOfCreation", "Name", "PictureUrl" },
                values: new object[,]
                {
                    { "059bb67a-c45c-49e7-9a2f-eb33b2020bb7", new DateTime(2024, 3, 20, 17, 4, 36, 346, DateTimeKind.Local).AddTicks(7011), "Marketing, Advertising, PR", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_hr_jbc5jn.png" },
                    { "109ec738-74b2-4dd7-bd9c-4f496e43f3c5", new DateTime(2024, 3, 20, 17, 4, 36, 346, DateTimeKind.Local).AddTicks(6983), "Media, Publishing", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_media_mpzkez.png" },
                    { "10af519f-189e-4681-b195-0235a09aaf8e", new DateTime(2024, 3, 20, 17, 4, 36, 346, DateTimeKind.Local).AddTicks(7025), "Energy, Water and Sewage, Utilities", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_energy_kznsrc.png" },
                    { "10e507b7-0677-411c-9afe-068164dd2d1c", new DateTime(2024, 3, 20, 17, 4, 36, 346, DateTimeKind.Local).AddTicks(6952), "Drivers, Couriers", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_derivers_q8g7p3.png" },
                    { "2f96d59b-255b-41af-9b70-6ed0399d84cb", new DateTime(2024, 3, 20, 17, 4, 36, 346, DateTimeKind.Local).AddTicks(7031), "Telecommunications - engineers and technicians", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_telecoms_sbsq5u.png" },
                    { "3788e599-5e1b-410a-9020-a60b27484eb2", new DateTime(2024, 3, 20, 17, 4, 36, 346, DateTimeKind.Local).AddTicks(6976), "Human Resources", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_hr_jbc5jn.png" },
                    { "44506664-a42d-4a20-8c52-cd4e029b3be5", new DateTime(2024, 3, 20, 17, 4, 36, 346, DateTimeKind.Local).AddTicks(6966), "Engineers and Technicians", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_engineer_wzjia1.png" },
                    { "49d281b5-b10c-4780-be7a-ac920b03c4df", new DateTime(2024, 3, 20, 17, 4, 36, 346, DateTimeKind.Local).AddTicks(7004), "Banking, Lending, Insurance", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_banking_dkgjma.png" },
                    { "4b76d573-9dd4-4f0d-b347-ecb8a988a607", new DateTime(2024, 3, 20, 17, 4, 36, 346, DateTimeKind.Local).AddTicks(7097), "Accouting, Audit, Finance", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_finance_r5bftt.png" },
                    { "51e3a8a0-c40e-4429-8658-1e10d71a18cb", new DateTime(2024, 3, 20, 17, 4, 36, 346, DateTimeKind.Local).AddTicks(6894), "Architecture, Construction", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_architecture_gqdlbl.png" },
                    { "5dcbb653-d6bb-4ab7-8623-55461c729553", new DateTime(2024, 3, 20, 17, 4, 36, 346, DateTimeKind.Local).AddTicks(7084), "Technical Support", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_techsupport_zph0mx.png" },
                    { "7012c3a2-b566-4be7-bb5c-005919969fe1", new DateTime(2024, 3, 20, 17, 4, 36, 346, DateTimeKind.Local).AddTicks(7078), "Retail, Wholesale", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824824/icon_retail_pgicm9.png" },
                    { "9136c27f-24f5-42e7-b4a3-9c737d6eefd3", new DateTime(2024, 3, 20, 17, 4, 36, 346, DateTimeKind.Local).AddTicks(7065), "Aviation, Airport & Airline", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_airline_bgvmiu.png" },
                    { "91bc1661-6b3d-4de9-b8ee-51be729e87ef", new DateTime(2024, 3, 20, 17, 4, 36, 346, DateTimeKind.Local).AddTicks(6959), "Restaurants, Bars, Hotels, Tourism", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824823/icon_restaurant_ee4ubg.png" },
                    { "972cd369-4840-42bd-be94-c7f25183a9b8", new DateTime(2024, 3, 20, 17, 4, 36, 346, DateTimeKind.Local).AddTicks(7051), "Real-estate", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_realestate_dkhhfe.png" },
                    { "a9b974a9-c287-4f74-ad43-1345f04c67fc", new DateTime(2024, 3, 20, 17, 4, 36, 346, DateTimeKind.Local).AddTicks(7038), "Education, Courses, Translators", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_education_kdsm7z.png" },
                    { "b1e639ef-3fb9-4022-abfb-20d5a49d93f0", new DateTime(2024, 3, 20, 17, 4, 36, 346, DateTimeKind.Local).AddTicks(6996), "Customer support", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_customersupport_fbvie5.png" },
                    { "c1d31fb9-9857-45a1-b1b4-66dc00ccf12f", new DateTime(2024, 3, 20, 17, 4, 36, 346, DateTimeKind.Local).AddTicks(7018), "Office and Business activities", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_office_xkdjih.png" },
                    { "c85eaa5f-a5c0-4a73-b219-207bee6d848f", new DateTime(2024, 3, 20, 17, 4, 36, 346, DateTimeKind.Local).AddTicks(6989), "Logistics, Spedition", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_logistic_ktvoqa.png" },
                    { "d303b80e-871f-4aab-b6ef-5b419cd2bd24", new DateTime(2024, 3, 20, 17, 4, 36, 346, DateTimeKind.Local).AddTicks(7090), "Research and development", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824822/icon_research_mdrafi.png" },
                    { "dd980b0a-6fa4-470d-8311-8f5e601b8c51", new DateTime(2024, 3, 20, 17, 4, 36, 346, DateTimeKind.Local).AddTicks(7044), "Security", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_security_c4fjq0.png" },
                    { "ee94ba4c-ae17-47c3-a908-5fa54dcac53a", new DateTime(2024, 3, 20, 17, 4, 36, 346, DateTimeKind.Local).AddTicks(6936), "Health and Pharmacy", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_health_nhktmm.png" },
                    { "f253c296-de78-4da9-841e-55a39ccc70ea", new DateTime(2024, 3, 20, 17, 4, 36, 346, DateTimeKind.Local).AddTicks(7071), "Auto Service", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824819/icon_autoservice_iabxkj.png" },
                    { "f613c771-90af-4acf-8da5-dfe686be98a4", new DateTime(2024, 3, 20, 17, 4, 36, 346, DateTimeKind.Local).AddTicks(7058), "Legal", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_legal_ofzofx.png" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "16842a20-7069-4cbd-a2bd-ff67ef1a6009", "Varna" },
                    { "332312f1-b597-4e8a-877a-c10da74ba24d", "Sofia" },
                    { "3a6eb306-e99f-431f-b382-68b5e0893bf4", "Blagoevgrad" },
                    { "58d4ddbc-ddce-4652-9bd1-4c9c34a6d043", "Burgas" },
                    { "67d9b96a-f3ec-4eae-93e6-b9fc79924d46", "Plovdiv" },
                    { "8044c37e-2030-4ca7-9a7a-5f0978c02d62", "Yambol" },
                    { "80eb2aad-8f49-4157-b803-13db4d4067de", "Sliven" },
                    { "83687b12-0d45-4746-942f-42135419c6e1", "Elhovo" },
                    { "d499deb5-cbc8-429e-9ddd-c465b07a0bfd", "Dimitrovgrad" },
                    { "f2a9357d-67ba-4ddd-904f-fbeef44b1fb1", "Ruse" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactFormSubmissions");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "059bb67a-c45c-49e7-9a2f-eb33b2020bb7");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "109ec738-74b2-4dd7-bd9c-4f496e43f3c5");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "10af519f-189e-4681-b195-0235a09aaf8e");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "10e507b7-0677-411c-9afe-068164dd2d1c");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "2f96d59b-255b-41af-9b70-6ed0399d84cb");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "3788e599-5e1b-410a-9020-a60b27484eb2");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "44506664-a42d-4a20-8c52-cd4e029b3be5");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "49d281b5-b10c-4780-be7a-ac920b03c4df");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "4b76d573-9dd4-4f0d-b347-ecb8a988a607");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "51e3a8a0-c40e-4429-8658-1e10d71a18cb");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "5dcbb653-d6bb-4ab7-8623-55461c729553");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "7012c3a2-b566-4be7-bb5c-005919969fe1");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "9136c27f-24f5-42e7-b4a3-9c737d6eefd3");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "91bc1661-6b3d-4de9-b8ee-51be729e87ef");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "972cd369-4840-42bd-be94-c7f25183a9b8");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "a9b974a9-c287-4f74-ad43-1345f04c67fc");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "b1e639ef-3fb9-4022-abfb-20d5a49d93f0");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "c1d31fb9-9857-45a1-b1b4-66dc00ccf12f");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "c85eaa5f-a5c0-4a73-b219-207bee6d848f");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "d303b80e-871f-4aab-b6ef-5b419cd2bd24");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "dd980b0a-6fa4-470d-8311-8f5e601b8c51");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "ee94ba4c-ae17-47c3-a908-5fa54dcac53a");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "f253c296-de78-4da9-841e-55a39ccc70ea");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "f613c771-90af-4acf-8da5-dfe686be98a4");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "16842a20-7069-4cbd-a2bd-ff67ef1a6009");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "332312f1-b597-4e8a-877a-c10da74ba24d");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "3a6eb306-e99f-431f-b382-68b5e0893bf4");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "58d4ddbc-ddce-4652-9bd1-4c9c34a6d043");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "67d9b96a-f3ec-4eae-93e6-b9fc79924d46");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "8044c37e-2030-4ca7-9a7a-5f0978c02d62");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "80eb2aad-8f49-4157-b803-13db4d4067de");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "83687b12-0d45-4746-942f-42135419c6e1");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "d499deb5-cbc8-429e-9ddd-c465b07a0bfd");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "f2a9357d-67ba-4ddd-904f-fbeef44b1fb1");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Articles");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DateOfCreation", "Name", "PictureUrl" },
                values: new object[,]
                {
                    { "0a37e6b1-9fa5-44e1-98cf-df2c1e7caa96", new DateTime(2024, 3, 14, 14, 51, 43, 797, DateTimeKind.Local).AddTicks(7789), "Customer support", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_customersupport_fbvie5.png" },
                    { "22b99f66-26c5-47b2-8aa2-1f501eb39497", new DateTime(2024, 3, 14, 14, 51, 43, 797, DateTimeKind.Local).AddTicks(7684), "Health and Pharmacy", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_health_nhktmm.png" },
                    { "2610c618-5115-4afc-8f80-5aa8e194ad6e", new DateTime(2024, 3, 14, 14, 51, 43, 797, DateTimeKind.Local).AddTicks(7896), "Research and development", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824822/icon_research_mdrafi.png" },
                    { "2d14f66c-7a80-45b8-a401-7b4495e446c0", new DateTime(2024, 3, 14, 14, 51, 43, 797, DateTimeKind.Local).AddTicks(7736), "Engineers and Technicians", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_engineer_wzjia1.png" },
                    { "3bc071f6-3097-4437-b5f9-2d83edad8436", new DateTime(2024, 3, 14, 14, 51, 43, 797, DateTimeKind.Local).AddTicks(7889), "Technical Support", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_techsupport_zph0mx.png" },
                    { "45467b4f-9e51-4fa4-956b-4cda82a33e4c", new DateTime(2024, 3, 14, 14, 51, 43, 797, DateTimeKind.Local).AddTicks(7689), "Drivers, Couriers", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_derivers_q8g7p3.png" },
                    { "4f7000d8-5e7c-47a0-aac2-634c36fcc064", new DateTime(2024, 3, 14, 14, 51, 43, 797, DateTimeKind.Local).AddTicks(7854), "Real-estate", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_realestate_dkhhfe.png" },
                    { "56a3582b-575f-43c4-8240-a0b6abbf81f6", new DateTime(2024, 3, 14, 14, 51, 43, 797, DateTimeKind.Local).AddTicks(7728), "Restaurants, Bars, Hotels, Tourism", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824823/icon_restaurant_ee4ubg.png" },
                    { "5730f17a-acb1-4a1c-9f6d-b5c97e82eafa", new DateTime(2024, 3, 14, 14, 51, 43, 797, DateTimeKind.Local).AddTicks(7904), "Accouting, Audit, Finance", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_finance_r5bftt.png" },
                    { "5b2b0f74-0757-4105-912d-74a3b10ef836", new DateTime(2024, 3, 14, 14, 51, 43, 797, DateTimeKind.Local).AddTicks(7862), "Legal", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_legal_ofzofx.png" },
                    { "5fa7c120-146b-4670-a195-dbb91ed043d6", new DateTime(2024, 3, 14, 14, 51, 43, 797, DateTimeKind.Local).AddTicks(7869), "Aviation, Airport & Airline", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_airline_bgvmiu.png" },
                    { "7325646d-702d-46f9-85b5-e82cda53d52d", new DateTime(2024, 3, 14, 14, 51, 43, 797, DateTimeKind.Local).AddTicks(7813), "Office and Business activities", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_office_xkdjih.png" },
                    { "7743323e-8664-4a34-8da6-1d6509278f6b", new DateTime(2024, 3, 14, 14, 51, 43, 797, DateTimeKind.Local).AddTicks(7882), "Retail, Wholesale", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824824/icon_retail_pgicm9.png" },
                    { "96c8d7e8-371e-4bdc-9c96-2ea0b74a4394", new DateTime(2024, 3, 14, 14, 51, 43, 797, DateTimeKind.Local).AddTicks(7620), "Architecture, Construction", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_architecture_gqdlbl.png" },
                    { "b319e51e-40bb-4d5e-a91e-05ff932b44f8", new DateTime(2024, 3, 14, 14, 51, 43, 797, DateTimeKind.Local).AddTicks(7848), "Security", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_security_c4fjq0.png" },
                    { "c22b9b10-3d4b-4dfd-b6ec-d6685c7ef3d3", new DateTime(2024, 3, 14, 14, 51, 43, 797, DateTimeKind.Local).AddTicks(7821), "Energy, Water and Sewage, Utilities", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_energy_kznsrc.png" },
                    { "c3286ba7-824e-44c0-bfee-b59e0fe19224", new DateTime(2024, 3, 14, 14, 51, 43, 797, DateTimeKind.Local).AddTicks(7751), "Human Resources", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_hr_jbc5jn.png" },
                    { "c8b6c121-2dbf-4867-92cf-2b1c740a3059", new DateTime(2024, 3, 14, 14, 51, 43, 797, DateTimeKind.Local).AddTicks(7876), "Auto Service", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824819/icon_autoservice_iabxkj.png" },
                    { "c988a75e-e75a-4eee-893b-b823672d3f16", new DateTime(2024, 3, 14, 14, 51, 43, 797, DateTimeKind.Local).AddTicks(7839), "Education, Courses, Translators", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_education_kdsm7z.png" },
                    { "d662caef-0fb3-4789-ac33-a8b33bebb4cc", new DateTime(2024, 3, 14, 14, 51, 43, 797, DateTimeKind.Local).AddTicks(7806), "Marketing, Advertising, PR", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_hr_jbc5jn.png" },
                    { "e01b0819-4b78-4c9a-925b-8c4e70f3d3ea", new DateTime(2024, 3, 14, 14, 51, 43, 797, DateTimeKind.Local).AddTicks(7781), "Logistics, Spedition", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_logistic_ktvoqa.png" },
                    { "e4326162-3d3d-4150-99f5-9b929b12ac2c", new DateTime(2024, 3, 14, 14, 51, 43, 797, DateTimeKind.Local).AddTicks(7759), "Media, Publishing", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_media_mpzkez.png" },
                    { "f9fa459e-d513-4d77-878b-0c40aed1d950", new DateTime(2024, 3, 14, 14, 51, 43, 797, DateTimeKind.Local).AddTicks(7798), "Banking, Lending, Insurance", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_banking_dkgjma.png" },
                    { "ff634f7f-1056-4008-a247-f8079751833d", new DateTime(2024, 3, 14, 14, 51, 43, 797, DateTimeKind.Local).AddTicks(7831), "Telecommunications - engineers and technicians", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_telecoms_sbsq5u.png" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "04ae6924-e107-456e-b235-4545ab6cca27", "Plovdiv" },
                    { "0d321f77-eb4d-48ca-9180-7b9f97c5fbf1", "Sliven" },
                    { "1a5a55f2-e219-41b3-bd6c-6f8f916fd904", "Varna" },
                    { "2abb2b92-8a02-4704-9c56-0d4943c4eb34", "Burgas" },
                    { "2cf5544e-b4a4-4260-b7e5-5e2432c9b543", "Yambol" },
                    { "4ec6d58c-04a4-462e-aea1-3a0445df0c3f", "Dimitrovgrad" },
                    { "8d6615de-db1e-4794-9a51-7d0260c0f060", "Elhovo" },
                    { "a9f313a1-fc58-49fa-a865-71360315e724", "Blagoevgrad" },
                    { "adda0d37-4f23-4d5a-954a-c46170ffdfa2", "Sofia" },
                    { "c7298e8e-aef7-42c9-ab42-aee212e44980", "Ruse" }
                });
        }
    }
}
