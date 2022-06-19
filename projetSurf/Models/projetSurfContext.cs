using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace projetSurf.Models
{
    public partial class projetSurfContext : DbContext
    {
        public projetSurfContext()
        {
        }

        public projetSurfContext(DbContextOptions<projetSurfContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Board> Boards { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Do> Dos { get; set; }
        public virtual DbSet<Lesson> Lessons { get; set; }
        public virtual DbSet<Monitor> Monitors { get; set; }
        public virtual DbSet<Perform> Performs { get; set; }
        public virtual DbSet<Rent> Rents { get; set; }
        public virtual DbSet<Reserve> Reserves { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Use> Uses { get; set; }
        public virtual DbSet<Wetsuit> Wetsuits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=projetSurf;uid=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.31-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            modelBuilder.Entity<Board>(entity =>
            {
                entity.HasKey(e => e.IdBoards)
                    .HasName("PRIMARY");

                entity.ToTable("boards");

                entity.Property(e => e.IdBoards)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_boards");

                entity.Property(e => e.BrandBoards)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("brand_boards");

                entity.Property(e => e.DatePurchaseBoards)
                    .HasColumnType("date")
                    .HasColumnName("datePurchase_boards");

                entity.Property(e => e.PriceRent1HourBoards).HasColumnName("priceRent1Hour_boards");

                entity.Property(e => e.SizeBoards)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("size_boards");

                entity.Property(e => e.StateBoards)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("state_boards");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdClients)
                    .HasName("PRIMARY");

                entity.ToTable("clients");

                entity.Property(e => e.IdClients)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_clients");

                entity.Property(e => e.FirstnameClients)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("firstname_clients");

                entity.Property(e => e.NameClients)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name_clients");
            });

            modelBuilder.Entity<Do>(entity =>
            {
                entity.HasKey(e => new { e.IdLessons, e.IdClients })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("do");

                entity.HasIndex(e => e.IdClients, "do_students0_FK");

                entity.Property(e => e.IdLessons)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_lessons");

                entity.Property(e => e.IdClients)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_clients");

                entity.HasOne(d => d.IdClientsNavigation)
                    .WithMany(p => p.Dos)
                    .HasForeignKey(d => d.IdClients)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("do_students0_FK");

                entity.HasOne(d => d.IdLessonsNavigation)
                    .WithMany(p => p.Dos)
                    .HasForeignKey(d => d.IdLessons)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("do_lessons_FK");
            });

            modelBuilder.Entity<Lesson>(entity =>
            {
                entity.HasKey(e => e.IdLessons)
                    .HasName("PRIMARY");

                entity.ToTable("lessons");

                entity.Property(e => e.IdLessons)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_lessons");

                entity.Property(e => e.DateStartLessons)
                    .HasColumnType("date")
                    .HasColumnName("dateStart_lessons");

                entity.Property(e => e.DayLessons)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("day_lessons");

                entity.Property(e => e.DurationLessons)
                    .HasColumnType("time")
                    .HasColumnName("duration_lessons");

                entity.Property(e => e.FreePlaceLessons)
                    .HasColumnType("int(11)")
                    .HasColumnName("freePlace_lessons");

                entity.Property(e => e.LevelLessons)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("level_lessons");

                entity.Property(e => e.NameLessons)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name_lessons");

                entity.Property(e => e.NmbMaxLessons)
                    .HasColumnType("int(11)")
                    .HasColumnName("nmbMax_lessons");

                entity.Property(e => e.NumberLessons)
                    .HasColumnType("int(11)")
                    .HasColumnName("number_lessons");

                entity.Property(e => e.PriceLessons).HasColumnName("price_lessons");

                entity.Property(e => e.StartHourLessons)
                    .HasColumnType("time")
                    .HasColumnName("startHour_lessons");
            });

            modelBuilder.Entity<Monitor>(entity =>
            {
                entity.HasKey(e => e.IdMonitors)
                    .HasName("PRIMARY");

                entity.ToTable("monitors");

                entity.Property(e => e.IdMonitors)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_monitors");

                entity.Property(e => e.AdministratorMonitor).HasColumnName("administrator_monitor");

                entity.Property(e => e.DateBirthMonitors)
                    .HasColumnType("date")
                    .HasColumnName("dateBirth_monitors");

                entity.Property(e => e.FirstnameMonitors)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("firstname_monitors");

                entity.Property(e => e.LoginMonitor)
                    .HasMaxLength(50)
                    .HasColumnName("login_monitor");

                entity.Property(e => e.NameMonitors)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name_monitors");

                entity.Property(e => e.PasswordMonitor)
                    .HasMaxLength(200)
                    .HasColumnName("password_monitor");

                entity.Property(e => e.PhoneMonitor)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("phone_monitor");
            });

            modelBuilder.Entity<Perform>(entity =>
            {
                entity.HasKey(e => new { e.IdMonitors, e.IdLessons })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("perform");

                entity.HasIndex(e => e.IdLessons, "perform_lessons0_FK");

                entity.Property(e => e.IdMonitors)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_monitors");

                entity.Property(e => e.IdLessons)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_lessons");

                entity.HasOne(d => d.IdLessonsNavigation)
                    .WithMany(p => p.Performs)
                    .HasForeignKey(d => d.IdLessons)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("perform_lessons0_FK");

                entity.HasOne(d => d.IdMonitorsNavigation)
                    .WithMany(p => p.Performs)
                    .HasForeignKey(d => d.IdMonitors)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("perform_monitors_FK");
            });

            modelBuilder.Entity<Rent>(entity =>
            {
                entity.HasKey(e => new { e.IdBoards, e.IdClients })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("rent");

                entity.HasIndex(e => e.IdClients, "rent_Clients0_FK");

                entity.Property(e => e.IdBoards)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_boards");

                entity.Property(e => e.IdClients)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_clients");

                entity.Property(e => e.DateEndRent)
                    .HasColumnType("date")
                    .HasColumnName("dateEnd_rent");

                entity.Property(e => e.DateStartRent)
                    .HasColumnType("date")
                    .HasColumnName("dateStart_rent");

                entity.HasOne(d => d.IdBoardsNavigation)
                    .WithMany(p => p.Rents)
                    .HasForeignKey(d => d.IdBoards)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rent_boards_FK");

                entity.HasOne(d => d.IdClientsNavigation)
                    .WithMany(p => p.Rents)
                    .HasForeignKey(d => d.IdClients)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rent_Clients0_FK");
            });

            modelBuilder.Entity<Reserve>(entity =>
            {
                entity.HasKey(e => new { e.IdLessons, e.IdBoards })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("reserve");

                entity.HasIndex(e => e.IdBoards, "reserve_boards0_FK");

                entity.Property(e => e.IdLessons)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_lessons");

                entity.Property(e => e.IdBoards)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_boards");

                entity.HasOne(d => d.IdBoardsNavigation)
                    .WithMany(p => p.Reserves)
                    .HasForeignKey(d => d.IdBoards)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("reserve_boards0_FK");

                entity.HasOne(d => d.IdLessonsNavigation)
                    .WithMany(p => p.Reserves)
                    .HasForeignKey(d => d.IdLessons)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("reserve_lessons_FK");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.IdClients)
                    .HasName("PRIMARY");

                entity.ToTable("students");

                entity.Property(e => e.IdClients)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id_clients");

                entity.Property(e => e.DateBirthStudents)
                    .HasColumnType("date")
                    .HasColumnName("dateBirth_students");

                entity.Property(e => e.FirstnameClients)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("firstname_clients");

                entity.Property(e => e.NameClients)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name_clients");

                entity.Property(e => e.PhoneStudents)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("phone_students");

                entity.Property(e => e.MailStudents)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("mail_students");

                entity.Property(e => e.PostalCodeStudents)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("postalCode_students");

                entity.HasOne(d => d.IdClientsNavigation)
                    .WithOne(p => p.Student)
                    .HasForeignKey<Student>(d => d.IdClients)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("students_Clients_FK");
            });

            modelBuilder.Entity<Use>(entity =>
            {
                entity.HasKey(e => new { e.IdLessons, e.IdWetsuits })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("use");

                entity.HasIndex(e => e.IdWetsuits, "use_wetsuits0_FK");

                entity.Property(e => e.IdLessons)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_lessons");

                entity.Property(e => e.IdWetsuits)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_wetsuits");

                entity.HasOne(d => d.IdLessonsNavigation)
                    .WithMany(p => p.Uses)
                    .HasForeignKey(d => d.IdLessons)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("use_lessons_FK");

                entity.HasOne(d => d.IdWetsuitsNavigation)
                    .WithMany(p => p.Uses)
                    .HasForeignKey(d => d.IdWetsuits)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("use_wetsuits0_FK");
            });

            modelBuilder.Entity<Wetsuit>(entity =>
            {
                entity.HasKey(e => e.IdWetsuits)
                    .HasName("PRIMARY");

                entity.ToTable("wetsuits");

                entity.Property(e => e.IdWetsuits)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_wetsuits");

                entity.Property(e => e.BrandWetsuits)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("brand_wetsuits");

                entity.Property(e => e.DatePurchaseWetsuits)
                    .HasColumnType("date")
                    .HasColumnName("datePurchase_wetsuits");

                entity.Property(e => e.GenderWetsuits)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("gender_wetsuits");

                entity.Property(e => e.HoodWetsuits)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("hood_wetsuits");

                entity.Property(e => e.LengthSleevesWetsuits)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("lengthSleeves_wetsuits");

                entity.Property(e => e.StateWetsuits)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("state_wetsuits");

                entity.Property(e => e.ThicknessWetsuits)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("thickness_wetsuits");

                entity.Property(e => e.TypeWetsuits)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("type_wetsuits");

                entity.Property(e => e.ZipperWetsuits)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("zipper_wetsuits");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
