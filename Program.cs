
using System;
using System.Runtime.InteropServices;
List<string> ListaDeBanda = new List<string>();


void Logo()


{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

    
}
void RegistrarBanda()
{
    Console.Clear();
    do {
    Console.WriteLine("*********************");
    Console.WriteLine("   Registrar banda");
    Console.WriteLine("*********************");
    Console.Write("\n Digite o nome da banda ou aperte Enter para voltar ao menu inicial: ");     
    string nomeBanda = Console.ReadLine()!;
    if (string.IsNullOrEmpty(nomeBanda))
    {
        break;
    }

    if (ListaDeBanda.Contains(nomeBanda))
    {

        Console.WriteLine($"\n Banda {nomeBanda} já existe!");

    } else {
    ListaDeBanda.Add(nomeBanda);
    Console.Write($"\n Banda {nomeBanda} registrada com sucesso");
    }

    Console.Clear();
    Thread.Sleep(1000);//gera um delay de 1 segundo antes da proxima instrução
    Console.Write("\n\n Deseja registrar outra banda? (S/N): ");
    string resposta = Console.ReadLine();
        Console.Clear();
    if (resposta != "s")
    {   
        break;
    } 
    } while (true);
    OpcoesMenu();
    
};
void ExibirBanda()
{
    Console.Clear();
    Console.WriteLine("*********************");
    Console.WriteLine("   Bandas registradas:");
    Console.WriteLine("*********************");
    foreach(string banda in ListaDeBanda)
    {
        Console.Write("\n" + banda + "\n");
    }
    Thread.Sleep(1000);//gera um delay de 1 segundo antes da proxima instrução
    Console.WriteLine("\n Pressione qualquer tecla para voltar ao menu inicial");
    Console.ReadKey();
    OpcoesMenu();//retorna ao menu de escolha1
    
};
void AvaliarBanda()
{
    Console.WriteLine("*****************");

    Console.WriteLine("*****************");
}
void OpcoesMenu()
{
    Logo();
    Console.WriteLine("\nBem vinco ao ScreenSound, utilize o teclado para navegar no menu.");

    Console.WriteLine("1 - Incluir novo registro");
    Console.WriteLine("2 - Exibir todos registros");  
    Console.WriteLine("3 - Avaliar um registro");
    Console.WriteLine("4 - Sair");

    string opcao = Console.ReadLine();
    int opcaoNumero = int.Parse(opcao);
    if (!String.IsNullOrEmpty(opcao)){
        switch(opcaoNumero)
        {
            case 1: RegistrarBanda(); 
                break;
            case 2: ExibirBanda();
                break;
            case 3: AvaliarBanda();
                break;
            case 4: Console.WriteLine(opcaoNumero + ": Encerrando");
                break;
            default: Console.WriteLine("Opcao invalida");
                break;
            
        }          
        
    }
    
}


OpcoesMenu();

