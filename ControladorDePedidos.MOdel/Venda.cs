using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControladorDePedidos.Model
{
    public class Venda : ClasseBase
    {
        public DateTime DataDeCadastro { get; set; }
        public DateTime DataDaEfetivacao { get; set; }
        public virtual List<ItemDaVenda> ItensDaVenda { get; set; }
        public eStatusDaVenda Status { get; set; }
        public virtual Cliente Cliente { get; set; }
        [NotMapped]
        public decimal ValorTotal
        {
            get
            {
                decimal valor = 0;
                foreach (var item in ItensDaVenda)
                {
                    valor = valor + item.ValorTotal;
                }

                return valor;
            }
        }

        [NotMapped]
        public int QuantidadeDeProdutos
        {
            get
            {
                var quantidade = 0;
                foreach (var item in ItensDaVenda)
                {
                    quantidade = quantidade + item.Quantidade;
                }

                return quantidade;
            }
        }
    }
}
