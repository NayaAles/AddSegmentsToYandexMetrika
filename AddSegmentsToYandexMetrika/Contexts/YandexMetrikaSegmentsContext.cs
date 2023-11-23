using Microsoft.EntityFrameworkCore;

namespace AddSegmentsToYandexMetrika.Contexts;

public partial class YandexMetrikaSegmentsContext : DbContext
{
    public YandexMetrikaSegmentsContext()
    {
    }

    public YandexMetrikaSegmentsContext(DbContextOptions<YandexMetrikaSegmentsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AddLog> ErrorLogs { get; set; }

    public virtual DbSet<AddLog> SuccessLogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql(SecureData.Get("YandexMetrikaContext"),
            ServerVersion.Parse("8.0.32-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<AddLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("error_log");

            entity.HasIndex(e => e.SegmentName, "segment_error").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateCreated)
            .HasColumnName("date_created");
            entity.Property(e => e.Logs)
                .HasColumnType("text")
                .HasColumnName("log");
            entity.Property(e => e.SegmentName)
                .HasMaxLength(100)
                .HasColumnName("segment_name");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status_added");
        });

        modelBuilder.Entity<AddLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("success_log");

            entity.HasIndex(e => e.SegmentName, "segment_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateCreated)
            .HasColumnName("date_created");
            entity.Property(e => e.Logs)
                .HasColumnType("text")
                .HasColumnName("log");
            entity.Property(e => e.SegmentName)
                .HasMaxLength(100)
                .HasColumnName("segment_name");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status_added");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
