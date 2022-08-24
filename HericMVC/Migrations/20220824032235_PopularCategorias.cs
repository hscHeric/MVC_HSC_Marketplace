using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HericMVC.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
               "VALUES('Quadros', 'Quadros decorativos nos mais diversos materiais')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
                "VALUES('Vestuario', 'Peças de roupas para os mais diversos gostos')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FOM Categorias");
        }
    }
}
