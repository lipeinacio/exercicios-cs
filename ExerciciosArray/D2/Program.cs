/*
    Exercício 2: 
Sequência de Quadrados
Descrição: Crie um programa que preencha um array com os quadrados dos números inteiros de 1 a 10. Exiba o conteúdo do array e depois mostre a soma de todos os quadrados.
    Dicas:
Use um loop para preencher o array com os quadrados dos números de 1 a 10.
Depois, use outro loop ou um método para calcular a soma dos valores no array.
*/

int[] quadrados = new int[10];
int soma = 0;

for (int i = 0; i < quadrados.Length; i++) 
{
    quadrados[i] = (i + 1) * (i + 1);
    soma += quadrados[i];
    Console.WriteLine($"Posição {i + 1}°: {quadrados[i]}");
}

Console.WriteLine($"\nSoma de todos os quadrados: {soma}");
