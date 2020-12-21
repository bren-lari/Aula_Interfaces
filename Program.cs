using System;
using Interface.Classes;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("\r\n--- Seção produtos ---\r\n");

            Carrinho carrinho = new Carrinho();

            Console.WriteLine("Lista de produtos: \r\n");

            Produto p = new Produto();

            p.Codigo = 147;
            p.Nome = "Geladeira K7";
            p.Preco = 5.578f;

            Produto p2 = new Produto();

            p2.Codigo = 2;
            p2.Nome = "Playstation 5";
            p2.Preco = 5.412f;

            Produto p3 = new Produto();

            p3.Codigo = 223;
            p3.Nome = "Notebook DELL";
            p3.Preco = 4.987f;

           Produto p4 = new Produto();
           p4.Codigo = 7;
           p4.Nome = "Bicicleta CANON";
           p4.Preco = 2.789f;


            carrinho.Cadastrar(p);
            carrinho.Cadastrar(p2);
            carrinho.Cadastrar(p3);
            carrinho.Cadastrar(p4);
            carrinho.Listar();

            Console.ForegroundColor = ConsoleColor.Blue;
            
            Console.WriteLine("\r\n Lista alterada: \r\n");

           carrinho.Alterar(p.Codigo, p4);
           carrinho.Listar();
           Console.ResetColor();

           Console.WriteLine("\r\n Lista com produto deletado: \r\n");
           Console.ForegroundColor = ConsoleColor.Magenta;

           carrinho.Deletar(p4);

           carrinho.Listar();

        }
    }
}
