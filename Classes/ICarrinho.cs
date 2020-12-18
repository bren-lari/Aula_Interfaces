namespace Interface.Classes
{
    public interface ICarrinho
    {
         void Listar();

         void Cadastrar(Produto produto);

         void Alterar(int _codigo, Produto Novoproduto);

         void Deletar(Produto produto);

    }
}