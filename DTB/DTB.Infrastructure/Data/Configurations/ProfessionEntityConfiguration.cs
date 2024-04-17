using DTB.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DTB.Infrastructure.Data.Configurations
{
    public class ProfessionEntityConfiguration : IEntityTypeConfiguration<Profession>
    {
        public void Configure(EntityTypeBuilder<Profession> builder)
        {
            builder.HasData(
              //"Architecture, Construction"
              new Profession
              {
                  Id = "f04259e9-3cf1-4c45-897d-f6c1e6c3df61",
                  Name = "Architect",
                  CategoryId = "80bb3283-c810-4b9c-9d42-da03e17b2ddf"
              },
              new Profession
              {
                  Id = "8ef0979d-2b57-49c2-aa41-7582fd88161c",
                  Name = "Urban Planner",
                  CategoryId = "80bb3283-c810-4b9c-9d42-da03e17b2ddf"
              },
              new Profession
              {
                  Id = "bd3a10e8-8835-4dd9-9168-9f935c9a1b85",
                  Name = "Landscape Architect",
                  CategoryId = "80bb3283-c810-4b9c-9d42-da03e17b2ddf"
              },
              new Profession
              {
                  Id = "d2f9bca5-e3d8-41a4-8179-58d960850c21",
                  Name = "Interior Designer",
                  CategoryId = "80bb3283-c810-4b9c-9d42-da03e17b2ddf"
              },
              //"Health and Pharmacy"
              new Profession
              {
                  Id = "77f2a9d9-3c90-4439-bf2a-38f326a731c4",
                  Name = "Pharmacist",
                  CategoryId = "a732a432-ef4f-4407-9dba-71f904d0ea6e"
              }, new Profession
              {
                  Id = "af0a0565-51c2-4969-9757-937d0cc8f35e",
                  Name = "Doctor",
                  CategoryId = "a732a432-ef4f-4407-9dba-71f904d0ea6e"
              }, new Profession
              {
                  Id = "53242ed3-c78e-4fa9-ae5c-d880c8e506b2",
                  Name = "Nurse",
                  CategoryId = "a732a432-ef4f-4407-9dba-71f904d0ea6e"
              }, new Profession
              {
                  Id = "59dc7d4a-52d0-4ebd-80fc-59dbb5f05b4f",
                  Name = "Pharmacy Technician",
                  CategoryId = "a732a432-ef4f-4407-9dba-71f904d0ea6e"
              }, new Profession
              {
                  Id = "0c6c6421-2a35-4c70-b8a1-14eef62286ee",
                  Name = "Pharmaceutical Scientist",
                  CategoryId = "a732a432-ef4f-4407-9dba-71f904d0ea6e"
              }, new Profession
              {
                  Id = "a61fcb21-3ed7-4392-a0aa-6741862c65d3",
                  Name = "Clinical Research Associate",
                  CategoryId = "a732a432-ef4f-4407-9dba-71f904d0ea6e"
              },
              //"Drivers, Couriers"
              new Profession
              {
                  Id = "f446f50a-7021-4d5a-9fc7-d59dcfe54f6e",
                  Name = "Delivery Driver",
                  CategoryId = "b89927d7-b1fd-4703-98df-a4681ce2db88"
              }, new Profession
              {
                  Id = "b66e4d92-5c30-48b0-92ac-f4b0fe2879e2",
                  Name = "Courier",
                  CategoryId = "b89927d7-b1fd-4703-98df-a4681ce2db88"
              }, new Profession
              {
                  Id = "d0494fe0-06f8-4f01-81fd-937df723d203",
                  Name = "Truck Driver",
                  CategoryId = "b89927d7-b1fd-4703-98df-a4681ce2db88"
              }, new Profession
              {
                  Id = "c4a3549f-2dd3-48e3-bd41-43d101baa24e",
                  Name = "Taxi Driver",
                  CategoryId = "b89927d7-b1fd-4703-98df-a4681ce2db88"
              }, new Profession
              {
                  Id = "73de6a98-fc71-4144-8154-20778c34e93b",
                  Name = "Bus Driver",
                  CategoryId = "b89927d7-b1fd-4703-98df-a4681ce2db88"
              }, new Profession
              {
                  Id = "4c87148f-52c8-45d6-801e-6663bc2b9615",
                  Name = "Van Driver",
                  CategoryId = "b89927d7-b1fd-4703-98df-a4681ce2db88"
              },
              //"Restaurants, Bars, Hotels, Tourism"
              new Profession
              {
                  Id = "fda9d7e2-471f-4b5a-8ad7-0e849cbb7f6c",
                  Name = "Chef",
                  CategoryId = "07a32cf2-3c7a-4ab0-ab70-9952c0966f30"
              }, new Profession
              {
                  Id = "28c92c7c-f39f-47a3-b79d-b6e0a9f08e88",
                  Name = "Bartender",
                  CategoryId = "07a32cf2-3c7a-4ab0-ab70-9952c0966f30"
              }, new Profession
              {
                  Id = "db083e3f-67a2-4c92-92d6-8b6e1dfdc48e",
                  Name = "Waiter/Waitress",
                  CategoryId = "07a32cf2-3c7a-4ab0-ab70-9952c0966f30"
              }, new Profession
              {
                  Id = "5e8f79b5-c176-4a85-86a5-3998adcc6822",
                  Name = "Restaurant Manager",
                  CategoryId = "07a32cf2-3c7a-4ab0-ab70-9952c0966f30"
              }, new Profession
              {
                  Id = "15a7dcd2-6c3b-4585-bce2-0270241f7d6e",
                  Name = "Hotel Manager",
                  CategoryId = "07a32cf2-3c7a-4ab0-ab70-9952c0966f30"
              }, new Profession
              {
                  Id = "9b7e1554-b94e-4c2a-91cf-af2465d93c09",
                  Name = "Concierge",
                  CategoryId = "07a32cf2-3c7a-4ab0-ab70-9952c0966f30"
              },
              //"Engineers and Technicians"
              new Profession
              {
                  Id = "64a522d8-6f5a-4d50-8e43-d7d5ad135b65",
                  Name = "Mechanical Engineer",
                  CategoryId = "38b5eb73-7829-497b-a207-9bcf3fef3b1b"
              }, new Profession
              {
                  Id = "b2db03c1-3c7c-44bb-bf82-8e35c212a7e1",
                  Name = "Electrical Engineer",
                  CategoryId = "38b5eb73-7829-497b-a207-9bcf3fef3b1b"
              }, new Profession
              {
                  Id = "85e233cf-85a2-4d5c-b0b3-9ef7a7a3523d",
                  Name = "Civil Engineer",
                  CategoryId = "38b5eb73-7829-497b-a207-9bcf3fef3b1b"
              }, new Profession
              {
                  Id = "9e8b4cb4-c9fb-4c54-8935-22eac0d69b6e",
                  Name = "Chemical Engineer",
                  CategoryId = "38b5eb73-7829-497b-a207-9bcf3fef3b1b"
              }, new Profession
              {
                  Id = "f30e12fb-05cc-4153-8a4a-2d31f3d9b2c8",
                  Name = "Computer Engineer",
                  CategoryId = "38b5eb73-7829-497b-a207-9bcf3fef3b1b"
              }, new Profession
              {
                  Id = "c47607b0-606e-48ee-b3cf-5df0f6a69e9e",
                  Name = "Software Engineer",
                  CategoryId = "38b5eb73-7829-497b-a207-9bcf3fef3b1b"
              },
              //"Human Resources"
              new Profession
              {
                  Id = "d77c3684-9ab9-4b51-85a4-45790c16d1ae",
                  Name = "HR Manager",
                  CategoryId = "438c1389-c017-43b8-a34a-46b8c64f5e1d"
              }, new Profession
              {
                  Id = "a8b7a34b-f7d7-4c4a-9297-49e93b09ecb6",
                  Name = "Talent Acquisition Specialist/Recruiter",
                  CategoryId = "438c1389-c017-43b8-a34a-46b8c64f5e1d"
              }, new Profession
              {
                  Id = "ee54b64a-76bc-47ff-81a3-02a4ac6c0d35",
                  Name = "Compensation and Benefits Manager",
                  CategoryId = "438c1389-c017-43b8-a34a-46b8c64f5e1d"
              }, new Profession
              {
                  Id = "baf35a3f-daf9-4b1f-a746-d75da4fcad9b",
                  Name = "Training and Development Specialist",
                  CategoryId = "438c1389-c017-43b8-a34a-46b8c64f5e1d"
              }, new Profession
              {
                  Id = "c6b32d99-681b-47f6-93c6-7c318fe8b3c8",
                  Name = "HR Coordinator",
                  CategoryId = "438c1389-c017-43b8-a34a-46b8c64f5e1d"
              },
              // "Media, Publishing"
              new Profession
              {
                  Id = "768442d1-47f4-44e3-8863-c2d45060f1e7",
                  Name = "Journalist",
                  CategoryId = "3c1fda93-5ef8-4db2-97f7-25f163fbca67"
              }, new Profession
              {
                  Id = "b8ef7c1c-7408-4956-83f0-1cb9b3284416",
                  Name = "Editor",
                  CategoryId = "3c1fda93-5ef8-4db2-97f7-25f163fbca67"
              }, new Profession
              {
                  Id = "81c74767-f1b5-4599-84f0-7ae382448d8d",
                  Name = "Writer",
                  CategoryId = "3c1fda93-5ef8-4db2-97f7-25f163fbca67"
              }, new Profession
              {
                  Id = "dc31dd20-d5f7-4f26-b611-8b0427b2ee32",
                  Name = "Reporter",
                  CategoryId = "3c1fda93-5ef8-4db2-97f7-25f163fbca67"
              }, new Profession
              {
                  Id = "d38e1340-4e35-47f4-a4e2-d2d8d07a9b4e",
                  Name = "Publisher",
                  CategoryId = "3c1fda93-5ef8-4db2-97f7-25f163fbca67"
              }, new Profession
              {
                  Id = "e0b6c971-9122-4042-8d43-2a0ee17b2dd7",
                  Name = "Copy Editor",
                  CategoryId = "3c1fda93-5ef8-4db2-97f7-25f163fbca67"
              },
              //"Logistics, Spedition"
              new Profession
              {
                  Id = "5b3fd229-c3b3-4cc7-84cf-7d4807927c88",
                  Name = "Logistics Coordinator",
                  CategoryId = "c4dd9eea-1569-402f-a5b8-8473f48437a1"
              }, new Profession
              {
                  Id = "c22b89de-97c8-4dc8-a2a7-2ad7eb61ec5e",
                  Name = "Supply Chain Manager",
                  CategoryId = "c4dd9eea-1569-402f-a5b8-8473f48437a1"
              }, new Profession
              {
                  Id = "d1e2ab06-08a0-439a-a05a-b7dd93cb1876",
                  Name = "Freight Forwarder",
                  CategoryId = "c4dd9eea-1569-402f-a5b8-8473f48437a1"
              }, new Profession
              {
                  Id = "746fa7c6-bb09-4e8d-89a5-4a9403e6fd91",
                  Name = "Warehouse Manager",
                  CategoryId = "c4dd9eea-1569-402f-a5b8-8473f48437a1"
              }, new Profession
              {
                  Id = "b3cf2977-d04d-44d3-b1d6-ecf6240db0d6",
                  Name = "Distribution Manager",
                  CategoryId = "c4dd9eea-1569-402f-a5b8-8473f48437a1"
              }, new Profession
              {
                  Id = "5a83ff30-17c1-4484-bb0e-3b8470cc1870",
                  Name = "Transportation Planner",
                  CategoryId = "c4dd9eea-1569-402f-a5b8-8473f48437a1"
              },
              //"Customer support"
              new Profession
              {
                  Id = "8e238be6-32ac-48e5-89d0-d43f7c7b1be5",
                  Name = "Customer Service Representative",
                  CategoryId = "c468efd1-09cf-4e6c-9245-2e837e500968"
              }, new Profession
              {
                  Id = "e607518e-f7dc-4e35-9f4d-0a16dd69d3db",
                  Name = "Technical Support Specialist",
                  CategoryId = "c468efd1-09cf-4e6c-9245-2e837e500968"
              }, new Profession
              {
                  Id = "5c2e8e13-03a9-4f71-bfc2-f713620ef86d",
                  Name = "Technical Support Specialist",
                  CategoryId = "c468efd1-09cf-4e6c-9245-2e837e500968"
              }, new Profession
              {
                  Id = "f5bda051-7b47-418e-a4a7-68cfae8b5eef",
                  Name = "Help Desk Analyst",
                  CategoryId = "c468efd1-09cf-4e6c-9245-2e837e500968"
              }, new Profession
              {
                  Id = "1a1e2c1a-91b1-456f-b23a-27d1e12e35ec",
                  Name = "Customer Success Manager",
                  CategoryId = "c468efd1-09cf-4e6c-9245-2e837e500968"
              }, new Profession
              {
                  Id = "a1e8fe6a-9027-4f9d-8532-0f44c569c810",
                  Name = "Client Support Specialist",
                  CategoryId = "c468efd1-09cf-4e6c-9245-2e837e500968"
              },
              //"Banking, Lending, Insurance"
              new Profession
              {
                  Id = "ae791c2d-0d5f-44d8-86b1-6d7ad46e4de9",
                  Name = "Bank Teller",
                  CategoryId = "ff13d479-760d-4387-8843-c882ad150609"
              }, new Profession
              {
                  Id = "05a4867c-c86e-43da-9c63-f09753e5d7d8",
                  Name = "Loan Officer",
                  CategoryId = "ff13d479-760d-4387-8843-c882ad150609"
              }, new Profession
              {
                  Id = "15f1df94-291d-4f8a-92c0-3f2f4fe0e6c8",
                  Name = "Financial Advisor",
                  CategoryId = "ff13d479-760d-4387-8843-c882ad150609"
              }, new Profession
              {
                  Id = "cf8e2882-5683-4eb3-9687-43897f28a27e",
                  Name = "Branch Manager",
                  CategoryId = "ff13d479-760d-4387-8843-c882ad150609"
              }, new Profession
              {
                  Id = "a7b254d2-6a12-40ad-9885-b86814a5a4b2",
                  Name = "Mortgage Broker",
                  CategoryId = "ff13d479-760d-4387-8843-c882ad150609"
              }, new Profession
              {
                  Id = "3debb73d-325f-47cc-8499-b2c9f8ed2045",
                  Name = "Credit Analyst",
                  CategoryId = "ff13d479-760d-4387-8843-c882ad150609"
              },
              // "Marketing, Advertising, PR"
              new Profession
              {
                  Id = "c1f48fb3-6e0d-45ef-a95c-268f441b8403",
                  Name = "Marketing Manager",
                  CategoryId = "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb"
              }, new Profession
              {
                  Id = "8a1b9ba4-d9e1-4d80-8617-13e607f1722c",
                  Name = "Advertising Executive",
                  CategoryId = "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb"
              }, new Profession
              {
                  Id = "ac8937b8-cd1b-4846-80cc-4c8e79dc9786",
                  Name = "Public Relations Specialist",
                  CategoryId = "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb"
              }, new Profession
              {
                  Id = "d6b43e8f-9068-41c1-818a-0d9e3541fe86",
                  Name = "Brand Manager",
                  CategoryId = "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb"
              }, new Profession
              {
                  Id = "e61546d8-5258-479f-8d6c-ecf52bbf40e8",
                  Name = "Digital Marketing Specialist",
                  CategoryId = "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb"
              }, new Profession
              {
                  Id = "5fc255cf-3993-46a8-a307-1c1ef4248e08",
                  Name = "Social Media Manager",
                  CategoryId = "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb"
              },
              // "Office and Business activities"
              new Profession
              {
                  Id = "b7cc4e9b-0624-4e8d-ba19-9266d90e20cb",
                  Name = "Office Manager",
                  CategoryId = "71eb6b38-7552-425e-bf09-ee22d23855bb"
              }, new Profession
              {
                  Id = "dc5f6828-d7d7-458a-9d18-d25fb61d02af",
                  Name = "Administrative Assistant",
                  CategoryId = "71eb6b38-7552-425e-bf09-ee22d23855bb"
              }, new Profession
              {
                  Id = "1d865eb6-af2e-4485-8d1a-6c684e02dc1b",
                  Name = "Executive Assistant",
                  CategoryId = "71eb6b38-7552-425e-bf09-ee22d23855bb"
              }, new Profession
              {
                  Id = "3a8e6162-67b3-45bc-aade-f57cb0147581",
                  Name = "Office Administrator",
                  CategoryId = "71eb6b38-7552-425e-bf09-ee22d23855bb"
              }, new Profession
              {
                  Id = "a3f9fd8e-021c-4d7a-b2b7-b808b163bc83",
                  Name = "Receptionist",
                  CategoryId = "71eb6b38-7552-425e-bf09-ee22d23855bb"
              }, new Profession
              {
                  Id = "ee53b8de-2ac9-4d7c-a5bc-7d1f6d9a90c0",
                  Name = "Data Entry Clerk",
                  CategoryId = "71eb6b38-7552-425e-bf09-ee22d23855bb"
              },
              // "Energy, Water and Sewage, Utilities"
              new Profession
              {
                  Id = "be73dbb1-f6b5-4be1-881d-289a0435a176",
                  Name = "Electrical Engineer",
                  CategoryId = "f239ac3f-856e-494c-95df-2521a3269a6b"
              }, new Profession
              {
                  Id = "d65e1d14-d0cf-4815-83e7-73f22dd6d21e",
                  Name = "Mechanical Engineer",
                  CategoryId = "f239ac3f-856e-494c-95df-2521a3269a6b"
              }, new Profession
              {
                  Id = "8f527e14-11a0-468e-bb29-918a5a90cb3e",
                  Name = "Power Plant Operator",
                  CategoryId = "f239ac3f-856e-494c-95df-2521a3269a6b"
              }, new Profession
              {
                  Id = "92b5b7f7-2d8e-4f9b-8049-14fb6dab160f",
                  Name = "Utility Technician",
                  CategoryId = "f239ac3f-856e-494c-95df-2521a3269a6b"
              }, new Profession
              {
                  Id = "7db1c426-0e26-43f6-95b2-3a4c9a0e60fb",
                  Name = "Energy Analyst",
                  CategoryId = "f239ac3f-856e-494c-95df-2521a3269a6b"
              }, new Profession
              {
                  Id = "e6a1ecf2-5d8d-4b39-8305-f5b75dd13a01",
                  Name = "Renewable Energy Specialist",
                  CategoryId = "f239ac3f-856e-494c-95df-2521a3269a6b"
              },
              // "Telecommunications - engineers and technicians"
              new Profession
              {
                  Id = "98ee0c64-b2cd-4c31-8561-d86c96c405c4",
                  Name = "Telecommunications Engineer",
                  CategoryId = "3ea25504-1598-4608-a362-84d82b1b2fce"
              }, new Profession
              {
                  Id = "7a0c7a11-57db-4be8-8b7e-9c28c4c33085",
                  Name = "Network Engineer",
                  CategoryId = "3ea25504-1598-4608-a362-84d82b1b2fce"
              }, new Profession
              {
                  Id = "3df00e70-7a0e-4a1a-bded-9b83799c8181",
                  Name = "Telecom Systems Engineer",
                  CategoryId = "3ea25504-1598-4608-a362-84d82b1b2fce"
              }, new Profession
              {
                  Id = "20c1e62b-46cd-47b6-880f-fdd12aa89a1d",
                  Name = "RF Engineer (Radio Frequency)",
                  CategoryId = "3ea25504-1598-4608-a362-84d82b1b2fce"
              }, new Profession
              {
                  Id = "f293b5f6-f7d0-4dc5-b072-0d5268a2530c",
                  Name = "Optical Network Engineer",
                  CategoryId = "3ea25504-1598-4608-a362-84d82b1b2fce"
              }, new Profession
              {
                  Id = "f4d21aa6-868e-4744-8275-b15b84f36e3e",
                  Name = "VoIP Engineer (Voice over Internet Protocol)",
                  CategoryId = "3ea25504-1598-4608-a362-84d82b1b2fce"
              },
              // "Education, Courses, Translators"
              new Profession
              {
                  Id = "6518d38b-34d8-418d-bb9a-786f560e2314",
                  Name = "Teacher",
                  CategoryId = "16bf1012-a018-453d-97f2-d9682a3588f1"
              }, new Profession
              {
                  Id = "f60cf3fb-5dd8-4b09-b46f-1e357e468fcc",
                  Name = "Professor",
                  CategoryId = "16bf1012-a018-453d-97f2-d9682a3588f1"
              }, new Profession
              {
                  Id = "a9815f4f-d85d-48e0-896b-258d89f82884",
                  Name = "Instructor",
                  CategoryId = "16bf1012-a018-453d-97f2-d9682a3588f1"
              }, new Profession
              {
                  Id = "0a4b6a5d-4dc2-4376-9b8d-f218e1e6e68b",
                  Name = "Tutor",
                  CategoryId = "16bf1012-a018-453d-97f2-d9682a3588f1"
              }, new Profession
              {
                  Id = "1d38807e-52d1-4f21-8a92-4aeecda64838",
                  Name = "Educational Consultant",
                  CategoryId = "16bf1012-a018-453d-97f2-d9682a3588f1"
              }, new Profession
              {
                  Id = "143f3523-11c2-4a0b-ba63-bc5d6f19255a",
                  Name = "Curriculum Developer",
                  CategoryId = "16bf1012-a018-453d-97f2-d9682a3588f1"
              },
              // "Security"
              new Profession
              {
                  Id = "b4b07136-27d4-4a1f-b9fc-97e03c1b448f",
                  Name = "Security Guard",
                  CategoryId = "8910967e-2a14-4a1a-a3f5-d16cc78a4b32"
              }, new Profession
              {
                  Id = "ba2d8ad0-130d-4cf5-b508-1e5f61ef056a",
                  Name = "Security Officer",
                  CategoryId = "8910967e-2a14-4a1a-a3f5-d16cc78a4b32"
              }, new Profession
              {
                  Id = "160c1c89-af8c-49e0-9c85-3968fb465b55",
                  Name = "Security Supervisor",
                  CategoryId = "8910967e-2a14-4a1a-a3f5-d16cc78a4b32"
              }, new Profession
              {
                  Id = "00b088f2-b24d-4d42-8d80-5d50b4ae02ab",
                  Name = "Security Manager",
                  CategoryId = "8910967e-2a14-4a1a-a3f5-d16cc78a4b32"
              }, new Profession
              {
                  Id = "181aa1e7-0053-4b99-80ee-88f173ba2f12",
                  Name = "Private Investigator",
                  CategoryId = "8910967e-2a14-4a1a-a3f5-d16cc78a4b32"
              }, new Profession
              {
                  Id = "a9dd6d86-2270-4b05-975d-816a14cfbe63",
                  Name = "Bodyguard",
                  CategoryId = "8910967e-2a14-4a1a-a3f5-d16cc78a4b32"
              },
              // "Real-estate"
              new Profession
              {
                  Id = "b1b5008b-50b0-48c3-9f0c-44e7eb31567f",
                  Name = "Real Estate Agent",
                  CategoryId = "0676aec9-89f5-4511-b642-6d0fe86e404a"
              }, new Profession
              {
                  Id = "1ac27ba5-49d7-4c09-b4ac-10d376a8b198",
                  Name = "Real Estate Broker",
                  CategoryId = "0676aec9-89f5-4511-b642-6d0fe86e404a"
              }, new Profession
              {
                  Id = "d571f77c-8c1f-48df-8a8f-cce98a3180b2",
                  Name = "Realtor",
                  CategoryId = "0676aec9-89f5-4511-b642-6d0fe86e404a"
              }, new Profession
              {
                  Id = "e876ba3a-16aa-4d27-bd80-fa9ed78e84db",
                  Name = "Property Manager",
                  CategoryId = "0676aec9-89f5-4511-b642-6d0fe86e404a"
              }, new Profession
              {
                  Id = "d9160ad9-dc8e-4097-9b5e-5a39985f7d69",
                  Name = "Real Estate Appraiser",
                  CategoryId = "0676aec9-89f5-4511-b642-6d0fe86e404a"
              }, new Profession
              {
                  Id = "b4749a27-2c91-4d42-b271-8f272e78dd82",
                  Name = "Leasing Consultant",
                  CategoryId = "0676aec9-89f5-4511-b642-6d0fe86e404a"
              },
              //"Legal"
              new Profession
              {
                  Id = "ac60f725-8a5a-4453-b76b-50c0b1f204a1",
                  Name = "Lawyer/Attorney",
                  CategoryId = "ec4b3c64-1f2f-455d-a6e4-75b525625371"
              }, new Profession
              {
                  Id = "5b4417b5-29a4-41e2-813a-8953730341f5",
                  Name = "Paralegal",
                  CategoryId = "ec4b3c64-1f2f-455d-a6e4-75b525625371"
              }, new Profession
              {
                  Id = "a2a21176-84b5-4537-85d2-c0c30058b7e2",
                  Name = "Legal Assistant",
                  CategoryId = "ec4b3c64-1f2f-455d-a6e4-75b525625371"
              }, new Profession
              {
                  Id = "6b9519a7-d540-4d54-9ef3-271c5c2e7f1d",
                  Name = "Legal Secretary",
                  CategoryId = "ec4b3c64-1f2f-455d-a6e4-75b525625371"
              }, new Profession
              {
                  Id = "be76b792-9e0e-4c42-a7fd-514b2ec04f20",
                  Name = "Judge",
                  CategoryId = "ec4b3c64-1f2f-455d-a6e4-75b525625371"
              }, new Profession
              {
                  Id = "de08f21c-1d36-42f7-9ec8-f37907988e91",
                  Name = "Legal Consultant",
                  CategoryId = "ec4b3c64-1f2f-455d-a6e4-75b525625371"
              },
              // "Aviation, Airport & Airline"
              new Profession
              {
                  Id = "e5b34805-13f5-42ad-ba77-85ed67cbf5a5",
                  Name = "Pilot",
                  CategoryId = "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c"
              }, new Profession
              {
                  Id = "0cfa84cc-0c1f-4729-a60a-36ab826a1a06",
                  Name = "Co-pilot/First Officer",
                  CategoryId = "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c"
              }, new Profession
              {
                  Id = "b4858ff4-2dd3-4bc8-9aae-49c6a8c8fd06",
                  Name = "Flight Attendant",
                  CategoryId = "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c"
              }, new Profession
              {
                  Id = "a7597cd2-3dcf-4d56-b36a-00e8a20cf8ef",
                  Name = "Air Traffic Controller",
                  CategoryId = "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c"
              }, new Profession
              {
                  Id = "f65d013a-854a-4a13-8d15-fce80b63e156",
                  Name = "Aircraft Maintenance Technician",
                  CategoryId = "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c"
              }, new Profession
              {
                  Id = "88e2c320-3b99-4cfc-8b4e-8a0b0f6899ef",
                  Name = "Aircraft Dispatcher",
                  CategoryId = "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c"
              },
              // "Auto Service"
              new Profession
              {
                  Id = "4df73c30-0951-4a41-8db1-19742ed4206a",
                  Name = "Automotive Technician/Mechanic",
                  CategoryId = "221e3547-3c78-41f9-9634-d7571a615fb8"
              }, new Profession
              {
                  Id = "92f7c3e1-2d18-47a6-ae12-7cc146c0d4fd",
                  Name = "Automotive Service Advisor",
                  CategoryId = "221e3547-3c78-41f9-9634-d7571a615fb8"
              }, new Profession
              {
                  Id = "548d12ac-837a-4c13-b7fc-b77c15d36ff9",
                  Name = "Auto Body Repair Technician",
                  CategoryId = "221e3547-3c78-41f9-9634-d7571a615fb8"
              }, new Profession
              {
                  Id = "3f0f3cd7-d7f7-49e6-95ee-43a536e49e8d",
                  Name = "Automotive Electrician",
                  CategoryId = "221e3547-3c78-41f9-9634-d7571a615fb8"
              }, new Profession
              {
                  Id = "f70d41ab-46c7-4d97-b6c2-7fd61b0549b2",
                  Name = "Brake Technician",
                  CategoryId = "221e3547-3c78-41f9-9634-d7571a615fb8"
              }, new Profession
              {
                  Id = "8c23f6cf-916d-41c7-8f35-5d3e5c4e8d6d",
                  Name = "Transmission Technician",
                  CategoryId = "221e3547-3c78-41f9-9634-d7571a615fb8"
              },
              // "Retail, Wholesale"
              new Profession
              {
                  Id = "c7514c88-0a16-4d54-b2c0-cb79916a494b",
                  Name = "Retail Sales Associate",
                  CategoryId = "265bc199-91e3-4eba-9886-bce0a19e6ce2"
              }, new Profession
              {
                  Id = "6d42145c-0cd9-4ee5-a4f1-c39dc6e464a1",
                  Name = "Store Manager",
                  CategoryId = "265bc199-91e3-4eba-9886-bce0a19e6ce2"
              }, new Profession
              {
                  Id = "93a1ec1e-af3e-4bc4-8048-62e69f6acdf2",
                  Name = "Assistant Store Manager",
                  CategoryId = "265bc199-91e3-4eba-9886-bce0a19e6ce2"
              }, new Profession
              {
                  Id = "27f6e1e3-c567-48af-92c4-d9f7ccdf90b2",
                  Name = "Cashier",
                  CategoryId = "265bc199-91e3-4eba-9886-bce0a19e6ce2"
              }, new Profession
              {
                  Id = "0d199b44-7e67-42f8-b9d1-15f6666993d7",
                  Name = "Customer Service Representative",
                  CategoryId = "265bc199-91e3-4eba-9886-bce0a19e6ce2"
              }, new Profession
              {
                  Id = "2d6a8b5e-b6d8-4f68-b7c2-5ed7d1065a54",
                  Name = "Retail Merchandiser",
                  CategoryId = "265bc199-91e3-4eba-9886-bce0a19e6ce2"
              },
              // "Technical Support"
              new Profession
              {
                  Id = "3ad80bfa-1de4-4a3e-9d80-78b1e4f38138",
                  Name = "Technical Support Specialist",
                  CategoryId = "fd71ecf5-cb6d-4e3c-ad4e-84358bdfa328"
              }, new Profession
              {
                  Id = "28d90df0-7592-4d33-915d-dba1b3cd95e5",
                  Name = "Help Desk Technician",
                  CategoryId = "fd71ecf5-cb6d-4e3c-ad4e-84358bdfa328"
              }, new Profession
              {
                  Id = "7ad9df7e-29f8-4b95-aa6e-f78d5c32d8c2",
                  Name = "IT Support Engineer",
                  CategoryId = "fd71ecf5-cb6d-4e3c-ad4e-84358bdfa328"
              }, new Profession
              {
                  Id = "6ecaa7c5-c11f-44aa-bad8-842af947e55f",
                  Name = "Customer Support Engineer",
                  CategoryId = "fd71ecf5-cb6d-4e3c-ad4e-84358bdfa328"
              }, new Profession
              {
                  Id = "2dbdb1b6-7e1c-46b4-a51a-d5d27a1e56ff",
                  Name = "Desktop Support Technician",
                  CategoryId = "fd71ecf5-cb6d-4e3c-ad4e-84358bdfa328"
              }, new Profession
              {
                  Id = "f7ed1254-7005-4568-bf02-02e1e37aa2bb",
                  Name = "Network Support Technician",
                  CategoryId = "fd71ecf5-cb6d-4e3c-ad4e-84358bdfa328"
              },
              //  "Research and development"
              new Profession
              {
                  Id = "ce81a194-2ec1-4b5c-a7aa-524cc11b06a6",
                  Name = "Research Scientist",
                  CategoryId = "6859c0a0-98d0-49c5-b017-17d2a64d3342"
              }, new Profession
              {
                  Id = "b6e83eb5-8d9a-40d5-9891-4c19117a09ed",
                  Name = "R&D Engineer",
                  CategoryId = "6859c0a0-98d0-49c5-b017-17d2a64d3342"
              }, new Profession
              {
                  Id = "289cb58e-b29d-4c64-8201-dfde7ff59c1a",
                  Name = "Research Associate",
                  CategoryId = "6859c0a0-98d0-49c5-b017-17d2a64d3342"
              }, new Profession
              {
                  Id = "f8a0cb10-8c65-4640-9954-80f0c9eeed0b",
                  Name = "Laboratory Technician",
                  CategoryId = "6859c0a0-98d0-49c5-b017-17d2a64d3342"
              }, new Profession
              {
                  Id = "b2f68861-f6c8-4484-bf80-99fc9349d53a",
                  Name = "Product Development Manager",
                  CategoryId = "6859c0a0-98d0-49c5-b017-17d2a64d3342"
              }, new Profession
              {
                  Id = "b6d002cb-d10f-40e7-9867-7e60f972a8a2",
                  Name = "Data Scientist",
                  CategoryId = "6859c0a0-98d0-49c5-b017-17d2a64d3342"
              },
              // "Accouting, Audit, Finance"
              new Profession
              {
                  Id = "d7e1f951-b436-4e07-98d7-71571c55e90a",
                  Name = "Accountant",
                  CategoryId = "dc8214a6-79cf-436c-bae1-7387b82a3bce"
              }, new Profession
              {
                  Id = "3b64b94a-0518-4796-9c4b-71aaf89e0f46",
                  Name = "Auditor",
                  CategoryId = "dc8214a6-79cf-436c-bae1-7387b82a3bce"
              }, new Profession
              {
                  Id = "8e8a09b2-3033-4866-8f9f-f896bfc5eb6a",
                  Name = "Financial Analyst",
                  CategoryId = "dc8214a6-79cf-436c-bae1-7387b82a3bce"
              }, new Profession
              {
                  Id = "ccd5fc90-b3f1-45fc-89bc-28c5f0cb1d42",
                  Name = "Certified Public Accountant (CPA)",
                  CategoryId = "dc8214a6-79cf-436c-bae1-7387b82a3bce"
              }, new Profession
              {
                  Id = "da7d57e3-334d-4e2a-8496-3e2c0e740a48",
                  Name = "Tax Accountant",
                  CategoryId = "dc8214a6-79cf-436c-bae1-7387b82a3bce"
              }, new Profession
              {
                  Id = "b1b6a016-5e24-4515-b4d8-1e7b97836b28",
                  Name = "Bookkeeper",
                  CategoryId = "dc8214a6-79cf-436c-bae1-7387b82a3bce"
              });
        }
    }
}
