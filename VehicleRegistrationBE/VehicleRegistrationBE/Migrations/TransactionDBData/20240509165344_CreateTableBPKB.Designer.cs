﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VehicleRegistrationBE.Entities.DataContext;

#nullable disable

namespace VehicleRegistrationBE.Migrations.TransactionDBData
{
    [DbContext(typeof(TransactionDBDataContext))]
    [Migration("20240509165344_CreateTableBPKB")]
    partial class CreateTableBPKB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("VehicleRegistrationBE.Entities.TrBPKB", b =>
                {
                    b.Property<string>("AgreementNumber")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("agreement_number");

                    b.Property<DateTime>("BPKBDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("bpkb_date");

                    b.Property<DateTime>("BPKBDateIn")
                        .HasColumnType("datetime2")
                        .HasColumnName("bpkb_date_in");

                    b.Property<string>("BPKBNo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("bpkb_no");

                    b.Property<string>("BranchId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("branch_id");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("created_by");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_at");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("deleted_by");

                    b.Property<DateTime>("FakturDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("faktur_date");

                    b.Property<string>("FakturNo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("faktur_no");

                    b.Property<string>("LocationId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("location_id");

                    b.Property<string>("PoliceNo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("police_no");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("updated_by");

                    b.HasKey("AgreementNumber");

                    b.ToTable("TR_BPKB");
                });
#pragma warning restore 612, 618
        }
    }
}
