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
                            ConcurrencyStamp = "e547e6fb-07d4-4819-ab47-14d797385a1f",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"),
                            ConcurrencyStamp = "6586a0c1-34cd-46aa-b253-07402d9e53df",
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

                    b.ToTable("ApplicationUsers");
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
                            CreatedDate = new DateTime(2020, 9, 2, 23, 47, 16, 851, DateTimeKind.Local).AddTicks(1970),
                            Name = "Login",
                            Uid = new Guid("18e63da4-f65a-4899-92c1-10efc7e4306b"),
                            UpdateDate = new DateTime(2020, 9, 2, 23, 47, 16, 871, DateTimeKind.Local).AddTicks(1290)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2020, 9, 2, 23, 47, 16, 871, DateTimeKind.Local).AddTicks(2670),
                            Name = "Logout",
                            Uid = new Guid("ab74ba34-6a32-48cf-a7b1-6820f33723c8"),
                            UpdateDate = new DateTime(2020, 9, 2, 23, 47, 16, 871, DateTimeKind.Local).AddTicks(2680)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2020, 9, 2, 23, 47, 16, 871, DateTimeKind.Local).AddTicks(2710),
                            Name = "Lockout",
                            Uid = new Guid("e18f5d5b-f8d3-4fd5-8433-5aefd8c23441"),
                            UpdateDate = new DateTime(2020, 9, 2, 23, 47, 16, 871, DateTimeKind.Local).AddTicks(2720)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2020, 9, 2, 23, 47, 16, 871, DateTimeKind.Local).AddTicks(2730),
                            Name = "PasswordReset",
                            Uid = new Guid("8468eec9-52e2-4c95-be7f-209095883372"),
                            UpdateDate = new DateTime(2020, 9, 2, 23, 47, 16, 871, DateTimeKind.Local).AddTicks(2730)
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

                    b.Property<int>("AssessmentTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("AssessmentUserUID")
                        .HasColumnType("TEXT");

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

                    b.HasIndex("AssessmentTypeId");

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
                            CreatedDate = new DateTime(2020, 9, 2, 23, 47, 16, 887, DateTimeKind.Local).AddTicks(9490),
                            Name = "DualNBack",
                            Uid = new Guid("bc82fa2c-7fe1-4c18-b866-33499d60eb32"),
                            UpdateDate = new DateTime(2020, 9, 2, 23, 47, 16, 887, DateTimeKind.Local).AddTicks(9530)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2020, 9, 2, 23, 47, 16, 887, DateTimeKind.Local).AddTicks(9690),
                            Name = "EFT",
                            Uid = new Guid("8dd94aed-3d25-4c37-9ea2-d00112b7c23e"),
                            UpdateDate = new DateTime(2020, 9, 2, 23, 47, 16, 887, DateTimeKind.Local).AddTicks(9700)
                        });
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
                            CreatedDate = new DateTime(2020, 9, 2, 23, 47, 16, 891, DateTimeKind.Local).AddTicks(2360),
                            Name = "E1",
                            Uid = new Guid("20dfddc4-430c-459b-b1d1-1684949ad833"),
                            UpdateDate = new DateTime(2020, 9, 2, 23, 47, 16, 891, DateTimeKind.Local).AddTicks(2400)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2020, 9, 2, 23, 47, 16, 891, DateTimeKind.Local).AddTicks(2550),
                            Name = "S1",
                            Uid = new Guid("14182799-a2cb-484b-b30b-c3c02961fc0b"),
                            UpdateDate = new DateTime(2020, 9, 2, 23, 47, 16, 891, DateTimeKind.Local).AddTicks(2560)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2020, 9, 2, 23, 47, 16, 891, DateTimeKind.Local).AddTicks(2600),
                            Name = "E2",
                            Uid = new Guid("0b1b5ab7-5913-4d78-9a82-ce44529a3bf1"),
                            UpdateDate = new DateTime(2020, 9, 2, 23, 47, 16, 891, DateTimeKind.Local).AddTicks(2600)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2020, 9, 2, 23, 47, 16, 891, DateTimeKind.Local).AddTicks(2610),
                            Name = "S2",
                            Uid = new Guid("4555262a-0f84-412b-8bd9-2cb9ba9c5822"),
                            UpdateDate = new DateTime(2020, 9, 2, 23, 47, 16, 891, DateTimeKind.Local).AddTicks(2620)
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
                    b.HasOne("AssessmentEngine.Domain.Entities.AssessmentType", "AssessmentType")
                        .WithMany("Assessments")
                        .HasForeignKey("AssessmentTypeId")
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
#pragma warning restore 612, 618
        }
    }
}
