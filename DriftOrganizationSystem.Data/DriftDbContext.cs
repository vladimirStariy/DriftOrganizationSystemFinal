using DriftOrganizationSystem.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriftOrganizationSystem.Data
{
    public class DriftDbContext : DbContext
    {
        public DriftDbContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        public DriftDbContext(DbContextOptions<DriftDbContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public virtual DbSet<Pilot> Pilots { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Achievement> Achievements { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<Judge> Judges { get; set; }
        public virtual DbSet<Organizator> Organizators { get; set; }
        public virtual DbSet<Sponsor> Sponsors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=DriftDb;Trusted_Connection=True;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pilot>(builder =>
            {
                builder.ToTable("Pilots").HasKey(x => x.Pilot_ID);
                builder.Property(x => x.Pilot_ID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Car>(builder =>
            {
                builder.ToTable("Cars").HasKey(x => x.Car_ID);
                builder.Property(x => x.Car_ID).ValueGeneratedOnAdd();
                builder.HasOne(x => x.Pilot)
                       .WithMany(x => x.Cars)
                       .HasForeignKey(x => x.Pilot_ID);
            });
            
            modelBuilder.Entity<Achievement>(builder =>
            {
                builder.ToTable("Achievements").HasKey(x => x.Achievement_ID);
                builder.Property(x => x.Achievement_ID).ValueGeneratedOnAdd();
                builder.HasOne(x => x.Pilot)
                       .WithMany(x => x.Achievements)
                       .HasForeignKey(x => x.Pilot_ID);
            });

            modelBuilder.Entity<Event>(builder =>
            {
                builder.ToTable("Events").HasKey(x => x.Event_ID);
                builder.Property(x => x.Event_ID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Registration>(builder =>
            {
                builder.ToTable("Registrations").HasKey(x => x.Registration_ID);
                builder.Property(x => x.Registration_ID).ValueGeneratedOnAdd();
                builder.HasOne(x => x.Event)
                       .WithMany(x => x.Registrations)
                       .HasForeignKey(x => x.Event_ID);
                builder.HasOne(x => x.Pilot)
                       .WithMany(x => x.Registrations)
                       .HasForeignKey(x => x.Pilot_ID);
            });

            modelBuilder.Entity<Judge>(builder =>
            {
                builder.ToTable("Judges").HasKey(x => x.Judge_ID);
                builder.Property(x => x.Judge_ID).ValueGeneratedOnAdd();
                builder.HasMany(x => x.Events)
                       .WithMany(x => x.Judges)
                       .UsingEntity(x => x.ToTable("EventJudges"));
            });

            modelBuilder.Entity<Organizator>(builder =>
            {
                builder.ToTable("Organizators").HasKey(x => x.Organizator_ID);
                builder.Property(x => x.Organizator_ID).ValueGeneratedOnAdd();
                builder.HasMany(x => x.Events)
                       .WithMany(x => x.Organizators)
                       .UsingEntity(x => x.ToTable("EventOrganizators"));
            });

            modelBuilder.Entity<Sponsor>(builder =>
            {
                builder.ToTable("Sponsors").HasKey(x => x.Sponsor_ID);
                builder.Property(x => x.Sponsor_ID).ValueGeneratedOnAdd();
                builder.HasMany(x => x.Events)
                       .WithMany(x => x.Sponsors)
                       .UsingEntity(x => x.ToTable("EventSponsors"));
            });
        }
    }
}
