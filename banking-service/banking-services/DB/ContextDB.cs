using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace banking_service.DB;

public partial class ContextDB : DbContext
{
    public ContextDB()
    {
    }

    public ContextDB(DbContextOptions<ContextDB> options)
        : base(options)
    {
    }

    public virtual DbSet<Transection> Transections { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;database=banking;user=root;guidformat=Binary16;password=Pan28060.", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.33-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Transection>(entity =>
        {
            entity.HasKey(e => e.TransectionId).HasName("PRIMARY");

            entity.ToTable("transection");

            entity.HasIndex(e => e.TransectionId, "transection_id_UNIQUE").IsUnique();

            entity.Property(e => e.TransectionId).HasColumnName("transection_id");
            entity.Property(e => e.TransectionAmount).HasColumnName("transection_amount");
            entity.Property(e => e.TransectionBalance).HasColumnName("transection_balance");
            entity.Property(e => e.TransectionDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("transection_date");
            entity.Property(e => e.TransectionOwner).HasColumnName("transection_owner");
            entity.Property(e => e.TransectionType)
                .HasMaxLength(45)
                .HasColumnName("transection_type");
            entity.Property(e => e.TransectionUserReferrence).HasColumnName("transection_user_referrence");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity.ToTable("user");

            entity.HasIndex(e => e.UserId, "user_id_UNIQUE").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.IsEnable).HasColumnName("is_enable");
            entity.Property(e => e.UserBalance).HasColumnName("user_balance");
            entity.Property(e => e.UserBirthday).HasColumnName("user_birthday");
            entity.Property(e => e.UserCreatedDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("user_created_date");
            entity.Property(e => e.UserLastname)
                .HasMaxLength(45)
                .HasColumnName("user_lastname");
            entity.Property(e => e.UserName)
                .HasMaxLength(45)
                .HasColumnName("user_name");
            entity.Property(e => e.UserPassword)
                .HasColumnType("text")
                .HasColumnName("user_password");
            entity.Property(e => e.UserUsername)
                .HasMaxLength(45)
                .HasColumnName("user_username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
