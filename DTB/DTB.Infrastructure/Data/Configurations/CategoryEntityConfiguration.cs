using DTB.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DTB.Infrastructure.Data.Configurations
{
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new List<Category>
                {
                    new Category
                    {
                        Id = "80bb3283-c810-4b9c-9d42-da03e17b2ddf",
                        Name = "Architecture, Construction",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_architecture_gqdlbl.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = "a732a432-ef4f-4407-9dba-71f904d0ea6e",
                        Name = "Health and Pharmacy",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_health_nhktmm.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = "b89927d7-b1fd-4703-98df-a4681ce2db88",
                        Name = "Drivers, Couriers",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_derivers_q8g7p3.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = "07a32cf2-3c7a-4ab0-ab70-9952c0966f30",
                        Name = "Restaurants, Bars, Hotels, Tourism",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824823/icon_restaurant_ee4ubg.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = "38b5eb73-7829-497b-a207-9bcf3fef3b1b",
                        Name = "Engineers and Technicians",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_engineer_wzjia1.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = "438c1389-c017-43b8-a34a-46b8c64f5e1d",
                        Name = "Human Resources",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_hr_jbc5jn.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = "3c1fda93-5ef8-4db2-97f7-25f163fbca67",
                        Name = "Media, Publishing",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_media_mpzkez.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = "c4dd9eea-1569-402f-a5b8-8473f48437a1",
                        Name = "Logistics, Spedition",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_logistic_ktvoqa.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = "c468efd1-09cf-4e6c-9245-2e837e500968",
                        Name = "Customer support",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_customersupport_fbvie5.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = "ff13d479-760d-4387-8843-c882ad150609",
                        Name = "Banking, Lending, Insurance",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_banking_dkgjma.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb",
                        Name = "Marketing, Advertising, PR",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_hr_jbc5jn.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = "71eb6b38-7552-425e-bf09-ee22d23855bb",
                        Name = "Office and Business activities",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_office_xkdjih.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = "f239ac3f-856e-494c-95df-2521a3269a6b",
                        Name = "Energy, Water and Sewage, Utilities",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_energy_kznsrc.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = "3ea25504-1598-4608-a362-84d82b1b2fce",
                        Name = "Telecommunications - engineers and technicians",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_telecoms_sbsq5u.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = "16bf1012-a018-453d-97f2-d9682a3588f1",
                        Name = "Education, Courses, Translators",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_education_kdsm7z.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = "8910967e-2a14-4a1a-a3f5-d16cc78a4b32",
                        Name = "Security",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_security_c4fjq0.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = "0676aec9-89f5-4511-b642-6d0fe86e404a",
                        Name = "Real-estate",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_realestate_dkhhfe.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = "ec4b3c64-1f2f-455d-a6e4-75b525625371",
                        Name = "Legal",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_legal_ofzofx.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c",
                        Name = "Aviation, Airport & Airline",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_airline_bgvmiu.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = "221e3547-3c78-41f9-9634-d7571a615fb8",
                        Name = "Auto Service",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824819/icon_autoservice_iabxkj.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = "265bc199-91e3-4eba-9886-bce0a19e6ce2",
                        Name = "Retail, Wholesale",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824824/icon_retail_pgicm9.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = "fd71ecf5-cb6d-4e3c-ad4e-84358bdfa328",
                        Name = "Technical Support",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_techsupport_zph0mx.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = "6859c0a0-98d0-49c5-b017-17d2a64d3342",
                        Name = "Research and development",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824822/icon_research_mdrafi.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = "dc8214a6-79cf-436c-bae1-7387b82a3bce",
                        Name = "Accouting, Audit, Finance",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_finance_r5bftt.png",
                        DateOfCreation = DateTime.Now
                    },
                });
        }
    }
}