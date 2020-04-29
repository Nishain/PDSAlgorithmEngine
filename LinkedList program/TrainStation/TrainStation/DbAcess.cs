using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
//using TrainStations.Migrations;
using TrainStations.Models;

namespace TrainStations.DAL
{
    public class DbAcess : DbContext
    {
        public DbAcess() : base("myconnection")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<DbAcess, Configuration>());
        }
        public DbSet<tbStations> stations { get; set; }
        public DbSet<Tbdistances> stationDistances { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           // modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<tbStations>()
            .HasMany<Tbdistances>(g => g.StationDistances1)
            .WithRequired(s => s.Stations1)
            .HasForeignKey<int>(s => s.station1id)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbStations>()
            .HasMany<Tbdistances>(g => g.StationDistances2)
            .WithRequired(s => s.Stations2)
            .HasForeignKey<int>(s => s.station2id)
            .WillCascadeOnDelete(false);
        }

    }
}