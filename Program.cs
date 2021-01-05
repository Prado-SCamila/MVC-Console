using System;
using System.Collections.Generic;
using  MVC_Console.Models;
using MVC_Console.Views;

namespace MVC_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoControllers produtoController = new ProdutoControllers();
            produtoController.MostrarProdutos();
            Console.WriteLine();
        }
    }
}
