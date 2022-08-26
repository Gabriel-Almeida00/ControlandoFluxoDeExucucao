// See https://aka.ms/new-console-template for more information
int mes;

Console.WriteLine("Digite um número do Mês");
mes = int.Parse(Console.ReadLine());

switch (mes)
{
    case 1:
        Console.WriteLine("Janeiro");
        break;
    case 2:
        Console.WriteLine("Fevereiro");
        break;
    case 3:
        Console.WriteLine("Março");
        break;
    case 4:
        Console.WriteLine("Abril");
        break;
    case 5:
        Console.WriteLine("Mail");
        break;
    default:
        Console.WriteLine("Inválido");
        break;

}

