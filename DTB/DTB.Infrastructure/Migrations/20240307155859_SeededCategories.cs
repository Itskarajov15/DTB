using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DTB.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeededCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
