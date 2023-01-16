using System;

internal class Program
{
  private static void Main(string[] args)
  {
    // Até a Aula 09. (Strings em geral)
    /*
    string username = "";

    Console.WriteLine("Olá, qual é o seu nome?");
    username = Console.ReadLine();
    Console.Write("fala meu bom, seja bem vindo " + username);
    Console.ReadKey();
    */

    // Aula 10 e 16. (Tabuada) (FOR)
    /* AULA 10 ->
    string enter = "";
    int n = 0;

    Console.WriteLine("Tabuada");
    Console.Write("Informe um número: ");
    enter = Console.ReadLine();
    n = Convert.ToInt32(enter);

    Console.WriteLine("Tabuada do " + n);
    Console.WriteLine(n + " x 1 = " + (n * 1));
    */

    //AULA 20
    /*
    int n = 0;
    Console.WriteLine("Tabuada de um numero");
    Console.Write("Informe um Número: ");
    n = Convert.ToInt32(Console.ReadLine());
    int i = 0;
    for(i = 1; i <= 10; i++)
    {
      Console.WriteLine("{0} x {1} = {2}", n, i, (n * i));
    }
    Console.ReadKey();
    */

    //Aula 11. (Área do triangulo)
    /*
    double a = 0;
    double b = 0;
    double h = 0;
    string enter = "";

    Console.WriteLine("Área do triangulo");
    Console.Write("Informe a base do triângulo: ");
    enter = Console.ReadLine();
    b = Convert.ToDouble(enter);
    Console.Write("Informe a altura do triângulo: ");
    enter = Console.ReadLine();
    h = Convert.ToDouble(enter);

    a = (b * h) / 2;
    Console.WriteLine("Área do triangulo e: " + a);
    */

    //Aula 12. (Divisão e resto)
    /*
    int n1 = 0; 
    int n2 = 0;
    double r  = 0;
    double q  = 0;

    Console.WriteLine("Programa que efetua a divisão de dois números");
    Console.Write("Informe o primeiro número: ");
    n1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Informe o segundo número: ");
    n2 = Convert.ToInt32(Console.ReadLine());

    q = n1 / n2;
    r = n1 % n2;

    Console.WriteLine("Resposta da divisão");
    Console.WriteLine("{0}/{1} = {2}", n1, n2, q);

    Console.WriteLine("Resto: {0}", r);
    Console.ReadKey();
    */

    //Aula 13 e 15. (Cálculo de idade)
    /*
    int currentYear = DateTime.Now.Year;
    int birthDate = 0;
    int age = 0;

    Console.WriteLine("Cálculo de idade");
    Console.Write("Ano de seu nascimento: ");
    birthDate = Convert.ToInt32(Console.ReadLine());

    if (birthDate <= currentYear)
    {
      age = currentYear - birthDate;
      Console.WriteLine("Sua idade e: " + age);
    }
    else
    {
      Console.WriteLine("Erro! Informe um ano de nascimento valido");
    }
    
    Console.ReadKey();
    */

    //Aula 14. (Condicionais)
    /*
    int n = 0;
    int r = 0;

    Console.WriteLine("Verifica se e par ou impar");
    Console.Write("Informe um numero: ");

    n = Convert.ToInt32(Console.ReadLine());

    r = n % 2;

    if( r > 0)
    {
      Console.WriteLine("O numero {0} e impar", n);
    }
    else
    {
      Console.WriteLine("O numero {0} e par", n);
    }
    Console.ReadKey();
    */

    //Aula 18. (Condicionais - Empréstimo)
    /*
    Boolean employee = false;
    Boolean guarantor = false;
    string enter = "";

    Console.WriteLine("Empréstimo…");
    Console.Write("Possui fiador (S/N): ");
    enter = Console.ReadLine();

    if (enter == "s")
    {
      guarantor = true;
    }

    Console.Write("Esta empregado (S/N): ");
    enter = Console.ReadLine();

    if (enter == "s")
    {
      employee = true;
    }

    if(employee || guarantor)
    {
      Console.WriteLine("Parabéns!!!!! Seu empréstimo foi liberado.");
    }
    else
    {
      Console.WriteLine("Seu empréstimo nao foi liberado.");
    }

    Console.ReadKey();
    */

    //Aula 19. (Condicionais - Final)
    /*
    string name = "";
    int age = 0;

    Console.WriteLine("Clase do Eleitor");
    Console.Write("Informe seu nome: ");
    name = Console.ReadLine();
    Console.Write("Informe a sua idade: ");
    age = Convert.ToInt32(Console.ReadLine());


    if(age < 16)
    {
      Console.WriteLine("{0} Você não possui idade para votar", name);
    }
    else
    {
      if((age > 15 && age < 18) || age > 65)
      {
        Console.WriteLine("{0} Você e um eleitor facultativo", name);
      }
      else
      {
        Console.WriteLine("{0}, seu voto e obrigatorio", name);
      }
    }

    Console.ReadKey();
    */

    //Aula 21. (For calculador de média)
    /*
    double num = 0;
    double average = 0;
    double total = 0;
    float tl = 0;

    Console.WriteLine("Programa que calcula a média dos números informados");
    Console.Write("Quantos números deseja informar: ");
    tl = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= tl; i++)
    {
      Console.Write("informe um numero: ");
      num = Convert.ToDouble(Console.ReadLine());
      total =+ num;
    }

    average = total / tl;
    Console.WriteLine("Total: " + total);
    Console.WriteLine("Media: {0}:", average);

    Console.ReadKey();
    */
  }
}