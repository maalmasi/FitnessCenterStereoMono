﻿// <auto-generated />
using System;
using FitnessCenterStereo.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FitnessCenterStereo.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190910090216_Fitness")]
    partial class Fitness
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:PostgresExtension:pg_buffercache", ",,")
                .HasAnnotation("Npgsql:PostgresExtension:pg_stat_statements", ",,")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("FitnessCenterStereo.DAL.Models.BodyPartType", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("Abbreviation");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("date");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("BodyPartType");
                });

            modelBuilder.Entity("FitnessCenterStereo.DAL.Models.Card", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("date");

                    b.Property<Guid?>("MembershipId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Card");
                });

            modelBuilder.Entity("FitnessCenterStereo.DAL.Models.ComplexityLevelType", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("Abbreviation");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("date");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ComplexityLevelType");
                });

            modelBuilder.Entity("FitnessCenterStereo.DAL.Models.DietType", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("Abbreviation");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("date");

                    b.Property<string>("Ingridients");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("DietType");
                });

            modelBuilder.Entity("FitnessCenterStereo.DAL.Models.Equipment", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("date");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("FitnessCenterStereo.DAL.Models.ExerciseEquipment", b =>
                {
                    b.Property<Guid?>("ExercisesId");

                    b.Property<Guid?>("EquipmentId");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("date");

                    b.Property<Guid>("Id");

                    b.HasKey("ExercisesId", "EquipmentId");

                    b.HasIndex("EquipmentId");

                    b.ToTable("ExerciseEquipment");
                });

            modelBuilder.Entity("FitnessCenterStereo.DAL.Models.ExerciseSchedule", b =>
                {
                    b.Property<Guid?>("ExercisesId");

                    b.Property<Guid?>("ScheduleId");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("date");

                    b.Property<Guid>("Id");

                    b.HasKey("ExercisesId", "ScheduleId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("ExerciseSchedule");
                });

            modelBuilder.Entity("FitnessCenterStereo.DAL.Models.Exercises", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<Guid?>("BodyPartId");

                    b.Property<Guid?>("ComplexityLeveTypelId");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("date");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("BodyPartId");

                    b.HasIndex("ComplexityLeveTypelId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("FitnessCenterStereo.DAL.Models.Membership", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("date");

                    b.Property<decimal?>("Price")
                        .HasColumnType("numeric(5,2)");

                    b.HasKey("Id");

                    b.ToTable("Membership");
                });

            modelBuilder.Entity("FitnessCenterStereo.DAL.Models.Plan", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("date");

                    b.Property<Guid?>("DietTypeId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("DietTypeId");

                    b.ToTable("Plan");
                });

            modelBuilder.Entity("FitnessCenterStereo.DAL.Models.PlanTrainer", b =>
                {
                    b.Property<Guid?>("PlanId");

                    b.Property<Guid>("TrainerId");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("date");

                    b.Property<Guid>("Id");

                    b.Property<Guid?>("PlanTrainerPlanId");

                    b.Property<Guid?>("PlanTrainerTrainerId");

                    b.HasKey("PlanId", "TrainerId");

                    b.HasAlternateKey("Id")
                        .HasName("Id_pkey");

                    b.HasIndex("TrainerId");

                    b.HasIndex("PlanTrainerPlanId", "PlanTrainerTrainerId");

                    b.ToTable("PlanTrainer");
                });

            modelBuilder.Entity("FitnessCenterStereo.DAL.Models.Schedule", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("date");

                    b.Property<int?>("Frequency");

                    b.Property<Guid?>("PlanId");

                    b.HasKey("Id");

                    b.HasIndex("PlanId");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("FitnessCenterStereo.DAL.Models.Step", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("Abbreaviaton");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("date");

                    b.Property<string>("Description");

                    b.Property<Guid?>("ExercisesId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("ExercisesId");

                    b.ToTable("Step");
                });

            modelBuilder.Entity("FitnessCenterStereo.DAL.Models.Trainer", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("date");

                    b.Property<string>("FirstName");

                    b.Property<DateTime?>("HiredAt")
                        .HasColumnType("date");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Trainer");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<Guid?>("PlanId");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.HasIndex("PlanId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("FitnessCenterStereo.DAL.Models.Card", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("FitnessCenterStereo.DAL.Models.ExerciseEquipment", b =>
                {
                    b.HasOne("FitnessCenterStereo.DAL.Models.Equipment", "Equipment")
                        .WithMany("ExerciseEquipment")
                        .HasForeignKey("EquipmentId")
                        .HasConstraintName("ExerciseEquipment_EquipmentId_fkey")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FitnessCenterStereo.DAL.Models.Exercises", "Exercises")
                        .WithMany("ExerciseEquipment")
                        .HasForeignKey("ExercisesId")
                        .HasConstraintName("ExerciseEquipment_ExercisesId_fkey")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FitnessCenterStereo.DAL.Models.ExerciseSchedule", b =>
                {
                    b.HasOne("FitnessCenterStereo.DAL.Models.Exercises", "Exercises")
                        .WithMany("ExerciseSchedule")
                        .HasForeignKey("ExercisesId")
                        .HasConstraintName("ExerciseSchedule_ExercisesId_fkey")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FitnessCenterStereo.DAL.Models.Schedule", "Schedule")
                        .WithMany("ExerciseSchedule")
                        .HasForeignKey("ScheduleId")
                        .HasConstraintName("ExerciseSchedule_ScheduleId_fkey")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FitnessCenterStereo.DAL.Models.Exercises", b =>
                {
                    b.HasOne("FitnessCenterStereo.DAL.Models.BodyPartType", "BodyPart")
                        .WithMany("Exercises")
                        .HasForeignKey("BodyPartId")
                        .HasConstraintName("Exercises_BodyPartId_fkey");

                    b.HasOne("FitnessCenterStereo.DAL.Models.ComplexityLevelType", "ComplexityLeveTypel")
                        .WithMany("Exercises")
                        .HasForeignKey("ComplexityLeveTypelId")
                        .HasConstraintName("Exercises_ComplexityLeveTypelId_fkey");
                });

            modelBuilder.Entity("FitnessCenterStereo.DAL.Models.Plan", b =>
                {
                    b.HasOne("FitnessCenterStereo.DAL.Models.DietType", "DietType")
                        .WithMany("Plan")
                        .HasForeignKey("DietTypeId")
                        .HasConstraintName("Plan_DietTypeId_fkey");
                });

            modelBuilder.Entity("FitnessCenterStereo.DAL.Models.PlanTrainer", b =>
                {
                    b.HasOne("FitnessCenterStereo.DAL.Models.Plan", "Plan")
                        .WithMany("PlanTrainers")
                        .HasForeignKey("PlanId")
                        .HasConstraintName("PlanTrainer_PlanId_fkey")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FitnessCenterStereo.DAL.Models.Trainer", "Trainer")
                        .WithMany("PlanTrainers")
                        .HasForeignKey("TrainerId")
                        .HasConstraintName("PlanTrainer_TrainerId_fkey")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FitnessCenterStereo.DAL.Models.PlanTrainer")
                        .WithMany("PlanTrainers")
                        .HasForeignKey("PlanTrainerPlanId", "PlanTrainerTrainerId");
                });

            modelBuilder.Entity("FitnessCenterStereo.DAL.Models.Schedule", b =>
                {
                    b.HasOne("FitnessCenterStereo.DAL.Models.Plan", "Plan")
                        .WithMany("Schedule")
                        .HasForeignKey("PlanId")
                        .HasConstraintName("Schedule_PlanId_fkey");
                });

            modelBuilder.Entity("FitnessCenterStereo.DAL.Models.Step", b =>
                {
                    b.HasOne("FitnessCenterStereo.DAL.Models.Exercises", "Exercises")
                        .WithMany("Step")
                        .HasForeignKey("ExercisesId")
                        .HasConstraintName("Step_ExercisesId_fkey");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.HasOne("FitnessCenterStereo.DAL.Models.Plan")
                        .WithMany("Users")
                        .HasForeignKey("PlanId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
