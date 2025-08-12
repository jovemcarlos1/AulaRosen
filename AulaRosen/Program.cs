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
decimal salario = decimal.Parse(Console.ReadLine());
Console.WriteLine($"Bem vindo(a) {nome}! O salário informado é de: R${salario} reais.");