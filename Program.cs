﻿// Sreen Sound

string mensagemDeBoasVindas = "Seja Bem Vindo ao Sreen Sound";

void ExibirLogo()
{   
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine();
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nEscolha uma opção:");
    Console.WriteLine("Digite 1 - Registrar uma Banda");
    Console.WriteLine("Digite 2 - Listar Bandas");
    Console.WriteLine("Digite 3 - Avaliar uma Banda");
    Console.WriteLine("Digite 4 - Média de Avaliação de uma Banda");
    Console.WriteLine("Digite -1 - Sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    
    switch (opcaoEscolhidaNumerica){
        case 1: RegistrarBanda() ;
            break;
        case 2: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica) ;
            break;
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica) ;
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica) ;
            break;
        case -1: Console.WriteLine("Até logo!") ;
            break;
        default: Console.WriteLine("Opção Inválida");
            break;
    }
}

void RegistrarBanda(){
    Console.Clear();
    Console.WriteLine( "Registro de Banda");
    Console.WriteLine( "Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirLogo();
ExibirOpcoesDoMenu();
