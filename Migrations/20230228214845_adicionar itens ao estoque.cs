using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace estoqueMVC.Migrations
{
    /// <inheritdoc />
    public partial class adicionaritensaoestoque : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //adicionar produtos ao banco de dados, alimentos
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Preco, Descricao) VALUES ('Arroz', 5.50, 'Arroz 5kg')");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Preco, Descricao) VALUES ('Feijão', 4.50, 'Feijão 1kg')");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Preco, Descricao) VALUES ('Macarrão', 2.50, 'Macarrão 500g')");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Preco, Descricao) VALUES ('Açúcar', 3.50, 'Açúcar 1kg')");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Preco, Descricao) VALUES ('Farinha', 2.50, 'Farinha 1kg')");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Preco, Descricao) VALUES ('Óleo', 5.50, 'Óleo 1L')");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Preco, Descricao) VALUES ('Sal', 1.50, 'Sal 1kg')");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Preco, Descricao) VALUES ('Leite', 3.50, 'Leite 1L')");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Preco, Descricao) VALUES ('Café', 5.50, 'Café 500g')");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Preco, Descricao) VALUES ('Biscoito', 2.50, 'Biscoito 500g')");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Preco, Descricao) VALUES ('Manteiga', 5.50, 'Manteiga 500g')");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Preco, Descricao) VALUES ('Requeijão', 5.50, 'Requeijão 500g')");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Preco, Descricao) VALUES ('Queijo', 5.50, 'Queijo 500g')");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Preco, Descricao) VALUES ('Presunto', 5.50, 'Presunto 500g')");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Preco, Descricao) VALUES ('Carne', 5.50, 'Carne 500g')");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Preco, Descricao) VALUES ('Frango', 5.50, 'Frango 500g')");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Preco, Descricao) VALUES ('Ovos', 5.50, 'Ovos 500g')");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Preco, Descricao) VALUES ('Salsicha', 5.50, 'Salsicha 500g')");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Preco, Descricao) VALUES ('Sorvete', 5.50, 'Sorvete 500g')");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Preco, Descricao) VALUES ('Iogurte', 5.50, 'Iogurte 500g')");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Preco, Descricao) VALUES ('Suco', 5.50, 'Suco 500g')");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Preco, Descricao) VALUES ('Cerveja', 5.50, 'Cerveja 500g')");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Preco, Descricao) VALUES ('Vinho', 5.50, 'Vinho 500g')");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Preco, Descricao) VALUES ('Vodka', 5.50, 'Vodka 500g')");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Preco, Descricao) VALUES ('Whisky', 5.50, 'Whisky 500g')");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Preco, Descricao) VALUES ('Cachaça', 5.50, 'Cachaça 500g')");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Preco, Descricao) VALUES ('Vodca', 5.50, 'Vodca 500g')");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Preco, Descricao) VALUES ('Café', 5.50, 'Café 500g')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //remover produtos do banco de dados
            migrationBuilder.Sql("DELETE FROM Produtos WHERE Nome IN ('Arroz', 'Feijão', 'Macarrão', 'Açúcar', 'Farinha', 'Óleo', 'Sal', 'Leite', 'Café', 'Biscoito', 'Manteiga', 'Requeijão', 'Queijo', 'Presunto', 'Carne', 'Frango', 'Ovos', 'Salsicha', 'Sorvete', 'Iogurte', 'Suco', 'Cerveja', 'Vinho', 'Vodka', 'Whisky', 'Cachaça', 'Vodca', 'Café')");
        }
    }
}
