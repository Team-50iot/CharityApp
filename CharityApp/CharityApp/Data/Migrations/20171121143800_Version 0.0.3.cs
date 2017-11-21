using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CharityApp.Data.Migrations
{
    public partial class Version003 : Migration
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
