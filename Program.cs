/*

Objetivo do Programa: Desenvolver um programa de venda de passagens aéreas.
Autores do Programa: Vinicius Mello, Vitor Emanuel, Yago Henrique.
Data de construção: 22/05/2023  
Última atualização: 11/06/2023

*/

//////Declaração de variaveis

int mais_cadastro_Voo = 0, mais_cadastro_Passa = 0;
double[][] voos = new double[100][];
string[][] passageiros = new string[100][];

int countVoos = 0, countPassageiros = 0;
bool sair = false;

//Parte Yago Henrique

static void printMenuInicial()
{
    Console.WriteLine("****************************");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("      Menu inicial");
    Console.ResetColor();
    Console.WriteLine("1) Para opções ver");
    Console.WriteLine("2) Para opções alterar");
    Console.WriteLine("3) Para opções excluir");
    Console.WriteLine("4) Para opções Cadastrar");
    Console.WriteLine("5) Para Inserir passageiro em um voo");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("6) Para Sair");
    Console.ResetColor();
    Console.Write("\nEscreva sua opção: ");
}

//Parte Vinicius Mello

void verVoos()
{
    //Aba para ver os vôos //

    Console.WriteLine("Menu de opções:\n\n1)Ver todos os voos\n2)Voos com mais passageiros\n3)Voos com menos passageiros\n4)Voos com maior distância\n5)Voos com menor distÂncia\n6)Ocupação média dos voos.");
    int num = int.Parse(Console.ReadLine());

    if (num == 1)
    {
        Console.WriteLine("\nLista de todos os {0} voos:\n", countVoos);
        for (int i = 0; i < countVoos; i++)
        {
            Console.WriteLine("****************");
            Console.WriteLine("Codigo do voo: " + voos[i][0]);
            Console.WriteLine("Distancia a ser percorrida: " + voos[i][1] + " KMs");
            Console.WriteLine("Total de passageiros: " + voos[i][3]);
            Console.WriteLine("Assentos disponiveis: " + (voos[i][2] - voos[i][3]));
        }
    }
    else if (num == 2)
    {
        double[][] vetor_mais_passageiros = new double[100][];
        vetor_mais_passageiros = voos;
        /*Foi utilizado o método de ordenação Bubblee Sort afim de ordenar os voos e passageiros de acordo com as solicitações do usuário. Esse método consiste em avaliar duas posições de um vetor e substituir uma pela outra. O método armazena um valor dentro de uma variável reserva quando for fazer a troca de posições. Com um laço de repetição for, essa comparação é realizada por todo vetor. E no final, temos o vetor ordenado de acordo com a solicitação do usuário. */
        for (int i = 0; i < countVoos - 1; i++)
        {
            for (int j = i + 1; j < countVoos; j++)
            {
                if (vetor_mais_passageiros[i][3] < vetor_mais_passageiros[j][3])
                {
                    double[] reserva = vetor_mais_passageiros[i];
                    vetor_mais_passageiros[i] = vetor_mais_passageiros[j];
                    vetor_mais_passageiros[j] = reserva;
                }
            }
        }
        if (countVoos % 2 == 0)
        {
            Console.WriteLine("\nLista de todos os {0} voos ordenados por mais passageiros:\n", countVoos / 2);
            for (int i = 0; i < countVoos / 2; i++)
            {
                Console.WriteLine("****************");
                Console.WriteLine("Codigo do voo: " + vetor_mais_passageiros[i][0]);
                Console.WriteLine("Distancia a ser percorrida: " + vetor_mais_passageiros[i][1] + " KMs");
                Console.WriteLine("Assentos disponiveis: " + (vetor_mais_passageiros[i][2] - vetor_mais_passageiros[i][3]));
                Console.WriteLine("Quatidade de passageiros: " + vetor_mais_passageiros[i][3]);
            }
        }
        else
        {
            Console.WriteLine("\nLista de todos os {0} voos ordenados por mais passageiros:\n", countVoos + 1 / 2);
            for (int i = 0; i < countVoos + 1 / 2; i++)
            {
                Console.WriteLine("****************");
                Console.WriteLine("Codigo do voo: " + vetor_mais_passageiros[i][0]);
                Console.WriteLine("Distancia a ser percorrida: " + vetor_mais_passageiros[i][1] + " KMs");
                Console.WriteLine("Assentos disponiveis: " + (vetor_mais_passageiros[i][2] - vetor_mais_passageiros[i][3]));
                Console.WriteLine("Quatidade de passageiros: " + vetor_mais_passageiros[i][3]);
            }
        }
    }


    else if (num == 3)
    {
        double[][] vetor_mais_passageiros = new double[100][];
        vetor_mais_passageiros = voos;

        for (int i = 0; i < countVoos - 1; i++)
        {
            for (int j = i + 1; j < countVoos; j++)
            {
                if (vetor_mais_passageiros[i][3] > vetor_mais_passageiros[j][3])
                {
                    double[] reserva = vetor_mais_passageiros[i];
                    vetor_mais_passageiros[i] = vetor_mais_passageiros[j];
                    vetor_mais_passageiros[j] = reserva;
                }
            }
        }
        if (countVoos % 2 == 0)
        {
            Console.WriteLine("\nLista de todos os {0} voos ordenados por menos passageiros:\n", countVoos / 2);
            for (int i = 0; i < countVoos / 2; i++)
            {
                Console.WriteLine("****************");
                Console.WriteLine("Codigo do voo: " + vetor_mais_passageiros[i][0]);
                Console.WriteLine("Distancia a ser percorrida: " + vetor_mais_passageiros[i][1] + " KMs");
                Console.WriteLine("Assentos disponiveis: " + (vetor_mais_passageiros[i][2] - vetor_mais_passageiros[i][3]));
                Console.WriteLine("Quatidade de passageiros: " + vetor_mais_passageiros[i][3]);
            }
        }
        else
        {
            Console.WriteLine("\nLista de todos os {0} voos ordenados por mais passageiros:\n", countVoos + 1 / 2);
            for (int i = 0; i < countVoos + 1 / 2; i++)
            {
                Console.WriteLine("****************");
                Console.WriteLine("Codigo do voo: " + vetor_mais_passageiros[i][0]);
                Console.WriteLine("Distancia a ser percorrida: " + vetor_mais_passageiros[i][1] + " KMs");
                Console.WriteLine("Assentos disponiveis: " + (vetor_mais_passageiros[i][2] - vetor_mais_passageiros[i][3]));
                Console.WriteLine("Quatidade de passageiros: " + vetor_mais_passageiros[i][3]);
            }
        }
    }
    else if (num == 4)
    {
        double[][] vetor_mais_distancia = new double[100][];
        vetor_mais_distancia = voos;

        for (int i = 0; i < countVoos - 1; i++)
        {
            for (int j = i + 1; j < countVoos; j++)
            {
                if (vetor_mais_distancia[i][1] < vetor_mais_distancia[j][1])
                {
                    double[] reserva = vetor_mais_distancia[i];
                    vetor_mais_distancia[i] = vetor_mais_distancia[j];
                    vetor_mais_distancia[j] = reserva;
                }
            }
        }
        if (countVoos % 2 == 0)
        {
            Console.WriteLine("\nLista de todos os {0} voos ordenados por maior distancia:\n", countVoos / 2);
            for (int i = 0; i < countVoos / 2; i++)
            {
                Console.WriteLine("****************");
                Console.WriteLine("Codigo do voo: " + vetor_mais_distancia[i][0]);
                Console.WriteLine("Distancia a ser percorrida: " + vetor_mais_distancia[i][1] + " KMs");
                Console.WriteLine("Assentos disponiveis: " + (vetor_mais_distancia[i][2] - vetor_mais_distancia[i][3]));
                Console.WriteLine("Quatidade de passageiros: " + vetor_mais_distancia[i][3]);
            }
        }
        else
        {
            Console.WriteLine("\nLista de todos os {0} voos ordenados por mais distancia:\n", countVoos + 1 / 2);
            for (int i = 0; i < countVoos + 1 / 2; i++)
            {
                Console.WriteLine("****************");
                Console.WriteLine("Codigo do voo: " + vetor_mais_distancia[i][0]);
                Console.WriteLine("Distancia a ser percorrida: " + vetor_mais_distancia[i][1] + " KMs");
                Console.WriteLine("Assentos disponiveis: " + (vetor_mais_distancia[i][2] - vetor_mais_distancia[i][3]));
                Console.WriteLine("Quatidade de passageiros: " + vetor_mais_distancia[i][3]);
            }
        }
    }
    else if (num == 5)
    {
        double[][] vetor_mais_distancia = new double[100][];
        vetor_mais_distancia = voos;

        for (int i = 0; i < countVoos - 1; i++)
        {
            for (int j = i + 1; j < countVoos; j++)
            {
                if (vetor_mais_distancia[i][1] > vetor_mais_distancia[j][1])
                {
                    double[] reserva = vetor_mais_distancia[i];
                    vetor_mais_distancia[i] = vetor_mais_distancia[j];
                    vetor_mais_distancia[j] = reserva;
                }
            }
        }
        if (countVoos % 2 == 0)
        {
            Console.WriteLine("\nLista de todos os {0} voos ordenados por menor distancia:\n", countVoos / 2);
            for (int i = 0; i < countVoos / 2; i++)
            {
                Console.WriteLine("****************");
                Console.WriteLine("Codigo do voo: " + vetor_mais_distancia[i][0]);
                Console.WriteLine("Distancia a ser percorrida: " + vetor_mais_distancia[i][1] + " KMs");
                Console.WriteLine("Assentos disponiveis: " + (vetor_mais_distancia[i][2] - vetor_mais_distancia[i][3]));
                Console.WriteLine("Quatidade de passageiros: " + vetor_mais_distancia[i][3]);
            }
        }
        else
        {
            Console.WriteLine("\nLista de todos os {0} voos ordenados por menor distancia:\n", countVoos + 1 / 2);
            for (int i = 0; i < countVoos + 1 / 2; i++)
            {
                Console.WriteLine("****************");
                Console.WriteLine("Codigo do voo: " + vetor_mais_distancia[i][0]);
                Console.WriteLine("Distancia a ser percorrida: " + vetor_mais_distancia[i][1] + " KMs");
                Console.WriteLine("Assentos disponiveis: " + (vetor_mais_distancia[i][2] - vetor_mais_distancia[i][3]));
                Console.WriteLine("Quatidade de passageiros: " + vetor_mais_distancia[i][3]);
            }
        }
    }
    else if (num == 6)
    {
        double mediaOcupacao = 0;
        for (int i = 0; i < countVoos; i++)
        {
            mediaOcupacao += voos[i][2] - voos[i][3];
        }
        mediaOcupacao /= countVoos;
        Console.WriteLine("****************************");
        Console.WriteLine("A media de ocupação é: {0} passageiros", mediaOcupacao);
    }
    else
    {
        Console.WriteLine("Código Inválido. Digite um válido.");
    }
}


void verPassageiros()
{
    Console.WriteLine("1) Ver passageiro especifico\n2) ver todos os passageiros a partir do voo");
    Console.Write("Escolha sua opção: ");
    int opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Console.Write("Informe o codigo do passageiro: ");
            string codigo = Console.ReadLine();
            string passageiro = "";
            for (int i = 0; i < countPassageiros; i++)
            {
                if (codigo == passageiros[i][0])
                {
                    passageiro = passageiros[i][1];
                }
            }

            if (passageiro == "")
            {
                Console.WriteLine("O passageiro de codigo: {0} não foi encontrado no sistema", codigo);
            }
            else
            {
                Console.WriteLine("O passageiro de codigo: {0} tem o nome de: {1}", codigo, passageiro);
            }

            break;
        case 2:
            Console.Write("Informe o codigo do voo: ");
            double codigoVoo = double.Parse(Console.ReadLine());
            for (int i = 0; i < countVoos; i++)
            {
                if (codigoVoo == voos[i][0])
                {
                    for (int j = 0; j < voos[i][3]; j++)
                    {
                        Console.WriteLine("****************************");
                        Console.WriteLine("Passageiro {0} do voo de codigo {1}", j + 1, codigoVoo);
                        Console.WriteLine("CODIGO PASSAGEIRO: " + voos[i][j + 4]);
                        for (int x = 0; x < countPassageiros; x++)
                        {
                            if (voos[i][j + 4] == double.Parse(passageiros[x][0]))
                            {
                                Console.WriteLine("NOME PASSAGEIRO: " + passageiros[x][1]);

                            }
                        }
                    }
                }
            }
            break;
        default:
            Console.WriteLine("OPÇÃO INVALIDA");
            break;
    }
}


//Cadastro de informações sobre os vôos

/*Metódo para cadastro de vôos. Esse metódo é chamado sempre que o usuário solicitar um novo cadastro de vôos através do menu de opções.*/

void cadastraVoo()
{
    Console.WriteLine("Cadastro de vôo:\n");

    double[] novoVoo = new double[100];

    /*Algoritmo responsável pela avaliação do código do vôo. Afim de não permitir código já cadastrado. Foi usado um laço de repetição while com várivel booleana afim de identificar códigos já existentes e não permitir códigos iguais/repetidos dos vôos*/

    double codigoNovo = 0;
    bool existe = true;

    while (existe == true)

    {            //Solicitador do código do vôo
        Console.WriteLine("Digite o código do voo:");
        codigoNovo = double.Parse(Console.ReadLine());
        int cont_j = 0;
        for (int i = 0; i < countVoos; i++)
        {
            if (codigoNovo == voos[i][0])
            {    //Informa que código já existe e solicita outro.
                Console.WriteLine("O código informado já existe, digite outro");
                existe = true;
                cont_j++;
            }
        }
        if (cont_j == 0)
        {
            existe = false;
        }
    }

    novoVoo[0] = codigoNovo;

    //cadastramento da quilometragem percorrida

    Console.Write("Digite a quantidade em quilômetros que será percorrida pelo avião:\n");
    novoVoo[1] = double.Parse(Console.ReadLine());

    //cadastramento da quantidade de assentos disponíveis

    Console.Write("Digite a quantidade de assentos disponívies no avião.\n");

    novoVoo[2] = double.Parse(Console.ReadLine());
    novoVoo[3] = 0;
    voos[countVoos] = novoVoo;
    countVoos += 1;

}

/*Metódo para cadastro de passageiros. Esse metódo é chamado sempre que o usuário solicitar um novo cadastro de passageiros através do menu de opções.*/

void cadastraPassageiros()
{
    string[] novoPassageiro = new string[2];

    Console.WriteLine("Cadastro de passageiros.\n");

    /*Algoritmo responsável pela avaliação do código do Passageiros. Afim de não permitir código já cadastrado. Foi usado um laço de repetição while com várivel booleana afim de identificar códigos já existentes e não permitir códigos de passageiros iguais/repetidos.*/

    string codigo_Passageiro = "";
    bool existe = true;

    while (existe == true)

    {

        Console.WriteLine("Digite o código do passageiro:");
        codigo_Passageiro = Console.ReadLine();
        int contador_j = 0;
        for (int i = 0; i < countPassageiros; i++)
        {
            if (codigo_Passageiro == passageiros[i][0])

            //Informa que código já existe e solicita outro.
            {
                Console.WriteLine("O código do passageiro informado já existe, digite outro");
                existe = true;
                contador_j++;
            }
        }
        if (contador_j == 0)
        {
            existe = false;
        }
    }

    //cadastro nome do passageiro

    Console.Write("Digite o nome do passageiro: ");
    novoPassageiro[1] = Console.ReadLine();
    novoPassageiro[0] = codigo_Passageiro;
    passageiros[countPassageiros] = novoPassageiro;
    countPassageiros += 1;
}


//Parte Vitor Emanuel

//Metódo para inserir passageiros no voo.
void inserirPassageiroVoo()
{
    string codPassInserir = "";
    double codigoVooInserir = 0;
    int posVooInserir = 0;

    // Loop para obter o código do passageiro a ser inserido.
    while (true)
    {
        int contadorDeEntradas = 0;
        Console.Write("Informe o codigo do passageiro que deseja inserir em um voo: ");
        codPassInserir = Console.ReadLine();

        // Verifica se o código do passageiro é válido.
        for (int i = 0; i < countPassageiros; i++)
        {
            if (codPassInserir == passageiros[i][0])
            {
                contadorDeEntradas++;
            }
        }

        // Se o código do passageiro for inválido, exibe uma mensagem de codigo invalido.
        if (contadorDeEntradas == 0)
        {
            Console.WriteLine("CODIGO INVALIDO!");
        }
        else
        {
            break;
        }
    }

    // Loop para obter o código do voo onde o passageiro será inserido.
    while (true)
    {
        int contadorDeEntradas = 0;
        Console.Write("Informe o codigo do voo que deseja inserir o passageiro: ");
        codigoVooInserir = double.Parse(Console.ReadLine());

        // Verifica se o código do voo é válido
        for (int i = 0; i < countVoos; i++)
        {
            if (codigoVooInserir == voos[i][0])
            {
                contadorDeEntradas++;
                posVooInserir = i;
            }
        }

        // Se o código do voo for inválido, exibe uma mensagem de codigo invalido.
        if (contadorDeEntradas == 0)
        {
            Console.WriteLine("CODIGO INVALIDO!");
        }
        else
        {
            break;
        }
    }

    // Loop para verificar se o passageiro já existe no voo
    while (true)
    {
        int contadorDeEntradas = 0;

        // Verifica cada passageiro no voo atual
        for (int i = Convert.ToInt16(voos[posVooInserir][3]); i < voos[posVooInserir][3] + 4; i++)
        {
            if (voos[posVooInserir][i] == double.Parse(codPassInserir))
            {
                contadorDeEntradas++;
            }
        }

        // Se o passageiro já existe no voo, pede um novo código de passageiro ate um que nao exista.
        if (contadorDeEntradas == 0)
        {
            break;
        }
        else
        {
            Console.Write("Codigo do passageiro já existe no voo!\nDigite outro codigo para inserir nesse voo: ");
            codPassInserir = Console.ReadLine();
        }
    }

    // Insere o passageiro no voo
    int totalPassageirosVooInserir = Convert.ToInt16(voos[posVooInserir][3]);
    voos[posVooInserir][totalPassageirosVooInserir + 4] = double.Parse(codPassInserir);
    voos[posVooInserir][3] += 1;

}


// Metodo criado para excluir um passageiro do sistema e dos voos que ele esta.
void excluirPassageiro()
{
    int posPassExcluido = 0;
    string codigoPassExcluir = "";

    // Loop para obter o código do passageiro a ser excluído
    while (true)
    {
        int contadorDeEntradas = 0;
        Console.Write("Digite o codigo do passageiro que deseja excluir: ");
        codigoPassExcluir = Console.ReadLine();

        // Verifica se o código do passageiro existe no sistema       
        for (int i = 0; i < countPassageiros; i++)
        {
            if (passageiros[i][0] == codigoPassExcluir)
            {
                contadorDeEntradas++;
                posPassExcluido = i;
            }
        }

        // Se o código do passageiro não for encontrado, exibe uma mensagem de passageiro nao encontrado(ERRO)
        if (contadorDeEntradas == 0)
        {
            Console.WriteLine("PASSAGEIRO NÃO ENCONTRADO!!");
        }
        else
        {
            break;
        }
    }

    // Remove o passageiro do sistema
    passageiros[posPassExcluido] = default;

    countPassageiros--;

    // Reposiciona os outros passageiros no vetor após a exclusão do passageiro.
    for (int i = posPassExcluido; i < countPassageiros - 1; i++)
    {
        passageiros[i] = passageiros[i + 1];
    }

    // Remove o passageiro dos voos em que ele estava presente

  
    int posPassExcluidoVoo = 0;
    int totalPassageirosVoo = 0;

    // Itera sobre todos os voos para encontrar o passageiro e removê-lo
    for (int i = 0; i < countVoos; i++)
    {
        totalPassageirosVoo = Convert.ToInt16(voos[i][3]);

        // Verifica se o passageiro está presente no voo atual
        for (int j = 4; j < totalPassageirosVoo + 4; j++)
        {
            if (voos[i][j] == double.Parse(codigoPassExcluir))
            {
                posPassExcluidoVoo = j;
                voos[i][j] = default;
                voos[i][3] -= 1;
                posPassExcluidoVoo = j;
            }
        }

        // Reposiciona os outros passageiros no voo após a exclusão do passageiro selecionado.
        for (int j = posPassExcluidoVoo; j < totalPassageirosVoo + 3; j++)
        {
            voos[i][j] = voos[i][j + 1];
        }
    }
}

// Metodo para fazer alterações nos voos.
void alterarVoo()
{
    Console.WriteLine("*****************************");
    Console.WriteLine("MENU ALTERAR VOO:\n1) Alterar codigo\n2) Alterar distância\n3) ALterar assentos disponiveis");
    Console.Write("Informe sua opção:");
    string codigoAlterarVoo = Console.ReadLine();

    switch (codigoAlterarVoo)
    {
        case "1":
            {
                // Alterar o código do voo 
                int posVooAlterado = 0;
                while (true)
                {
                    // Pede o código do voo a ser alterado e confere se o voo existe no sistema
                    Console.Write("Informe o codigo do voo que deseja alterar: ");
                    double codigoVoo = double.Parse(Console.ReadLine());
                    int contadorDeEntradas = 0;
                    for (int i = 0; i < countVoos; i++)
                    {
                        if (voos[i][0] == codigoVoo)
                        {
                            posVooAlterado = i;
                            contadorDeEntradas++;
                        }
                    }
                    if (contadorDeEntradas != 0)
                    {

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Codigo não existe no sistema!");
                    }
                }
                while (true)
                {
                    // Solicita o novo código para o voo
                    Console.Write("Informe o codigo novo: ");
                    double codigoNovo = double.Parse(Console.ReadLine());
                    int contadorDeEntradas = 0;
                    for (int i = 0; i < countVoos; i++)
                    {
                        if (voos[i][0] == codigoNovo)
                        {
                            contadorDeEntradas++;
                        }
                    }
                    if (contadorDeEntradas == 0)
                    {
                        // Atualiza o código do voo
                        voos[posVooAlterado][0] = codigoNovo;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Codigo já existe no sistema!");
                    }
                }
                break;
            }
        case "2":
            {
                // Alterar a distância do voo
                int posVooAlterado = 0;
                while (true)
                {
                    // Solicita o código do voo a ser alterado
                    Console.Write("Informe o codigo do voo que deseja alterar: ");
                    double codigoVoo = double.Parse(Console.ReadLine());
                    int contadorDeEntradas = 0;
                    // confere se o voo existe no sistema
                    for (int i = 0; i < countVoos; i++)
                    {
                        if (voos[i][0] == codigoVoo)
                        {
                            posVooAlterado = i;
                            contadorDeEntradas++;
                        }
                    }
                    if (contadorDeEntradas != 0)
                    {

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Codigo não existe no sistema!");
                    }
                }
                //Pede a nova distancia do voo

                Console.Write($"Distacia antiga: {voos[posVooAlterado][1]}\nInforme a distancia do voo nova: ");
                double distanciaAntiga = voos[posVooAlterado][1];
                double distanciaNova = double.Parse(Console.ReadLine());
                voos[posVooAlterado][1] = distanciaNova;
                Console.WriteLine($"Distancia alterada de {distanciaAntiga} para {voos[posVooAlterado][1]}");
                break;
            }
        case "3":
            {
                // Alterar a disponibilidade de assentos do voo
                int posVooAlterado = 0;
                while (true)
                {
                    // Solicita o código do voo a ser alterado
                    Console.Write("Informe o codigo do voo que deseja alterar: ");
                    double codigoVoo = double.Parse(Console.ReadLine());
                    int contadorDeEntradas = 0;
                    // Confere se o voo existe no sistema
                    for (int i = 0; i < countVoos; i++)
                    {
                        if (voos[i][0] == codigoVoo)
                        {
                            posVooAlterado = i;
                            contadorDeEntradas++;
                        }
                    }
                    if (contadorDeEntradas != 0)
                    {

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Codigo não existe no sistema!");
                    }
                }
                // pede a nova disponibilidade do voo 
                Console.Write($"Disponibilidade de assentos antiga: {voos[posVooAlterado][2]}\nInforme a disponibilidade do voo nova: ");
                double assentosAntigos = voos[posVooAlterado][2];
                double assentosNovo = double.Parse(Console.ReadLine());
                voos[posVooAlterado][2] = assentosNovo;
                Console.WriteLine($"Distancia alterada de {assentosAntigos} para {voos[posVooAlterado][2]}");

                break;
            }
        // Mensagem de erro caso o codido digitado não esteja entre 1 e 3
        default:
            Console.WriteLine("CODIGO INVALIDO!");
            break;
    }
}

void excluirVoo()
{
    bool existeVoo = false;
    do
    {
        double vooExcluido;

        Console.Write("Digite o codigo do voo que voce deseja excluir: ");
        vooExcluido = double.Parse(Console.ReadLine());

        // Percorre todos os voos existentes
        for (int i = 0; i < countVoos; i++)
        {
            // Verifica se o código do voo fornecido pelo usuário corresponde a um voo existente
            if (voos[i][0] == vooExcluido)
            {
                existeVoo = true; // Marca que o voo existe
                vooExcluido = voos[i][0];
                voos[i] = default; // Remove o voo atribuindo o valor default para a posição dele.
                Console.WriteLine("Voo {0} excluido", vooExcluido);

                // Reorganiza os voos restantes no vetor
                for (int j = i; j < countVoos; j++)
                {
                    voos[j] = voos[j + 1];
                }
                countVoos--; // diminui em 1 o contador de voos
            }

        }
    } while (existeVoo == false); // Repete o loop enquanto o voo não existir no sistema
}

void alterarpassageiro()
{
    string altPassageiro;
    string codOuNome;
    int contadorNaoEntrado;

    Console.Write("Digite o ID do passageiro que deseja alterar: ");
    altPassageiro = Console.ReadLine();

    bool passageiroEncontrado = false;

    do
    {
        contadorNaoEntrado = 0;
        for (int i = 0; i < countPassageiros; i++)
        {
            // Verifica se o ID do passageiro fornecido pelo usuário corresponde a um passageiro existente
            if (altPassageiro == passageiros[i][0])
            {
                passageiroEncontrado = true;
                Console.Write("\nO que você deseja alterar: código(1) ou nome(2)? ");
                codOuNome = Console.ReadLine();
                // pergunta o que deseja alterar para começar a alteração
                if (codOuNome == "1")
                {
                    string codNovo = "";

                    while (true)
                    {
                        // Pede o novo codigo para alterar
                        int contadorDeEntradas = 0;
                        Console.Write("Informe o novo código do passageiro: ");
                        codNovo = Console.ReadLine();

                        // Verifica se o novo código já existe no sistema                       
                        for (int j = 0; j < countPassageiros; j++)
                        {
                            if (passageiros[j][0] == codNovo)
                            {
                                contadorDeEntradas++;
                            }
                        }
                        if (contadorDeEntradas == 0)
                        {
                            break;
                        }
                        else
                        {   // verifica se o novo codigo existe no sistema
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Codigo ja existe no sistema");
                            Console.ResetColor();
                        }
                    }

                    // por fim altera o codigo do passageiro
                    passageiros[i][0] = codNovo;
                    Console.WriteLine($"Codigo do passageiro alterado para: {passageiros[i][0]}");
                }
                // seleção para trocar o nome do passageiro
                else if (codOuNome == "2")
                {
                    // Pede o novo nome do passageiro
                    Console.WriteLine("Nome antigo: {0}", passageiros[i][1]);
                    Console.Write("Informe o novo nome do passageiro: ");
                    passageiros[i][1] = Console.ReadLine();
                    Console.WriteLine("Nome alterardo para: {0}", passageiros[i][1]);
                }
            }
            else
            {
                contadorNaoEntrado++;
            }
        }

        // verifica se o nome antigo existe no sistema para ser alterado.
        if (passageiroEncontrado == false)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Passageiro não encontrado.\t");
            Console.ResetColor();
            Console.Write("Digite o ID do passageiro que deseja alterar: ");
            altPassageiro = Console.ReadLine();
        }

    } while (!passageiroEncontrado);

}

//Programa Main
while (sair != true)
{

    printMenuInicial();
    int escolha = int.Parse(Console.ReadLine());
    switch (escolha)
    {
        case 1:
            Console.WriteLine("Escolha foi " + escolha);
            Console.WriteLine("Opções ver:\n1) Voos \n2) Passageiros");
            Console.Write("Escolha sua opção: ");
            escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    verVoos();
                    break;
                case 2:
                    verPassageiros();
                    break;
            }

            break;
        case 2:
            Console.WriteLine("Escolha foi " + escolha);
            Console.WriteLine("Opções alterar:\n1) Voos \n2) Passageiros");
            Console.Write("Escolha sua opção: ");
            escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    alterarVoo();
                    break;
                case 2:
                    alterarpassageiro();
                    break;
            }
            break;
        case 3:
            Console.WriteLine("Escolha foi " + escolha);
            Console.WriteLine("Opções excluir:\n1) Voos \n2) Passageiros");
            Console.Write("Escolha sua opção: ");
            escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    excluirVoo();
                    break;
                case 2:
                    excluirPassageiro();
                    break;
            }
            break;
        case 4:
            Console.WriteLine("Voce deseja cadastrar\n1) voos\n2) Passageiros ");
            Console.Write("Informe sua opção: ");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    //Chama o metódo de cadastro de vôo

                    cadastraVoo();
                    //Menu para perguntar se deseja cadastrar mais vôos 

                    Console.WriteLine("Você deseja cadastrar mais vôos?\n1)Sim\n2)Não\n");
                    mais_cadastro_Voo = int.Parse(Console.ReadLine());

                    //Opção que chama novamente o metódo de cadastro de vôos

                    if (mais_cadastro_Voo == 1)
                    {
                        cadastraVoo();
                    }

                    //Opção que chama o método cadastro de passageiros

                    else if (mais_cadastro_Voo == 2)
                    {
                        break;
                    }

                    //Checa se código é inválido e solicita ao usuário um novo código.

                    else
                    {
                        Console.WriteLine("Opção Inválida. Digite uma válida.");
                        mais_cadastro_Passa = int.Parse(Console.ReadLine());
                    }
                    break;
                case 2:
                    cadastraPassageiros();
                    Console.WriteLine("Voce deseja cadastrar mais passageiros? \n1) sim \n2) não");
                    mais_cadastro_Passa = int.Parse(Console.ReadLine());
                    //chama o metódo de cadastro de passageiro novamente.

                    if (mais_cadastro_Passa == 1)
                    {
                        cadastraPassageiros();

                    }
                    //Vai para o próximo menu de opções do aeroporto.

                    else if (mais_cadastro_Passa == 2)
                    {
                        break;
                    }

                    //Volta ao cadastro de vôos

                    else if (mais_cadastro_Passa == 3)
                    {
                        cadastraVoo();
                    }

                    //Checa se código é inválido e solicita ao usuário um novo código.

                    else
                    {
                        Console.WriteLine("Código Inválido. Digite um válido.");
                        mais_cadastro_Passa = int.Parse(Console.ReadLine());
                    }
                    break;

            }

            break;

        case 5:
            inserirPassageiroVoo();
            break;
        case 6:
            Console.WriteLine("Escolha foi sair");
            sair = true;
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("OPÇÃO INVALIDA!");
            Console.ResetColor();
            break;

    }
}