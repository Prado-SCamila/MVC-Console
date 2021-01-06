
using MVC_Console.Models;
using MVC_Console.Views;
using System.Collections.Generic;
using System;

namespace MVC_Console.Controllers
{
    public class ProdutoController
    {

        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();
        public void MostrarProduto(){
            List<Produto> todos = produto.Ler();
            produtoView.ListarTodos(todos);
        }
      
    }
}

    
