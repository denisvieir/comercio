﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorDePedidos.Model
{
    public class Compra : ClasseBase
    {
        public DateTime DataDeCadastro { get; set; }
        public DateTime DataDaEfetivacao { get; set; }
        public DateTime DataDoRecebimento { get; set; }
        public virtual List<ItemDaCompra> ItensDaCompra { get; set; }
        public eStatusDaCompra Status { get; set; }
        [NotMapped]
        public decimal ValorTotal
        {
            get
            {
                decimal valor = 0;
                foreach (var item in ItensDaCompra)
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
                foreach (var item in ItensDaCompra)
                {
                    quantidade = quantidade + item.Quantidade;
                }

                return quantidade;
            }
        }
    }
}
