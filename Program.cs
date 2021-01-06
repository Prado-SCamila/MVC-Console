using System;
using MVC_Console.Models;
using MVC_Console.Controllers;

namespace MVC_Console
{
    class Program
    {
        static void Main(string[] args)
        {
          ProdutoController produtoController = new ProdutoController();
          produtoController.MostrarProduto();
        }
    }
}
