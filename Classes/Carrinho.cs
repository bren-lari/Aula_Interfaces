using System;
using System.Collections.Generic;

namespace Interface.Classes
{
    public class Carrinho : ICarrinho
    {

        
        
        
        List<Produto> carrinho = new List<Produto>();


        public void Alterar(int cod, Produto produto)
        {
            carrinho.Find(x => x.Codigo == cod ).Nome = produto.Nome;
            carrinho.Find(x => x.Codigo == cod ).Preco = produto.Preco;
        }

        public void Cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Deletar(Produto produto)
        {
           carrinho.Remove(produto);
        }

        public void Listar()
        {
            foreach (Produto item in carrinho)
            {
              Console.WriteLine($"{item.Codigo} -> Nome do produto {item.Nome} -> Preço do produto: {item.Preco}")  ;
            }
        }
    }
}