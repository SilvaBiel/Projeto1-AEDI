using System;
class Produto{
  private string Nome;
  private string Característica;
  private double Preço;



  public void SetNome(string n){
    Nome = n;
  }

  public void SetPreço(double p){
    Preço = p;
  }

  public double CalculoTotal(int qtd){
    return qtd*Preço;

  }

  public static double CalculoTotal(int qtd, double valor){
    return qtd*valor;

  }
  }