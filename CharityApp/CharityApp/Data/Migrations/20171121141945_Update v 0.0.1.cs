﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CharityApp.Data.Migrations
{
    public partial class Updatev001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_News_NewsId",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_NewsId",
                table: "News");

            migrationBuilder.DropColumn(
                name: "NewsId",
                table: "News");

            migrationBuilder.AddColumn<int>(
                name: "NewsId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_NewsId",
                table: "Categories",
                column: "NewsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_News_NewsId",
                table: "Categories",
                column: "NewsId",
                principalTable: "News",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_News_NewsId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_NewsId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "NewsId",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "NewsId",
                table: "News",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_News_NewsId",
                table: "News",
                column: "NewsId");

            migrationBuilder.AddForeignKey(
                name: "FK_News_News_NewsId",
                table: "News",
                column: "NewsId",
                principalTable: "News",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
