﻿// <auto-generated />
using System;
using LIBRARY.EXWHYZEE.LGT.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EXWHYZEE.LGT.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EXWHYZEE.LGT.Data.Model.AppRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("EXWHYZEE.LGT.Data.Model.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryProfile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateStart")
                        .HasColumnType("datetime2");

                    b.Property<long>("LocalGovernmentId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LocalGovernmentId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EXWHYZEE.LGT.Data.Model.CategoryExecutive", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CategoryId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("CategoryExecutives");
                });

            modelBuilder.Entity("EXWHYZEE.LGT.Data.Model.Community", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Employed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Female")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandMass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("LocalGovernmentId")
                        .HasColumnType("bigint");

                    b.Property<string>("Longitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Male")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Populations")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SelfEmployed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnEmployed")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LocalGovernmentId");

                    b.ToTable("Communities");
                });

            modelBuilder.Entity("EXWHYZEE.LGT.Data.Model.CommunityExecutive", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CommunityId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CommunityId");

                    b.HasIndex("UserId");

                    b.ToTable("CommunityExecutives");
                });

            modelBuilder.Entity("EXWHYZEE.LGT.Data.Model.LgaStaff", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EmploymentDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("LocalGovernmentId")
                        .HasColumnType("bigint");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RetirementDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("LocalGovernmentId");

                    b.HasIndex("UserId");

                    b.ToTable("LgaStaffs");
                });

            modelBuilder.Entity("EXWHYZEE.LGT.Data.Model.LocalGovernment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Employed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Female")
                        .HasColumnType("int");

                    b.Property<string>("LandMass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Male")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Populations")
                        .HasColumnType("int");

                    b.Property<string>("SelfEmployed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("StateId")
                        .HasColumnType("bigint");

                    b.Property<string>("UnEmployed")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("LocalGovernments");
                });

            modelBuilder.Entity("EXWHYZEE.LGT.Data.Model.LocalGovtExecutive", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("LocalGovernmentId")
                        .HasColumnType("bigint");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("LocalGovernmentId");

                    b.HasIndex("UserId");

                    b.ToTable("LocalGovtExecutives");
                });

            modelBuilder.Entity("EXWHYZEE.LGT.Data.Model.MineralResource", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CommunityId")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CommunityId");

                    b.ToTable("MineralResources");
                });

            modelBuilder.Entity("EXWHYZEE.LGT.Data.Model.Profile", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("AltPoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AppointmentLetter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BodyStructure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("CommunitiesId")
                        .HasColumnType("bigint");

                    b.Property<long?>("CommunitytId")
                        .HasColumnType("bigint");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EmploymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullContactAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Height")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Level")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("LocalGovernmentId")
                        .HasColumnType("bigint");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Middlename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("Passport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermanentHomeAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rank")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RetirementDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SalaryAccountBank")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalaryAccountName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalaryAccountNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("StateId")
                        .HasColumnType("bigint");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("ValidIdCard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Weight")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CommunitiesId");

                    b.HasIndex("LocalGovernmentId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("StateId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("EXWHYZEE.LGT.Data.Model.Section", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CategoryId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("EXWHYZEE.LGT.Data.Model.SectionDocument", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpiringDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("SectionId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SectionId");

                    b.ToTable("SectionDocuments");
                });

            modelBuilder.Entity("EXWHYZEE.LGT.Data.Model.SectionExecutive", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("SectionId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("SectionId");

                    b.HasIndex("UserId");

                    b.ToTable("SectionExecutives");
                });

            modelBuilder.Entity("EXWHYZEE.LGT.Data.Model.State", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("States");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("EXWHYZEE.LGT.Data.Model.Category", b =>
                {
                    b.HasOne("EXWHYZEE.LGT.Data.Model.LocalGovernment", "LocalGovernment")
                        .WithMany("Categories")
                        .HasForeignKey("LocalGovernmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EXWHYZEE.LGT.Data.Model.CategoryExecutive", b =>
                {
                    b.HasOne("EXWHYZEE.LGT.Data.Model.Category", "Category")
                        .WithMany("CategoryExecutives")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("EXWHYZEE.LGT.Data.Model.Community", b =>
                {
                    b.HasOne("EXWHYZEE.LGT.Data.Model.LocalGovernment", "LocalGovernment")
                        .WithMany("Communities")
                        .HasForeignKey("LocalGovernmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EXWHYZEE.LGT.Data.Model.CommunityExecutive", b =>
                {
                    b.HasOne("EXWHYZEE.LGT.Data.Model.Community", "Community")
                        .WithMany("CommunityExecutives")
                        .HasForeignKey("CommunityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("EXWHYZEE.LGT.Data.Model.LgaStaff", b =>
                {
                    b.HasOne("EXWHYZEE.LGT.Data.Model.LocalGovernment", "LocalGovernment")
                        .WithMany("LgaStaff")
                        .HasForeignKey("LocalGovernmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("EXWHYZEE.LGT.Data.Model.LocalGovernment", b =>
                {
                    b.HasOne("EXWHYZEE.LGT.Data.Model.State", "State")
                        .WithMany("LocalGovernments")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EXWHYZEE.LGT.Data.Model.LocalGovtExecutive", b =>
                {
                    b.HasOne("EXWHYZEE.LGT.Data.Model.LocalGovernment", "LocalGovernment")
                        .WithMany("LocalGovtExecutives")
                        .HasForeignKey("LocalGovernmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("EXWHYZEE.LGT.Data.Model.MineralResource", b =>
                {
                    b.HasOne("EXWHYZEE.LGT.Data.Model.Community", "Community")
                        .WithMany("MineralResources")
                        .HasForeignKey("CommunityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EXWHYZEE.LGT.Data.Model.Profile", b =>
                {
                    b.HasOne("EXWHYZEE.LGT.Data.Model.Community", "Communities")
                        .WithMany()
                        .HasForeignKey("CommunitiesId");

                    b.HasOne("EXWHYZEE.LGT.Data.Model.LocalGovernment", "LocalGovernment")
                        .WithMany()
                        .HasForeignKey("LocalGovernmentId");

                    b.HasOne("EXWHYZEE.LGT.Data.Model.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId");
                });

            modelBuilder.Entity("EXWHYZEE.LGT.Data.Model.Section", b =>
                {
                    b.HasOne("EXWHYZEE.LGT.Data.Model.Category", "Category")
                        .WithMany("Sections")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EXWHYZEE.LGT.Data.Model.SectionDocument", b =>
                {
                    b.HasOne("EXWHYZEE.LGT.Data.Model.Section", "Section")
                        .WithMany("SectionDocuments")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EXWHYZEE.LGT.Data.Model.SectionExecutive", b =>
                {
                    b.HasOne("EXWHYZEE.LGT.Data.Model.Section", "Section")
                        .WithMany("SectionExecutives")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("EXWHYZEE.LGT.Data.Model.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("EXWHYZEE.LGT.Data.Model.Profile", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EXWHYZEE.LGT.Data.Model.Profile", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("EXWHYZEE.LGT.Data.Model.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EXWHYZEE.LGT.Data.Model.Profile", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("EXWHYZEE.LGT.Data.Model.Profile", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
