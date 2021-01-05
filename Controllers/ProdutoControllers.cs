using System.Collections.Generic;
using MVC_Console.Models;
using MVC_Console.Views;
using System;

namespace MVC_Console.Controllers
{
    public class ProdutoController
    {
        Produto produto = new Produto();
        ProdutoViews produtoview = new ProdutoViews();

        public void MostrarProdutos();
        {
            List<Produtos> todos = produto.Ler();
            produtoview.ListarTodos(todos);
            

        }
    }

    
}