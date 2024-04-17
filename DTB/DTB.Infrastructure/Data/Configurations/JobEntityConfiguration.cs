//using DTB.Infrastructure.Data.Entities;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Microsoft.EntityFrameworkCore;

//namespace DTB.Infrastructure.Data.Configurations
//{
//    public class JobEntityConfiguration : IEntityTypeConfiguration<JobAd>
//    {
//        public void Configure(EntityTypeBuilder<JobAd> builder)
//        {
//            builder.HasData(
//                new JobAd
//                {
//                    Id = "cefb22ed-0879-4e1f-aa50-8d8e7d92f8df",
//                    ProfessionId = "f04259e9-3cf1-4c45-897d-f6c1e6c3df61",
//                    Experience = "Two years",
//                    Description = "We are looking for a skilled Architect to lead the design and development of architectural projects from conception to completion. The ideal candidate will have a strong background in architectural design, project management, and client interaction. They will be responsible for translating client needs into practical, functional, and aesthetically pleasing designs while adhering to budgetary and regulatory requirements.",
//                    CompanyId = "fca0a5f6-9bf4-4a64-a0bc-6752d75e87a1",
//                    LocationId = "0212d51d-5cc7-41c6-91b4-8b7237882442",
//                    CategoryId = "80bb3283-c810-4b9c-9d42-da03e17b2ddf"
//                },
//                new JobAd
//                {
//                    Id = "96af75b6-47d8-47cb-88b1-d186d9f55f24",
//                    ProfessionId = "77f2a9d9-3c90-4439-bf2a-38f326a731c4",
//                    Experience = "Three years",
//                    Description = "We are seeking a licensed Pharmacist to play a key role in our pharmacy operations, ensuring the safe and effective use of medications for our patients. The ideal candidate will have a strong clinical background, excellent communication skills, and a commitment to delivering high-quality pharmaceutical services. They will work collaboratively with healthcare providers and other pharmacy staff to optimize medication therapy and promote positive patient outcomes.",
//                    CompanyId = "3a7fe8c6-9b6d-4f5d-aa4e-1e4e64f2c3a9",
//                    LocationId = "be267067-1415-4d9c-9d45-ef62b1588c58",
//                    CategoryId = "a732a432-ef4f-4407-9dba-71f904d0ea6e"
//                },
//                new JobAd
//                {
//                    Id = "7cf52a90-3819-4a1b-b4e4-0ad2b6e7dbfd",
//                    ProfessionId = "f446f50a-7021-4d5a-9fc7-d59dcfe54f6e",
//                    Experience = "One year",
//                    Description = "We are hiring Delivery Drivers to transport goods and packages to customers in a safe and timely manner. The Delivery Driver will be responsible for loading and unloading cargo, navigating delivery routes, and providing exceptional customer service. The ideal candidate will have a valid driver's license, a clean driving record, and a positive attitude. They must be reliable, punctual, and capable of working independently while adhering to company policies and procedures.",
//                    CompanyId = "5f4b18e2-ec14-4bcf-9a5d-8b52e5a67132",
//                    LocationId = "1dbfe0e6-d4cb-46e8-a6cc-0a0c1f60f6de",
//                    CategoryId = "b89927d7-b1fd-4703-98df-a4681ce2db88"
//                },
//                new JobAd
//                {
//                    Id = "e595b4ae-1b7b-4c91-b6e2-0acfb74338c1",
//                    ProfessionId = "fda9d7e2-471f-4b5a-8ad7-0e849cbb7f6c",
//                    Experience = "Five years",
//                    Description = "We are looking for an experienced Chef to lead our kitchen team and oversee all aspects of food preparation, menu development, and kitchen operations. The Chef will be responsible for creating inspired dishes that showcase seasonal ingredients, culinary techniques, and artistic presentation. The ideal candidate will have a strong culinary background, creative flair, and leadership skills to motivate and mentor kitchen staff.",
//                    CompanyId = "b09f7d3c-6d78-4a21-8a4c-21b2a9e2d3c7",
//                    LocationId = "79f47c1b-0975-42e7-8b94-12e3e3bbd319",
//                    CategoryId = "07a32cf2-3c7a-4ab0-ab70-9952c0966f30"
//                },
//                new JobAd
//                {
//                    Id = "67ec7e25-d5a5-4e08-af90-9fcb49c27a36",
//                    ProfessionId = "c47607b0-606e-48ee-b3cf-5df0f6a69e9e",
//                    Experience = "Five years",
//                    Description = "We are looking for experienced Software Engineers to design, develop, and implement software solutions that meet the needs of our clients and users. The Software Engineer will work collaboratively with cross-functional teams to analyze requirements, architect solutions, and deliver high-quality software products. The ideal candidate will have a strong technical background, problem-solving skills, and a passion for technology innovation.",
//                    CompanyId = "1a6f9d2d-8c73-4fd0-b1aa-97241a25e0dc",
//                    LocationId = "9b51ab5b-59a6-4e02-b883-27e2085e5ad3",
//                    CategoryId = "38b5eb73-7829-497b-a207-9bcf3fef3b1b"
//                },
//                new JobAd
//                {
//                    Id = "3c84e3b4-1f0c-4edf-b3e6-428fbfd0a9e1",
//                    ProfessionId = "d77c3684-9ab9-4b51-85a4-45790c16d1ae",
//                    Experience = "Two years",
//                    Description = "We are looking for an experienced HR Manager to oversee all aspects of human resources management, including recruitment, employee relations, performance management, training and development, and HR compliance. The HR Manager will play a critical role in shaping our company culture, promoting employee engagement, and implementing HR strategies and initiatives that align with our organizational goals. The ideal candidate will have a strong HR background, excellent interpersonal skills, and a passion for building and nurturing high-performing teams.",
//                    CompanyId = "acd84b87-1f42-4b92-8e82-036e0f24c8e9",
//                    LocationId = "f83622f2-b418-4a1a-9dcb-24d0e79c9b7b",
//                    CategoryId = "438c1389-c017-43b8-a34a-46b8c64f5e1d"
//                });
//        }
//    }
//}