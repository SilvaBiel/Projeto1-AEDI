using System;

class MainClass {
  public static void Main (string[] args) {
    double total = 0;
    string nome, endereço, continuar="S", CheckTotal;
    int PosProduto, qtd;
    double[] PrecoProdutos;
    string[] ListaDeProdutos;
    Cliente cliente = new Cliente();
    Console.WriteLine("Digite o seu nome, por favor");
    cliente.Nome = Console.ReadLine();
    Console.WriteLine("Digite o seu endereço, por favor");
    cliente.Endereço = Console.ReadLine();
    ListaDeProdutos = new string[] { "arroz", "feijao", "carne" };
    PrecoProdutos = new double[] { 20,7,25 };
      for (int i=0;i<3;i++){
      Console.WriteLine("O preço do(a) {0} é {1}",ListaDeProdutos[i],PrecoProdutos[i]);
      }
      
    
  Carrinho CarrinhoCliente = new Carrinho();
  while (continuar == "S"){
    Console.WriteLine("Digite a posição do produto na tabela de produtos, inicia-se por zero");
    PosProduto = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a quantidade");
    qtd = int.Parse(Console.ReadLine());
    CarrinhoCliente.CompraProduto(ListaDeProdutos[PosProduto], PrecoProdutos[PosProduto], qtd);
    Console.WriteLine("\nPara continuar fazendo compras digite S, para sair digite N");
    continuar = Console.ReadLine();
  }
  Console.WriteLine("Deseja saber o valor total do seu carrinho? Se sim digite S, se não, digite N");
  CheckTotal= Console.ReadLine();
  if (CheckTotal == "S"){
    Console.WriteLine(CarrinhoCliente.CarrinhoTotal());
  }
  Carrinho.ProdutoPreco(20,4);
    
    }

  }