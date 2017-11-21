using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CharityApp.Data.Migrations
{
    public partial class AddUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_Categories_CategoriesId",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_CategoriesId",
                table: "News");

            migrationBuilder.DropColumn(
                name: "CategoriesId",
                table: "News");

            migrationBuilder.AddColumn<int>(
                name: "NewsId",
                table: "News",
                type: "int",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "CategoriesId",
                table: "News",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_News_CategoriesId",
                table: "News",
                column: "CategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Categories_CategoriesId",
                table: "News",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
