using System.Collections.Generic;
namespace trabalho.Models{

    public class Servico
    {
        private static List<ItemServico> listaDeItens = new List<ItemServico>();
        public void AdicionaServico(ItemServico servico){
            listaDeItens.Add(servico);
        }
        public static double TotalizaServicos(){
            double total = 0;
            foreach (var lista in listaDeItens){
                total = total + lista.valor * lista.quantidade;
            }
            return total;
        }
        public List<ItemServico> ListaServicos(){
            return listaDeItens;
        }
    }

}