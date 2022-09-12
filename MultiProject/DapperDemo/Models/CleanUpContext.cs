using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DapperDemo.Models
{
    public partial class CleanUpContext : DbContext
    {
        public CleanUpContext()
        {
        }

        public CleanUpContext(DbContextOptions<CleanUpContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<BuildingLayout> BuildingLayouts { get; set; }
        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobTask> JobTasks { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectsV13;Database=CleanUp;Trusted_Connection=True;");
//            }
//        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        //    modelBuilder.Entity<Building>(entity =>
        //    {
        //        entity.ToTable("Building");

        //        entity.Property(e => e.Latitude).HasMaxLength(50);

        //        entity.Property(e => e.Longitude).HasMaxLength(50);

        //        entity.HasOne(d => d.Client)
        //            .WithMany(p => p.Buildings)
        //            .HasForeignKey(d => d.ClientId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_Building_Client");
        //    });

        //    modelBuilder.Entity<BuildingLayout>(entity =>
        //    {
        //        entity.ToTable("BuildingLayout");

        //        entity.Property(e => e.Description).HasMaxLength(255);

        //        entity.Property(e => e.Floor).HasMaxLength(50);

        //        entity.Property(e => e.SpaceName).HasMaxLength(50);

        //        entity.HasOne(d => d.Building)
        //            .WithMany(p => p.BuildingLayouts)
        //            .HasForeignKey(d => d.BuildingId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_BuildingLayout_Building");
        //    });

        //    modelBuilder.Entity<Candidate>(entity =>
        //    {
        //        entity.ToTable("Candidate");
        //    });

        //    modelBuilder.Entity<Client>(entity =>
        //    {
        //        entity.ToTable("Client");

        //        entity.Property(e => e.BirthDate).HasColumnType("date");
        //    });

        //    modelBuilder.Entity<Employee>(entity =>
        //    {
        //        entity.ToTable("Employee");

        //        entity.Property(e => e.CreatedAt).HasColumnType("datetime");

        //        entity.Property(e => e.Latitude).HasMaxLength(50);

        //        entity.Property(e => e.Longitude).HasMaxLength(50);

        //        entity.Property(e => e.StartDate).HasColumnType("datetime");
        //    });

        //    modelBuilder.Entity<Event>(entity =>
        //    {
        //        entity.ToTable("Event");

        //        entity.Property(e => e.EventId).ValueGeneratedNever();

        //        entity.Property(e => e.EventDate)
        //            .HasColumnType("datetime")
        //            .HasDefaultValueSql("(getdate())");

        //        entity.Property(e => e.Name)
        //            .HasMaxLength(255)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Notes).IsUnicode(false);

        //        entity.Property(e => e.Type)
        //            .HasMaxLength(255)
        //            .IsUnicode(false);
        //    });

        //    modelBuilder.Entity<Job>(entity =>
        //    {
        //        entity.ToTable("Job");

        //        entity.Property(e => e.Finish).HasColumnType("datetime");

        //        entity.Property(e => e.JobType)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Start).HasColumnType("datetime");

        //        entity.Property(e => e.Status)
        //            .HasMaxLength(20)
        //            .IsUnicode(false);

        //        entity.HasOne(d => d.Building)
        //            .WithMany(p => p.Jobs)
        //            .HasForeignKey(d => d.BuildingId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_Job_Building");
        //    });

        //    modelBuilder.Entity<JobTask>(entity =>
        //    {
        //        entity.ToTable("JobTask");

        //        entity.Property(e => e.JobTaskId).ValueGeneratedNever();

        //        entity.Property(e => e.DateTimeAssigned).HasColumnType("datetime");

        //        entity.Property(e => e.Finish).HasColumnType("datetime");

        //        entity.Property(e => e.Start).HasColumnType("datetime");

        //        entity.HasOne(d => d.Job)
        //            .WithMany(p => p.JobTasks)
        //            .HasForeignKey(d => d.JobId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_JobTask_Job");
        //    });

        //    modelBuilder.Entity<Location>(entity =>
        //    {
        //        entity.ToTable("Location");

        //        entity.Property(e => e.LocationId).ValueGeneratedNever();

        //        entity.Property(e => e.Type).HasMaxLength(50);
        //    });

        //    modelBuilder.Entity<Task>(entity =>
        //    {
        //        entity.ToTable("Task");

        //        entity.HasOne(d => d.Building)
        //            .WithMany(p => p.Tasks)
        //            .HasForeignKey(d => d.BuildingId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_Task_Building");
        //    });

        //    OnModelCreatingPartial(modelBuilder);
        //}

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
