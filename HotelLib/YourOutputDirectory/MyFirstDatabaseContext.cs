using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HotelClasses.NET.YourOutputDirectory;

public partial class MyFirstDatabaseContext : DbContext
{
    public MyFirstDatabaseContext()
    {
    }

    public MyFirstDatabaseContext(DbContextOptions<MyFirstDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Guest> Guests { get; set; }

    public virtual DbSet<Hotel> Hotels { get; set; }

    public virtual DbSet<HotelReservation> HotelReservations { get; set; }

    public virtual DbSet<HotelRoom> HotelRooms { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<RoomService> RoomServices { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:h672645.database.windows.net,1433;Initial Catalog=MyFirstDatabase;Persist Security Info=False;User ID=h672645;Password=4ak96a2bb5A;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.AdminId).HasName("PK__Admin__719FE488C3368116");

            entity.ToTable("Admin");

            entity.Property(e => e.AdminId).ValueGeneratedNever();

            entity.HasOne(d => d.AdminNavigation).WithOne(p => p.Admin)
                .HasForeignKey<Admin>(d => d.AdminId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Admin__AdminId__68487DD7");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04F11F18084B2");

            entity.ToTable("Employee");

            entity.Property(e => e.EmployeeId).ValueGeneratedNever();
            entity.Property(e => e.Stilling).HasMaxLength(100);

            entity.HasOne(d => d.EmployeeNavigation).WithOne(p => p.Employee)
                .HasForeignKey<Employee>(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Employee__Employ__656C112C");
        });

        modelBuilder.Entity<Guest>(entity =>
        {
            entity.HasKey(e => e.GuestId).HasName("PK__Guest__0C423C121AE80D67");

            entity.ToTable("Guest");

            entity.Property(e => e.GuestId).ValueGeneratedNever();

            entity.HasOne(d => d.GuestNavigation).WithOne(p => p.Guest)
                .HasForeignKey<Guest>(d => d.GuestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Guest__GuestId__628FA481");
        });

        modelBuilder.Entity<Hotel>(entity =>
        {
            entity.HasKey(e => e.HotelId).HasName("PK__Hotel__46023BDF13B164E0");

            entity.ToTable("Hotel");

            entity.Property(e => e.HotellKjede).HasMaxLength(100);
            entity.Property(e => e.Navn).HasMaxLength(100);
        });

        modelBuilder.Entity<HotelReservation>(entity =>
        {
            entity.HasKey(e => e.ReservationId).HasName("PK__HotelRes__B7EE5F24A324BFC7");

            entity.ToTable("HotelReservation");

            entity.Property(e => e.ReservationId).ValueGeneratedNever();
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.Guest).WithMany(p => p.HotelReservations)
                .HasForeignKey(d => d.GuestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Guest");

            entity.HasOne(d => d.Room).WithMany(p => p.HotelReservations)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("FK_Room");
        });

        modelBuilder.Entity<HotelRoom>(entity =>
        {
            entity.HasKey(e => e.RoomId).HasName("PK__HotelRoo__32863939F4289E21");

            entity.ToTable("HotelRoom");

            entity.Property(e => e.QualityOfRoom).HasMaxLength(50);
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.PersonId).HasName("PK__Person__AA2FFBE597F6ADD6");

            entity.ToTable("Person");

            entity.Property(e => e.Etternavn).HasMaxLength(50);
            entity.Property(e => e.Fornavn).HasMaxLength(50);
        });

        modelBuilder.Entity<RoomService>(entity =>
        {
            entity.HasKey(e => e.RoomId).HasName("PK__RoomServ__32863939AC35DC6D");

            entity.ToTable("RoomService");

            entity.Property(e => e.RoomId).ValueGeneratedNever();
            entity.Property(e => e.Tjeneste)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
