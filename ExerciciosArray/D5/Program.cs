/*
Exercício 5:

Compra de Produtos com Variação de Preços
Descrição:Leia o preço de 6 produtos e armazene-os em um array. Após isso, aplique um aumento de 8% em todos os preços e exiba a lista de preços atualizados.
    Dicas:
Preencha o array com os preços dos produtos.
Utilize um loop para aplicar o aumento de preço a cada item do array.
Mostre os preços atualizados após a alteração.
*/

decimal[] precos = new decimal[6];

        
    for (int i = 0; i < precos.Length; i++)
    {
        Console.WriteLine($"Digite o preço do {i + 1}° produto:");
        precos[i] = decimal.Parse(Console.ReadLine());
    }

    for (int i = 0; i < precos.Length; i++)
    {
        precos[i] += precos[i] * 0.08m;
    }
Console.WriteLine("\nPreços atualizados com 8% de aumento:");
    for (int i = 0; i < precos.Length; i++)
    {
        Console.WriteLine($"Preço do {i + 1}° produto: R$ {precos[i]:F2}");
    }


