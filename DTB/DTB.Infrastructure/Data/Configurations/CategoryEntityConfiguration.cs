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
                        Id = Guid.NewGuid().ToString(),
                        Name = "Architecture, Construction",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_architecture_gqdlbl.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Health and Pharmacy",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_health_nhktmm.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Drivers, Couriers",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_derivers_q8g7p3.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Restaurants, Bars, Hotels, Tourism",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824823/icon_restaurant_ee4ubg.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Engineers and Technicians",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_engineer_wzjia1.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Human Resources",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_hr_jbc5jn.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Media, Publishing",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_media_mpzkez.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Logistics, Spedition",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_logistic_ktvoqa.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Customer support",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_customersupport_fbvie5.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Banking, Lending, Insurance",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_banking_dkgjma.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Marketing, Advertising, PR",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_hr_jbc5jn.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Office and Business activities",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_office_xkdjih.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Energy, Water and Sewage, Utilities",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_energy_kznsrc.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Telecommunications - engineers and technicians",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_telecoms_sbsq5u.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Education, Courses, Translators",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_education_kdsm7z.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Security",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_security_c4fjq0.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Real-estate",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_realestate_dkhhfe.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Legal",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824821/icon_legal_ofzofx.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Aviation, Airport & Airline",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_airline_bgvmiu.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Auto Service",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824819/icon_autoservice_iabxkj.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Retail, Wholesale",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824824/icon_retail_pgicm9.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Technical Support",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824825/icon_techsupport_zph0mx.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Research and development",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824822/icon_research_mdrafi.png",
                        DateOfCreation = DateTime.Now
                    },
                    new Category
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Accouting, Audit, Finance",
                        PictureUrl = "https://res.cloudinary.com/dftfu5p0r/image/upload/v1709824820/icon_finance_r5bftt.png",
                        DateOfCreation = DateTime.Now
                    },
                });
        }
    }
}