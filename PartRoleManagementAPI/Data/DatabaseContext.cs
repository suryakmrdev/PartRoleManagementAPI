using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.EntityFrameworkCore;
using PartyRoleManagementAPI.Models;

namespace PartRoleManagementAPI.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext (DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
        public DbSet<ContactMedium> ContactMedia { get; set; }
        public DbSet<CreditProfile> CreditProfiles { get; set; }
        public DbSet<PartyRole> PartyRole { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactMedium>().OwnsOne(sh => sh.Characteristic, navigationsBuilder =>
            {
                navigationsBuilder.ToTable("MediumCharacteristics");
                
            })
            .OwnsOne(sh => sh.ValidFor, navigationsBuilder =>
             {
                 navigationsBuilder.ToJson();

             });


            modelBuilder.Entity<CreditProfile>().OwnsOne(sh => sh.ValidFor, navigationsBuilder =>
            {
                navigationsBuilder.ToJson();

            });


            modelBuilder.Entity<PartyRole>()
                .OwnsMany(sh => sh.Account, navigationsBuilder =>
                {
                    navigationsBuilder.ToTable("AccountRef");
                })
                .OwnsMany(sh => sh.Agreement, navigationsBuilder =>
                {
                    navigationsBuilder.ToTable("AgreementRefs");
                })
                .OwnsMany(sh => sh.Characteristic, navigationsBuilder =>
                {
                    navigationsBuilder.ToTable("Characteristics");
                })
                .OwnsMany(sh => sh.PaymentMethod, navigationsBuilder =>
                {
                    navigationsBuilder.ToTable("PaymentMethods");
                })
                .OwnsMany(sh => sh.RelatedParty, navigationsBuilder =>
                {
                    // navigationsBuilder.ToJson();
                    navigationsBuilder.ToTable("RelatedPartys");
                })
                .OwnsOne(sh => sh.EngagedParty, navigationsBuilder =>
                {
                    navigationsBuilder.ToTable("EngagedPartys");
                })
                .OwnsOne(sh => sh.ValidFor, navigationsBuilder =>
                {
                    navigationsBuilder.ToJson();

                });
        }


    }
}
