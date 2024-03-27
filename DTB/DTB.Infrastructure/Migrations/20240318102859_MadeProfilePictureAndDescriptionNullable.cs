using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DTB.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MadeProfilePictureAndDescriptionNullable : Migration
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

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePicture",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DateOfCreation", "Name", "PictureUrl" },
                values: new object[,]
                {
                    { "015f0988-dcf7-4a44-892c-ae4eac49cc6f", new DateTime(2024, 3, 18, 12, 28, 57, 944, DateTimeKind.Local).AddTicks(4305), "Telecommunications - engineers and technicians", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_telecoms_sbsq5u.png" },
                    { "02b612b0-be2e-4faf-9d1c-5800c1ba0177", new DateTime(2024, 3, 18, 12, 28, 57, 944, DateTimeKind.Local).AddTicks(4366), "Technical Support", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_techsupport_zph0mx.png" },
                    { "1350d7c8-78da-42d5-b165-a99c481bbaa0", new DateTime(2024, 3, 18, 12, 28, 57, 944, DateTimeKind.Local).AddTicks(4381), "Accouting, Audit, Finance", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_finance_r5bftt.png" },
                    { "1799ed9f-6a0f-41aa-9fd0-b8cce18eb8ba", new DateTime(2024, 3, 18, 12, 28, 57, 944, DateTimeKind.Local).AddTicks(4352), "Auto Service", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824819/icon_autoservice_iabxkj.png" },
                    { "1efd4897-236c-47ce-a738-ee6dd12103b7", new DateTime(2024, 3, 18, 12, 28, 57, 944, DateTimeKind.Local).AddTicks(4203), "Restaurants, Bars, Hotels, Tourism", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824823/icon_restaurant_ee4ubg.png" },
                    { "2cd2d3c7-f761-4e8b-9a3d-1a50aff25eba", new DateTime(2024, 3, 18, 12, 28, 57, 944, DateTimeKind.Local).AddTicks(4323), "Security", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_security_c4fjq0.png" },
                    { "33319516-ca1d-47a2-84f2-7699259ce93d", new DateTime(2024, 3, 18, 12, 28, 57, 944, DateTimeKind.Local).AddTicks(4262), "Customer support", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_customersupport_fbvie5.png" },
                    { "38b5eb73-7829-497b-a207-9bcf3fef3b1b", new DateTime(2024, 3, 18, 12, 28, 57, 944, DateTimeKind.Local).AddTicks(4210), "Engineers and Technicians", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_engineer_wzjia1.png" },
                    { "3c1fda93-5ef8-4db2-97f7-25f163fbca67", new DateTime(2024, 3, 18, 12, 28, 57, 944, DateTimeKind.Local).AddTicks(4232), "Media, Publishing", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_media_mpzkez.png" },
                    { "42ee7dab-40de-4dfa-92e2-19e84d9d28b5", new DateTime(2024, 3, 18, 12, 28, 57, 944, DateTimeKind.Local).AddTicks(4194), "Drivers, Couriers", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_derivers_q8g7p3.png" },
                    { "438c1389-c017-43b8-a34a-46b8c64f5e1d", new DateTime(2024, 3, 18, 12, 28, 57, 944, DateTimeKind.Local).AddTicks(4224), "Human Resources", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_hr_jbc5jn.png" },
                    { "67d9d43a-345f-47d6-a90d-c81a9602fa23", new DateTime(2024, 3, 18, 12, 28, 57, 944, DateTimeKind.Local).AddTicks(4274), "Banking, Lending, Insurance", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_banking_dkgjma.png" },
                    { "90d67576-3cf2-4b69-a5c1-1f0c4d9aad97", new DateTime(2024, 3, 18, 12, 28, 57, 944, DateTimeKind.Local).AddTicks(4298), "Energy, Water and Sewage, Utilities", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_energy_kznsrc.png" },
                    { "93d4ba11-bfc1-44e8-8468-597b339ffd24", new DateTime(2024, 3, 18, 12, 28, 57, 944, DateTimeKind.Local).AddTicks(4341), "Legal", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_legal_ofzofx.png" },
                    { "991c653d-8328-4d32-b705-20b109951d6a", new DateTime(2024, 3, 18, 12, 28, 57, 944, DateTimeKind.Local).AddTicks(4359), "Retail, Wholesale", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824824/icon_retail_pgicm9.png" },
                    { "9cd67ced-4cfc-4398-9d10-0dbd9527ffaf", new DateTime(2024, 3, 18, 12, 28, 57, 944, DateTimeKind.Local).AddTicks(4290), "Office and Business activities", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_office_xkdjih.png" },
                    { "9d25e57d-afde-4014-a242-bca591dca67e", new DateTime(2024, 3, 18, 12, 28, 57, 944, DateTimeKind.Local).AddTicks(4331), "Real-estate", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_realestate_dkhhfe.png" },
                    { "a478fea2-8413-4e1f-a8e5-e2bdf9eec127", new DateTime(2024, 3, 18, 12, 28, 57, 944, DateTimeKind.Local).AddTicks(4178), "Health and Pharmacy", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_health_nhktmm.png" },
                    { "aa941b0a-6549-422e-8ce4-fd84ade11de0", new DateTime(2024, 3, 18, 12, 28, 57, 944, DateTimeKind.Local).AddTicks(4313), "Education, Courses, Translators", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_education_kdsm7z.png" },
                    { "c8d30a81-9fac-4371-adbd-e2e853e7f711", new DateTime(2024, 3, 18, 12, 28, 57, 944, DateTimeKind.Local).AddTicks(3489), "Architecture, Construction", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_architecture_gqdlbl.png" },
                    { "cd804d62-8242-428f-ac64-06f215959969", new DateTime(2024, 3, 18, 12, 28, 57, 944, DateTimeKind.Local).AddTicks(4373), "Research and development", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824822/icon_research_mdrafi.png" },
                    { "d4c1bbc7-1c04-4ce5-899f-821becc77677", new DateTime(2024, 3, 18, 12, 28, 57, 944, DateTimeKind.Local).AddTicks(4282), "Marketing, Advertising, PR", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_hr_jbc5jn.png" },
                    { "f835430c-177d-4313-90d4-4f93bc99ab8a", new DateTime(2024, 3, 18, 12, 28, 57, 944, DateTimeKind.Local).AddTicks(4347), "Aviation, Airport & Airline", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_airline_bgvmiu.png" },
                    { "faa94ce0-792b-4e2f-901d-c726d0b2527a", new DateTime(2024, 3, 18, 12, 28, 57, 944, DateTimeKind.Local).AddTicks(4254), "Logistics, Spedition", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_logistic_ktvoqa.png" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "2162e896-167e-492a-9800-b0e5c875e5ef", "Burgas" },
                    { "36f23e96-1b0a-49d1-bb56-0c2f8696d83e", "Blagoevgrad" },
                    { "539ce7e0-3dc6-4301-9be4-c1f75e5b4846", "Varna" },
                    { "5e98b3c8-019d-4ddb-a4f1-f2c53bdaa147", "Elhovo" },
                    { "657f6f85-d8d2-45a1-8ddc-4eb39d574732", "Yambol" },
                    { "adc41865-003d-4cde-9738-e9c2db4a72b8", "Sofia" },
                    { "c05a5f30-ad12-4246-bb9a-7a0232e85fae", "Plovdiv" },
                    { "dc432008-8802-4899-adda-720d11c9c762", "Ruse" },
                    { "f2bdba4c-898d-46a9-8021-257a582f5fce", "Sliven" },
                    { "f58cca15-7681-4f13-8894-906db6df8944", "Dimitrovgrad" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "015f0988-dcf7-4a44-892c-ae4eac49cc6f");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "02b612b0-be2e-4faf-9d1c-5800c1ba0177");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "1350d7c8-78da-42d5-b165-a99c481bbaa0");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "1799ed9f-6a0f-41aa-9fd0-b8cce18eb8ba");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "1efd4897-236c-47ce-a738-ee6dd12103b7");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "2cd2d3c7-f761-4e8b-9a3d-1a50aff25eba");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "33319516-ca1d-47a2-84f2-7699259ce93d");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "38b5eb73-7829-497b-a207-9bcf3fef3b1b");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "3c1fda93-5ef8-4db2-97f7-25f163fbca67");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "42ee7dab-40de-4dfa-92e2-19e84d9d28b5");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "438c1389-c017-43b8-a34a-46b8c64f5e1d");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "67d9d43a-345f-47d6-a90d-c81a9602fa23");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "90d67576-3cf2-4b69-a5c1-1f0c4d9aad97");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "93d4ba11-bfc1-44e8-8468-597b339ffd24");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "991c653d-8328-4d32-b705-20b109951d6a");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "9cd67ced-4cfc-4398-9d10-0dbd9527ffaf");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "9d25e57d-afde-4014-a242-bca591dca67e");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "a478fea2-8413-4e1f-a8e5-e2bdf9eec127");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "aa941b0a-6549-422e-8ce4-fd84ade11de0");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "c8d30a81-9fac-4371-adbd-e2e853e7f711");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cd804d62-8242-428f-ac64-06f215959969");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "d4c1bbc7-1c04-4ce5-899f-821becc77677");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "f835430c-177d-4313-90d4-4f93bc99ab8a");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "faa94ce0-792b-4e2f-901d-c726d0b2527a");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "2162e896-167e-492a-9800-b0e5c875e5ef");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "36f23e96-1b0a-49d1-bb56-0c2f8696d83e");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "539ce7e0-3dc6-4301-9be4-c1f75e5b4846");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "5e98b3c8-019d-4ddb-a4f1-f2c53bdaa147");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "657f6f85-d8d2-45a1-8ddc-4eb39d574732");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "adc41865-003d-4cde-9738-e9c2db4a72b8");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "c05a5f30-ad12-4246-bb9a-7a0232e85fae");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "dc432008-8802-4899-adda-720d11c9c762");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "f2bdba4c-898d-46a9-8021-257a582f5fce");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "f58cca15-7681-4f13-8894-906db6df8944");

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePicture",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
