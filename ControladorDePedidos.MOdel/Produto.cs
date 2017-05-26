namespace ControladorDePedidos.Model
{
    public class Produto : ClasseBase
    {
        public virtual Marca Marca { get; set; }

        public string Nome { get; set; }

        public decimal ValorDeCompra { get; set; }

        public decimal ValorDeVenda { get; set; }

        public int QuantidadeEmEstoque { get; set; }

        public int QuantidadeMinimaEmEstoque { get; set; }

        public int QuantidadeDesejavelEmEstoque { get; set; }

        public Fornecedor Fornecedor { get; set; }
    }

}
