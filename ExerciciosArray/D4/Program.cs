/*
    Exercício 4: 
Registro de Temperaturas
Descrição: Crie um programa que leia as temperaturas registradas durante 7 dias e armazene-as em um array. Calcule a temperatura média, a temperatura mais alta e a mais baixa durante esses dias.
    Dicas:
Use um loop para ler as temperaturas diárias e armazená-las em um array.
Calcule a média, a temperatura mais alta e a mais baixa enquanto lê os dados.
*/

using System.Runtime.InteropServices;
using System.Xml.Serialization;

int[] temp = new int[7];
int tempMax = int.MinValue, tempMin = int.MaxValue, soma = 0;

for (int i = 0;i < temp.Length; i++)
{
    Console.WriteLine($"Digite a temperatura do {i + 1}° dia");
    temp[i] = int.Parse(Console.ReadLine());
    soma += temp[i];
    if (temp[i] > tempMax)
    {
        tempMax = temp[i];
    }
    if (temp[i] < tempMin)
    {
        tempMin = temp[i];
    }
}

    Console.WriteLine($"\nMedia das Temperaturas: {soma/temp.Length}");
    Console.WriteLine($"Maior Temperatura: {tempMax}");
    Console.WriteLine($"Menor Temperatura: {tempMin}");