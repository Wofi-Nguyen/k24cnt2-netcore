using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Nvm_Lesson10.Models;

public partial class NvmK24cnt2Lesson10Context : DbContext
{
    public NvmK24cnt2Lesson10Context()
    {
    }

    public NvmK24cnt2Lesson10Context(DbContextOptions<NvmK24cnt2Lesson10Context> options)
        : base(options)
    {
    }

    public virtual DbSet<NvmMember> NvmMembers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=WOLF;Database=NvmK24cnt2_Lesson10;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NvmMember>(entity =>
        {
            entity.ToTable("Nvm_Member");

            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
