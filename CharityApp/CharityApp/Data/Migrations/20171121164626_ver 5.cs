﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CharityApp.Data.Migrations
{
    public partial class ver5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_Categories_CategoriId",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_CategoriId",
                table: "News");

            migrationBuilder.DropColumn(
                name: "CategoriId",
                table: "News");

            migrationBuilder.AddColumn<int>(
                name: "CategoriesId",
                table: "News",
                type: "int",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "CategoriId",
                table: "News",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_News_CategoriId",
                table: "News",
                column: "CategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Categories_CategoriId",
                table: "News",
                column: "CategoriId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}