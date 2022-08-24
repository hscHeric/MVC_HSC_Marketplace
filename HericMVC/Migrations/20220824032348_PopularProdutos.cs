using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HericMVC.Migrations
{
    public partial class PopularProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Produtos(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsProdutoPreferido,Nome,Preco) " +
                          "VALUES(1,'Quadro player tentacles.','altura: 20cm|comprimento: 1cm|largura: 26cm|peso: 31gr',1, 'https://images.tcdn.com.br/img/img_prod/723087/180_quadro_metal_26x20cm_player_tentacles_6839_1_20201214140323.jpg','https://images.tcdn.com.br/img/img_prod/723087/quadro_metal_26x20cm_player_tentacles_6839_1_20201214140323.jpg', 1 ,'QUADRO METAL - JOGADOR TENTÁCULO', 29.90)");


            migrationBuilder.Sql("INSERT INTO Produtos(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsProdutoPreferido,Nome,Preco) " +
                            "VALUES(1,'QUADRO STAR WARS','altura: 26 cm | largura: 19 cm | material: metal | peso: 245g |',1, 'https://images.tcdn.com.br/img/img_prod/723087/180_quadro_metal_26x20cm_que_a_forca_esteja_com_voce_7251_1_20201214140614.jpg','https://images.tcdn.com.br/img/img_prod/723087/quadro_metal_26x20cm_que_a_forca_esteja_com_voce_7251_1_20201214140614.jpg', 0 ,'QUADRO METAL - QUE A FORÇA ESTEJA COM VOCÊ', 29.90)");

            migrationBuilder.Sql("INSERT INTO Produtos(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsProdutoPreferido,Nome,Preco) " +
                            "VALUES(2,'Camiseta Naruto.','Camiseta 100% algodão e com uma estampa que não tem erro',1, 'https://images.tcdn.com.br/img/img_prod/723087/180_camiseta_akatsuki_membros_naruto_8397_1_59d70ec9d9103813948cd4c62a2de1a8.png','https://images.tcdn.com.br/img/img_prod/723087/camiseta_akatsuki_membros_naruto_8397_1_59d70ec9d9103813948cd4c62a2de1a8.png', 0 ,'CAMISETA AKATSUKI MEMBROS - NARUTO', 29.90)");

            migrationBuilder.Sql("INSERT INTO Produtos(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsProdutoPreferido,Nome,Preco) " +
                            "VALUES(2,'STAR WARS CHINELO','Especificações: Altura: 31cm |Comprimento: 45cm| Largura 32cm| Peso: 217gr| Material: Poliester',1, 'https://images.tcdn.com.br/img/img_prod/723087/180_quadro_metal_26x20cm_player_tentacles_6839_1_20201214140323.jpg','https://images.tcdn.com.br/img/img_prod/723087/pantufa_star_wars_chinelo_de_quarto_8265_1_d690215b2c9cca847406309f0ae5d8a1.png', 1 ,'PANTUFA STAR WARS CHINELO DE QUARTO', 109.90)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FOM Produtos");
        }
    }
}
