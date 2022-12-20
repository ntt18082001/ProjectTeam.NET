﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectTeam.Data;

#nullable disable

namespace ProjectTeam.Data.Migrations
{
    [DbContext(typeof(WebAppDbContext))]
    partial class WebAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjectTeam.Data.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool?>("CanDelete")
                        .HasColumnType("bit");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("AppRole", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CanDelete = false,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Khách hàng",
                            Name = "Khách hàng",
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CanDelete = true,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Quản trị toàn bộ hệ thống",
                            Name = "Quản trị hệ thống",
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("ProjectTeam.Data.Entities.AppRolePermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AppRoleId")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<int>("MstPermissionId")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AppRoleId");

                    b.HasIndex("MstPermissionId");

                    b.ToTable("AppRolePermission", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AppRoleId = 2,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1101,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            AppRoleId = 2,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1102,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            AppRoleId = 2,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1103,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            AppRoleId = 2,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1104,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            AppRoleId = 2,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1105,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            AppRoleId = 2,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1001,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            AppRoleId = 2,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1002,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            AppRoleId = 2,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1003,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            AppRoleId = 2,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1004,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            AppRoleId = 2,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1005,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11,
                            AppRoleId = 2,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1006,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 12,
                            AppRoleId = 2,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1007,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 13,
                            AppRoleId = 2,
                            CreatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MstPermissionId = 1008,
                            UpdatedDate = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("ProjectTeam.Data.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("AppRoleId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Avatar")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("BlockedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BlockedTo")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varbinary(200)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varbinary(200)");

                    b.Property<string>("PhoneNumber1")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("PhoneNumber2")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("AppRoleId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("AppUser", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Thành phố Hồ Chí Minh",
                            AppRoleId = 2,
                            CreatedBy = -1,
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin_test@gmail.com",
                            FullName = "Nguyen ProVip123",
                            PasswordHash = new byte[] { 25, 38, 70, 46, 168, 156, 119, 173, 154, 26, 66, 184, 128, 157, 160, 154, 199, 50, 25, 0, 91, 166, 218, 45, 134, 5, 121, 46, 60, 46, 206, 25, 212, 121, 30, 184, 138, 94, 199, 130, 159, 146, 164, 1, 27, 227, 57, 237, 32, 116, 54, 185, 53, 163, 232, 4, 93, 156, 187, 40, 182, 75, 165, 85 },
                            PasswordSalt = new byte[] { 162, 106, 76, 134, 80, 110, 153, 60, 242, 176, 136, 137, 61, 3, 144, 63, 176, 93, 235, 112, 211, 89, 211, 94, 161, 220, 212, 193, 219, 17, 237, 189, 119, 12, 133, 123, 96, 211, 51, 165, 161, 184, 36, 97, 53, 197, 244, 29, 85, 178, 67, 138, 235, 49, 66, 105, 96, 0, 85, 145, 148, 162, 55, 145, 86, 82, 175, 18, 231, 46, 146, 106, 131, 1, 10, 2, 12, 15, 20, 182, 175, 56, 201, 204, 105, 78, 122, 202, 119, 0, 94, 54, 62, 85, 176, 218, 131, 239, 25, 167, 154, 30, 252, 66, 40, 177, 255, 140, 245, 215, 45, 82, 129, 204, 242, 196, 143, 133, 42, 153, 45, 210, 244, 196, 28, 27, 21, 54 },
                            PhoneNumber1 = "0939002144",
                            PhoneNumber2 = "0939002144",
                            UpdatedBy = -1,
                            UpdatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("ProjectTeam.Data.Entities.MstPermission", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Table")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("MstPermission", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1103,
                            Code = "CREATE",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Thêm quyền",
                            GroupName = "Quản lý phân quyền",
                            Table = "AppRole"
                        },
                        new
                        {
                            Id = 1105,
                            Code = "DELETE",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Xóa quyền",
                            GroupName = "Quản lý phân quyền",
                            Table = "AppRole"
                        },
                        new
                        {
                            Id = 1104,
                            Code = "UPDATE",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Sửa quyền",
                            GroupName = "Quản lý phân quyền",
                            Table = "AppRole"
                        },
                        new
                        {
                            Id = 1102,
                            Code = "VIEW_DETAIL",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Xem chi tiết quyền",
                            GroupName = "Quản lý phân quyền",
                            Table = "AppRole"
                        },
                        new
                        {
                            Id = 1101,
                            Code = "VIEW_LIST",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Xem danh sách quyền",
                            GroupName = "Quản lý phân quyền",
                            Table = "AppRole"
                        },
                        new
                        {
                            Id = 1006,
                            Code = "BLOCK",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Khóa người dùng",
                            GroupName = "Quản lý người dùng",
                            Table = "AppUser"
                        },
                        new
                        {
                            Id = 1003,
                            Code = "CREATE",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Thêm người dùng",
                            GroupName = "Quản lý người dùng",
                            Table = "AppUser"
                        },
                        new
                        {
                            Id = 1008,
                            Code = "DELETE",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Xóa người dùng",
                            GroupName = "Quản lý người dùng",
                            Table = "AppUser"
                        },
                        new
                        {
                            Id = 1007,
                            Code = "UNBLOCK",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Mở khóa người dùng",
                            GroupName = "Quản lý người dùng",
                            Table = "AppUser"
                        },
                        new
                        {
                            Id = 1004,
                            Code = "UPDATE",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Cập nhật người dùng",
                            GroupName = "Quản lý người dùng",
                            Table = "AppUser"
                        },
                        new
                        {
                            Id = 1005,
                            Code = "UPDATE_PWD",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Đổi mật khẩu",
                            GroupName = "Quản lý người dùng",
                            Table = "AppUser"
                        },
                        new
                        {
                            Id = 1002,
                            Code = "VIEW_DETAIL",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Xem chi tiết người dùng",
                            GroupName = "Quản lý người dùng",
                            Table = "AppUser"
                        },
                        new
                        {
                            Id = 1001,
                            Code = "VIEW_LIST",
                            CreatedDate = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desc = "Xem danh sách người dùng",
                            GroupName = "Quản lý người dùng",
                            Table = "AppUser"
                        });
                });

            modelBuilder.Entity("ProjectTeam.Data.Entities.AppRolePermission", b =>
                {
                    b.HasOne("ProjectTeam.Data.Entities.AppRole", "AppRole")
                        .WithMany("AppRolePermissions")
                        .HasForeignKey("AppRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectTeam.Data.Entities.MstPermission", "MstPermission")
                        .WithMany("AppRolePermissions")
                        .HasForeignKey("MstPermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppRole");

                    b.Navigation("MstPermission");
                });

            modelBuilder.Entity("ProjectTeam.Data.Entities.AppUser", b =>
                {
                    b.HasOne("ProjectTeam.Data.Entities.AppRole", "AppRole")
                        .WithMany("AppUsers")
                        .HasForeignKey("AppRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppRole");
                });

            modelBuilder.Entity("ProjectTeam.Data.Entities.AppRole", b =>
                {
                    b.Navigation("AppRolePermissions");

                    b.Navigation("AppUsers");
                });

            modelBuilder.Entity("ProjectTeam.Data.Entities.MstPermission", b =>
                {
                    b.Navigation("AppRolePermissions");
                });
#pragma warning restore 612, 618
        }
    }
}
