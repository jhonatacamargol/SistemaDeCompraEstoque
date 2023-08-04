using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque
{
    public class Produto
    {
        public string Lote { get; set; }
        public string Item { get; set; }
        public DateTime? DataVencimento { get; set; }
        public DateTime? DataFabricacao { get; set; }

        public Produto(string lote, string item, DateTime dataFabricacao, DateTime dataVencimento)
        {
            Lote = lote;
            Item = item;
            DataFabricacao = dataFabricacao;
            DataVencimento = dataVencimento;
        }

        public override string ToString()
        {
            return $"Lote: {Lote}, Item: {Item}, Data de Fabricação: {DataFabricacao.ToString()}, Data de Vencimento: {DataVencimento.ToString()}";
        }
    }
}
