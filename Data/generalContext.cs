using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using general.Models;

namespace general.Data
{
    public class generalContext : DbContext
    {
        public generalContext(DbContextOptions<generalContext> options)
            : base(options)
        {
        }

        public DbSet<general.Models.sabt>? sabt { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<v_nbt_sms3>()
            //.ToView(nameof(v_nbt_sms2))
            //.HasNoKey();

           // modelBuilder.Entity<v_nbt_sms2>()
           //.ToView(nameof(v_nbt_sms2))
           //.HasNoKey();

        }

    }
}
