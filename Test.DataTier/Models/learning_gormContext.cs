using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Test.DataTier.Models
{
    public partial class learning_gormContext : DbContext
    {
        public learning_gormContext()
        {
        }

        public learning_gormContext(DbContextOptions<learning_gormContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SysAuthority> SysAuthorities { get; set; }
        public virtual DbSet<SysBook> SysBooks { get; set; }
        public virtual DbSet<SysLockJwt> SysLockJwts { get; set; }
        public virtual DbSet<SysUser> SysUsers { get; set; }
        public virtual DbSet<SysUserAuthority> SysUserAuthorities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source = .;Initial Catalog = learning_gorm;uid = sa; pwd= sa1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<SysAuthority>(entity =>
            {
                entity.HasKey(e => e.AuthorityId)
                    .HasName("PK__sys_auth__52804DABAF06C3E2");

                entity.ToTable("sys_authorities");

                entity.HasIndex(e => e.AuthorityId, "UQ__sys_auth__52804DAAEF3C7F72")
                    .IsUnique();

                entity.HasIndex(e => e.DeletedAt, "idx_sys_authorities_deleted_at");

                entity.Property(e => e.AuthorityId)
                    .HasMaxLength(90)
                    .HasColumnName("authority_id");

                entity.Property(e => e.AuthorityName).HasColumnName("authority_name");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DefaultRouter)
                    .HasColumnName("default_router")
                    .HasDefaultValueSql("('dashboard')");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<SysBook>(entity =>
            {
                entity.ToTable("sys_books");

                entity.HasIndex(e => e.Id, "UQ__sys_book__3213E83E9A071E1C")
                    .IsUnique();

                entity.HasIndex(e => e.DeletedAt, "idx_sys_books_deleted_at");

                entity.Property(e => e.Id)
                    .HasMaxLength(256)
                    .HasColumnName("id");

                entity.Property(e => e.AvailableQuantity).HasColumnName("available_quantity");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.SellerId).HasColumnName("seller_id");

                entity.Property(e => e.SoldQuantity).HasColumnName("sold_quantity");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.SysBooks)
                    .HasForeignKey(d => d.SellerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_sys_users_books");
            });

            modelBuilder.Entity<SysLockJwt>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__sys_lock__B9BE370F9A953774");

                entity.ToTable("sys_lock_jwts");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("user_id");

                entity.Property(e => e.RebasedTime).HasColumnName("rebased_time");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.SysLockJwt)
                    .HasForeignKey<SysLockJwt>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_sys_users_sys_lock_jwt");
            });

            modelBuilder.Entity<SysUser>(entity =>
            {
                entity.ToTable("sys_users");

                entity.HasIndex(e => e.DeletedAt, "idx_sys_users_deleted_at");

                entity.HasIndex(e => e.Username, "idx_username")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.NickName).HasColumnName("nick_name");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.Username)
                    .HasMaxLength(256)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<SysUserAuthority>(entity =>
            {
                entity.HasKey(e => new { e.SysUserId, e.SysAuthorityAuthorityId })
                    .HasName("PK__sys_user__43C789537AB7B0CA");

                entity.ToTable("sys_user_authorities");

                entity.Property(e => e.SysUserId).HasColumnName("sys_user_id");

                entity.Property(e => e.SysAuthorityAuthorityId)
                    .HasMaxLength(90)
                    .HasColumnName("sys_authority_authority_id");

                entity.HasOne(d => d.SysAuthorityAuthority)
                    .WithMany(p => p.SysUserAuthorities)
                    .HasForeignKey(d => d.SysAuthorityAuthorityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_sys_user_authorities_sys_authority");

                entity.HasOne(d => d.SysUser)
                    .WithMany(p => p.SysUserAuthorities)
                    .HasForeignKey(d => d.SysUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_sys_user_authorities_sys_user");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
