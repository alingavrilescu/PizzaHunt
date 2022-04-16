﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pizza_Hunt.Models;

#nullable disable

namespace Pizza_Hunt.Migrations
{
    [DbContext(typeof(PizzaContext))]
    [Migration("20220403134335_InitialCreate2")]
    partial class InitialCreate2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Pizza_Hunt.Models.desert", b =>
                {
                    b.Property<int>("desertId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("desertId"), 1L, 1);

                    b.Property<string>("img_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ingredients")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kcal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("desertId");

                    b.ToTable("desert");
                });

            modelBuilder.Entity("Pizza_Hunt.Models.FavoriteDesert", b =>
                {
                    b.Property<int>("desertID")
                        .HasColumnType("int");

                    b.Property<int>("usersID")
                        .HasColumnType("int");

                    b.HasKey("desertID", "usersID");

                    b.HasIndex("usersID");

                    b.ToTable("FavoriteDesert");
                });

            modelBuilder.Entity("Pizza_Hunt.Models.FavoritePasta", b =>
                {
                    b.Property<int>("pastaID")
                        .HasColumnType("int");

                    b.Property<int>("usersID")
                        .HasColumnType("int");

                    b.HasKey("pastaID", "usersID");

                    b.HasIndex("usersID");

                    b.ToTable("FavoritePasta");
                });

            modelBuilder.Entity("Pizza_Hunt.Models.FavoritePizza", b =>
                {
                    b.Property<int>("pizzaID")
                        .HasColumnType("int");

                    b.Property<int>("usersID")
                        .HasColumnType("int");

                    b.HasKey("pizzaID", "usersID");

                    b.HasIndex("usersID");

                    b.ToTable("FavoritePizza");
                });

            modelBuilder.Entity("Pizza_Hunt.Models.FavoriteRefreshment", b =>
                {
                    b.Property<int>("refreshmentsID")
                        .HasColumnType("int");

                    b.Property<int>("usersID")
                        .HasColumnType("int");

                    b.HasKey("refreshmentsID", "usersID");

                    b.HasIndex("usersID");

                    b.ToTable("FavoriteRefreshment");
                });

            modelBuilder.Entity("Pizza_Hunt.Models.pasta", b =>
                {
                    b.Property<int>("pastaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("pastaId"), 1L, 1);

                    b.Property<string>("img_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ingredients")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kcal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("pastaId");

                    b.ToTable("pasta");
                });

            modelBuilder.Entity("Pizza_Hunt.Models.pizza", b =>
                {
                    b.Property<int>("pizzaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("pizzaId"), 1L, 1);

                    b.Property<string>("img_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ingredients")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kcal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("pizzaId");

                    b.ToTable("pizza");
                });

            modelBuilder.Entity("Pizza_Hunt.Models.refreshments", b =>
                {
                    b.Property<int>("refreshmentsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("refreshmentsId"), 1L, 1);

                    b.Property<string>("img_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kcal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("refreshmentsId");

                    b.ToTable("refreshments");
                });

            modelBuilder.Entity("Pizza_Hunt.Models.users", b =>
                {
                    b.Property<int>("usersID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("usersID"), 1L, 1);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("first_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("last_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("usersID");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Pizza_Hunt.Models.FavoriteDesert", b =>
                {
                    b.HasOne("Pizza_Hunt.Models.desert", "desert")
                        .WithMany("FavoriteDesert")
                        .HasForeignKey("desertID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pizza_Hunt.Models.users", "users")
                        .WithMany("FavoriteDesert")
                        .HasForeignKey("usersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("desert");

                    b.Navigation("users");
                });

            modelBuilder.Entity("Pizza_Hunt.Models.FavoritePasta", b =>
                {
                    b.HasOne("Pizza_Hunt.Models.pasta", "pasta")
                        .WithMany("FavoritePasta")
                        .HasForeignKey("pastaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pizza_Hunt.Models.users", "users")
                        .WithMany("FavoritePasta")
                        .HasForeignKey("usersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pasta");

                    b.Navigation("users");
                });

            modelBuilder.Entity("Pizza_Hunt.Models.FavoritePizza", b =>
                {
                    b.HasOne("Pizza_Hunt.Models.pizza", "pizza")
                        .WithMany("FavoritePizza")
                        .HasForeignKey("pizzaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pizza_Hunt.Models.users", "users")
                        .WithMany("FavoritePizza")
                        .HasForeignKey("usersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pizza");

                    b.Navigation("users");
                });

            modelBuilder.Entity("Pizza_Hunt.Models.FavoriteRefreshment", b =>
                {
                    b.HasOne("Pizza_Hunt.Models.refreshments", "refreshments")
                        .WithMany("FavoriteRefreshment")
                        .HasForeignKey("refreshmentsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pizza_Hunt.Models.users", "users")
                        .WithMany("FavoriteRefreshment")
                        .HasForeignKey("usersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("refreshments");

                    b.Navigation("users");
                });

            modelBuilder.Entity("Pizza_Hunt.Models.desert", b =>
                {
                    b.Navigation("FavoriteDesert");
                });

            modelBuilder.Entity("Pizza_Hunt.Models.pasta", b =>
                {
                    b.Navigation("FavoritePasta");
                });

            modelBuilder.Entity("Pizza_Hunt.Models.pizza", b =>
                {
                    b.Navigation("FavoritePizza");
                });

            modelBuilder.Entity("Pizza_Hunt.Models.refreshments", b =>
                {
                    b.Navigation("FavoriteRefreshment");
                });

            modelBuilder.Entity("Pizza_Hunt.Models.users", b =>
                {
                    b.Navigation("FavoriteDesert");

                    b.Navigation("FavoritePasta");

                    b.Navigation("FavoritePizza");

                    b.Navigation("FavoriteRefreshment");
                });
#pragma warning restore 612, 618
        }
    }
}