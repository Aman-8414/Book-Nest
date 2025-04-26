using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommProject_1144.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddSPToCoverTypeModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           /* migrationBuilder.Sql(@"CREATE PROCEDURE SP_CreateCoverType
	       @name varchar(50)
           AS
	       insert CoverTypes values(@name)");
            migrationBuilder.Sql(@"CREATE PROCEDURE SP_UpdateCoverType
            @id int,
	       @name varchar(50)
           AS
	       update CoverTypes set name=@name where id=@id");
            migrationBuilder.Sql(@"CREATE PROCEDURE SP_DeleteCoverType
            @id int
           AS
	       delete from CoverTypes where id=@id");
            migrationBuilder.Sql(@"CREATE PROCEDURE SP_GetCoverType
           AS
	       select*from CoverTypes");
            migrationBuilder.Sql(@"CREATE PROCEDURE SP_GetCoverTypes
           @id int
           AS
	       select*from CoverTypes where id=@id");*/
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
