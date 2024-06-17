using System;

class Program {
  public static void Main (string[] args) {
    
    // Faça um programa que leia uma frase, calcule e mostre a quantidade de palavras da frase.
    //   Exemplos:
    //     Frase 1: Nas quintas há aula teórica de Algoritmos e Técnicas de Programação
    //     Número de palavras: 11
    //     Frase 2: A lista de exercícios é sobre strings
    //     Número de palavras: 7

    // declaração

    string frase;
    int contador = 1;

    // solicitar frase
    Console.Write("Digite a frase: ");
    frase = Console.ReadLine();

    // calcular a quantidade de palavras
    for (int i = 0; i < frase.Length; i++) {
      if (frase[i] == ' ') {
        contador++;
      }
    }

    // imprimir a quantidade de palavras
     Console.Write("Número de palavras: " + contador);
  }
}