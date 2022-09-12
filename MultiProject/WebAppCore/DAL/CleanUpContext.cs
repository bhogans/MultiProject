using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using WebAppCore.Models;

#nullable disable

namespace WebAppCore.DAL
{
    public partial class CleanUp3Context : DbContext
    {
        public CleanUp3Context()
        {
        }

        public CleanUp3Context(DbContextOptions<CleanUp3Context> options)
            : base(options)
        {
        }

        //public virtual DbSet<Building> Buildings { get; set; }
        //public virtual DbSet<BuildingLayout> BuildingLayouts { get; set; }
        //public virtual DbSet<Candidate> Candidates { get; set; }
        //public virtual DbSet<Client> Clients { get; set; }
        //public virtual DbSet<Employee> Employees { get; set; }
        //public virtual DbSet<Event> Events { get; set; }
        //public virtual DbSet<Job> Jobs { get; set; }
        //public virtual DbSet<JobTask> JobTasks { get; set; }
        //public virtual DbSet<Location> Locations { get; set; }
        //public virtual DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //IConfigurationRoot configuration = new ConfigurationBuilder()

            //    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            //    .AddJsonFile("appsettings.json")
            //    .Build();
            //optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyDbConnection"));
        }

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //// To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //                optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectsV13;Database=CleanUp3;Trusted_Connection=True;");
        //            }
        //        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    #region seed data
        //    var buildingLayouts = new BuildingLayout[]
        //    {
        //        new BuildingLayout {BuildingLayoutId = 1, BuildingId = 2, SpaceName = "Foyer", Floor = "1st", Length = 12, Width = 15, Description="Area as you enter the front door"},
        //        new BuildingLayout {BuildingLayoutId = 2, BuildingId = 2, SpaceName = "Living Room", Floor = "1st", Length = 15, Width = 15, Description="Main living room"},
        //        new BuildingLayout {BuildingLayoutId = 3, BuildingId = 2, SpaceName = "Family Room", Floor = "1st", Length = 18, Width = 15, Description="Den/family room"}
        //    };
        //    #endregion
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    #region seed data
        //    var movies = new Movie[] {
        //        new Movie { Id = 1, Name = "Avengers: Endgame", WorldwideBoxOfficeGross = 2_797_800_564, DurationInMinutes = 181, Release = new DateTime(2019, 4, 26) },
        //        new Movie { Id = 2, Name = "The Lion King", WorldwideBoxOfficeGross = 1_654_791_102, DurationInMinutes     = 118, Release = new DateTime(2019, 7, 19) },
        //        new Movie { Id = 3, Name = "Ip Man 4", WorldwideBoxOfficeGross = 192_617_891, DurationInMinutes = 105, Release = new DateTime(2019, 12, 25) },
        //        new Movie { Id = 4, Name = "Gemini Man", WorldwideBoxOfficeGross = 166_623_705, DurationInMinutes = 116, Release = new DateTime(2019, 11, 20) },
        //        new Movie { Id = 5, Name = "Downton Abbey", WorldwideBoxOfficeGross = 194_051_302, DurationInMinutes = 120, Release = new DateTime(2020, 9, 20 )}
        //    };
        //    var series = new Series[] {
        //        new Series { Id = 6 , Name = "The Fresh Prince of Bel-Air", NumberOfEpisodes = 148, Release = new DateTime(1990, 9, 10) },
        //        new Series { Id = 7 , Name = "Downton Abbey", NumberOfEpisodes = 52, Release = new DateTime(2010, 09, 26) },
        //        new Series { Id = 8 , Name = "Stranger Things", NumberOfEpisodes = 34 , Release = new DateTime(2016, 7, 11) },
        //        new Series { Id = 9 , Name = "Kantaro: The Sweet Tooth Salaryman", NumberOfEpisodes = 12, Release = new DateTime(2017,7, 14) },
        //        new Series { Id = 10, Name = "The Walking Dead", NumberOfEpisodes = 177 , Release = new DateTime(2010, 10, 31) }
        //    };
        //    var productions = movies
        //        .Cast<Production>()
        //        .Union(series)
        //        .ToList();
        //    modelBuilder.Entity<Movie>().HasData(movies);
        //    modelBuilder.Entity<Series>().HasData(series);
        //    // characters
        //    modelBuilder.Entity<Character>().HasData(new Character[]
        //    {
        //        // movies
        //        new Character { Id = 1, Name = "Tony Stark", ProductionId = 1, ActorId = 1 },
        //        new Character { Id = 2, Name = "Steve Rogers", ProductionId = 1, ActorId = 2 },
        //        new Character { Id = 3, Name = "Okoye", ProductionId = 1, ActorId = 3 },
        //        new Character { Id = 4, Name = "Simba", ProductionId = 2, ActorId = 4 },
        //        new Character { Id = 5, Name = "Nala", ProductionId = 2, ActorId = 5 },
        //        new Character { Id = 6, Name = "Ip Man", ProductionId = 3, ActorId = 6 },
        //        new Character { Id = 7, Name = "Henry Brogan", ProductionId = 4, ActorId = 7 },
        //        new Character { Id = 8, Name = "Violet Crawley", ProductionId = 5, ActorId = 8 },
        //        new Character { Id = 9, Name = "Lady Mary Crawley", ProductionId = 5, ActorId = 9 },
        //        // television
        //        new Character { Id = 10, Name = "Will Smith", ProductionId = 6, ActorId = 7},
        //        new Character { Id = 11, Name = "Hilary Banks", ProductionId = 6, ActorId = 10 },
        //        new Character { Id = 12, Name = "Violet Crawley", ProductionId = 7, ActorId = 8 },
        //        new Character { Id = 13, Name = "Lady Mary Crawley", ProductionId = 7, ActorId = 9 },
        //        new Character { Id = 14, Name = "Eleven", ProductionId = 8, ActorId = 11 },
        //        new Character { Id = 15, Name = "Lucas", ProductionId = 8, ActorId = 12 },
        //        new Character { Id = 16, Name = "Joyce Byers", ProductionId = 8, ActorId = 13 },
        //        new Character { Id = 17, Name = "Jim Hopper", ProductionId = 8, ActorId = 14 },
        //        new Character { Id = 18, Name = "Ametani Kantarou", ProductionId = 9, ActorId = 15},
        //        new Character { Id = 19, Name = "Sano Erika", ProductionId = 9, ActorId = 16 },
        //        new Character { Id = 20, Name = "Daryl Dixon", ProductionId = 10, ActorId = 17 },
        //        new Character { Id = 21, Name = "Michonne", ProductionId = 10, ActorId = 3 },
        //        new Character { Id = 22, Name = "Carol Peletier", ProductionId = 10, ActorId = 18 }
        //      });
        //    // actors
        //    modelBuilder.Entity<Actor>().HasData(new Actor[]
        //    {
        //        new Actor { Id = 1, Name = "Robert Downey Jr." },
        //        new Actor { Id = 2, Name = "Chris Evans" },
        //        new Actor { Id = 3, Name = "Danai Guira" },
        //        new Actor { Id = 4, Name = "Donald Glover" },
        //        new Actor { Id = 5, Name = "Beyoncé" },
        //        new Actor { Id = 6, Name = "Donny Yen" },
        //        new Actor { Id = 7, Name = "Will Smith" },
        //        new Actor { Id = 8, Name = "Maggie Smith" },
        //        new Actor { Id = 9, Name = "Michelle Dockery" },
        //        new Actor { Id = 10, Name = "Karyn Parsons" },
        //        new Actor { Id = 11, Name = "Millie Bobby Brown" },
        //        new Actor { Id = 12, Name = "Caleb McLaughlin" },
        //        new Actor { Id = 13, Name = "Winona Ryder"},
        //        new Actor { Id = 14, Name = "David Harbour" },
        //        new Actor { Id = 15, Name = "Matsuya Onoe" },
        //        new Actor { Id = 16, Name = "Hazuki Shimizu"},
        //        new Actor { Id = 17, Name = "Norman Reedus" },
        //        new Actor { Id = 18, Name = "Melissa McBride" }
        //            });
        //            // let's generate lots of ratings
        //            var random = new Random();
        //            var size = 100;
        //            var sources = new[] {
        //        "Internet",
        //        "Newspaper",
        //        "Magazine",
        //        "App"
        //    };
        //    var ratings = productions
        //        .SelectMany((production, index) => {
        //            return Enumerable
        //                .Range(index * 100 + 1, size - 1)
        //                .Select(id => new Rating
        //                {
        //                    Id = id,
        //                    ProductionId = production.Id,
        //                    Stars = random.Next(1, 6),
        //                    Source = sources[random.Next(0, 4)]
        //                }).ToList();
        //        });
        //    modelBuilder.Entity<Rating>().HasData(ratings);
        //    #endregion
        //    base.OnModelCreating(modelBuilder);
        //}

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
