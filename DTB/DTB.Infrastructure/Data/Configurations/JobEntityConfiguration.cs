using DTB.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DTB.Infrastructure.Data.Configurations
{
    public class JobEntityConfiguration : IEntityTypeConfiguration<JobAd>
    {
        public void Configure(EntityTypeBuilder<JobAd> builder)
        {
            builder.HasData(
                new JobAd
                {
                    Id = "56fe9d96-21c1-4b8e-9a84-6d92d0fbb2f3",
                    ProfessionId = "063a9c7b-f301-4e49-a718-5975654b4b07",
                    Experience = "Two years",
                    Description = "We are seeking an experienced Aircraft Dispatcher to join our team. The Aircraft Dispatcher" +
                    " will play a crucial role in planning and coordinating flight operations to ensure the safe and efficient movement of aircraft." +
                    " The ideal candidate will have a strong understanding of aviation regulations and procedures" +
                    ", excellent communication skills, and the ability to work well under pressure.",
                    CompanyId = "993a6fd5-7c2b-4789-9104-8353e676e0ab",
                    CategoryId = "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c",
                    LocationId = "0ade62ed-aeb5-42fe-b87b-55432e1e4e61"
                });
                //new JobAd
                //{
                //    Id = "c5e4787e-f2ab-4e0b-8622-54879a81d73c",

                //},
                //new JobAd
                //{
                //    Id = "70f7a2e3-fcf1-4f52-b20a-4db25cf0d8c3",

                //},
                //new JobAd
                //{
                //    Id = "52bd301a-1fb4-46c5-a4d0-5c1c8a3b6d30",

                //},
                //new JobAd
                //{
                //    Id = "bba35f5e-7fe1-44ac-a7dd-1d15f69fd3e1",

                //}, new JobAd
                //{
                //    Id = "2f21b06d-6dc2-48f2-baaf-31f3d41d2e07",

                //});
        }
    }
}