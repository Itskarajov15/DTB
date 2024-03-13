using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DTB.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangedCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "0fec5bab-498e-4546-81f5-96fc75f21146");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "1354fee4-1827-4ec9-9177-2ae0c76e56bc");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "137d3b1a-c398-42d8-96ef-715045f09e86");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "20447446-67f0-4fb7-b94c-abc0df8a4139");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "2a780e7b-4765-4708-a1a2-48e2309259db");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "4584bcdc-6436-4f59-8d7e-622aacad8f04");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "46c8d38c-bf64-4c60-919b-ed0c960db518");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "4dfbb10a-2449-4ed5-a42e-75a96d45a3da");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "59610d91-2264-4050-ac38-f10e159b1be2");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "5e0e1d81-995f-4411-9907-20b8ca4f405a");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "6566fd3f-95bf-4fc6-bb38-dd82b49307ca");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "74ade804-4765-42b0-a97f-c85a8da13fb3");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "76637dc2-ac18-412b-9173-2938cf786dc9");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "87c4df22-bb76-402b-ad19-d5fddfdbac52");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "a32435f5-2115-4982-ad00-506dd7a5c202");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "a539eeb0-2c29-4828-a53d-d8dabeeb0d85");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "b4675cc5-8cc8-4b15-9720-75e0bbd94954");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "b49f54ac-a2f4-41e4-a077-76b52e8112d7");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "ba1aa67f-6954-4ea1-b83c-1bb507fccb6a");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "d9fed1c6-a63e-4dce-aace-70b902318f9b");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "e7fbd8d3-2c3c-4f8a-8c43-1bf85fc08761");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "fafc997c-f069-4d6a-9137-25f580d53576");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "fc3e7a69-7fae-41e7-901c-2e4053f0047b");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "fe95392f-f076-4b3d-9bee-9ae541e2116f");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfCreation",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "DateOfCreation",
                table: "Categories");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "PictureUrl" },
                values: new object[,]
                {
                    { "0fec5bab-498e-4546-81f5-96fc75f21146", "Media, Publishing", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_media_mpzkez.png" },
                    { "1354fee4-1827-4ec9-9177-2ae0c76e56bc", "Research and development", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824822/icon_research_mdrafi.png" },
                    { "137d3b1a-c398-42d8-96ef-715045f09e86", "Auto Service", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824819/icon_autoservice_iabxkj.png" },
                    { "20447446-67f0-4fb7-b94c-abc0df8a4139", "Health and Pharmacy", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_health_nhktmm.png" },
                    { "2a780e7b-4765-4708-a1a2-48e2309259db", "Banking, Lending, Insurance", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_banking_dkgjma.png" },
                    { "4584bcdc-6436-4f59-8d7e-622aacad8f04", "Human Resources", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_hr_jbc5jn.png" },
                    { "46c8d38c-bf64-4c60-919b-ed0c960db518", "Office and Business activities", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_office_xkdjih.png" },
                    { "4dfbb10a-2449-4ed5-a42e-75a96d45a3da", "Real-estate", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_realestate_dkhhfe.png" },
                    { "59610d91-2264-4050-ac38-f10e159b1be2", "Security", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_security_c4fjq0.png" },
                    { "5e0e1d81-995f-4411-9907-20b8ca4f405a", "Restaurants, Bars, Hotels, Tourism", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824823/icon_restaurant_ee4ubg.png" },
                    { "6566fd3f-95bf-4fc6-bb38-dd82b49307ca", "Aviation, Airport & Airline", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_airline_bgvmiu.png" },
                    { "74ade804-4765-42b0-a97f-c85a8da13fb3", "Energy, Water and Sewage, Utilities", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_energy_kznsrc.png" },
                    { "76637dc2-ac18-412b-9173-2938cf786dc9", "Telecommunications - engineers and technicians", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_telecoms_sbsq5u.png" },
                    { "87c4df22-bb76-402b-ad19-d5fddfdbac52", "Customer support", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_customersupport_fbvie5.png" },
                    { "a32435f5-2115-4982-ad00-506dd7a5c202", "Engineers and Technicians", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_engineer_wzjia1.png" },
                    { "a539eeb0-2c29-4828-a53d-d8dabeeb0d85", "Education, Courses, Translators", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_education_kdsm7z.png" },
                    { "b4675cc5-8cc8-4b15-9720-75e0bbd94954", "Architecture, Construction", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_architecture_gqdlbl.png" },
                    { "b49f54ac-a2f4-41e4-a077-76b52e8112d7", "Marketing, Advertising, PR", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_hr_jbc5jn.png" },
                    { "ba1aa67f-6954-4ea1-b83c-1bb507fccb6a", "Legal", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_legal_ofzofx.png" },
                    { "d9fed1c6-a63e-4dce-aace-70b902318f9b", "Logistics, Spedition", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_logistic_ktvoqa.png" },
                    { "e7fbd8d3-2c3c-4f8a-8c43-1bf85fc08761", "Accouting, Audit, Finance", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_finance_r5bftt.png" },
                    { "fafc997c-f069-4d6a-9137-25f580d53576", "Technical Support", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_techsupport_zph0mx.png" },
                    { "fc3e7a69-7fae-41e7-901c-2e4053f0047b", "Drivers, Couriers", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_derivers_q8g7p3.png" },
                    { "fe95392f-f076-4b3d-9bee-9ae541e2116f", "Retail, Wholesale", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824824/icon_retail_pgicm9.png" }
                });
        }
    }
}
