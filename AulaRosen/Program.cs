// See https://aka.ms/new-console-template for more information
/*int idade = 23;
Console.WriteLine($"Sua idade é: {idade}");

if (idade >= 18)
    Console.WriteLine("Você pode tirar habilitação!");
else
    Console.WriteLine("Você não pode tirar habilitação");*/


Console.WriteLine("Informe seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine("informe seu salário: ");
double salario = double.Parse(Console.ReadLine());
Console.WriteLine($"Bem vindo(a) {nome}! O salário informado é de: R${salario} reais.");

//Informem o valor do IRPF a ser pago de acordo com o salário informado. Utilize a tabela real de desconto de IRPF

decimal irpf;

if (salario < 2248.80)
{
    irpf = (decimal)salario * 0 - 0;
    Console.WriteLine($"IRPF a ser pago: {irpf}");

}
else if (salario >= 2248.81 && salario <= 2826.65)
{
    irpf = (decimal)salario * 0.0075 - 182.16;
    Console.WriteLine(irpf);

}