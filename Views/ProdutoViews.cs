using System;
using System.Collections.Generic;
using MVC_Console.Models;

namespace MVC_Console.Views
{
    public class ProdutoViews
    {
        public void ListarTodos(List <Produto> produtos){
            foreach (Produto item in produtos){
                Console.WriteLine($"Codigo: {item.Codigo}");
                  Console.WriteLine($"Nome: {item.Nome}");
                    Console.WriteLine($"Preço: {item.Preco}");
            }
        }
    }
}