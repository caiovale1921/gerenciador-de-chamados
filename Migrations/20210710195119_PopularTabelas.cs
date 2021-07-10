using Microsoft.EntityFrameworkCore.Migrations;

namespace TiTech.Migrations
{
    public partial class PopularTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Clientes VALUES ('Cliente Padrao')");
            migrationBuilder.Sql("INSERT INTO Funcionarios VALUES ('AdminServer', 'Admin')");
            migrationBuilder.Sql("INSERT INTO Categorias VALUES ('10/07/2021', 'Manutencao')");
            migrationBuilder.Sql("INSERT INTO Situacaos VALUES ('10/07/2021', 'Em andamento')");
            migrationBuilder.Sql("INSERT INTO Prioridades VALUES ('10/07/2021', 'Urgente')");
            migrationBuilder.Sql("INSERT INTO Chamados VALUES ('Chamado de Teste', '10/07/2021', '1', '1', '1', '1', '1', '10/08/2021', 'Descricao generica do chamado')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM CHAMADO");
        }
    }
}
