using DTB.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DTB.Infrastructure.Data.Configurations
{
    public class CompanyEntityConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
               new Company
               {
                   Id = "fca0a5f6-9bf4-4a64-a0bc-6752d75e87a1",
                   Name = "Horizon Architects",
                   Address = "123 Main Street",
                   CategoryId = "80bb3283-c810-4b9c-9d42-da03e17b2ddf",
               },
               new Company
               {
                   Id = "d8b94bc7-6d85-4c38-ba13-9825d1a6e0a9",
                   Name = "SwiftCargo Logistics",
                   Address = "456 Commerce Avenue",
                   CategoryId = "c4dd9eea-1569-402f-a5b8-8473f48437a1",
               },
               new Company
               {
                   Id = "91d593e4-3a7e-44f3-af87-40bcce5b3105",
                   Name = "BrightWave Marketing Solutions",
                   Address = "789 Marketing Street",
                   CategoryId = "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb",
               },
               new Company
               {
                   Id = "e562a2b9-8d4b-4f6e-91b8-e5658fd7995e",
                   Name = "NexusOffice Business Services",
                   Address = "10 Business Boulevard",
                   CategoryId = "71eb6b38-7552-425e-bf09-ee22d23855bb",
               },
               new Company
               {
                   Id = "c7839c89-7865-4a1e-9eb7-7c5b3b2a8c86",
                   Name = "Polyglot Learning Solutions",
                   Address = "789 Language Avenue",
                   CategoryId = "16bf1012-a018-453d-97f2-d9682a3588f1",
               },
               new Company
               {
                   Id = "4fd7a348-d16c-4963-9a53-7d2cbbfe611b",
                   Name = "AeroStar Air Services",
                   Address = "123 Aviation Boulevard",
                   CategoryId = "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c",
               },
                new Company
                {
                    Id = "3a7fe8c6-9b6d-4f5d-aa4e-1e4e64f2c3a9",
                    Name = "WellnessPlus Healthcare",
                    Address = "456 Healthway Street",
                    CategoryId = "a732a432-ef4f-4407-9dba-71f904d0ea6e",
                },
                new Company
                {
                    Id = "1a6f9d2d-8c73-4fd0-b1aa-97241a25e0dc",
                    Name = "CodeCrafters Software Solutions",
                    Address = "789 Innovation Avenue",
                    CategoryId = "38b5eb73-7829-497b-a207-9bcf3fef3b1b",
                }, 
                new Company
                {
                    Id = "b09f7d3c-6d78-4a21-8a4c-21b2a9e2d3c7",
                    Name = "FlavorFusion Restaurant Group",
                    Address = "123 Gourmet Street",
                    CategoryId = "07a32cf2-3c7a-4ab0-ab70-9952c0966f30",
                },  
                new Company
                {
                    Id = "acd84b87-1f42-4b92-8e82-036e0f24c8e9",
                    Name = "TalentConnect HR Solutions",
                    Address = "789 Staffing Avenue",
                    CategoryId = "438c1389-c017-43b8-a34a-46b8c64f5e1d",
                },
                new Company
                {
                    Id = "5f4b18e2-ec14-4bcf-9a5d-8b52e5a67132",
                    Name = "DriveMasters Solutions",
                    Address = "567 Driver Avenue",
                    CategoryId = "b89927d7-b1fd-4703-98df-a4681ce2db88",
                });
        }
    }
}