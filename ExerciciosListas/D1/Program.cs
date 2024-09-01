/*
    Exercício 1: 
Adicionando e Removendo Elementos de uma Lista
Descrição: Crie um programa que inicialize uma lista de strings representando nomes de frutas. Peça ao usuário para adicionar mais frutas à lista até que ele digite "sair". Em seguida, permita que o usuário remova frutas específicas da lista digitando o nome da fruta a ser removida. 
    Dicas:
Use List<string> para criar a lista.
Utilize Add para adicionar elementos e Remove para removê-los.
Aprenda a verificar se um item existe na lista com Contains.
*/

List<string> frutas = ["Maçã", "Banana", "Laranja"];

string entrada;

do
{
    Console.WriteLine("Digite o nome de uma fruta para adicionar (ou 'sair' para terminar):");
    entrada = Console.ReadLine();

    if (entrada.ToLower() != "sair")
    {
        frutas.Add(entrada);
        Console.WriteLine($"{entrada} foi adicionada à lista.");
    }
} while (entrada.ToLower() != "sair");

do
{
    Console.WriteLine("Digite o nome de uma fruta para remover (ou 'sair' para terminar):");
    entrada = Console.ReadLine();

    if (entrada.ToLower() != "sair")
    {
        if (frutas.Contains(entrada))
        {
            frutas.Remove(entrada);
            Console.WriteLine($"{entrada} foi removida da lista.");
        }
        else
        {
            Console.WriteLine($"{entrada} não está na lista.");
        }
    }
} while (entrada.ToLower() != "sair");

Console.WriteLine("Lista final de frutas:");
foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}
