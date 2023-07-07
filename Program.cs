// Sreen Sound

string mensagemDeBoasVindas = "Seja Bem Vindo ao Sreen Sound";
// List<string> listaDasBandas = new List<string> {"U2","The Beatles", "Calypso"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("U2", new List<int>{10, 9, 8, 7, 6});
bandasRegistradas.Add("The Beatles", new List<int>());

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
        case 2: MostrarBandasRegistradas() ;
            break;
        case 3: AvaliarBanda() ;
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
    ExibirTituloDaOpcao("Registro de Bandas");
    Console.WriteLine( "Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas(){
    Console.Clear();
    ExibirTituloDaOpcao("Bandas Registradas");

    // for (int i = 0; i< listaDasBandas.Count; i++){
    //    Console.WriteLine($"Banda: {listaDasBandas[i]} ");
    //}
    
    foreach(string banda in bandasRegistradas.Keys){
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo){
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarBanda(){
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Bandas");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Digite a nota que deseja dar para a banda {nomeDaBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA banda {nomeDaBanda} foi avaliada com sucesso com a nota {nota}!");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    } else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
}

void MediaDasBandas(){
    Console.Clear();
    ExibirTituloDaOpcao("Média das Bandas");
    Console.Write("Qual a banda você deseja consultar a média das notas? : ");
    string nomeDaBanda = Console.ReadLine()!;
    
}


ExibirOpcoesDoMenu();
