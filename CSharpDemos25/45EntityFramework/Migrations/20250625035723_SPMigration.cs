using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _45EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class SPMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE PROCEDURE GetCustomerById
                @Id INT
                AS
                BEGIN
                SELECT * FROM Cust WHERE Id=@Id
                END
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP PROCEDURE GetCustomerById");
        }
    }
}
