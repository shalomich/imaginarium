﻿// <auto-generated />
using Imaginarium.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Imaginarium.Persistance.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CardCardSet", b =>
                {
                    b.Property<int>("CardSetsId")
                        .HasColumnType("int");

                    b.Property<int>("CardsId")
                        .HasColumnType("int");

                    b.HasKey("CardSetsId", "CardsId");

                    b.HasIndex("CardsId");

                    b.ToTable("CardCardSet");
                });

            modelBuilder.Entity("Imaginarium.Persistance.Entities.Association", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.Property<int>("GamerId")
                        .HasColumnType("int");

                    b.Property<string>("Phrase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoundId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("GamerId");

                    b.HasIndex("RoundId")
                        .IsUnique();

                    b.ToTable("Association");
                });

            modelBuilder.Entity("Imaginarium.Persistance.Entities.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CollectionId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CollectionId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("Imaginarium.Persistance.Entities.CardSet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CardSet");

                    b.HasDiscriminator<string>("Discriminator").HasValue("CardSet");
                });

            modelBuilder.Entity("Imaginarium.Persistance.Entities.Collection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Collections");
                });

            modelBuilder.Entity("Imaginarium.Persistance.Entities.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Imaginarium.Persistance.Entities.Gamer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<bool>("IsPresenter")
                        .HasColumnType("bit");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("UserId");

                    b.ToTable("Gamers");
                });

            modelBuilder.Entity("Imaginarium.Persistance.Entities.Round", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Rounds");
                });

            modelBuilder.Entity("Imaginarium.Persistance.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Imaginarium.Persistance.Entities.Vote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.Property<int>("GamerId")
                        .HasColumnType("int");

                    b.Property<int>("VotingId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("GamerId");

                    b.HasIndex("VotingId");

                    b.ToTable("Vote");
                });

            modelBuilder.Entity("Imaginarium.Persistance.Entities.Voting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoundId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoundId")
                        .IsUnique();

                    b.ToTable("Voting");
                });

            modelBuilder.Entity("Imaginarium.Persistance.Entities.Deck", b =>
                {
                    b.HasBaseType("Imaginarium.Persistance.Entities.CardSet");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.HasIndex("GameId")
                        .IsUnique()
                        .HasFilter("[GameId] IS NOT NULL");

                    b.HasDiscriminator().HasValue("Deck");
                });

            modelBuilder.Entity("Imaginarium.Persistance.Entities.Election", b =>
                {
                    b.HasBaseType("Imaginarium.Persistance.Entities.CardSet");

                    b.Property<int>("RoundId")
                        .HasColumnType("int");

                    b.HasIndex("RoundId")
                        .IsUnique()
                        .HasFilter("[RoundId] IS NOT NULL");

                    b.HasDiscriminator().HasValue("Election");
                });

            modelBuilder.Entity("Imaginarium.Persistance.Entities.Hand", b =>
                {
                    b.HasBaseType("Imaginarium.Persistance.Entities.CardSet");

                    b.Property<int>("GamerId")
                        .HasColumnType("int");

                    b.HasIndex("GamerId")
                        .IsUnique()
                        .HasFilter("[GamerId] IS NOT NULL");

                    b.HasDiscriminator().HasValue("Hand");
                });

            modelBuilder.Entity("CardCardSet", b =>
                {
                    b.HasOne("Imaginarium.Persistance.Entities.CardSet", null)
                        .WithMany()
                        .HasForeignKey("CardSetsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Imaginarium.Persistance.Entities.Card", null)
                        .WithMany()
                        .HasForeignKey("CardsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Imaginarium.Persistance.Entities.Association", b =>
                {
                    b.HasOne("Imaginarium.Persistance.Entities.Card", "Card")
                        .WithMany()
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Imaginarium.Persistance.Entities.Gamer", "Gamer")
                        .WithMany()
                        .HasForeignKey("GamerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Imaginarium.Persistance.Entities.Round", "Round")
                        .WithOne("Association")
                        .HasForeignKey("Imaginarium.Persistance.Entities.Association", "RoundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");

                    b.Navigation("Gamer");

                    b.Navigation("Round");
                });

            modelBuilder.Entity("Imaginarium.Persistance.Entities.Card", b =>
                {
                    b.HasOne("Imaginarium.Persistance.Entities.Collection", "Collection")
                        .WithMany("Cards")
                        .HasForeignKey("CollectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Collection");
                });

            modelBuilder.Entity("Imaginarium.Persistance.Entities.Collection", b =>
                {
                    b.HasOne("Imaginarium.Persistance.Entities.User", "User")
                        .WithMany("Collections")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Imaginarium.Persistance.Entities.Gamer", b =>
                {
                    b.HasOne("Imaginarium.Persistance.Entities.Game", "Game")
                        .WithMany("Gamers")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Imaginarium.Persistance.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Imaginarium.Persistance.Entities.Round", b =>
                {
                    b.HasOne("Imaginarium.Persistance.Entities.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("Imaginarium.Persistance.Entities.Vote", b =>
                {
                    b.HasOne("Imaginarium.Persistance.Entities.Card", "Card")
                        .WithMany()
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Imaginarium.Persistance.Entities.Gamer", "Gamer")
                        .WithMany()
                        .HasForeignKey("GamerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Imaginarium.Persistance.Entities.Voting", "Voting")
                        .WithMany("Votes")
                        .HasForeignKey("VotingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");

                    b.Navigation("Gamer");

                    b.Navigation("Voting");
                });

            modelBuilder.Entity("Imaginarium.Persistance.Entities.Voting", b =>
                {
                    b.HasOne("Imaginarium.Persistance.Entities.Round", "Round")
                        .WithOne("Voting")
                        .HasForeignKey("Imaginarium.Persistance.Entities.Voting", "RoundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Round");
                });

            modelBuilder.Entity("Imaginarium.Persistance.Entities.Deck", b =>
                {
                    b.HasOne("Imaginarium.Persistance.Entities.Game", "Game")
                        .WithOne("Deck")
                        .HasForeignKey("Imaginarium.Persistance.Entities.Deck", "GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("Imaginarium.Persistance.Entities.Election", b =>
                {
                    b.HasOne("Imaginarium.Persistance.Entities.Round", "Round")
                        .WithOne("Election")
                        .HasForeignKey("Imaginarium.Persistance.Entities.Election", "RoundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Round");
                });

            modelBuilder.Entity("Imaginarium.Persistance.Entities.Hand", b =>
                {
                    b.HasOne("Imaginarium.Persistance.Entities.Gamer", "Gamer")
                        .WithOne("Hand")
                        .HasForeignKey("Imaginarium.Persistance.Entities.Hand", "GamerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gamer");
                });

            modelBuilder.Entity("Imaginarium.Persistance.Entities.Collection", b =>
                {
                    b.Navigation("Cards");
                });

            modelBuilder.Entity("Imaginarium.Persistance.Entities.Game", b =>
                {
                    b.Navigation("Deck");

                    b.Navigation("Gamers");
                });

            modelBuilder.Entity("Imaginarium.Persistance.Entities.Gamer", b =>
                {
                    b.Navigation("Hand");
                });

            modelBuilder.Entity("Imaginarium.Persistance.Entities.Round", b =>
                {
                    b.Navigation("Association");

                    b.Navigation("Election");

                    b.Navigation("Voting");
                });

            modelBuilder.Entity("Imaginarium.Persistance.Entities.User", b =>
                {
                    b.Navigation("Collections");
                });

            modelBuilder.Entity("Imaginarium.Persistance.Entities.Voting", b =>
                {
                    b.Navigation("Votes");
                });
#pragma warning restore 612, 618
        }
    }
}
