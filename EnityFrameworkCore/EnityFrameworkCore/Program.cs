using System;
using System.Linq;

namespace EnityFrameworkCore
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //GravarUsandoAdoNet();
            //GravarUsandoEntity();
            RecuperarProdutos();
            RemoverProduto();
            RecuperarProdutos();
        }

        private static void RemoverProduto()
        {
            using (var context = new LojaContext())
            {
                var produtos = context.Produtos.ToList();
                foreach (var item in produtos)
                {
                    context.Produtos.Remove(item);
                }
                context.SaveChanges();
            }
        }

        private static void RecuperarProdutos()
        {
            using (var context = new LojaContext())
            {
                var produtos = context.Produtos.ToList();

                Console.WriteLine("Foram encontrados {0} produto(s).", produtos.Count);

                foreach (var item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }
            }
        }

        private static void GravarUsandoEntity()
        {
            Produto p = new Produto
            {
                Nome = "Cassino Royale",
                Categoria = "Filmes",
                Preco = 19.89
            };

            using (var context = new LojaContext())
            {
                context.Produtos.Add(p);
                context.SaveChanges();
            }
        }

        private static void GravarUsandoAdoNet()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var repo = new ProdutoDAO())
            {
                repo.Adicionar(p);
            }
        }
    }
}