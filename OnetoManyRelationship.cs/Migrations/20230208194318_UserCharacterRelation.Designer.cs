﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnetoManyRelationship.cs.Data;

#nullable disable

namespace OnetoManyRelationship.cs.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230208194318_UserCharacterRelation")]
    partial class UserCharacterRelation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OnetoManyRelationship.cs.Character", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("HitPoints")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("userid");

                    b.ToTable("characters");
                });

            modelBuilder.Entity("OnetoManyRelationship.cs.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("OnetoManyRelationship.cs.Character", b =>
                {
                    b.HasOne("OnetoManyRelationship.cs.User", "user")
                        .WithMany("characters")
                        .HasForeignKey("userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("OnetoManyRelationship.cs.User", b =>
                {
                    b.Navigation("characters");
                });
#pragma warning restore 612, 618
        }
    }
}
