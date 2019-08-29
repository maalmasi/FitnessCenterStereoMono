﻿using Microsoft.EntityFrameworkCore;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class FitnessContext : DbContext
    {
        #region Constructors

        public FitnessContext()
        {
        }

        public FitnessContext(DbContextOptions<FitnessContext> options)
            : base(options)
        {
        }

        #endregion Constructors

        #region Properties

        public virtual DbSet<BodyPartType> BodyPartType { get; set; }
        public virtual DbSet<Card> Card { get; set; }
        public virtual DbSet<PlanTrainer> Compiles { get; set; }
        public virtual DbSet<ComplexityLevelType> ComplexityLevelType { get; set; }
        public virtual DbSet<DietType> DietType { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<ExerciseEquipment> ExerciseEquipment { get; set; }
        public virtual DbSet<Exercises> Exercises { get; set; }
        public virtual DbSet<ExerciseSchedule> ExerciseSchedule { get; set; }
        public virtual DbSet<Membership> Membership { get; set; }
        public virtual DbSet<Plan> Plan { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<Step> Step { get; set; }
        public virtual DbSet<Trainer> Trainer { get; set; }

        #endregion Properties

        #region Methods

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Server=praksafitness.postgres.database.azure.com;Database=Fitness;Port=5432;User Id=praksamonogym@praksafitness;Password=Fitness123.;Ssl Mode=Require;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("pg_buffercache")
                .HasPostgresExtension("pg_stat_statements")
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<BodyPartType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateUpdated).HasColumnType("date");
            });

            modelBuilder.Entity<Card>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateUpdated).HasColumnType("date");

                //entity.HasOne(d => d.User)
                //    .WithMany(p => p.Card)
                //    .HasForeignKey(d => d.UserId)
                //    .HasConstraintName("Card_UserId_fkey");
            });

            modelBuilder.Entity<PlanTrainer>(entity =>
            {
                entity.HasKey(e => e.TrainerId)
                    .HasName("PlanTrainers_pkey");

                entity.Property(e => e.TrainerId).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateUpdated).HasColumnType("date");

                entity.HasOne(d => d.Trainer)
                    .WithMany(p => p.PlanTrainers)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("PlanTrainers_TrainerId_fkey");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanTrainers)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("PlanTrainers_PlanId_fkey");
            });

            modelBuilder.Entity<ComplexityLevelType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateUpdated).HasColumnType("date");
            });

            modelBuilder.Entity<DietType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateUpdated).HasColumnType("date");
            });

            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateUpdated).HasColumnType("date");
            });

            modelBuilder.Entity<ExerciseEquipment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateUpdated).HasColumnType("date");

                entity.HasKey(x => new { x.EquipmentId, x.ExercisesId });

                entity.HasOne(d => d.Equipment)
                    .WithMany(p => p.ExerciseEquipment)
                    .HasForeignKey(d => d.EquipmentId)
                    .HasConstraintName("ExerciseEquipment_EquipmentId_fkey");

                entity.HasOne(d => d.Exercises)
                    .WithMany(p => p.ExerciseEquipment)
                    .HasForeignKey(d => d.ExercisesId)
                    .HasConstraintName("ExerciseEquipment_ExercisesId_fkey");
            });

            modelBuilder.Entity<ExerciseSchedule>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateUpdated).HasColumnType("date");

                entity.HasOne(d => d.Exercises)
                    .WithMany(p => p.ExerciseSchedule)
                    .HasForeignKey(d => d.ExercisesId)
                    .HasConstraintName("ExerciseSchedule_ExercisesId_fkey");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.ExerciseSchedule)
                    .HasForeignKey(d => d.ScheduleId)
                    .HasConstraintName("ExerciseSchedule_ScheduleId_fkey");
            });

            modelBuilder.Entity<Exercises>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateUpdated).HasColumnType("date");

                entity.HasOne(d => d.BodyPart)
                    .WithMany(p => p.Exercises)
                    .HasForeignKey(d => d.BodyPartId)
                    .HasConstraintName("Exercises_BodyPartId_fkey");

                entity.HasOne(d => d.ComplexityLeveTypel)
                    .WithMany(p => p.Exercises)
                    .HasForeignKey(d => d.ComplexityLeveTypelId)
                    .HasConstraintName("Exercises_ComplexityLeveTypelId_fkey");
            });

            modelBuilder.Entity<Membership>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateUpdated).HasColumnType("date");

                entity.Property(e => e.Price).HasColumnType("numeric(5,2)");
            });

            modelBuilder.Entity<Plan>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateUpdated).HasColumnType("date");

                entity.HasOne(d => d.DietType)
                    .WithMany(p => p.Plan)
                    .HasForeignKey(d => d.DietTypeId)
                    .HasConstraintName("Plan_DietTypeId_fkey");
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateUpdated).HasColumnType("date");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("Schedule_PlanId_fkey");
            });

            modelBuilder.Entity<Step>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateUpdated).HasColumnType("date");

                entity.HasOne(d => d.Exercises)
                    .WithMany(p => p.Step)
                    .HasForeignKey(d => d.ExercisesId)
                    .HasConstraintName("Step_ExercisesId_fkey");
            });

            modelBuilder.Entity<Trainer>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateUpdated).HasColumnType("date");

                entity.Property(e => e.HiredAt).HasColumnType("date");
            });
        }

        #endregion Methods
    }
}