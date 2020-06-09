using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Categoria
    {
        public string Operacao { get; set; }
        public int CategoriaId { get; set; }
        public string NomeCateg { get; set; }
        public bool Estado { get; set; }
    }

    public class SubCategoria
    {
        public string Operacao { get; set; }
        public int CategoriaId { get; set; }
        public int SubCategoriaId { get; set; }
        public string NomeSubCateg { get; set; }
        public bool Estado { get; set; }

    }

    public class TipoFarmaco
    {
        public string Operacao { get; set; }
        public int TipoFarmacoId { get; set; }
        public string NomeTipoFarmaco { get; set; }
        public int SubCategoriaId { get; set; }
    }

    public class Categ_SubCateg
    {
        public string Operacao { get; set; }
        public int CategSubId { get; set; }
        public int CategoriaId { get; set; }
        public string NomeCateg { get; set; }
        public int SubCategoriaId { get; set; }
        public string NomeSubCateg { get; set; }
        public bool Estado { get; set; }
    }

    public class Estoque
    {
        public string Operacao { get; set; }
        public int EstoqueId { get; set; }
        public int ProdutoId { get; set; }

        //----------------Usados para pesquisar--------------
        public string NomeCateg { get; set; }
        public string NomeProduto { get; set; }
        public string NomeTipoFarmaco { get; set; }
        
        //---------------------------------------------------
        public string Descricao { get; set; }
        public bool Estado { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataFabrico { get; set; }
        public DateTime DataExp { get; set; }
        public int FuncionarioId { get; set; }
        public string Lote { get; set; }
        public Decimal PrecoCompra { get; set; }
        public Decimal PrecoVenda { get; set; }
    }
    public class Caixa
    {
        public string Operacao { get; set; }
        public int CaixaId { get; set; }
        public string Descricao { get; set; }
        public bool Estado { get; set; }
    }
    public class Funcionario
    {
        public string Operacao { get; set; }
        public int FuncionarioId { get; set; }
        public string NomeCompleto { get; set; }
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public string Abertura { get; set; }
        public string Cargo { get; set; }
        public Decimal SaldoInicial { get; set; }
        public int CaixaId { get; set; }
        public int CaixaFunc { get; set; }
        public int NrVenda { get; set; }
        public string Telf { get; set; }
        public int Genero { get; set; }
        public string Email { get; set; }
        public int CargoId { get; set; }
        public string Endereco { get; set; }
        public bool Estado { get; set; }

    }

    public class Venda
    {
        public string Operacao { get; set; }
        public int VendaId { get; set; }
        public int CaixaFunc { get; set; }
        public decimal ValorTotal { get; set; }
        public int TipoPagamento { get; set; }
        public int ClienteId { get; set; }
    }

    public class Pedido
    {
        public string Operacao { get; set; }
        public int VendaId { get;set; }
        public int Quantidade { get; set; }
        public int EstoqueId { get; set; }
        public Decimal PrecoVenda { get; set; }

    }

    public class Relatorio
    {
        public string Operacao { get; set; }
        public int FuncionarioId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Ano { get; set; }

    }

    public class Cliente
    {
        public string Operacao { get; set; }
        public int ClienteId { get; set; }
        public string NomeCompleto { get; set; }
        public int PessoaId { get; set; }
        public int ContactoId { get; set; }
        public string Telf { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public bool Estado { get; set; }
    }
    public class Fornecedor
    {
        public string Operacao { get; set; }

        public string NomeFornecedor { get; set; }
        public int ContactoId { get; set; }
        public string Telf { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }

    }
}
