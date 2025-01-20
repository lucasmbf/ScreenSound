
using System.Runtime.InteropServices;



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

void OpcoesMenu()

{
    
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
            case 1: Console.WriteLine("Opcao escolhida: " + opcaoNumero); 
                break;
            case 2: Console.WriteLine("Opcao escolhida: " + opcaoNumero);
                break;
            case 3: Console.WriteLine("Opcao escolhida: " + opcaoNumero);
                break;
            case 4: Console.WriteLine(opcaoNumero + ": Encerrando");
                break;
            default: Console.WriteLine("Opcao invalida");
                break;
            
        }          
        
    }
    
}


Logo();
OpcoesMenu();

