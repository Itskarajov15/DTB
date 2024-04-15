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
                  Id = Guid.NewGuid().ToString(),
                  Name = "Architect",
                  CategoryId = "80bb3283-c810-4b9c-9d42-da03e17b2ddf"
              },
              new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Urban Planner",
                  CategoryId = "80bb3283-c810-4b9c-9d42-da03e17b2ddf"
              },
              new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Landscape Architect",
                  CategoryId = "80bb3283-c810-4b9c-9d42-da03e17b2ddf"
              },
              new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Interior Designer",
                  CategoryId = "80bb3283-c810-4b9c-9d42-da03e17b2ddf"
              },
              //"Health and Pharmacy"
              new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Pharmacist",
                  CategoryId = "a732a432-ef4f-4407-9dba-71f904d0ea6e"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Doctor",
                  CategoryId = "a732a432-ef4f-4407-9dba-71f904d0ea6e"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Nurse",
                  CategoryId = "a732a432-ef4f-4407-9dba-71f904d0ea6e"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Pharmacy Technician",
                  CategoryId = "a732a432-ef4f-4407-9dba-71f904d0ea6e"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Pharmaceutical Scientist",
                  CategoryId = "a732a432-ef4f-4407-9dba-71f904d0ea6e"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Clinical Research Associate",
                  CategoryId = "a732a432-ef4f-4407-9dba-71f904d0ea6e"
              },
              //"Drivers, Couriers"
              new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Delivery Driver",
                  CategoryId = "b89927d7-b1fd-4703-98df-a4681ce2db88"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Courier",
                  CategoryId = "b89927d7-b1fd-4703-98df-a4681ce2db88"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Truck Driver",
                  CategoryId = "b89927d7-b1fd-4703-98df-a4681ce2db88"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Taxi Driver",
                  CategoryId = "b89927d7-b1fd-4703-98df-a4681ce2db88"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Bus Driver",
                  CategoryId = "b89927d7-b1fd-4703-98df-a4681ce2db88"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Van Driver",
                  CategoryId = "b89927d7-b1fd-4703-98df-a4681ce2db88"
              },
              //"Restaurants, Bars, Hotels, Tourism"
              new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Chef",
                  CategoryId = "07a32cf2-3c7a-4ab0-ab70-9952c0966f30"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Bartender",
                  CategoryId = "07a32cf2-3c7a-4ab0-ab70-9952c0966f30"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Waiter/Waitress",
                  CategoryId = "07a32cf2-3c7a-4ab0-ab70-9952c0966f30"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Restaurant Manager",
                  CategoryId = "07a32cf2-3c7a-4ab0-ab70-9952c0966f30"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Hotel Manager",
                  CategoryId = "07a32cf2-3c7a-4ab0-ab70-9952c0966f30"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Concierge",
                  CategoryId = "07a32cf2-3c7a-4ab0-ab70-9952c0966f30"
              },
              //"Engineers and Technicians"
              new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Mechanical Engineer",
                  CategoryId = "38b5eb73-7829-497b-a207-9bcf3fef3b1b"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Electrical Engineer",
                  CategoryId = "38b5eb73-7829-497b-a207-9bcf3fef3b1b"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Civil Engineer",
                  CategoryId = "38b5eb73-7829-497b-a207-9bcf3fef3b1b"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Chemical Engineer",
                  CategoryId = "38b5eb73-7829-497b-a207-9bcf3fef3b1b"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Computer Engineer",
                  CategoryId = "38b5eb73-7829-497b-a207-9bcf3fef3b1b"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Software Engineer",
                  CategoryId = "38b5eb73-7829-497b-a207-9bcf3fef3b1b"
              },
              //"Human Resources"
              new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "HR Manager",
                  CategoryId = "438c1389-c017-43b8-a34a-46b8c64f5e1d"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Talent Acquisition Specialist/Recruiter",
                  CategoryId = "438c1389-c017-43b8-a34a-46b8c64f5e1d"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Compensation and Benefits Manager",
                  CategoryId = "438c1389-c017-43b8-a34a-46b8c64f5e1d"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Training and Development Specialist",
                  CategoryId = "438c1389-c017-43b8-a34a-46b8c64f5e1d"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "HR Coordinator",
                  CategoryId = "438c1389-c017-43b8-a34a-46b8c64f5e1d"
              },
              // "Media, Publishing"
              new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Journalist",
                  CategoryId = "3c1fda93-5ef8-4db2-97f7-25f163fbca67"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Editor",
                  CategoryId = "3c1fda93-5ef8-4db2-97f7-25f163fbca67"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Writer",
                  CategoryId = "3c1fda93-5ef8-4db2-97f7-25f163fbca67"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Reporter",
                  CategoryId = "3c1fda93-5ef8-4db2-97f7-25f163fbca67"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Publisher",
                  CategoryId = "3c1fda93-5ef8-4db2-97f7-25f163fbca67"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Copy Editor",
                  CategoryId = "3c1fda93-5ef8-4db2-97f7-25f163fbca67"
              },
              //"Logistics, Spedition"
              new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Logistics Coordinator",
                  CategoryId = "c4dd9eea-1569-402f-a5b8-8473f48437a1"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Supply Chain Manager",
                  CategoryId = "c4dd9eea-1569-402f-a5b8-8473f48437a1"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Freight Forwarder",
                  CategoryId = "c4dd9eea-1569-402f-a5b8-8473f48437a1"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Warehouse Manager",
                  CategoryId = "c4dd9eea-1569-402f-a5b8-8473f48437a1"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Distribution Manager",
                  CategoryId = "c4dd9eea-1569-402f-a5b8-8473f48437a1"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Transportation Planner",
                  CategoryId = "c4dd9eea-1569-402f-a5b8-8473f48437a1"
              },
              //"Customer support"
              new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Customer Service Representative",
                  CategoryId = "c468efd1-09cf-4e6c-9245-2e837e500968"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Technical Support Specialist",
                  CategoryId = "c468efd1-09cf-4e6c-9245-2e837e500968"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Technical Support Specialist",
                  CategoryId = "c468efd1-09cf-4e6c-9245-2e837e500968"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Help Desk Analyst",
                  CategoryId = "c468efd1-09cf-4e6c-9245-2e837e500968"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Customer Success Manager",
                  CategoryId = "c468efd1-09cf-4e6c-9245-2e837e500968"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Client Support Specialist",
                  CategoryId = "c468efd1-09cf-4e6c-9245-2e837e500968"
              },
              //"Banking, Lending, Insurance"
              new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Bank Teller",
                  CategoryId = "ff13d479-760d-4387-8843-c882ad150609"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Loan Officer",
                  CategoryId = "ff13d479-760d-4387-8843-c882ad150609"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Financial Advisor",
                  CategoryId = "ff13d479-760d-4387-8843-c882ad150609"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Branch Manager",
                  CategoryId = "ff13d479-760d-4387-8843-c882ad150609"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Mortgage Broker",
                  CategoryId = "ff13d479-760d-4387-8843-c882ad150609"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Credit Analyst",
                  CategoryId = "ff13d479-760d-4387-8843-c882ad150609"
              },
              // "Marketing, Advertising, PR"
              new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Marketing Manager",
                  CategoryId = "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Advertising Executive",
                  CategoryId = "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Public Relations Specialist",
                  CategoryId = "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Brand Manager",
                  CategoryId = "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Digital Marketing Specialist",
                  CategoryId = "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Social Media Manager",
                  CategoryId = "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb"
              },
              // "Office and Business activities"
              new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Office Manager",
                  CategoryId = "71eb6b38-7552-425e-bf09-ee22d23855bb"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Administrative Assistant",
                  CategoryId = "71eb6b38-7552-425e-bf09-ee22d23855bb"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Executive Assistant",
                  CategoryId = "71eb6b38-7552-425e-bf09-ee22d23855bb"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Office Administrator",
                  CategoryId = "71eb6b38-7552-425e-bf09-ee22d23855bb"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Receptionist",
                  CategoryId = "71eb6b38-7552-425e-bf09-ee22d23855bb"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Data Entry Clerk",
                  CategoryId = "71eb6b38-7552-425e-bf09-ee22d23855bb"
              },
              // "Energy, Water and Sewage, Utilities"
              new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Electrical Engineer",
                  CategoryId = "f239ac3f-856e-494c-95df-2521a3269a6b"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Mechanical Engineer",
                  CategoryId = "f239ac3f-856e-494c-95df-2521a3269a6b"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Power Plant Operator",
                  CategoryId = "f239ac3f-856e-494c-95df-2521a3269a6b"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Utility Technician",
                  CategoryId = "f239ac3f-856e-494c-95df-2521a3269a6b"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Energy Analyst",
                  CategoryId = "f239ac3f-856e-494c-95df-2521a3269a6b"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Renewable Energy Specialist",
                  CategoryId = "f239ac3f-856e-494c-95df-2521a3269a6b"
              },
              // "Telecommunications - engineers and technicians"
              new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Telecommunications Engineer",
                  CategoryId = "3ea25504-1598-4608-a362-84d82b1b2fce"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Network Engineer",
                  CategoryId = "3ea25504-1598-4608-a362-84d82b1b2fce"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Telecom Systems Engineer",
                  CategoryId = "3ea25504-1598-4608-a362-84d82b1b2fce"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "RF Engineer (Radio Frequency)",
                  CategoryId = "3ea25504-1598-4608-a362-84d82b1b2fce"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Optical Network Engineer",
                  CategoryId = "3ea25504-1598-4608-a362-84d82b1b2fce"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "VoIP Engineer (Voice over Internet Protocol)",
                  CategoryId = "3ea25504-1598-4608-a362-84d82b1b2fce"
              },
              // "Education, Courses, Translators"
              new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Teacher",
                  CategoryId = "16bf1012-a018-453d-97f2-d9682a3588f1"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Professor",
                  CategoryId = "16bf1012-a018-453d-97f2-d9682a3588f1"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Instructor",
                  CategoryId = "16bf1012-a018-453d-97f2-d9682a3588f1"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Tutor",
                  CategoryId = "16bf1012-a018-453d-97f2-d9682a3588f1"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Educational Consultant",
                  CategoryId = "16bf1012-a018-453d-97f2-d9682a3588f1"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Curriculum Developer",
                  CategoryId = "16bf1012-a018-453d-97f2-d9682a3588f1"
              },
              // "Security"
              new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Security Guard",
                  CategoryId = "8910967e-2a14-4a1a-a3f5-d16cc78a4b32"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Security Officer",
                  CategoryId = "8910967e-2a14-4a1a-a3f5-d16cc78a4b32"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Security Supervisor",
                  CategoryId = "8910967e-2a14-4a1a-a3f5-d16cc78a4b32"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Security Manager",
                  CategoryId = "8910967e-2a14-4a1a-a3f5-d16cc78a4b32"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Private Investigator",
                  CategoryId = "8910967e-2a14-4a1a-a3f5-d16cc78a4b32"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Bodyguard",
                  CategoryId = "8910967e-2a14-4a1a-a3f5-d16cc78a4b32"
              },
              // "Real-estate"
              new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Real Estate Agent",
                  CategoryId = "0676aec9-89f5-4511-b642-6d0fe86e404a"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Real Estate Broker",
                  CategoryId = "0676aec9-89f5-4511-b642-6d0fe86e404a"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Realtor",
                  CategoryId = "0676aec9-89f5-4511-b642-6d0fe86e404a"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Property Manager",
                  CategoryId = "0676aec9-89f5-4511-b642-6d0fe86e404a"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Real Estate Appraiser",
                  CategoryId = "0676aec9-89f5-4511-b642-6d0fe86e404a"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Leasing Consultant",
                  CategoryId = "0676aec9-89f5-4511-b642-6d0fe86e404a"
              },
              //"Legal"
              new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Lawyer/Attorney",
                  CategoryId = "ec4b3c64-1f2f-455d-a6e4-75b525625371"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Paralegal",
                  CategoryId = "ec4b3c64-1f2f-455d-a6e4-75b525625371"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Legal Assistant",
                  CategoryId = "ec4b3c64-1f2f-455d-a6e4-75b525625371"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Legal Secretary",
                  CategoryId = "ec4b3c64-1f2f-455d-a6e4-75b525625371"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Judge",
                  CategoryId = "ec4b3c64-1f2f-455d-a6e4-75b525625371"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Legal Consultant",
                  CategoryId = "ec4b3c64-1f2f-455d-a6e4-75b525625371"
              },
              // "Aviation, Airport & Airline"
              new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Pilot",
                  CategoryId = "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Co-pilot/First Officer",
                  CategoryId = "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Flight Attendant",
                  CategoryId = "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Air Traffic Controller",
                  CategoryId = "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Aircraft Maintenance Technician",
                  CategoryId = "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Aircraft Dispatcher",
                  CategoryId = "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c"
              },
              // "Auto Service"
              new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Automotive Technician/Mechanic",
                  CategoryId = "221e3547-3c78-41f9-9634-d7571a615fb8"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Automotive Service Advisor",
                  CategoryId = "221e3547-3c78-41f9-9634-d7571a615fb8"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Auto Body Repair Technician",
                  CategoryId = "221e3547-3c78-41f9-9634-d7571a615fb8"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Automotive Electrician",
                  CategoryId = "221e3547-3c78-41f9-9634-d7571a615fb8"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Brake Technician",
                  CategoryId = "221e3547-3c78-41f9-9634-d7571a615fb8"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Transmission Technician",
                  CategoryId = "221e3547-3c78-41f9-9634-d7571a615fb8"
              },
              // "Retail, Wholesale"
              new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Retail Sales Associate",
                  CategoryId = "265bc199-91e3-4eba-9886-bce0a19e6ce2"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Store Manager",
                  CategoryId = "265bc199-91e3-4eba-9886-bce0a19e6ce2"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Assistant Store Manager",
                  CategoryId = "265bc199-91e3-4eba-9886-bce0a19e6ce2"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Cashier",
                  CategoryId = "265bc199-91e3-4eba-9886-bce0a19e6ce2"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Customer Service Representative",
                  CategoryId = "265bc199-91e3-4eba-9886-bce0a19e6ce2"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Retail Merchandiser",
                  CategoryId = "265bc199-91e3-4eba-9886-bce0a19e6ce2"
              },
              // "Technical Support"
              new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Technical Support Specialist",
                  CategoryId = "fd71ecf5-cb6d-4e3c-ad4e-84358bdfa328"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Help Desk Technician",
                  CategoryId = "fd71ecf5-cb6d-4e3c-ad4e-84358bdfa328"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "IT Support Engineer",
                  CategoryId = "fd71ecf5-cb6d-4e3c-ad4e-84358bdfa328"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Customer Support Engineer",
                  CategoryId = "fd71ecf5-cb6d-4e3c-ad4e-84358bdfa328"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Desktop Support Technician",
                  CategoryId = "fd71ecf5-cb6d-4e3c-ad4e-84358bdfa328"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Network Support Technician",
                  CategoryId = "fd71ecf5-cb6d-4e3c-ad4e-84358bdfa328"
              },
              //  "Research and development"
              new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Research Scientist",
                  CategoryId = "6859c0a0-98d0-49c5-b017-17d2a64d3342"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "R&D Engineer",
                  CategoryId = "6859c0a0-98d0-49c5-b017-17d2a64d3342"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Research Associate",
                  CategoryId = "6859c0a0-98d0-49c5-b017-17d2a64d3342"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Laboratory Technician",
                  CategoryId = "6859c0a0-98d0-49c5-b017-17d2a64d3342"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Product Development Manager",
                  CategoryId = "6859c0a0-98d0-49c5-b017-17d2a64d3342"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Data Scientist",
                  CategoryId = "6859c0a0-98d0-49c5-b017-17d2a64d3342"
              },
              // "Accouting, Audit, Finance"
              new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Accountant",
                  CategoryId = "dc8214a6-79cf-436c-bae1-7387b82a3bce"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Auditor",
                  CategoryId = "dc8214a6-79cf-436c-bae1-7387b82a3bce"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Financial Analyst",
                  CategoryId = "dc8214a6-79cf-436c-bae1-7387b82a3bce"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Certified Public Accountant (CPA)",
                  CategoryId = "dc8214a6-79cf-436c-bae1-7387b82a3bce"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Tax Accountant",
                  CategoryId = "dc8214a6-79cf-436c-bae1-7387b82a3bce"
              }, new Profession
              {
                  Id = Guid.NewGuid().ToString(),
                  Name = "Bookkeeper",
                  CategoryId = "dc8214a6-79cf-436c-bae1-7387b82a3bce"
              });
        }
    }
}
