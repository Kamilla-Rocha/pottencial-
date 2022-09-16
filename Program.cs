using exemplos_fundamentos.Models;

string opcao;

while (true)
{

   
    Console.WriteLine(" Digite a sua opção");
    Console.WriteLine("1 -Cadastrar cliente");
    Console.WriteLine("2 -Buscar cliente");
    Console.WriteLine("3 -APAGAR CLIENTE");
    Console.WriteLine("4 -Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;

        case "2":
            Console.WriteLine("Busca cliente");
            break;

        case "3":
            Console.WriteLine("Apagar cliente");
            break;


        case "4":
            Console.WriteLine("Encerrar");
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;


    }

}
