using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SigurAPI.tcdblogs
{
    public partial class tcdblogContext : DbContext
    {
        public tcdblogContext()
        {
        }

        public tcdblogContext(DbContextOptions<tcdblogContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Log> Logs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=192.168.1.164;Port=3305;user=root;password=392576;database=tc-db-log;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Log>(entity =>
            {
                entity.ToTable("logs");

                entity.HasIndex(e => e.Devhint, "DEVHINT");

                entity.HasIndex(e => e.Emphint, "EMPHINT");

                entity.HasIndex(e => e.Logtime, "LOGTIME");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Area)
                    .HasColumnType("int(11)")
                    .HasColumnName("AREA")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Devhint)
                    .HasColumnType("int(11)")
                    .HasColumnName("DEVHINT")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Emphint)
                    .HasColumnType("int(11)")
                    .HasColumnName("EMPHINT")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Framets)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("FRAMETS");

                entity.Property(e => e.Logdata)
                    .HasColumnType("tinyblob")
                    .HasColumnName("LOGDATA")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Logtime)
                    .HasColumnType("datetime")
                    .HasColumnName("LOGTIME")
                    .HasDefaultValueSql("'NULL'");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
