using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    public partial class ChangeDateTimeDefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NewsCategories_Categories_CategoryId",
                table: "NewsCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_NewsCategories_News_CategoryId",
                table: "NewsCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_NewsCommentReplies_NewsComments_CommentId",
                table: "NewsCommentReplies");

            migrationBuilder.DropForeignKey(
                name: "FK_NewsCommentReplies_Users_UserId",
                table: "NewsCommentReplies");

            migrationBuilder.DropForeignKey(
                name: "FK_NewsTags_News_NewsId",
                table: "NewsTags");

            migrationBuilder.DropForeignKey(
                name: "FK_NewsTags_Tags_TagId",
                table: "NewsTags");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentDate",
                table: "NewsComments",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 6, 2, 19, 20, 22, 801, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReplyDate",
                table: "NewsCommentReplies",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 6, 2, 19, 20, 22, 802, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "News",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 6, 2, 19, 20, 22, 803, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.AddForeignKey(
                name: "FK_NewsCategories_Categories_CategoryId",
                table: "NewsCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NewsCategories_News_CategoryId",
                table: "NewsCategories",
                column: "CategoryId",
                principalTable: "News",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NewsCommentReplies_NewsComments_CommentId",
                table: "NewsCommentReplies",
                column: "CommentId",
                principalTable: "NewsComments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NewsCommentReplies_Users_UserId",
                table: "NewsCommentReplies",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NewsTags_News_NewsId",
                table: "NewsTags",
                column: "NewsId",
                principalTable: "News",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NewsTags_Tags_TagId",
                table: "NewsTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NewsCategories_Categories_CategoryId",
                table: "NewsCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_NewsCategories_News_CategoryId",
                table: "NewsCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_NewsCommentReplies_NewsComments_CommentId",
                table: "NewsCommentReplies");

            migrationBuilder.DropForeignKey(
                name: "FK_NewsCommentReplies_Users_UserId",
                table: "NewsCommentReplies");

            migrationBuilder.DropForeignKey(
                name: "FK_NewsTags_News_NewsId",
                table: "NewsTags");

            migrationBuilder.DropForeignKey(
                name: "FK_NewsTags_Tags_TagId",
                table: "NewsTags");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentDate",
                table: "NewsComments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 6, 2, 19, 20, 22, 801, DateTimeKind.Local).AddTicks(5655),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReplyDate",
                table: "NewsCommentReplies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 6, 2, 19, 20, 22, 802, DateTimeKind.Local).AddTicks(4453),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "News",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 6, 2, 19, 20, 22, 803, DateTimeKind.Local).AddTicks(7614),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AddForeignKey(
                name: "FK_NewsCategories_Categories_CategoryId",
                table: "NewsCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NewsCategories_News_CategoryId",
                table: "NewsCategories",
                column: "CategoryId",
                principalTable: "News",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NewsCommentReplies_NewsComments_CommentId",
                table: "NewsCommentReplies",
                column: "CommentId",
                principalTable: "NewsComments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NewsCommentReplies_Users_UserId",
                table: "NewsCommentReplies",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NewsTags_News_NewsId",
                table: "NewsTags",
                column: "NewsId",
                principalTable: "News",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NewsTags_Tags_TagId",
                table: "NewsTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
