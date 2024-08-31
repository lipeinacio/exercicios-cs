/*
    Exercício 3:
Cálculo de Preço Total com Desconto
Descrição: Leia os preços de 5 itens de uma loja e armazene-os em um array. Calcule o preço total e aplique um desconto de 12% se o total for maior que um determinado valor (por exemplo, R$ 100). Exiba o preço total e o valor com desconto (se aplicável).
    Dicas:
Use um loop para ler os preços dos itens e acumular o total.
Verifique se o total é maior que o valor de referência para aplicar o desconto.
Lembre-se de atualizar e exibir o total com desconto.
*/

double[] precos = new double[5];
double soma = 0;

for(int i = 0; i < precos.Length; i++)
{
    Console.WriteLine($"Digite o Preço do {i + 1}° Produto");
    precos[i] = double.Parse(Console.ReadLine());
    soma += precos[i];
}
Console.WriteLine($"O valor total a ser pago é de: R${soma:F2}");
if (soma > 100)
{
    soma = soma * 0.88;
    Console.WriteLine($"Parabéns sua compra ganhou um desconto: {soma:F2}");
}
