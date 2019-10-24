using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcionários",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 40, nullable: false),
                    Dep = table.Column<string>(maxLength: 30, nullable: false),
                    Tel1 = table.Column<string>(maxLength: 15, nullable: false),
                    Email = table.Column<string>(maxLength: 30, nullable: false),
                    Date = table.Column<string>(maxLength: 10, nullable: false),
                    Tel2 = table.Column<string>(maxLength: 15, nullable: true),
                    Acess = table.Column<bool>(nullable: false),
                    Login = table.Column<string>(maxLength: 20, nullable: false),
                    Senha = table.Column<string>(maxLength: 15, nullable: false),
                    ConfirmSenha = table.Column<string>(maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionários", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionários");
        }
    }
}
