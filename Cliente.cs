using System;

class Cliente{
  public string Nome;
  public string Endereço;

  public void EscolherProduto(string nome, int quantidade){
    Console.WriteLine("Produto >> {0} - Total >> {1} ", nome, quantidade);

  }

  public void Pagar(int qtd, double valor){
    Console.WriteLine(Produto.CalculoTotal(qtd, valor));

  }



}