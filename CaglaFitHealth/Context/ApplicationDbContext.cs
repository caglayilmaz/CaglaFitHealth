
using Microsoft.EntityFrameworkCore;
using System;
using CaglaFitHealth.Models.Entity;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CaglaFitHealth.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)  
        {
            //Postgresql DateTime->Timestamp dönüşüm sorunu çözümü için
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Admin> Admins { get; set; }


    }
}
