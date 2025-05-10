using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using TransactionMonitoring.Domain.Entities;

namespace TransactionMonitoring.Domain
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(t => t.Id);

                entity.Property(t => t.Amount)
                    .IsRequired();

                entity.Property(t => t.Status)
                    .HasMaxLength(50)
                    .IsRequired();

                entity.Property(t => t.CreateTime)
                    .IsRequired();

                entity.Property(t => t.Reference)
                    .HasMaxLength(100);
            });

        }
    }
}

