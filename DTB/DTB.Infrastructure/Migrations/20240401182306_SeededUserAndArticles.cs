﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DTB.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeededUserAndArticles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_AspNetUsers_AuthorId",
                table: "Articles");

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

            migrationBuilder.AlterColumn<string>(
                name: "AuthorId",
                table: "Articles",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ChatId", "ConcurrencyStamp", "Description", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cad23a9b-e215-45e8-823f-87207f8c2b71", 0, null, "b878ba5b-7b9e-4493-b0cb-3b996e126fce", null, "BaseUser", "test@abv.bg", false, false, null, null, "test@abv.bg", "6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b", null, false, null, "61073353-8935-46c9-9351-1bb57d8fc609", false, "test" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DateOfCreation", "Name", "PictureUrl" },
                values: new object[,]
                {
                    { "04b24fd7-7eb9-467a-9000-03b5ad0a4b63", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(1858), "Health and Pharmacy", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_health_nhktmm.png" },
                    { "0cd06519-87a4-43cd-ad98-628b2ac58931", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(1913), "Logistics, Spedition", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_logistic_ktvoqa.png" },
                    { "0ff496ae-42ed-4684-a0ca-b19445ecf696", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(2044), "Real-estate", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_realestate_dkhhfe.png" },
                    { "2b8af1a0-aae3-4410-9cf4-a180cf6daa0d", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(1809), "Architecture, Construction", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_architecture_gqdlbl.png" },
                    { "301c410c-1891-4fb3-9e17-40f1963f7fff", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(1945), "Energy, Water and Sewage, Utilities", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_energy_kznsrc.png" },
                    { "3d4e0875-c049-46cf-9558-187c3331128a", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(2087), "Accouting, Audit, Finance", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_finance_r5bftt.png" },
                    { "4e2c02fe-c17c-4af0-aa13-2c6779ebaf9d", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(2080), "Research and development", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824822/icon_research_mdrafi.png" },
                    { "4f58a38d-e569-4468-9389-ec92bbe2c68e", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(2075), "Technical Support", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_techsupport_zph0mx.png" },
                    { "64c4f882-97b2-43d5-8bb9-c376ecb90c7f", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(1894), "Media, Publishing", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_media_mpzkez.png" },
                    { "8a1b162d-9149-4eb5-a9d3-4fd0e38cd9fc", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(1956), "Education, Courses, Translators", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_education_kdsm7z.png" },
                    { "9b305282-62ee-4f8d-8165-cd92964eaf27", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(1931), "Banking, Lending, Insurance", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_banking_dkgjma.png" },
                    { "a71cd58d-d2c5-431f-aa59-c1dab12f5b19", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(1949), "Telecommunications - engineers and technicians", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_telecoms_sbsq5u.png" },
                    { "ab54d1df-fcb7-4c0b-aa86-49243cb6d01a", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(1890), "Human Resources", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_hr_jbc5jn.png" },
                    { "b5243015-2dab-45d1-8a02-5fe94b6062e6", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(1921), "Customer support", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_customersupport_fbvie5.png" },
                    { "bd5d90bb-b45d-43da-b2a5-18cbde65bfa0", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(2058), "Aviation, Airport & Airline", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_airline_bgvmiu.png" },
                    { "bfdb2926-c5bb-48c2-a12d-a5cfb26341a0", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(1938), "Marketing, Advertising, PR", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_hr_jbc5jn.png" },
                    { "c17146a6-57da-45c3-b0a4-da36a808eba3", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(2036), "Security", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_security_c4fjq0.png" },
                    { "c66f545c-cbd7-4114-b597-07e68499752e", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(2064), "Auto Service", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824819/icon_autoservice_iabxkj.png" },
                    { "c7667ab7-bda4-45bc-bb2a-19e2b26d1cdb", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(1866), "Drivers, Couriers", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_derivers_q8g7p3.png" },
                    { "d8441c32-1802-47dc-a8e6-6b84af9f6659", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(1873), "Restaurants, Bars, Hotels, Tourism", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824823/icon_restaurant_ee4ubg.png" },
                    { "e418d12e-1c3a-4b1b-b85b-075293e9d4ab", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(1942), "Office and Business activities", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_office_xkdjih.png" },
                    { "ee96eae7-1329-4b35-b106-ee288a5f166a", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(1880), "Engineers and Technicians", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_engineer_wzjia1.png" },
                    { "eea01812-80ac-420d-889a-bc3ab7f4b971", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(2052), "Legal", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_legal_ofzofx.png" },
                    { "ef399db7-7cbb-48d0-ab6e-83bce469ea69", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(2069), "Retail, Wholesale", "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824824/icon_retail_pgicm9.png" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "27ce8666-68da-4d5d-b9ff-57200d834b43", "Dimitrovgrad" },
                    { "4c5a78cf-c46a-4477-af2e-2aca3e4aedbf", "Varna" },
                    { "5a86c519-6db7-45dc-bac4-461a1b755a31", "Yambol" },
                    { "5c88844b-b9d8-46f2-b95f-d9199b8e943d", "Sofia" },
                    { "77de2f0e-77c4-4562-a764-b1c54eb2b8bc", "Plovdiv" },
                    { "7fdc6a54-eea8-4595-bd19-d177b1f26387", "Sliven" },
                    { "bc12c9b1-9cea-4657-a89f-ca34f1d6b06e", "Blagoevgrad" },
                    { "e39c6f15-369c-4b7e-92de-5a33d25b099c", "Burgas" },
                    { "f277a479-6540-49b6-ad30-edf9e7a7f40e", "Elhovo" },
                    { "fd9de968-d08b-458c-9847-f72769761678", "Ruse" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "AuthorId", "Content", "DateOfCreation", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { "12c2dc5a-74e5-43b1-978e-462562a357b1", "cad23a9b-e215-45e8-823f-87207f8c2b71", "In the wake of the COVID-19 pandemic, the traditional office-centric model of work has undergone a seismic shift. Remote work has become the new norm for many organizations, accelerating the adoption of digital technologies and fundamentally reshaping the way we approach talent acquisition. In this article, we'll explore strategies for navigating the digital talent landscape and effectively hiring in a remote-first world.:\r\nEmbrace Remote Work as the New Reality::\r\n\r\n\r\n\r\nThe first step in adapting to the remote-first world is to embrace it as the new reality. Recognize that remote work offers numerous benefits, including access to a broader talent pool, increased flexibility for employees, and reduced overhead costs for organizations. By embracing remote work, companies can tap into a diverse range of talent from around the globe and leverage digital tools to facilitate seamless collaboration across distributed teams.\r\nLeverage Digital Platforms for Recruitment:\r\n\r\n\r\n\r\nIn a remote-first world, traditional recruitment methods such as in-person interviews and job fairs may no longer be feasible. Instead, organizations must leverage digital platforms and technologies to connect with and attract top talent. This may include utilizing online job boards, social media platforms, and professional networking sites to advertise job openings and engage with potential candidates. Additionally, consider leveraging video interviewing platforms and virtual recruitment events to conduct remote interviews and assess candidates' skills and fit for the role.\r\nPrioritize Communication and Collaboration:\r\n\r\n\r\n\r\nEffective communication and collaboration are essential for success in a remote work environment. When hiring for remote positions, prioritize candidates who demonstrate strong communication skills, self-motivation, and the ability to work independently. Additionally, ensure that your organization has robust communication tools and practices in place to facilitate seamless collaboration among remote teams. This may include utilizing messaging apps, video conferencing software, and project management tools to keep teams connected and aligned.\r\nFocus on Results and Outcomes:\r\n\r\n\r\n\r\nIn a remote-first world, it's essential to focus on results and outcomes rather than hours worked or physical presence. When evaluating candidates, prioritize those who have a track record of delivering results in a remote or distributed work environment. Look for candidates who are self-directed, results-oriented, and able to thrive in a virtual setting. Additionally, consider implementing performance metrics and goals that emphasize outcomes rather than activities, empowering employees to focus on achieving measurable results regardless of their physical location.\r\nProvide Support and Resources for Remote Employees:\r\n\r\n\r\n\r\nRemote work can present unique challenges for employees, including feelings of isolation, difficulty maintaining work-life balance, and technological barriers. To support remote employees and ensure their success, provide access to resources and support services tailored to their needs. This may include offering remote onboarding and training programs, providing access to remote work tools and technology, and fostering a culture of inclusivity and support for remote employees.\r\nConclusion\r\n\r\n\r\n\r\nINavigating the digital talent landscape requires a shift in mindset and approach to hiring in a remote-first world. By embracing remote work as the new reality, leveraging digital platforms for recruitment, prioritizing communication and collaboration, focusing on results and outcomes, and providing support and resources for remote employees, organizations can effectively navigate the challenges and opportunities of hiring in a remote-first world. By embracing these strategies, companies can build diverse, high-performing teams that drive innovation and success in the digital age.\r\n\r\n\r\n\r\n\r\nMilena Koleva is a seasoned HR professional with a passion for talent acquisition and organizational development. With a focus on leveraging digital technologies and remote work strategies, Milena helps organizations navigate the complexities of hiring in a remote-first world. Through her expertise and dedication, Milena empowers companies to build diverse, resilient teams that thrive in today's digital landscape.\r\n", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(2477), "https://res.cloudinary.com/dftfu5p0r/image/upload/v1711995437/remoteworking_o1rphp.jpg", "Navigating The Digital Talent Landscape: Strategies For Hiring In A Remote-First World" },
                    { "1eb518cf-4d21-426a-9c37-cb48e8fe5ffb", "cad23a9b-e215-45e8-823f-87207f8c2b71", "In today's rapidly evolving global landscape, fostering diversity and inclusion (D&I) in the workplace is not just a moral imperative; it's also a strategic advantage. Companies that embrace diversity and inclusion tend to be more innovative, productive, and resilient. However, achieving true diversity and inclusion requires a concerted effort, particularly in the hiring process, where biases can often inadvertently creep in. In this article, we'll explore some best practices for navigating diversity and inclusion in hiring to build a truly inclusive workforce.\r\n1. Foster a Culture of Inclusion from the Top Down:\r\n\r\n\r\n\r\nTLeadership plays a crucial role in shaping organizational culture. It's essential for top executives and managers to actively champion diversity and inclusion initiatives and lead by example. When leaders prioritize D&I efforts, it sends a clear message throughout the organization that diversity is valued and integral to the company's success.\r\n2. Implement Unbiased Hiring Practices:\r\n\r\n\r\n\r\nUnconscious biases can influence hiring decisions, leading to homogeneity rather than diversity in the workforce. To combat this, companies should implement strategies to mitigate bias in the hiring process. This may include using structured interviews, blind resume reviews, diverse hiring panels, and standardized evaluation criteria to ensure that candidates are assessed based on their skills, qualifications, and potential rather than extraneous factors.\r\n3. Expand Outreach and Recruitment Efforts:\r\n\r\n\r\n\r\nTo attract diverse talent pools, companies should broaden their outreach and recruitment efforts. This may involve partnering with organizations that specialize in diverse talent pipelines, attending job fairs and networking events targeted at underrepresented groups, and leveraging social media platforms to reach a diverse audience. Additionally, creating inclusive job descriptions and ensuring that job postings are accessible to all can help attract a more diverse applicant pool.\r\n4. Provide Diversity and Inclusion Training:\r\n\r\n\r\n\r\nOffering training on diversity and inclusion to hiring managers and employees can increase awareness of unconscious biases and promote inclusive behaviors. Training sessions can cover topics such as cultural competency, empathy, inclusive language, and strategies for creating equitable opportunities for all candidates. By investing in education and awareness-building, companies can foster a more inclusive hiring environment.\r\n5. Prioritize Diversity in Talent Acquisition:\r\n\r\n\r\n\r\nMake diversity and inclusion integral components of your talent acquisition strategy. Set specific diversity goals and metrics to track progress over time. Establishing accountability mechanisms and regularly reviewing hiring practices and outcomes can help ensure that diversity and inclusion remain top priorities throughout the recruitment process.\r\n6. Create a Supportive Onboarding Experience:\r\n\r\n\r\n\r\nOnce diverse candidates are hired, it's crucial to provide them with a supportive onboarding experience. This includes offering mentorship programs, affinity groups, and cultural integration initiatives to help new hires feel welcomed and valued within the organization. By fostering a sense of belonging from the outset, companies can improve retention rates and cultivate a more diverse and inclusive workplace culture.\r\nConclusion\r\n\r\n\r\n\r\nBuilding a diverse and inclusive workforce requires a multifaceted approach that starts with the hiring process. By fostering a culture of inclusion, implementing unbiased hiring practices, expanding outreach efforts, providing training, prioritizing diversity in talent acquisition, and creating a supportive onboarding experience, companies can attract and retain diverse talent that drives innovation and success. Embracing diversity and inclusion isn't just the right thing to do—it's also a strategic imperative for building stronger, more resilient organizations in today's interconnected world.\r\n\r\n\r\n\r\n\r\nMaria Dimitrova is a dedicated advocate for diversity and inclusion (D&I) in the workplace, with a passion for fostering inclusive environments where every individual feels valued and empowered to thrive. With a background in human resources and talent management, Maria has extensive experience navigating the complexities of diversity and inclusion in hiring processes and organizational culture.\r\n", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(2460), "https://res.cloudinary.com/dftfu5p0r/image/upload/v1711995437/property-03_ednnld.png", "Navigating Diversity And Inclusion In Hiring: Best Practices For Building An Inclusive Workforce" },
                    { "6bafd97b-04dd-4557-b6e7-d9a377270fa1", "cad23a9b-e215-45e8-823f-87207f8c2b71", "In the dynamic landscape of modern workplaces, diversity and inclusion (D&I) have emerged as critical components of organizational success. Beyond just fulfilling ethical obligations, companies that prioritize D&I enjoy a myriad of benefits, including enhanced innovation, stronger employee engagement, and improved financial performance. However, achieving a truly diverse and inclusive workforce requires deliberate efforts at every stage of the employee lifecycle, from recruitment to retention. In this article, we'll explore some best practices for both recruitment and retention that can help organizations build and maintain a diverse and inclusive workforce.\r\nRecruitment Best Practices:\r\n\r\n\r\n\r\n1. Expand Outreach Efforts: To attract a diverse pool of candidates, it's crucial to broaden recruitment efforts beyond traditional channels. This may involve collaborating with diversity-focused organizations, attending events tailored to underrepresented groups, and utilizing targeted advertising on social media platforms. By proactively seeking out diverse talent, organizations can ensure a more inclusive recruitment process.\r\n2. Review Job Descriptions: Job descriptions should be crafted with inclusivity in mind. Avoid using biased language or requirements that may unintentionally deter certain candidates. Focus on the essential skills and qualifications needed for the role, rather than unnecessary criteria that may exclude qualified candidates from diverse backgrounds.\r\n3.Implement Blind Screening: Unconscious biases can influence hiring decisions, even unintentionally. Implementing blind screening processes, where personal information such as name, gender, and ethnicity is removed from resumes during the initial review, can help mitigate bias and ensure fair evaluation based solely on qualifications and experience.\r\n4. Diverse Interview Panels: Including diverse perspectives in the interview process is essential for promoting inclusivity. Consider assembling interview panels that reflect the diversity of your workforce and the broader community. This can help mitigate biases and ensure that candidates are evaluated fairly.\r\nRetention Best Practices:\r\n\r\n\r\n\r\n1. Promote Inclusive Culture: Creating a culture of inclusivity starts from the top. Leaders should actively champion D&I initiatives and foster an environment where all employees feel valued and respected. Encourage open dialogue, celebrate diversity, and address any instances of discrimination or bias promptly and effectively.\r\n2. Offer Development Opportunities: Provide opportunities for professional development and career advancement for all employees. Offer mentorship programs, training workshops, and leadership development initiatives that support the growth and progression of diverse talent within the organization.\r\n3.Establish Support Networks: Employee resource groups (ERGs) can provide a valuable support network for employees from underrepresented backgrounds. Encourage the formation of ERGs based on common identities or interests and provide resources and support to help them thrive.\r\n4. Regularly Review Policies: Periodically review HR policies and practices to ensure they are inclusive and equitable. Solicit feedback from employees and make necessary adjustments to address any gaps or areas for improvement.\r\nConclusion\r\n\r\n\r\n\r\nBuilding a diverse and inclusive workforce is not only the right thing to do—it's also a strategic imperative for organizations seeking to thrive in today's global marketplace. By implementing best practices for recruitment and retention, organizations can create environments where every individual feels valued, respected, and empowered to contribute their unique perspectives and talents. Through intentional efforts and proactive strategies, we can build a more equitable and inclusive future where diversity is celebrated and embraced as a source of strength and innovation.\r\n\r\n\r\n\r\n\r\nNikolai Ivanov is a seasoned HR professional with a deep commitment to building diverse and inclusive workplaces. With a wealth of experience in recruitment, talent development, and organizational culture, Nikolai understands the importance of creating environments where every individual feels valued, respected, and empowered to contribute their unique perspectives and talents.\r\n", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(2483), "https://res.cloudinary.com/dftfu5p0r/image/upload/v1711995700/article6_yhytju.jpg", "Building A Diverse And Inclusive Workforce: Best Practices For Recruitment And Retention" },
                    { "7c81bc5e-37c5-48df-a215-acd9a2c97e59", "cad23a9b-e215-45e8-823f-87207f8c2b71", "In today's competitive job market, finding top talent is more challenging than ever. With companies vying for the same pool of qualified candidates, mastering the art of candidate sourcing has become essential for recruitment success. Effective sourcing strategies not only help in attracting the right candidates but also ensure a streamlined and efficient hiring process. Here are some key strategies to consider when sourcing candidates:\r\n1. Utilize Multiple Sourcing Channels:\r\n\r\n\r\n\r\nGone are the days when job postings on a single platform were sufficient to attract qualified candidates. Today, recruiters must leverage a variety of sourcing channels to reach a diverse pool of talent. This includes job boards, social media platforms, professional networking sites, industry-specific forums, and even employee referrals. By casting a wide net across different channels, recruiters can increase their chances of finding the ideal candidate.\r\n2. Implement Advanced Search Techniques:\r\n\r\n\r\n\r\nWith the abundance of information available online, recruiters can use advanced search techniques to narrow down their candidate search. Boolean search strings, for example, allow recruiters to combine keywords and phrases to find candidates with specific skills and experience. Moreover, utilizing filters and advanced search options on job boards and professional networking sites can further refine the candidate pool based on location, experience level, education, and other criteria.\r\n3. Build and Nurture Talent Pipelines:\r\n\r\n\r\n\r\nBuilding a talent pipeline involves proactively sourcing and engaging with potential candidates, even if there are no immediate job openings. By continuously networking and maintaining relationships with passive candidates, recruiters can create a pool of qualified individuals who can be tapped into when relevant opportunities arise. This not only reduces time-to-hire but also ensures a steady stream of talent for future hiring needs.\r\n4. Develop Employer Branding Initiatives:\r\n\r\n\r\n\r\nA strong employer brand can significantly impact an organization's ability to attract top talent. Therefore, it's essential to invest in employer branding initiatives that showcase the company culture, values, and opportunities for growth. This can include creating engaging content for social media, highlighting employee testimonials and success stories, and actively participating in industry events and networking activities. A positive employer brand not only attracts candidates but also helps in retaining and engaging existing employees.\r\n5. Leverage Technology and Automation:\r\n\r\n\r\n\r\nIn today's digital age, technology plays a crucial role in candidate sourcing and recruitment. Recruiters can leverage Applicant Tracking Systems (ATS), AI-powered sourcing tools, and automation software to streamline the sourcing process, manage candidate pipelines, and analyze data for insights. These technologies not only save time and effort but also enable recruiters to identify and engage with candidates more effectively.\r\n6. Foster Diversity and Inclusion:\r\n\r\n\r\n\r\nDiversity and inclusion should be integral components of any candidate sourcing strategy. Actively seeking out candidates from diverse backgrounds not only enhances creativity and innovation within the organization but also reflects a commitment to creating an inclusive workplace culture. Recruiters should proactively reach out to underrepresented groups, participate in diversity-focused events and initiatives, and ensure that job postings are inclusive and free from bias.\r\n7. Measure and Optimize Performance:\r\n\r\n\r\n\r\nContinuous improvement is key to success in candidate sourcing. Recruiters should regularly monitor and measure the performance of their sourcing efforts, analyzing metrics such as time-to-fill, cost-per-hire, and quality-of-hire. By identifying areas for improvement and optimizing sourcing strategies based on data-driven insights, recruiters can enhance their effectiveness and achieve better recruitment outcomes over time.\r\nConclusion\r\n\r\n\r\n\r\nIn conclusion, mastering the art of candidate sourcing requires a combination of creativity, strategic thinking, and leveraging the right tools and techniques. By adopting a multi-channel approach, utilizing advanced search techniques, building talent pipelines, investing in employer branding, leveraging technology, fostering diversity and inclusion, and continuously measuring and optimizing performance, recruiters can enhance their recruitment success and attract top alent to their organizations.\r\n\r\n\r\n\r\n\r\nGeorgi Ivanov is a seasoned HR professional with over a decade of experience in talent acquisition and recruitment strategy. He is passionate about helping organizations build high-performing teams through effective sourcing and talent management practices.\r\n", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(2467), "https://res.cloudinary.com/dftfu5p0r/image/upload/v1711995437/property-06_fkugqv.png", "Mastering The Art Of Candidate Sourcing: Effective Strategies For Recruitment Success" },
                    { "a2363fe6-5885-4af6-b16a-77607408f90b", "cad23a9b-e215-45e8-823f-87207f8c2b71", "In the dynamic landscape of today's job market, success isn't just about possessing the right qualifications or technical skills; it's about embodying a unique set of traits that set top performers apart from the rest. Whether you're a seasoned professional or a recent graduate, understanding and cultivating these essential traits can be the key to unlocking your full potential and achieving success in your career. Let's explore some of the fundamental traits that top performers exhibit in today's competitive job market.\r\n1. Adaptability and Resilience:\r\n\r\n\r\n\r\nIn a rapidly evolving work environment, adaptability is paramount. Top performers demonstrate the ability to quickly adjust to changes, whether it's new technology, shifting priorities, or unforeseen challenges. They approach setbacks as opportunities for growth and bounce back from adversity with resilience, maintaining a positive attitude and a forward-thinking mindset.\r\n2. Continuous Learning and Growth:\r\n\r\n\r\n\r\nThe pursuit of knowledge and personal development is a hallmark of top performers. They understand that learning doesn't end with formal education but is an ongoing process. Whether through formal training programs, self-study, or seeking mentorship, they are committed to expanding their skills and expertise to stay ahead of the curve in their respective fields.\r\n3. Strong Communication Skills:\r\n\r\n\r\n\r\nEffective communication is essential for success in any role. Top performers excel not only in articulating their ideas clearly but also in listening actively and empathetically. They can communicate across various mediums and tailor their message to different audiences, fostering collaboration and building strong relationships with colleagues, clients, and stakeholders.\r\n4. Proactive Problem-Solving Abilities:\r\n\r\n\r\n\r\nTop performers possess strong problem-solving skills and a proactive approach to tackling challenges. Rather than waiting for problems to arise, they anticipate potential issues and take preemptive action to address them. They analyze situations critically, think creatively, and implement innovative solutions, demonstrating resourcefulness and initiative in their work.\r\n5. Emotional Intelligence and Empathy:\r\n\r\n\r\n\r\nEmotional intelligence, including self-awareness, self-regulation, social awareness, and relationship management, is a critical trait of top performers. They understand their own emotions and motivations, allowing them to navigate complex interpersonal dynamics effectively. Moreover, they demonstrate empathy and understanding towards others, fostering a positive work environment and building trust and rapport with colleagues.\r\n6. Goal-Oriented and Results-Driven:\r\n\r\n\r\n\r\nTop performers are driven by a strong sense of purpose and are laser-focused on achieving their goals. They set ambitious yet achievable objectives, develop actionable plans to attain them, and consistently track their progress. They are outcome-oriented, measuring success not only by their individual achievements but also by their contributions to the overall success of their team and organization.\r\n7. Adaptability to Remote Work and Digital Skills:\r\n\r\n\r\n\r\nIn the wake of the COVID-19 pandemic, remote work has become increasingly prevalent. Top performers exhibit adaptability to this new work model, leveraging technology to collaborate effectively, stay organized, and maintain productivity. They are proficient in digital tools and platforms relevant to their roles, allowing them to thrive in virtual environments and stay connected with their teams and clients.\r\nConclusion\r\n\r\n\r\n\r\nIn conclusion, success in today's job market requires more than just technical expertise; it demands a diverse range of essential traits that enable individuals to navigate challenges, seize opportunities, and excel in their careers. By cultivating adaptability, continuous learning, strong communication, proactive problem-solving, emotional intelligence, goal orientation, and adaptability to remote work, individuals can position themselves as top performers in their respective fields, unlocking their full potential and achieving lasting success in today's dynamic work landscape.\r\n\r\n\r\n\r\n\r\nDimitar Genov is a seasoned professional with extensive experience in talent development and organizational leadership. He is passionate about empowering individuals to unleash their full potential and thrive in today's competitive job market.\r\n", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(2472), "https://res.cloudinary.com/dftfu5p0r/image/upload/v1711995451/unlockingsuccess_nhuhe2.jpg", "Unlocking Success: The Essential Traits Of Top Performers In Today's Job Market\r\n" },
                    { "ac8bea30-f027-4e6b-94b5-4dedc5ebe704", "cad23a9b-e215-45e8-823f-87207f8c2b71", "In the ever-evolving landscape of recruitment, the integration of technology has proven to be a game-changer. Gone are the days of sifting through stacks of resumes or conducting endless rounds of interviews. Today, forward-thinking companies are embracing innovative technological solutions to streamline their hiring processes and find t he best talent efficiently.\r\nThe Traditional Hiring Conundrum\r\n\r\n\r\n\r\nTraditional recruitment methods often posed significant challenges for both employers and candidates alike. Employers grappled with time-consuming tasks such as manually reviewing resumes, scheduling interviews, and coordinating feedback among hiring teams. On the other hand, candidates faced lengthy application processes and prolonged wait times for responses, leading to frustration and disengagement.\r\nThe Rise of Technological Solutions\r\n\r\n\r\n\r\nATS platforms have become indispensable tools for modern recruiters. These systems automate the process of collecting, sorting, and managing applicant data, allowing recruiters to streamline their workflow and focus on engaging with top candidates. ATS platforms also offer features such as resume parsing, candidate scoring, and automated communication, enabling recruiters to identify the most qualified candidates efficiently.\r\nApplicant Tracking Systems (ATS)\r\n\r\n\r\n\r\nRecognizing the need for a more efficient approach, recruitment professionals turned to technology to revolutionize the hiring process. From applicant tracking systems (ATS) to artificial intelligence (AI)-powered tools, a myriad of solutions emerged to address the pain points of traditional recruitment methods.\r\nAI-Powered Recruitment Tools\r\n\r\n\r\n\r\nArtificial intelligence has transformed the recruitment landscape by offering advanced capabilities for candidate sourcing, screening, and assessment. AI-powered tools leverage machine learning algorithms to analyze vast amounts of data and identify patterns that match candidates with job requirements. These tools can source candidates from various channels, assess their skills and qualifications, and even predict their likelihood of success in specific roles. By harnessing the power of AI, recruiters can significantly reduce time-to-hire, improve candidate quality, and make more data-driven hiring decisions.\r\nVideo Interviewing Platforms\r\n\r\n\r\n\r\nWith the rise of remote work and distributed teams, video interviewing platforms have gained popularity as an essential tool for modern recruitment. These platforms enable recruiters to conduct virtual interviews with candidates from anywhere in the world, eliminating the need for costly and time-consuming travel. Video interviews also offer additional benefits such as asynchronous interviewing, interview recording, and integration with other recruitment software, making the hiring process more efficient and flexible for both recruiters and candidates.\r\nThe Future of Recruitment\r\n\r\n\r\n\r\nAs technology continues to evolve, the future of recruitment holds immense promise for further innovation. Emerging technologies such as augmented reality (AR), virtual reality (VR), and predictive analytics are poised to reshape the recruitment landscape in unprecedented ways. These technologies offer exciting possibilities for immersive candidate experiences, data-driven decision-making, and predictive talent analytics, paving the way for a more efficient, inclusive, and transparent recruitment process.\r\nConclusion\r\n\r\n\r\n\r\nIn the fast-paced world of recruitment, staying ahead of the curve is essential for attracting top talent and driving organizational success. By embracing technology and leveraging innovative solutions, recruiters can revolutionize the hiring process, streamline workflows, and make more informed decisions. As we continue to harness the power of technology, the future of recruitment is brighter than ever, offering boundless opportunities for companies to build diverse, high-performing teams that drive innovation and growth.\r\n\r\n\r\n\r\n\r\nIvan Petrov is a visionary leader in the field of recruitment, with a passion for leveraging technology to drive innovation and efficiency in the hiring process. With years of experience in talent acquisition and human resources, Ivan has witnessed firsthand the challenges faced by both employers and candidates in traditional recruitment methods. Motivated by a desire to revolutionize the industry, Ivan has dedicated his career to exploring and implementing cutting-edge technological solutions that transform the way companies identify and attract top talent.\r\n", new DateTime(2024, 4, 1, 21, 23, 4, 851, DateTimeKind.Local).AddTicks(2454), "https://res.cloudinary.com/dftfu5p0r/image/upload/v1711995437/property-01_mkg5z5.jpg", "Revolutionizing Recruitment: Leveraging Technology To Streamline The Hiring Process" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_AspNetUsers_AuthorId",
                table: "Articles",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_AspNetUsers_AuthorId",
                table: "Articles");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: "12c2dc5a-74e5-43b1-978e-462562a357b1");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: "1eb518cf-4d21-426a-9c37-cb48e8fe5ffb");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: "6bafd97b-04dd-4557-b6e7-d9a377270fa1");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: "7c81bc5e-37c5-48df-a215-acd9a2c97e59");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: "a2363fe6-5885-4af6-b16a-77607408f90b");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: "ac8bea30-f027-4e6b-94b5-4dedc5ebe704");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "04b24fd7-7eb9-467a-9000-03b5ad0a4b63");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "0cd06519-87a4-43cd-ad98-628b2ac58931");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "0ff496ae-42ed-4684-a0ca-b19445ecf696");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "2b8af1a0-aae3-4410-9cf4-a180cf6daa0d");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "301c410c-1891-4fb3-9e17-40f1963f7fff");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "3d4e0875-c049-46cf-9558-187c3331128a");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "4e2c02fe-c17c-4af0-aa13-2c6779ebaf9d");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "4f58a38d-e569-4468-9389-ec92bbe2c68e");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "64c4f882-97b2-43d5-8bb9-c376ecb90c7f");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "8a1b162d-9149-4eb5-a9d3-4fd0e38cd9fc");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "9b305282-62ee-4f8d-8165-cd92964eaf27");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "a71cd58d-d2c5-431f-aa59-c1dab12f5b19");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "ab54d1df-fcb7-4c0b-aa86-49243cb6d01a");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "b5243015-2dab-45d1-8a02-5fe94b6062e6");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "bd5d90bb-b45d-43da-b2a5-18cbde65bfa0");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "bfdb2926-c5bb-48c2-a12d-a5cfb26341a0");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "c17146a6-57da-45c3-b0a4-da36a808eba3");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "c66f545c-cbd7-4114-b597-07e68499752e");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "c7667ab7-bda4-45bc-bb2a-19e2b26d1cdb");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "d8441c32-1802-47dc-a8e6-6b84af9f6659");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "e418d12e-1c3a-4b1b-b85b-075293e9d4ab");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "ee96eae7-1329-4b35-b106-ee288a5f166a");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "eea01812-80ac-420d-889a-bc3ab7f4b971");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "ef399db7-7cbb-48d0-ab6e-83bce469ea69");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "27ce8666-68da-4d5d-b9ff-57200d834b43");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "4c5a78cf-c46a-4477-af2e-2aca3e4aedbf");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "5a86c519-6db7-45dc-bac4-461a1b755a31");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "5c88844b-b9d8-46f2-b95f-d9199b8e943d");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "77de2f0e-77c4-4562-a764-b1c54eb2b8bc");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "7fdc6a54-eea8-4595-bd19-d177b1f26387");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "bc12c9b1-9cea-4657-a89f-ca34f1d6b06e");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "e39c6f15-369c-4b7e-92de-5a33d25b099c");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "f277a479-6540-49b6-ad30-edf9e7a7f40e");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "fd9de968-d08b-458c-9847-f72769761678");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cad23a9b-e215-45e8-823f-87207f8c2b71");

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

            migrationBuilder.AlterColumn<string>(
                name: "AuthorId",
                table: "Articles",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_AspNetUsers_AuthorId",
                table: "Articles",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}