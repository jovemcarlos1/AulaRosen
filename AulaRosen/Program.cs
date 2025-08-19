// See https://aka.ms/new-console-template for more information
/*int idade = 23;
Console.WriteLine($"Sua idade é: {idade}");

if (idade >= 18)
    Console.WriteLine("Você pode tirar habilitação!");
else
    Console.WriteLine("Você não pode tirar habilitação");*/

try
{
    Console.WriteLine("Informe seu nome: ");
    string nome = Console.ReadLine();
    Console.WriteLine("informe seu salário: ");
    decimal salario = decimal.Parse(Console.ReadLine());
    Console.WriteLine($"Bem vindo(a) {nome}! O salário informado é de: R${salario} reais.");

    //Informem o valor do IRPF a ser pago de acordo com o salário informado. Utilize a tabela real de desconto de IRPF

    decimal irpf;

    if (salario <= 2259.20m)
        irpf = 0;
    else if (salario >= 2826.65m)
        irpf = salario * 0.075m - 169.21m;
    else if (salario <= 3751.05m)
        irpf = salario * 0.15m - 381.44m;
    else if (salario <= 4664.68m)
        irpf = salario * 0.225m - 662.77m;
    else
        irpf = salario * 0.275m - 896m;

    Console.WriteLine($"Para o salário de {salario} o valor a ser pago de IRPF é {irpf}, então o salário com desconto de IRPF será {salario - irpf}");

}
catch(FormatException)
{
    Console.WriteLine("O salário deve ser informado em formato numérico.");
}

catch (Exception e)
{
    Console.WriteLine("Ocorreu um erro. Contate o Suporte Técnico.");
    Console.WriteLine(e.StackTrace);
}


