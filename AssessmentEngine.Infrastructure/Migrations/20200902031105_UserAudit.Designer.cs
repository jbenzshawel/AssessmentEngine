﻿// <auto-generated />
using System;
using AssessmentEngine.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AssessmentEngine.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200902031105_UserAudit")]
    partial class UserAudit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            ConcurrencyStamp = "ac6841cc-9e9b-40fd-962a-68ba7b433dfd",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"),
                            ConcurrencyStamp = "933bdb11-fc96-405b-aefa-59a8eb7d4bba",
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
                            CreatedDate = new DateTime(2020, 9, 1, 22, 11, 4, 821, DateTimeKind.Local).AddTicks(2800),
                            Name = "Login",
                            Uid = new Guid("253423e9-e8a3-4c5a-b30e-34f0b830249c"),
                            UpdateDate = new DateTime(2020, 9, 1, 22, 11, 4, 841, DateTimeKind.Local).AddTicks(5010)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2020, 9, 1, 22, 11, 4, 841, DateTimeKind.Local).AddTicks(6310),
                            Name = "Logout",
                            Uid = new Guid("5e7bbd4f-a114-4a14-9532-df7a3881a345"),
                            UpdateDate = new DateTime(2020, 9, 1, 22, 11, 4, 841, DateTimeKind.Local).AddTicks(6330)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2020, 9, 1, 22, 11, 4, 841, DateTimeKind.Local).AddTicks(6350),
                            Name = "Lockout",
                            Uid = new Guid("83298d08-00e2-403a-8033-76ee52e58e05"),
                            UpdateDate = new DateTime(2020, 9, 1, 22, 11, 4, 841, DateTimeKind.Local).AddTicks(6350)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2020, 9, 1, 22, 11, 4, 841, DateTimeKind.Local).AddTicks(6370),
                            Name = "PasswordReset",
                            Uid = new Guid("926afc7b-5abc-42c3-a642-68e3d9fcc8bc"),
                            UpdateDate = new DateTime(2020, 9, 1, 22, 11, 4, 841, DateTimeKind.Local).AddTicks(6370)
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
                            CreatedDate = new DateTime(2020, 9, 1, 22, 11, 4, 857, DateTimeKind.Local).AddTicks(7240),
                            Name = "DualNBack",
                            Uid = new Guid("5c1a88ad-c071-4ebe-bc19-73b11c7f90e9"),
                            UpdateDate = new DateTime(2020, 9, 1, 22, 11, 4, 857, DateTimeKind.Local).AddTicks(7280)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2020, 9, 1, 22, 11, 4, 857, DateTimeKind.Local).AddTicks(7430),
                            Name = "EFT",
                            Uid = new Guid("71a367ff-011e-481a-9b02-e2fd08deace3"),
                            UpdateDate = new DateTime(2020, 9, 1, 22, 11, 4, 857, DateTimeKind.Local).AddTicks(7440)
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
                            CreatedDate = new DateTime(2020, 9, 1, 22, 11, 4, 861, DateTimeKind.Local).AddTicks(4240),
                            Name = "E1",
                            Uid = new Guid("aedc5a15-16c8-44e3-afd0-e14e1e37a4de"),
                            UpdateDate = new DateTime(2020, 9, 1, 22, 11, 4, 861, DateTimeKind.Local).AddTicks(4280)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2020, 9, 1, 22, 11, 4, 861, DateTimeKind.Local).AddTicks(4450),
                            Name = "S1",
                            Uid = new Guid("5ec16940-1dca-45de-80d0-facb2012a2e4"),
                            UpdateDate = new DateTime(2020, 9, 1, 22, 11, 4, 861, DateTimeKind.Local).AddTicks(4450)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2020, 9, 1, 22, 11, 4, 861, DateTimeKind.Local).AddTicks(4470),
                            Name = "E2",
                            Uid = new Guid("1c8f9067-ab5b-40bb-80d2-eb75c273f316"),
                            UpdateDate = new DateTime(2020, 9, 1, 22, 11, 4, 861, DateTimeKind.Local).AddTicks(4470)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2020, 9, 1, 22, 11, 4, 861, DateTimeKind.Local).AddTicks(4490),
                            Name = "S2",
                            Uid = new Guid("d26306ea-e2f7-4758-9f29-af81913b724e"),
                            UpdateDate = new DateTime(2020, 9, 1, 22, 11, 4, 861, DateTimeKind.Local).AddTicks(4490)
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
