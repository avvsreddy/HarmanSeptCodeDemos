using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ContactManagementApp;

public partial class DbFirstDemoDbContext : DbContext
{
    public DbFirstDemoDbContext()
    {
    }

    public DbFirstDemoDbContext(DbContextOptions<DbFirstDemoDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contact> Contacts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=DbFirstDemoDB;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Contacts__3214EC0716B5A031");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ContactName)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Mobile)
                .HasMaxLength(15)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
