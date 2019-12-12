﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using vue_expenses_api.Infrastructure;

namespace vue_expenses_api.Migrations
{
    [DbContext(typeof(ExpensesContext))]
    [Migration("20191203070956_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("vue_expenses_api.Domain.Expense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Archived")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comments")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TypeId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Expenses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Archived = false,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2019, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2019, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TypeId = 2,
                            UpdatedAt = new DateTime(2019, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1,
                            Value = 1403.46750426268m
                        },
                        new
                        {
                            Id = 2,
                            Archived = false,
                            CategoryId = 4,
                            CreatedAt = new DateTime(2019, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2019, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TypeId = 4,
                            UpdatedAt = new DateTime(2019, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1,
                            Value = 791.256844667372m
                        },
                        new
                        {
                            Id = 3,
                            Archived = false,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2019, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2019, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TypeId = 2,
                            UpdatedAt = new DateTime(2019, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1,
                            Value = 99.009541607932m
                        },
                        new
                        {
                            Id = 4,
                            Archived = false,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2019, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2019, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TypeId = 2,
                            UpdatedAt = new DateTime(2019, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1,
                            Value = 1126.86389969981m
                        },
                        new
                        {
                            Id = 5,
                            Archived = false,
                            CategoryId = 4,
                            CreatedAt = new DateTime(2019, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2019, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TypeId = 4,
                            UpdatedAt = new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1,
                            Value = 835.003490017263m
                        },
                        new
                        {
                            Id = 6,
                            Archived = false,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2019, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2019, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TypeId = 4,
                            UpdatedAt = new DateTime(2019, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1,
                            Value = 672.835299360024m
                        },
                        new
                        {
                            Id = 7,
                            Archived = false,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2019, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2019, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TypeId = 3,
                            UpdatedAt = new DateTime(2019, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1,
                            Value = 492.141799299112m
                        },
                        new
                        {
                            Id = 8,
                            Archived = false,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2019, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2019, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TypeId = 4,
                            UpdatedAt = new DateTime(2019, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1,
                            Value = 334.451731217304m
                        },
                        new
                        {
                            Id = 9,
                            Archived = false,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2019, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2019, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TypeId = 2,
                            UpdatedAt = new DateTime(2019, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1,
                            Value = 1103.60175958071m
                        },
                        new
                        {
                            Id = 10,
                            Archived = false,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2019, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2019, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TypeId = 2,
                            UpdatedAt = new DateTime(2019, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1,
                            Value = 833.508845108333m
                        },
                        new
                        {
                            Id = 11,
                            Archived = false,
                            CategoryId = 4,
                            CreatedAt = new DateTime(2019, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TypeId = 3,
                            UpdatedAt = new DateTime(2019, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1,
                            Value = 1454.17837749896m
                        },
                        new
                        {
                            Id = 12,
                            Archived = false,
                            CategoryId = 4,
                            CreatedAt = new DateTime(2019, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2019, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TypeId = 4,
                            UpdatedAt = new DateTime(2019, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1,
                            Value = 850.961542618909m
                        },
                        new
                        {
                            Id = 13,
                            Archived = false,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2019, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2019, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TypeId = 3,
                            UpdatedAt = new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1,
                            Value = 854.321417330914m
                        },
                        new
                        {
                            Id = 14,
                            Archived = false,
                            CategoryId = 4,
                            CreatedAt = new DateTime(2019, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2019, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TypeId = 3,
                            UpdatedAt = new DateTime(2019, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1,
                            Value = 343.066516492081m
                        },
                        new
                        {
                            Id = 15,
                            Archived = false,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2019, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2019, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TypeId = 2,
                            UpdatedAt = new DateTime(2019, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1,
                            Value = 530.740105794156m
                        },
                        new
                        {
                            Id = 16,
                            Archived = false,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2019, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TypeId = 2,
                            UpdatedAt = new DateTime(2019, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1,
                            Value = 758.134676496561m
                        },
                        new
                        {
                            Id = 17,
                            Archived = false,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2019, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2019, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TypeId = 4,
                            UpdatedAt = new DateTime(2019, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1,
                            Value = 922.086741506162m
                        },
                        new
                        {
                            Id = 18,
                            Archived = false,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2019, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2019, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TypeId = 4,
                            UpdatedAt = new DateTime(2019, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1,
                            Value = 1349.4523751314m
                        },
                        new
                        {
                            Id = 19,
                            Archived = false,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2019, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2019, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TypeId = 3,
                            UpdatedAt = new DateTime(2019, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1,
                            Value = 440.349611658766m
                        },
                        new
                        {
                            Id = 20,
                            Archived = false,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2019, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2019, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TypeId = 3,
                            UpdatedAt = new DateTime(2019, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1,
                            Value = 228.618344631334m
                        },
                        new
                        {
                            Id = 21,
                            Archived = false,
                            CategoryId = 4,
                            CreatedAt = new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2019, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TypeId = 2,
                            UpdatedAt = new DateTime(2019, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1,
                            Value = 1391.87224064575m
                        },
                        new
                        {
                            Id = 22,
                            Archived = false,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2019, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2019, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TypeId = 2,
                            UpdatedAt = new DateTime(2019, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1,
                            Value = 168.342807641413m
                        },
                        new
                        {
                            Id = 23,
                            Archived = false,
                            CategoryId = 4,
                            CreatedAt = new DateTime(2019, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2019, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TypeId = 4,
                            UpdatedAt = new DateTime(2019, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1,
                            Value = 1129.74741199508m
                        },
                        new
                        {
                            Id = 24,
                            Archived = false,
                            CategoryId = 4,
                            CreatedAt = new DateTime(2019, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2019, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TypeId = 2,
                            UpdatedAt = new DateTime(2019, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1,
                            Value = 1091.68861228586m
                        });
                });

            modelBuilder.Entity("vue_expenses_api.Domain.ExpenseCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Archived")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Budget")
                        .HasColumnType("TEXT");

                    b.Property<string>("ColourHex")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ExpenseCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Archived = false,
                            Budget = 2000m,
                            ColourHex = "#CE93D8",
                            CreatedAt = new DateTime(2019, 12, 3, 7, 9, 55, 787, DateTimeKind.Local).AddTicks(9411),
                            Name = "General Expenses",
                            UpdatedAt = new DateTime(2019, 12, 3, 7, 9, 55, 787, DateTimeKind.Local).AddTicks(9411),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Archived = false,
                            Budget = 3000m,
                            ColourHex = "#64B5F6",
                            CreatedAt = new DateTime(2019, 12, 3, 7, 9, 55, 787, DateTimeKind.Local).AddTicks(9411),
                            Name = "Shopping",
                            UpdatedAt = new DateTime(2019, 12, 3, 7, 9, 55, 787, DateTimeKind.Local).AddTicks(9411),
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Archived = false,
                            Budget = 2500m,
                            ColourHex = "#26A69A",
                            CreatedAt = new DateTime(2019, 12, 3, 7, 9, 55, 787, DateTimeKind.Local).AddTicks(9411),
                            Name = "Utilities",
                            UpdatedAt = new DateTime(2019, 12, 3, 7, 9, 55, 787, DateTimeKind.Local).AddTicks(9411),
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            Archived = false,
                            Budget = 1000m,
                            ColourHex = "#FB8C00",
                            CreatedAt = new DateTime(2019, 12, 3, 7, 9, 55, 787, DateTimeKind.Local).AddTicks(9411),
                            Name = "Travel",
                            UpdatedAt = new DateTime(2019, 12, 3, 7, 9, 55, 787, DateTimeKind.Local).AddTicks(9411),
                            UserId = 1
                        });
                });

            modelBuilder.Entity("vue_expenses_api.Domain.ExpenseType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Archived")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ExpenseTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Archived = false,
                            CreatedAt = new DateTime(2019, 12, 3, 7, 9, 55, 787, DateTimeKind.Local).AddTicks(9411),
                            Name = "Credit Card",
                            UpdatedAt = new DateTime(2019, 12, 3, 7, 9, 55, 787, DateTimeKind.Local).AddTicks(9411),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Archived = false,
                            CreatedAt = new DateTime(2019, 12, 3, 7, 9, 55, 787, DateTimeKind.Local).AddTicks(9411),
                            Name = "Debit Card",
                            UpdatedAt = new DateTime(2019, 12, 3, 7, 9, 55, 787, DateTimeKind.Local).AddTicks(9411),
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Archived = false,
                            CreatedAt = new DateTime(2019, 12, 3, 7, 9, 55, 787, DateTimeKind.Local).AddTicks(9411),
                            Name = "Cheque",
                            UpdatedAt = new DateTime(2019, 12, 3, 7, 9, 55, 787, DateTimeKind.Local).AddTicks(9411),
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            Archived = false,
                            CreatedAt = new DateTime(2019, 12, 3, 7, 9, 55, 787, DateTimeKind.Local).AddTicks(9411),
                            Name = "Cash",
                            UpdatedAt = new DateTime(2019, 12, 3, 7, 9, 55, 787, DateTimeKind.Local).AddTicks(9411),
                            UserId = 1
                        });
                });

            modelBuilder.Entity("vue_expenses_api.Domain.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("TEXT");

                    b.Property<string>("Token")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("vue_expenses_api.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Archived")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("CurrencyRegionName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Hash")
                        .HasColumnType("BLOB");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Salt")
                        .HasColumnType("BLOB");

                    b.Property<string>("SystemName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<bool>("UseDarkMode")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Archived = false,
                            CreatedAt = new DateTime(2019, 12, 3, 7, 9, 55, 787, DateTimeKind.Local).AddTicks(9411),
                            CurrencyRegionName = "GB",
                            Email = "test@demo.com",
                            FirstName = "John",
                            FullName = "John Doe",
                            Hash = new byte[] { 87, 187, 231, 98, 18, 94, 234, 113, 35, 110, 119, 13, 89, 84, 4, 174, 99, 10, 173, 17, 131, 198, 189, 178, 105, 37, 173, 28, 112, 254, 45, 92, 142, 10, 75, 183, 131, 93, 232, 147, 9, 253, 122, 45, 214, 157, 245, 101, 78, 86, 210, 97, 54, 142, 199, 227, 150, 150, 50, 113, 32, 25, 213, 79 },
                            LastName = "Doe",
                            Salt = new byte[] { 52, 239, 132, 228, 105, 110, 101, 66, 183, 165, 173, 144, 153, 137, 12, 116 },
                            SystemName = "VueExpenses",
                            UpdatedAt = new DateTime(2019, 12, 3, 7, 9, 55, 787, DateTimeKind.Local).AddTicks(9411),
                            UseDarkMode = true
                        });
                });

            modelBuilder.Entity("vue_expenses_api.Domain.Expense", b =>
                {
                    b.HasOne("vue_expenses_api.Domain.ExpenseCategory", "Category")
                        .WithMany("Expenses")
                        .HasForeignKey("CategoryId");

                    b.HasOne("vue_expenses_api.Domain.ExpenseType", "Type")
                        .WithMany("Expenses")
                        .HasForeignKey("TypeId");

                    b.HasOne("vue_expenses_api.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("vue_expenses_api.Domain.ExpenseCategory", b =>
                {
                    b.HasOne("vue_expenses_api.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("vue_expenses_api.Domain.ExpenseType", b =>
                {
                    b.HasOne("vue_expenses_api.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("vue_expenses_api.Domain.RefreshToken", b =>
                {
                    b.HasOne("vue_expenses_api.Domain.User", "User")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}