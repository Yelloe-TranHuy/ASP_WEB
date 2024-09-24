﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiKiemTra02.Data.Migrations
{
    /// <inheritdoc />
    public partial class asp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreate",
                table: "LopHoc");

            migrationBuilder.AddColumn<int>(
                name: "NamNhapHoc",
                table: "LopHoc",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NamRaTruong",
                table: "LopHoc",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SoLuongSinhVien",
                table: "LopHoc",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TenLopHoc",
                table: "LopHoc",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NamNhapHoc",
                table: "LopHoc");

            migrationBuilder.DropColumn(
                name: "NamRaTruong",
                table: "LopHoc");

            migrationBuilder.DropColumn(
                name: "SoLuongSinhVien",
                table: "LopHoc");

            migrationBuilder.DropColumn(
                name: "TenLopHoc",
                table: "LopHoc");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreate",
                table: "LopHoc",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
