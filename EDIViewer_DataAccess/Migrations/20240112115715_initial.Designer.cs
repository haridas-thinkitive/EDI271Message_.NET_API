﻿// <auto-generated />
using System;
using EDIViewer_DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EDIViewer_DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240112115715_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EDIViewer_DataAccess.Models.MessageListData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CoPayment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EncounterID")
                        .HasColumnType("int");

                    b.Property<string>("FreeMessageText_01")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logmessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Segment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SubMessageDataId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubMessageDataId");

                    b.ToTable("MessageListData");
                });

            modelBuilder.Entity("EDIViewer_DataAccess.Models.Messages", b =>
                {
                    b.Property<int>("EncounterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EncounterId"));

                    b.Property<string>("Response")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EncounterId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("EDIViewer_DataAccess.Models.SubMessageData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("TestMessageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TestMessageId");

                    b.ToTable("SubMessageData");
                });

            modelBuilder.Entity("EDIViewer_DataAccess.Models.TestMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("testMessages");
                });

            modelBuilder.Entity("EDIViewer_DataAccess.Models.MessageListData", b =>
                {
                    b.HasOne("EDIViewer_DataAccess.Models.SubMessageData", null)
                        .WithMany("messageListDatas")
                        .HasForeignKey("SubMessageDataId");
                });

            modelBuilder.Entity("EDIViewer_DataAccess.Models.SubMessageData", b =>
                {
                    b.HasOne("EDIViewer_DataAccess.Models.TestMessage", null)
                        .WithMany("SubMessages")
                        .HasForeignKey("TestMessageId");
                });

            modelBuilder.Entity("EDIViewer_DataAccess.Models.SubMessageData", b =>
                {
                    b.Navigation("messageListDatas");
                });

            modelBuilder.Entity("EDIViewer_DataAccess.Models.TestMessage", b =>
                {
                    b.Navigation("SubMessages");
                });
#pragma warning restore 612, 618
        }
    }
}
