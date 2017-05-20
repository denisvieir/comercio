﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorDePedidos.Model
{
    public class Venda
    {
        [Key]
        public int Codigo { get; set; }
        public DateTime DataDeCadastro { get; set; }
        public DateTime DataDaEfetivacao { get; set; }
        public virtual List<ItemDaVenda> ItensDaVenda { get; set; }
        public eStatusDaVenda Status { get; set; }
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
