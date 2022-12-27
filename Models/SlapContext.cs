using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Backendslap.Models;

public partial class SlapContext : DbContext
{
    public SlapContext()
    {
    }

    public SlapContext(DbContextOptions<SlapContext> options)
        : base(options)
    {
    }

    public virtual DbSet<SlapDefinition> SlapDefinitions { get; set; }

    public virtual DbSet<Slaptable> Slaptables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ASTLPTWFH118\\SQLEXPRESS;Initial Catalog=Slap;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SlapDefinition>(entity =>
        {
            entity.HasKey(e => e.Slid).HasName("PK__SlapDefi__BC7BB91132099167");

            entity.ToTable("SlapDefinition");

            entity.Property(e => e.DescriptionS)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Description_s");
            entity.Property(e => e.PayGroupCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Pay_Group_Code");
            entity.Property(e => e.ShortName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Short_Name");
            entity.Property(e => e.StatusS)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Status_s");
        });

        modelBuilder.Entity<Slaptable>(entity =>
        {
            entity.HasKey(e => e.Slapid).HasName("PK__Slaptabl__FE549DDFA01BBCE4");

            entity.ToTable("Slaptable");

            entity.Property(e => e.Slapid).HasColumnName("slapid");
            entity.Property(e => e.PayGroupCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Pay_Group_Code");
            entity.Property(e => e.SlapHighValue)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Slap_High_value");
            entity.Property(e => e.SlapLowValue)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Slap_Low_value");
            entity.Property(e => e.SlapName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Slap_name");
            entity.Property(e => e.SlapPercentage).HasColumnName("Slap_Percentage");
            entity.Property(e => e.SlapValue)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Slap_Value");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
