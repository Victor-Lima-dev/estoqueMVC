using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estoqueMVC.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataValidade { get; set; }

        public void CadastrarProduto(Produto produto)
        {
            produto.DataCadastro = DateTime.Now;
            produto.DataValidade = DateTime.Now.AddYears(1);
        }


        
        
    }
}