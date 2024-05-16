using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VideoLibrary.Models;

public partial class МедиатекаContext : DbContext
{
    public МедиатекаContext()
    {
    }

    public МедиатекаContext(DbContextOptions<МедиатекаContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Film> Films { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Purchase> Purchases { get; set; }

    public virtual DbSet<Rate> Rates { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localDB)\\MSSQLLocalDB;Initial Catalog=Медиатека;Integrated Security=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Cyrillic_General_CI_AS");

        modelBuilder.Entity<Film>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Director)
                .HasMaxLength(25)
                .IsFixedLength();
            entity.Property(e => e.FilmCoast)
                .HasColumnType("money")
                .HasColumnName("Film_Coast");
            entity.Property(e => e.Genre)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.IdFilm)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Film");
            entity.Property(e => e.IdRate).HasColumnName("Id_Rate");
            entity.Property(e => e.MainActor)
                .HasMaxLength(25)
                .IsFixedLength()
                .HasColumnName("Main_Actor");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.UserRate).HasColumnName("User_Rate");
            entity.Property(e => e.YearOfIssue).HasColumnName("Year_of_Issue");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Genre");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.GenreName)
                .HasMaxLength(25)
                .IsFixedLength()
                .HasColumnName("Genre_Name");
            entity.Property(e => e.IdGenre)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Genre");
        });

        modelBuilder.Entity<Purchase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Purchase ");

            entity.Property(e => e.IdFilm).HasColumnName("Id_Film");
            entity.Property(e => e.IdPurchase)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Purchase");
            entity.Property(e => e.IdRate).HasColumnName("Id_Rate");
            entity.Property(e => e.IdUser).HasColumnName("Id_User");
            entity.Property(e => e.PurchaseCoast).HasColumnName("Purchase_Coast");
        });

        modelBuilder.Entity<Rate>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.IdRate)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Rate");
            entity.Property(e => e.NumbersOfFilms).HasColumnName("Numbers_of_Films");
            entity.Property(e => e.RateCoastPerMonth)
                .HasColumnType("money")
                .HasColumnName("Rate_Coast_Per_Month");
            entity.Property(e => e.RateName)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("Rate_Name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FullName)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("Full_Name");
            entity.Property(e => e.IdRate).HasColumnName("Id_Rate");
            entity.Property(e => e.IdUser)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_User");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(25)
                .IsFixedLength()
                .HasColumnName("Payment_Method");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(25)
                .IsFixedLength()
                .HasColumnName("Phone_Number");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
