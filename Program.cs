using System;

namespace Calculator // Note: actual namespace depends on the project name.
{
  public static class UserName
  {
    public static string nameUser;
  }
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Olá, usuario, digite Seu Nome, por favor:");
      UserName.nameUser = Console.ReadLine();
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("Qual das operações abaixo deseja fazer, " + UserName.nameUser + "?");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Divisão");
      Console.WriteLine("4 - Multiplicação");
      Console.WriteLine("5 - Sair");

      Console.WriteLine("----------");
      Console.WriteLine("Selecione uma opção:");

      short res = short.Parse(Console.ReadLine());

      switch (res)
      {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 5: Sair(); break;
        default: Menu(); break;
      }
    }
    static void Soma()
    {
      Console.Clear();
      Console.WriteLine("Primeiro valor:");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo Valor:");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = v1 + v2;
      // Console.WriteLine("O resultado da soma é " + resultado);(Concatenado)
      Console.WriteLine($"O resultado da soma é {resultado}");// (Sifram)
      // Console.WriteLine($"O resultado da soma é {v1 + v2}");(Sifram com Soma Direta)
      // Console.WriteLine("O resultado da soma é " + (v1 + v2));(Concatenado com Soma Direta)
      Console.ReadKey();
      Menu();
    }

    static void Subtracao()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor:");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor:");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = v1 - v2;
      Console.WriteLine($"O resultado da subtração é {resultado}");
      Console.ReadKey();
      Menu();
    }

    static void Divisao()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor:");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = v1 / v2;
      Console.WriteLine($"O resultado da divisão é {resultado}");
      Console.ReadKey();
      Menu();
    }

    static void Multiplicacao()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor:");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = v1 * v2;
      Console.WriteLine("O resultado da multiplicação é " + (v1 * v2));
      Console.ReadKey();
      Menu();
    }

    static void Sair()
    {
      Console.WriteLine("Obrigado, " + UserName.nameUser + ", por usar nosso Sistema!:3³");
      Console.ReadKey();
      System.Environment.Exit(0);
    }
  }
}
/* See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!"); */