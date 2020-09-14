﻿// <auto-generated />
using System;
using AssessmentEngine.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AssessmentEngine.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7");

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("ApplicationRoles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5d587953-2fb4-4198-9a5d-e64095439783"),
                            ConcurrencyStamp = "9b0e05e9-6c2d-4e35-bc0a-ddee6772dab2",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"),
                            ConcurrencyStamp = "1f29db58-42ab-44b4-9a72-ae21a05bbf02",
                            Name = "Participant",
                            NormalizedName = "PARTICIPANT"
                        });
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.ApplicationRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("ApplicationRoleClaims");
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("ParticipantId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ParticipantTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.HasIndex("ParticipantId")
                        .IsUnique();

                    b.HasIndex("ParticipantTypeId");

                    b.ToTable("ApplicationUsers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("61479990-b62a-40e4-8973-f6d6eb1ab9b8"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "66046443-f6a0-4c4a-beed-902dc49f1903",
                            Email = "admin@assessment.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ASSESSMENT.COM",
                            NormalizedUserName = "ADMIN@ASSESSMENT.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGwu9ZqklcHcnJ2rf9wzQDYQZKFmGpJ6Ye65my0yvVsjqBW4yfFZ+gli0PicTseu0Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "QJYMV3R4ITNYXH7EV3JVN3M2DZXEQZEF",
                            TwoFactorEnabled = false,
                            UserName = "admin@assessment.com"
                        });
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.ApplicationUserAudit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ApplicationUserAuditId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ActionDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ApplicationUserAuditTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ApplicationUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ApplicationUserAuditUid")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserAuditTypeId");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("ApplicationUserAudits");
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.ApplicationUserAuditType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ApplicationUserAuditTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(500);

                    b.Property<int>("SortOrder")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ApplicationUserAuditTypeUid")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUserAuditTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2020, 9, 13, 20, 29, 17, 208, DateTimeKind.Local).AddTicks(6780),
                            Name = "Login",
                            SortOrder = 1,
                            Uid = new Guid("fdfdae4f-4d1f-4fbd-8f69-7189b13953c0"),
                            UpdateDate = new DateTime(2020, 9, 13, 20, 29, 17, 228, DateTimeKind.Local).AddTicks(3330)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2020, 9, 13, 20, 29, 17, 228, DateTimeKind.Local).AddTicks(5440),
                            Name = "Logout",
                            SortOrder = 2,
                            Uid = new Guid("bea3247d-b455-4854-8e57-978005a28d7f"),
                            UpdateDate = new DateTime(2020, 9, 13, 20, 29, 17, 228, DateTimeKind.Local).AddTicks(5470)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2020, 9, 13, 20, 29, 17, 228, DateTimeKind.Local).AddTicks(5670),
                            Name = "Lockout",
                            SortOrder = 3,
                            Uid = new Guid("86909065-99f5-40c7-9247-bff0f9739c1e"),
                            UpdateDate = new DateTime(2020, 9, 13, 20, 29, 17, 228, DateTimeKind.Local).AddTicks(5670)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2020, 9, 13, 20, 29, 17, 228, DateTimeKind.Local).AddTicks(5690),
                            Name = "PasswordReset",
                            SortOrder = 4,
                            Uid = new Guid("18942ed4-5b51-4e69-86aa-b890caaaffe9"),
                            UpdateDate = new DateTime(2020, 9, 13, 20, 29, 17, 228, DateTimeKind.Local).AddTicks(5690)
                        });
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.ApplicationUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ApplicationUserClaims");
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.ApplicationUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("ApplicationUserLogins");
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.ApplicationUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("ApplicationUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("61479990-b62a-40e4-8973-f6d6eb1ab9b8"),
                            RoleId = new Guid("5d587953-2fb4-4198-9a5d-e64095439783")
                        });
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.ApplicationUserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("ApplicationUserTokens");
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.Assessment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AssessmentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AssessmentVersionId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CompletedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartedDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AssessmentUid")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AssessmentVersionId");

                    b.ToTable("Assessments");
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.AssessmentBlock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AssessmentBlockId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AssessmentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BlockTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CompletedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("SeriesRecall")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AssessmentBlockUid")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BlockTypeId");

                    b.ToTable("AssessmentBlocks");
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.AssessmentParticipant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AssessmentParticipantId")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ApplicationUserId")
                        .HasColumnType("TEXT");

                    b.Property<int>("AssessmentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AssessmentParticipantUid")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("AssessmentId");

                    b.ToTable("AssessmentParticipants");
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.AssessmentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AssessmentTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(500);

                    b.Property<int>("SortOrder")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AssessmentTypeUid")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AssessmentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2020, 9, 13, 20, 29, 17, 249, DateTimeKind.Local).AddTicks(3220),
                            Name = "DualNBack",
                            SortOrder = 1,
                            Uid = new Guid("dbc2a2cc-b0f1-4d4b-b3dc-134ea99a9924"),
                            UpdateDate = new DateTime(2020, 9, 13, 20, 29, 17, 249, DateTimeKind.Local).AddTicks(3250)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2020, 9, 13, 20, 29, 17, 249, DateTimeKind.Local).AddTicks(3660),
                            Name = "EFT",
                            SortOrder = 2,
                            Uid = new Guid("3f5baf40-510e-4802-8cd4-5fa02b5a2cb9"),
                            UpdateDate = new DateTime(2020, 9, 13, 20, 29, 17, 249, DateTimeKind.Local).AddTicks(3670)
                        });
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.AssessmentVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AssessmentVersionId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AssessmentTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BlankScreenViewingTime")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CognitiveLoadViewingTime")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int?>("ImageViewingTime")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AssessmentVersionUid")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("VersionName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AssessmentTypeId");

                    b.ToTable("AssessmentVersions");
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.BlockType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("BlockTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(500);

                    b.Property<int>("SortOrder")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("BlockTypeUid")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("BlockTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2020, 9, 13, 20, 29, 17, 252, DateTimeKind.Local).AddTicks(8540),
                            Name = "E1",
                            SortOrder = 1,
                            Uid = new Guid("935db3eb-fd10-4b1f-8a16-745bcd32e7e9"),
                            UpdateDate = new DateTime(2020, 9, 13, 20, 29, 17, 252, DateTimeKind.Local).AddTicks(8580)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2020, 9, 13, 20, 29, 17, 252, DateTimeKind.Local).AddTicks(9060),
                            Name = "S1",
                            SortOrder = 2,
                            Uid = new Guid("11c29bfc-0699-4a15-bfd7-167afb70b30b"),
                            UpdateDate = new DateTime(2020, 9, 13, 20, 29, 17, 252, DateTimeKind.Local).AddTicks(9070)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2020, 9, 13, 20, 29, 17, 252, DateTimeKind.Local).AddTicks(9090),
                            Name = "E2",
                            SortOrder = 3,
                            Uid = new Guid("3347a1b0-c585-476e-92e2-6c918de6a4be"),
                            UpdateDate = new DateTime(2020, 9, 13, 20, 29, 17, 252, DateTimeKind.Local).AddTicks(9100)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2020, 9, 13, 20, 29, 17, 252, DateTimeKind.Local).AddTicks(9110),
                            Name = "S2",
                            SortOrder = 4,
                            Uid = new Guid("e88272c3-0507-4cbe-b748-91d0d2958c9d"),
                            UpdateDate = new DateTime(2020, 9, 13, 20, 29, 17, 252, DateTimeKind.Local).AddTicks(9120)
                        });
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.BlockVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("BlockVersionId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AssessmentVersionId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BlockTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CognitiveLoad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Series")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("BlockVersionUid")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AssessmentVersionId");

                    b.HasIndex("BlockTypeId");

                    b.ToTable("BlockVersions");
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.ParticipantType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ParticipantTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(500);

                    b.Property<int>("SortOrder")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ParticipantTypeUid")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ParticipantTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2020, 9, 13, 20, 29, 17, 257, DateTimeKind.Local).AddTicks(9350),
                            Name = "Civilian",
                            SortOrder = 1,
                            Uid = new Guid("6e592e84-cec3-4d73-a13b-0a48984678f0"),
                            UpdateDate = new DateTime(2020, 9, 13, 20, 29, 17, 257, DateTimeKind.Local).AddTicks(9380)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2020, 9, 13, 20, 29, 17, 257, DateTimeKind.Local).AddTicks(9780),
                            Name = "Veteran",
                            SortOrder = 2,
                            Uid = new Guid("bbc35e10-84a4-4bbc-a845-1cc01f55baf6"),
                            UpdateDate = new DateTime(2020, 9, 13, 20, 29, 17, 257, DateTimeKind.Local).AddTicks(9790)
                        });
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.ApplicationRoleClaim", b =>
                {
                    b.HasOne("AssessmentEngine.Domain.Entities.ApplicationRole", "Role")
                        .WithMany("RoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.ApplicationUser", b =>
                {
                    b.HasOne("AssessmentEngine.Domain.Entities.ParticipantType", "ParticipantType")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("ParticipantTypeId");
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.ApplicationUserAudit", b =>
                {
                    b.HasOne("AssessmentEngine.Domain.Entities.ApplicationUserAuditType", "ApplicationUserAuditType")
                        .WithMany("ApplicationUserAudits")
                        .HasForeignKey("ApplicationUserAuditTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AssessmentEngine.Domain.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("ApplicationUserAudits")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.ApplicationUserClaim", b =>
                {
                    b.HasOne("AssessmentEngine.Domain.Entities.ApplicationUser", "User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.ApplicationUserLogin", b =>
                {
                    b.HasOne("AssessmentEngine.Domain.Entities.ApplicationUser", "User")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.ApplicationUserRole", b =>
                {
                    b.HasOne("AssessmentEngine.Domain.Entities.ApplicationRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AssessmentEngine.Domain.Entities.ApplicationUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.ApplicationUserToken", b =>
                {
                    b.HasOne("AssessmentEngine.Domain.Entities.ApplicationUser", "User")
                        .WithMany("Tokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.Assessment", b =>
                {
                    b.HasOne("AssessmentEngine.Domain.Entities.AssessmentVersion", "AssessmentVersion")
                        .WithMany("Assessments")
                        .HasForeignKey("AssessmentVersionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.AssessmentBlock", b =>
                {
                    b.HasOne("AssessmentEngine.Domain.Entities.Assessment", "Assessment")
                        .WithMany("AssessmentBlocks")
                        .HasForeignKey("BlockTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AssessmentEngine.Domain.Entities.BlockType", "BlockType")
                        .WithMany("AssessmentBlocks")
                        .HasForeignKey("BlockTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.AssessmentParticipant", b =>
                {
                    b.HasOne("AssessmentEngine.Domain.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("AssessmentParticipants")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AssessmentEngine.Domain.Entities.Assessment", "Assessment")
                        .WithMany("AssessmentParticipants")
                        .HasForeignKey("AssessmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.AssessmentVersion", b =>
                {
                    b.HasOne("AssessmentEngine.Domain.Entities.AssessmentType", "AssessmentType")
                        .WithMany("AssessmentVersions")
                        .HasForeignKey("AssessmentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.BlockVersion", b =>
                {
                    b.HasOne("AssessmentEngine.Domain.Entities.AssessmentVersion", null)
                        .WithMany("BlockVersions")
                        .HasForeignKey("AssessmentVersionId");

                    b.HasOne("AssessmentEngine.Domain.Entities.BlockType", "BlockType")
                        .WithMany()
                        .HasForeignKey("BlockTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
