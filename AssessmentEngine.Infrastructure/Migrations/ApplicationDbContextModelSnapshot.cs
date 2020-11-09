﻿// <auto-generated />
using System;
using AssessmentEngine.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AssessmentEngine.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("character varying(256)")
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
                            ConcurrencyStamp = "4667977b-6282-4c0c-a428-f9fbc0ac0ae4",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"),
                            ConcurrencyStamp = "c32513a1-7535-40c7-b215-20379fb3ecc8",
                            Name = "Participant",
                            NormalizedName = "PARTICIPANT"
                        });
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.ApplicationRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("ApplicationRoleClaims");
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("ParticipantId")
                        .HasColumnType("text");

                    b.Property<int?>("ParticipantTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("character varying(256)")
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
                        },
                        new
                        {
                            Id = new Guid("b4c0ddd2-86e7-4193-9da2-9950abdb909c"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "dbd73ece-9ffc-4d48-b214-5d151d7a4dfa",
                            Email = "vetflex@tc.columbia.edu",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "VETFLEX@TC.COLUMBIA.EDU",
                            NormalizedUserName = "VETFLEX@TC.COLUMBIA.EDU",
                            PasswordHash = "AQAAAAEAACcQAAAAEGwu9ZqklcHcnJ2rf9wzQDYQZKFmGpJ6Ye65my0yvVsjqBW4yfFZ+gli0PicTseu0Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3GZIA7EYTIPDD6PE2LUY4XNAMVQ3D3BG",
                            TwoFactorEnabled = false,
                            UserName = "vetflex@tc.columbia.edu"
                        });
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.ApplicationUserAudit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ApplicationUserAuditId")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("ActionDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("ApplicationUserAuditTypeId")
                        .HasColumnType("integer");

                    b.Property<Guid>("ApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ApplicationUserAuditUid")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text");

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
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<int>("SortOrder")
                        .HasColumnType("integer");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUserAuditTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Login",
                            SortOrder = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Logout",
                            SortOrder = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Lockout",
                            SortOrder = 3
                        },
                        new
                        {
                            Id = 4,
                            Name = "PasswordReset",
                            SortOrder = 4
                        });
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.ApplicationUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ApplicationUserClaims");
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.ApplicationUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("ApplicationUserLogins");
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.ApplicationUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("ApplicationUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("61479990-b62a-40e4-8973-f6d6eb1ab9b8"),
                            RoleId = new Guid("5d587953-2fb4-4198-9a5d-e64095439783")
                        },
                        new
                        {
                            UserId = new Guid("b4c0ddd2-86e7-4193-9da2-9950abdb909c"),
                            RoleId = new Guid("5d587953-2fb4-4198-9a5d-e64095439783")
                        });
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.ApplicationUserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("ApplicationUserTokens");
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.Assessment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AssessmentId")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AssessmentVersionId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CompletedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("StartedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AssessmentUid")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AssessmentVersionId");

                    b.ToTable("Assessments");
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.AssessmentBlock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AssessmentBlockId")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AssessmentId")
                        .HasColumnType("integer");

                    b.Property<int>("BlockTypeId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CompletedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("SeriesRecall")
                        .HasColumnType("text");

                    b.Property<Guid>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AssessmentBlockUid")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("BlockTypeId");

                    b.ToTable("AssessmentBlocks");
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.AssessmentParticipant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AssessmentParticipantId")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<Guid>("ApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<int>("AssessmentId")
                        .HasColumnType("integer");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AssessmentParticipantUid")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text");

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
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<int>("SortOrder")
                        .HasColumnType("integer");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AssessmentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "DualNBack",
                            SortOrder = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "EFT",
                            SortOrder = 2
                        });
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.AssessmentVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AssessmentVersionId")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<Guid?>("ApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<int>("AssessmentTypeId")
                        .HasColumnType("integer");

                    b.Property<int?>("CognitiveLoadViewingTime")
                        .HasColumnType("integer");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("FixationCrossViewingTime")
                        .HasColumnType("integer");

                    b.Property<int?>("ImageViewingTime")
                        .HasColumnType("integer");

                    b.Property<Guid>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AssessmentVersionUid")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text");

                    b.Property<string>("VersionName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("AssessmentTypeId");

                    b.ToTable("AssessmentVersions");
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.BlockType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("BlockTypeId")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<int>("SortOrder")
                        .HasColumnType("integer");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("BlockTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "EP1",
                            SortOrder = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "EP2",
                            SortOrder = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "EN1",
                            SortOrder = 3
                        },
                        new
                        {
                            Id = 4,
                            Name = "EN2",
                            SortOrder = 4
                        },
                        new
                        {
                            Id = 5,
                            Name = "SP1",
                            SortOrder = 5
                        },
                        new
                        {
                            Id = 6,
                            Name = "SP2",
                            SortOrder = 6
                        },
                        new
                        {
                            Id = 7,
                            Name = "SN1",
                            SortOrder = 7
                        },
                        new
                        {
                            Id = 8,
                            Name = "SN2",
                            SortOrder = 8
                        },
                        new
                        {
                            Id = 9,
                            Name = "VP1",
                            SortOrder = 9
                        },
                        new
                        {
                            Id = 10,
                            Name = "VP2",
                            SortOrder = 10
                        },
                        new
                        {
                            Id = 11,
                            Name = "VN1",
                            SortOrder = 11
                        },
                        new
                        {
                            Id = 12,
                            Name = "VN2",
                            SortOrder = 12
                        });
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.BlockVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("BlockVersionId")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AssessmentVersionId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("BlockEndDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("BlockStartDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("BlockTypeId")
                        .HasColumnType("integer");

                    b.Property<bool>("CognitiveLoad")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("CompletedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("EmotionalRating")
                        .HasColumnType("text");

                    b.Property<string>("Series")
                        .HasColumnType("text");

                    b.Property<string>("SeriesRecall")
                        .HasColumnType("text");

                    b.Property<int>("SortOrder")
                        .HasColumnType("integer");

                    b.Property<Guid>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("BlockVersionUid")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text");

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
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<int>("SortOrder")
                        .HasColumnType("integer");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ParticipantTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Civilian",
                            SortOrder = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Veteran",
                            SortOrder = 2
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
                    b.HasOne("AssessmentEngine.Domain.Entities.ParticipantType", null)
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
                    b.HasOne("AssessmentEngine.Domain.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("AssessmentVersions")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("AssessmentEngine.Domain.Entities.AssessmentType", "AssessmentType")
                        .WithMany("AssessmentVersions")
                        .HasForeignKey("AssessmentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AssessmentEngine.Domain.Entities.BlockVersion", b =>
                {
                    b.HasOne("AssessmentEngine.Domain.Entities.AssessmentVersion", "AssessmentVersion")
                        .WithMany("BlockVersions")
                        .HasForeignKey("AssessmentVersionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
