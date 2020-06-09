using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Produto
    {
        public string Operacao { get; set; }
        public int ProdutoId { get; set; }
        public string NomeProduto { get; set; }
        public int CategoriaId { get; set; }
        public string NomeCategoria { get; set; }
        public string UrlImg { get; set; }
        public string Descricao { get; set; }
        public int Medida { get; set; }
        public int PaisOrigem { get; set; }
        public int TipoFarmacoId { get; set; }
        public int EstoqueId { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataFabrico { get; set; }
        public DateTime DataExp { get; set; }
        public int FuncionarioId { get; set; }
        public string Lote { get; set; }
        public Decimal PrecoCompra { get; set; }

        public Decimal PrecoVenda { get; set; }
    }
}
