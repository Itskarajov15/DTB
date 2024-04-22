//using DTB.Infrastructure.Data.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace DTB.Infrastructure.Data.Configurations
//{
//    public class CompanyEntityConfiguration : IEntityTypeConfiguration<Company>
//    {
//        public void Configure(EntityTypeBuilder<Company> builder)
//        {
//            new List<Company>()
//            {
//                new Company
//                    {
//                        //Id = "993a6fd5-7c2b-4789-9104-8353e676e0ab",
//                        Name = "InnovateTech Solutions Inc.",
//                        Address = "789 Innovation Drive, Techville, Techland 67890",
//                        CategoryId = "438c1389-c017-43b8-a34a-46b8c64f5e1d"
//                    },
//                    new Company
//                    {
//                        //Id = "c3c7cfd4-3cfb-48e1-88ac-9a60ad22ad5b",
//                        Name = "HealthCare Solutions Ltd.",
//                        Address = "101 Medical Avenue, Medtown, Healthland 12345",
//                        CategoryId = "a732a432-ef4f-4407-9dba-71f904d0ea6e"
//                    },
//                    new Company
//                    {
//                       // Id = "04acfc77-893b-4c23-8815-666c472e4dc1",
//                        Name = "FinancialEdge Advisors LLC",
//                        Address = "222 Financial Street, FinCity, FinLand 45678",
//                        CategoryId = "dc8214a6-79cf-436c-bae1-7387b82a3bce"
//                    },
//                    new Company
//                    {
//                      //  Id = "35b872d7-c69c-4852-8b7b-2b10efbfa0c1",
//                        Name = "EduTech Academy Inc.",
//                        Address = "333 Education Lane, EduTown, LearnLand 78901",
//                        CategoryId = "16bf1012-a018-453d-97f2-d9682a3588f1"
//                    },
//                    new Company
//                    {
//                        //Id = "889ab26c-41e4-4edf-b23d-dcc5b464c500",
//                        Name = "MarketBoost Marketing Agency",
//                        Address = "444 Advertisers Avenue, AdCity, PromoLand 23456",
//                        CategoryId = "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb"
//                    },
//                    new Company
//                    {
//                        //Id = "0cf20cc9-7c59-4a5f-abe5-50337f23085f",
//                        Name = "TalentMax HR Solutions Ltd.",
//                        Address = "555 HR Plaza, HRTown, TalentLand 56789",
//                        CategoryId = "438c1389-c017-43b8-a34a-46b8c64f5e1d"
//                    },
//                    new Company
//                    {
//                        //Id = "f7a5f370-17f8-42d3-9d65-5ac57a185d8d",
//                        Name = "Prime Properties Realty",
//                        Address = "666 Realty Street, RealCity, EstateLand 34567",
//                        CategoryId = "0676aec9-89f5-4511-b642-6d0fe86e404a"
//                    },
//                    new Company
//                    {
//                       // Id = "a4e72d2b-22a3-4b36-8ae8-d4bcfacbb27b",
//                        Name = "SwiftLogistics Solutions Inc.",
//                        Address = "777 Logistics Road, LogTown, ShipLand 89012",
//                        CategoryId = "c4dd9eea-1569-402f-a5b8-8473f48437a1"
//                    },
//                    new Company
//                    {
//                       // Id = "d8770595-981a-4c7d-b6aa-eeb01fd41a0f",
//                        Name = "SupportMaster Solutions Ltd.",
//                        Address = "888 Support Avenue, HelpCity, AssistLand 90123",
//                        CategoryId = "c468efd1-09cf-4e6c-9245-2e837e500968"
//                    },
//                    new Company
//                    {
//                        //Id = "985e1d94-1247-4f41-b0a4-f7d7c6d0e3dc",
//                        Name = "LegalEase Attorneys at Law",
//                        Address = "999 Legal Street, LawCity, CourtLand 67890",
//                        CategoryId = "ec4b3c64-1f2f-455d-a6e4-75b525625371"
//                    },
//                    new Company
//                    {
//                       // Id = "b7e7d55e-c12e-43df-bb2e-1a9b27ff7b13",
//                        Name = "SecureGuard Security Services Inc.",
//                        Address = "111 Security Lane, SafeCity, ProtectLand 12345",
//                        CategoryId = "8910967e-2a14-4a1a-a3f5-d16cc78a4b32"
//                    },
//                    new Company
//                    {
//                       // Id = "c2123a08-b227-4e8a-af0e-935d2b39b97d",
//                        Name = "MegaMart Retailers Inc.",
//                        Address = "222 Retail Road, ShopCity, SaleLand 23456",
//                        CategoryId = "265bc199-91e3-4eba-9886-bce0a19e6ce2"
//                    },
//                    new Company
//                    {
//                        //Id = "e9282cd4-f4c0-4977-bac9-ef0b6b8d3e07",
//                        Name = "ResearchInnovate R&D Ltd.",
//                        Address = "333 Research Street, LabCity, InnovateLand 34567",
//                        CategoryId = "6859c0a0-98d0-49c5-b017-17d2a64d3342"
//                    },
//                    new Company
//                    {
//                      //  Id = "67b43df8-fbe9-42c7-86a4-0d10fe18b181",
//                        Name = "AutoTech Service Center",
//                        Address = "444 Auto Avenue, CarCity, DriveLand 45678",
//                        CategoryId = "221e3547-3c78-41f9-9634-d7571a615fb8"
//                    },
//                    new Company
//                    {
//                      //  Id = "7eaf9e2a-71ef-42a0-97d5-9461e9e29a10",
//                        Name = "TeleComTech Solutions Ltd.",
//                        Address = "555 Telecom Street, ConnectCity, NetLand 56789",
//                        CategoryId = "3ea25504-1598-4608-a362-84d82b1b2fce"
//                    },
//                    new Company
//                    {
//                     //  Id = "9f31e35d-05a4-4a4e-bc17-d757173cd1a6",
//                        Name = "EnergySolutions Ltd.",
//                        Address = "666 Energy Road, PowerCity, WattLand 67890",
//                        CategoryId = "f239ac3f-856e-494c-95df-2521a3269a6b"
//                    },
//                    new Company
//                    {
//                       // Id = "c9bc07a5-85c8-4711-9de3-d85c2de6c8e5",
//                        Name = "MediaMaster Publishing Inc.",
//                        Address = "777 Media Lane, PressCity, PublishLand 89012",
//                        CategoryId = "3c1fda93-5ef8-4db2-97f7-25f163fbca67"
//                    },
//                    new Company
//                    {
//                       // Id = "2b67c9fc-4499-48a2-8d86-9c8191ee8b77",
//                        Name = "OfficePro Business Solutions Inc.",
//                        Address = "888 Business Avenue, WorkCity, OfficeLand 90123",
//                        CategoryId = "71eb6b38-7552-425e-bf09-ee22d23855bb"
//                    },
//                    new Company
//                    {
//                       // Id = "b71e8003-ee32-4c5b-93c4-51e3f98c5f39",
//                        Name = "FinancialSecure Banking Corporation",
//                        Address = "999 Banking Street, MoneyCity, InsureLand 34567",
//                        CategoryId = "ff13d479-760d-4387-8843-c882ad150609"
//                    },
//                    new Company
//                    {
//                      //  Id = "d31993cb-3b2a-402e-9470-ae526c8e963e",
//                        Name = "AeroTech Airlines Inc.",
//                        Address = "111 Aviation Road, FlyCity, SkyLand 67890",
//                        CategoryId = "18aee4dd-17bc-4fe9-8d8d-18ed13a9138c"

//                    },
//                    new Company
//                    {
//                      //  Id = "84e4a107-65fc-4bc0-983e-7d556998e60d",
//                        Name = "AutoCare Service Center",
//                        Address = "222 Auto Street, FixCity, RevLand 12345",
//                        CategoryId = "221e3547-3c78-41f9-9634-d7571a615fb8"

//                    },
//                    new Company
//                    {
//                      //  Id = "8fd3d11e-189a-4a18-9255-64bc1c76035b",
//                        Name = "TechSupport Solutions Ltd.",
//                        Address = "333 Tech Lane, ITCity, SupportLand 23456",
//                        CategoryId = "fd71ecf5-cb6d-4e3c-ad4e-84358bdfa328"
//                    },
//                    new Company
//                    {
//                       // Id = "5a92e15c-89e2-4dc3-a405-1919f9e1fc8e",
//                        Name = "MarketBoost Marketing Agency",
//                        Address = "444 Advertisers Avenue, AdCity, PromoLand 34567",
//                        CategoryId = "bdb3c38b-bc2f-48d3-a2f6-56f74573cecb"

//                    },
//                    new Company
//                    {
//                      //  Id = "b47a504c-d9e8-4931-8829-4b82844f7685",
//                        Name = "FinTech Financial Solutions Inc.",
//                        Address = "555 Finance Street, MoneyCity, AuditLand 45678",
//                        CategoryId = "16bf1012-a018-453d-97f2-d9682a3588f1"
//                    }
//            };
//        }
//    }
//}