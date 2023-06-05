﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PartRoleManagementAPI.Data;

#nullable disable

namespace PartRoleManagementAPI.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PartyRoleManagementAPI.Models.ContactMedium", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BaseType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartyRoleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool?>("Preferred")
                        .HasColumnType("bit");

                    b.Property<string>("SchemaLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PartyRoleId");

                    b.ToTable("ContactMedia");
                });

            modelBuilder.Entity("PartyRoleManagementAPI.Models.CreditProfile", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreditProfileDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CreditRiskRating")
                        .HasColumnType("bigint");

                    b.Property<long>("CreditScore")
                        .HasColumnType("bigint");

                    b.Property<string>("PartyRoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PartyRoleId");

                    b.ToTable("CreditProfiles");
                });

            modelBuilder.Entity("PartyRoleManagementAPI.Models.PartyRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Href")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusReason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PartyRole");
                });

            modelBuilder.Entity("PartyRoleManagementAPI.Models.ContactMedium", b =>
                {
                    b.HasOne("PartyRoleManagementAPI.Models.PartyRole", null)
                        .WithMany("ContactMedium")
                        .HasForeignKey("PartyRoleId");

                    b.OwnsOne("PartyRoleManagementAPI.Models.TimePeriod", "ValidFor", b1 =>
                        {
                            b1.Property<string>("ContactMediumId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<DateTime?>("EndDateTime")
                                .HasColumnType("datetime2");

                            b1.Property<DateTime?>("StartDateTime")
                                .HasColumnType("datetime2");

                            b1.HasKey("ContactMediumId");

                            b1.ToTable("ContactMedia");

                            b1.ToJson("ValidFor");

                            b1.WithOwner()
                                .HasForeignKey("ContactMediumId");
                        });

                    b.OwnsOne("PartyRoleManagementAPI.Models.MediumCharacteristic", "Characteristic", b1 =>
                        {
                            b1.Property<string>("ContactMediumId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("EmailAddress")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("FaxNumber")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Id")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("PhoneNumber")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("PostCode")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("StateOrProvince")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Street1")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Street2")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Type")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ContactMediumId");

                            b1.ToTable("MediumCharacteristics", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("ContactMediumId");
                        });

                    b.Navigation("Characteristic")
                        .IsRequired();

                    b.Navigation("ValidFor")
                        .IsRequired();
                });

            modelBuilder.Entity("PartyRoleManagementAPI.Models.CreditProfile", b =>
                {
                    b.HasOne("PartyRoleManagementAPI.Models.PartyRole", null)
                        .WithMany("CreditProfile")
                        .HasForeignKey("PartyRoleId");

                    b.OwnsOne("PartyRoleManagementAPI.Models.TimePeriod", "ValidFor", b1 =>
                        {
                            b1.Property<string>("CreditProfileId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<DateTime?>("EndDateTime")
                                .HasColumnType("datetime2");

                            b1.Property<DateTime?>("StartDateTime")
                                .HasColumnType("datetime2");

                            b1.HasKey("CreditProfileId");

                            b1.ToTable("CreditProfiles");

                            b1.ToJson("ValidFor");

                            b1.WithOwner()
                                .HasForeignKey("CreditProfileId");
                        });

                    b.Navigation("ValidFor")
                        .IsRequired();
                });

            modelBuilder.Entity("PartyRoleManagementAPI.Models.PartyRole", b =>
                {
                    b.OwnsMany("PartyRoleManagementAPI.Models.AccountRef", "Account", b1 =>
                        {
                            b1.Property<string>("PartyRoleId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("Id")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("Description")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Href")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("ReferredType")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("PartyRoleId", "Id");

                            b1.ToTable("AccountRef", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("PartyRoleId");
                        });

                    b.OwnsMany("PartyRoleManagementAPI.Models.AgreementRef", "Agreement", b1 =>
                        {
                            b1.Property<string>("PartyRoleId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("Id")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("Href")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("ReferredType")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("PartyRoleId", "Id");

                            b1.ToTable("AgreementRefs", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("PartyRoleId");
                        });

                    b.OwnsMany("PartyRoleManagementAPI.Models.Characteristic", "Characteristic", b1 =>
                        {
                            b1.Property<string>("PartyRoleId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("ValueType")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("PartyRoleId", "Id");

                            b1.ToTable("Characteristics", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("PartyRoleId");
                        });

                    b.OwnsOne("PartyRoleManagementAPI.Models.RelatedParty", "EngagedParty", b1 =>
                        {
                            b1.Property<string>("PartyRoleId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("BaseType")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Href")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Id")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("ReferredType")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Role")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("SchemaLocation")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Type")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("PartyRoleId");

                            b1.ToTable("EngagedPartys", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("PartyRoleId");
                        });

                    b.OwnsMany("PartyRoleManagementAPI.Models.RelatedParty", "RelatedParty", b1 =>
                        {
                            b1.Property<string>("PartyRoleId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("Id")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("BaseType")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Href")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("ReferredType")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Role")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("SchemaLocation")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Type")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("PartyRoleId", "Id");

                            b1.ToTable("RelatedPartys", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("PartyRoleId");
                        });

                    b.OwnsOne("PartyRoleManagementAPI.Models.TimePeriod", "ValidFor", b1 =>
                        {
                            b1.Property<string>("PartyRoleId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<DateTime?>("EndDateTime")
                                .HasColumnType("datetime2");

                            b1.Property<DateTime?>("StartDateTime")
                                .HasColumnType("datetime2");

                            b1.HasKey("PartyRoleId");

                            b1.ToTable("PartyRole");

                            b1.ToJson("ValidFor");

                            b1.WithOwner()
                                .HasForeignKey("PartyRoleId");
                        });

                    b.OwnsMany("PartyRoleManagementAPI.Models.PaymentMethodRef", "PaymentMethod", b1 =>
                        {
                            b1.Property<string>("PartyRoleId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("Id")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("Href")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("ReferredType")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("PartyRoleId", "Id");

                            b1.ToTable("PaymentMethods", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("PartyRoleId");
                        });

                    b.Navigation("Account");

                    b.Navigation("Agreement");

                    b.Navigation("Characteristic");

                    b.Navigation("EngagedParty")
                        .IsRequired();

                    b.Navigation("PaymentMethod");

                    b.Navigation("RelatedParty");

                    b.Navigation("ValidFor")
                        .IsRequired();
                });

            modelBuilder.Entity("PartyRoleManagementAPI.Models.PartyRole", b =>
                {
                    b.Navigation("ContactMedium");

                    b.Navigation("CreditProfile");
                });
#pragma warning restore 612, 618
        }
    }
}
