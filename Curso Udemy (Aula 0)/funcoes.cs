using System;

internal class Funcoes
{
  public static void ShowDate()
  {
    string date = DateTime.Now.Date.ToString();
    Console.WriteLine(date);
  }

  public static void ShowMessage(string username)
  {
    Console.WriteLine("Ola {0}", username);
  }

  static void Main(string[] args)
  {
    Console.WriteLine("Aprendendo com trabalhar com Funções segundo arquivo");
    ShowDate();
    Console.ReadKey();


  } 
    
}

