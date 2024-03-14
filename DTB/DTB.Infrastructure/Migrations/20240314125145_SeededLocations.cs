using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DTB.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeededLocations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "0de06753-27d9-40be-a58a-65ac33ca8dfc");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "13ba54ca-ccd4-4bde-a81f-d9b25429cd37");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "179ae6fb-a446-4138-8359-d1d8bafb51b3");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "24a4704c-e855-459e-bc84-bb14ff9c5300");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "42ddca84-dd4a-492c-ada4-e988fae7e5e1");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "507f3e99-6543-46ba-a422-36ab35703cb1");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "51aa5900-a32b-473b-a7c2-152404e4e27f");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "5e8e9edb-5db6-43f4-96a4-373755755314");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "6ae5f6d1-0560-4ca9-9a85-3601b531c680");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "6bbd2f15-0cb1-4af1-9e31-7fc00eaa9d72");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "704c9458-51bc-4fb3-a238-8fbaf2fc2c0b");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "7a6d0ab7-296c-490d-81e2-30a51f433fbf");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "7f42b129-71be-4f06-8f44-a5c6910edc24");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "b26c0981-03b6-41ba-95c4-888ad219e718");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "b8dc5ad1-ff5f-4acf-b6c0-acda39b0026e");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "c2f62778-5f6f-4117-b4a0-57356a45c143");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "c39aa039-e2af-4445-a9d6-0076cf11bd68");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "c575dcfd-9a45-4dd4-a2b2-35708ca9ea33");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "ca22d765-2bfb-4ca0-ac00-fb94a0759ee1");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "e28fe478-6b33-4e92-a7d1-09462f0847d3");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "e2bd38f7-11fa-476f-aaf7-79fa4fdcace8");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "e40120c1-e95a-477f-b53b-c486b518da2d");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "e6c80278-8283-488c-ad9b-3b30530c1765");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "fb4cb4f5-8c12-4108-8251-cdd80fcbe4f1");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DateOfCreation", "Name", "PictureUrl" },
                values: new object[,]
                {
                    { "0de06753-27d9-40be-a58a-65ac33ca8dfc", new DateTime(2024, 3, 13, 14, 39, 16, 113, DateTimeKind.Local).AddTicks(1377), "Auto Service", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824819/icon_autoservice_iabxkj.png" },
                    { "13ba54ca-ccd4-4bde-a81f-d9b25429cd37", new DateTime(2024, 3, 13, 14, 39, 16, 113, DateTimeKind.Local).AddTicks(1351), "Real-estate", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_realestate_dkhhfe.png" },
                    { "179ae6fb-a446-4138-8359-d1d8bafb51b3", new DateTime(2024, 3, 13, 14, 39, 16, 113, DateTimeKind.Local).AddTicks(1271), "Logistics, Spedition", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_logistic_ktvoqa.png" },
                    { "24a4704c-e855-459e-bc84-bb14ff9c5300", new DateTime(2024, 3, 13, 14, 39, 16, 113, DateTimeKind.Local).AddTicks(1386), "Retail, Wholesale", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824824/icon_retail_pgicm9.png" },
                    { "42ddca84-dd4a-492c-ada4-e988fae7e5e1", new DateTime(2024, 3, 13, 14, 39, 16, 113, DateTimeKind.Local).AddTicks(1361), "Legal", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_legal_ofzofx.png" },
                    { "507f3e99-6543-46ba-a422-36ab35703cb1", new DateTime(2024, 3, 13, 14, 39, 16, 113, DateTimeKind.Local).AddTicks(1288), "Banking, Lending, Insurance", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_banking_dkgjma.png" },
                    { "51aa5900-a32b-473b-a7c2-152404e4e27f", new DateTime(2024, 3, 13, 14, 39, 16, 113, DateTimeKind.Local).AddTicks(1207), "Drivers, Couriers", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_derivers_q8g7p3.png" },
                    { "5e8e9edb-5db6-43f4-96a4-373755755314", new DateTime(2024, 3, 13, 14, 39, 16, 113, DateTimeKind.Local).AddTicks(1395), "Technical Support", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_techsupport_zph0mx.png" },
                    { "6ae5f6d1-0560-4ca9-9a85-3601b531c680", new DateTime(2024, 3, 13, 14, 39, 16, 113, DateTimeKind.Local).AddTicks(1414), "Accouting, Audit, Finance", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_finance_r5bftt.png" },
                    { "6bbd2f15-0cb1-4af1-9e31-7fc00eaa9d72", new DateTime(2024, 3, 13, 14, 39, 16, 113, DateTimeKind.Local).AddTicks(1298), "Marketing, Advertising, PR", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_hr_jbc5jn.png" },
                    { "704c9458-51bc-4fb3-a238-8fbaf2fc2c0b", new DateTime(2024, 3, 13, 14, 39, 16, 113, DateTimeKind.Local).AddTicks(1054), "Architecture, Construction", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_architecture_gqdlbl.png" },
                    { "7a6d0ab7-296c-490d-81e2-30a51f433fbf", new DateTime(2024, 3, 13, 14, 39, 16, 113, DateTimeKind.Local).AddTicks(1239), "Human Resources", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_hr_jbc5jn.png" },
                    { "7f42b129-71be-4f06-8f44-a5c6910edc24", new DateTime(2024, 3, 13, 14, 39, 16, 113, DateTimeKind.Local).AddTicks(1315), "Energy, Water and Sewage, Utilities", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_energy_kznsrc.png" },
                    { "b26c0981-03b6-41ba-95c4-888ad219e718", new DateTime(2024, 3, 13, 14, 39, 16, 113, DateTimeKind.Local).AddTicks(1223), "Engineers and Technicians", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_engineer_wzjia1.png" },
                    { "b8dc5ad1-ff5f-4acf-b6c0-acda39b0026e", new DateTime(2024, 3, 13, 14, 39, 16, 113, DateTimeKind.Local).AddTicks(1325), "Telecommunications - engineers and technicians", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_telecoms_sbsq5u.png" },
                    { "c2f62778-5f6f-4117-b4a0-57356a45c143", new DateTime(2024, 3, 13, 14, 39, 16, 113, DateTimeKind.Local).AddTicks(1280), "Customer support", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_customersupport_fbvie5.png" },
                    { "c39aa039-e2af-4445-a9d6-0076cf11bd68", new DateTime(2024, 3, 13, 14, 39, 16, 113, DateTimeKind.Local).AddTicks(1344), "Security", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_security_c4fjq0.png" },
                    { "c575dcfd-9a45-4dd4-a2b2-35708ca9ea33", new DateTime(2024, 3, 13, 14, 39, 16, 113, DateTimeKind.Local).AddTicks(1305), "Office and Business activities", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_office_xkdjih.png" },
                    { "ca22d765-2bfb-4ca0-ac00-fb94a0759ee1", new DateTime(2024, 3, 13, 14, 39, 16, 113, DateTimeKind.Local).AddTicks(1338), "Education, Courses, Translators", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_education_kdsm7z.png" },
                    { "e28fe478-6b33-4e92-a7d1-09462f0847d3", new DateTime(2024, 3, 13, 14, 39, 16, 113, DateTimeKind.Local).AddTicks(1405), "Research and development", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824822/icon_research_mdrafi.png" },
                    { "e2bd38f7-11fa-476f-aaf7-79fa4fdcace8", new DateTime(2024, 3, 13, 14, 39, 16, 113, DateTimeKind.Local).AddTicks(1129), "Health and Pharmacy", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_health_nhktmm.png" },
                    { "e40120c1-e95a-477f-b53b-c486b518da2d", new DateTime(2024, 3, 13, 14, 39, 16, 113, DateTimeKind.Local).AddTicks(1216), "Restaurants, Bars, Hotels, Tourism", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824823/icon_restaurant_ee4ubg.png" },
                    { "e6c80278-8283-488c-ad9b-3b30530c1765", new DateTime(2024, 3, 13, 14, 39, 16, 113, DateTimeKind.Local).AddTicks(1371), "Aviation, Airport & Airline", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_airline_bgvmiu.png" },
                    { "fb4cb4f5-8c12-4108-8251-cdd80fcbe4f1", new DateTime(2024, 3, 13, 14, 39, 16, 113, DateTimeKind.Local).AddTicks(1260), "Media, Publishing", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_media_mpzkez.png" }
                });
        }
    }
}
