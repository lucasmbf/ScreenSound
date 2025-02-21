
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
    Console.WriteLine("*********************\n");
    Console.Write("Digite o nome da banda ou aperte Enter para voltar ao menu inicial: ");     
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
    Console.Write($"\n Banda **{nomeBanda}** registrada com sucesso");
    }

    
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
    Console.WriteLine("************************");
    Console.WriteLine("   Bandas registradas:");
    Console.WriteLine("************************\n");
    /*foreach(string banda in ListaDeBanda)
    {
        Console.Write("\n" + banda + "\n");
    }*/
    if (ListaDeBanda.Count == 0)
    {
        Console.WriteLine("Nenhuma banda foi cadastrada ainda \n");
        Thread.Sleep(2000);
        OpcoesMenu();
    }
    for (int i = 0; i < ListaDeBanda.Count; i++) 
    {
        Console.WriteLine($"\n {i + 1} - {ListaDeBanda[i]}");
    }
    Thread.Sleep(1000);//gera um delay de 1 segundo antes da proxima instrução
    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu inicial");
    Console.ReadKey();
    OpcoesMenu();//retorna ao menu de escolha
    
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

