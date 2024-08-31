/*
    Exercício 1: 
Avaliação de Notas de Estudantes
Descrição: Crie um programa que leia as notas de 6 estudantes em uma disciplina. Armazene essas notas em um array e calcule a nota total e a média das notas. Em seguida, informe a nota mais alta e a mais baixa da turma.
    Dicas:
Use um loop para ler as notas dos estudantes e armazená-las no array.
Para calcular a soma e a média, você pode usar um acumulador e a contagem de elementos.
Para encontrar a nota mais alta e a mais baixa, você pode comparar os valores enquanto lê as notas.
*/

double[] notas = new double[6];
double soma = 0, notaMenor = int.MaxValue, notaMaior = int.MinValue;

for (int i = 0; i< notas.Length; i++)
{
    Console.WriteLine($"Digite a nota do {i+1}° Aluno ");
    notas[i] = double.Parse(Console.ReadLine());
    soma += notas[i];

    if (notas[i] > notaMaior)
    {
        notaMaior =  notas[i];
    }
    if (notas[i] < notaMenor)
    {
        notaMenor = notas[i];
    }
}
    Console.WriteLine($"\nTotal de notas: {soma}");
    Console.WriteLine($"Media das notas: {soma/notas.Length:F2}");
    Console.WriteLine($"Maior Nota: {notaMaior}");
    Console.WriteLine($"Menor Nota: {notaMenor}");
