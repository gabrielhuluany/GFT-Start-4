using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    bool sucesso = false;

    Console.Write("Digite o valor inicial e o valor final do intervalo: ");
    List<int> lista = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToList());
    List<int> impar = new List<int>();

    for(int i = lista[0]; i < lista[1]; i++) {
        impar.Add(lista[0] + i);
    }

    while(!sucesso) {

      /*
      if(lista[0] < 0) {
        Console.Write("Digite um valor maior que 0!\n");
        sucesso = false;
      }

      if(lista[1] <= lista[0]) {
        Console.Write("Digite um valor final maior que o valor inicial!\n");
        sucesso = false;
      }
      */

      sucesso = true;
    }

/*
    for(int i = 0; i < lista.Count(); i++) {
      if(lista[i] % 2 != 0) {
        Console.WriteLine(lista[i]);
      }
    }
*/
    foreach(int i in impar) {
      if(i % 2 != 0) {
        Console.WriteLine(i);
      }
      
    }

    Console.WriteLine("Pressione qualquer tecla para fechar esta janela...");
    Console.ReadKey();
  }
}