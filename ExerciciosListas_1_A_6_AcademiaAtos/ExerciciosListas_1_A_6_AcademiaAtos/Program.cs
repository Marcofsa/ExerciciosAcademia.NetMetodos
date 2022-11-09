using System.Globalization;
using System.Security.Cryptography;
using System.Transactions;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    class Program
    {
        //LISTA 1<<<<<<<<<<
        // QUESTÃO 1


        //static void Main(string[] args)
        //  {
        // Calcular a média entre quatro números;

        //int nt1, nt2, nt3, nt4;
        //float media, soma;

        // Entrada;

        //Console.WriteLine("Vamos calcular a media\n");
        //Console.WriteLine(" ");

        // Coleta de valores;

        //Console.Write("Digite o primeiro valor: ");
        //nt1 = int.Parse(Console.ReadLine());

        //Console.Write("Digite o segundo valor: ");
        //nt2 = int.Parse(Console.ReadLine());

        //Console.Write("Digite o terceiro valor: ");
        //nt3 = int.Parse(Console.ReadLine());

        //Console.Write("Digite o quarto valor: ");
        //nt4 = int.Parse(Console.ReadLine());

        //soma = (nt1 + nt2);
        //media = soma / 4;


        //Console.Write(" soma = " + soma);

        // Console.Write(" Media = " + media);

        //Console.ReadKey();

        // }

        //QUESTÃO 2
        //static void Main(string[] args)
        // {
        // Calcular a média entre quatro números;

        //int nt1, nt2, nt3, nt4;
        // float media, soma;

        // Entrada;

        // Console.WriteLine("Vamos calcular a media");
        // Console.WriteLine(" ");

        // Coleta de valores;

        // Console.Write("Digite o primeiro valor: ");
        //  nt1 = int.Parse(Console.ReadLine());

        // Console.Write("Digite o segundo valor: ");
        // nt2 = int.Parse(Console.ReadLine());

        // Console.Write("Digite o terceiro valor: ");
        // nt3 = int.Parse(Console.ReadLine());

        // Console.Write("Digite o quarto valor: ");
        // nt4 = int.Parse(Console.ReadLine());

        // soma = (nt1 + nt2 + nt3 + nt4);
        // media = soma / 4;

        // Console.Write(" soma = " + soma);

        // Console.Write(" Media = " + media);

        // Console.ReadKey();

        // }


        //QUESTÃO 3

        //static void Main(string[] args)
        //{
        // int A = 2;
        // int B = 3;
        // int box1;

        //  box1 = A;
        //  A = B;
        //  B = box1;

        // }

        //QUESTÃO 4

        //static void Main(string[] args)
        //{
        //    string d;
        //    string m;
        //    string a;
        //    string data;

        //    Console.WriteLine("Informe que o dia, mês e ano (AAAAMMDD):");
        //    data = Console.ReadLine();

        //    a = data.Substring(0, 4);
        //    m = data.Substring(4, 2);
        //    d = data.Substring(6);
        //    a.Substring(2);


        //    Console.ReadKey();

        //}

        //QUESTÃO 5

        //static void Main(string[] args)
        //{
        //    float dist, consumoMedio;
        //    double combustivelGasto;
        //    Console.WriteLine("Digite a distância percorrida:")
        //    dist = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Digite o combustível disponível:")
        //    combustivelGasto = Convert.ToDouble(Console.ReadLine());
        //    consumoMedio = dist / combustivelGasto;
        //    Console.WriteLine("{0:0.000} kmL", consumoMedio);

        //}


        //QUESTÃO 6

        //static void Main(string[] args)
        //{

        //    int QuantA, QuantB, soma;
        //    float precoA, precoB, ipi;

        //    Console.WriteLine("Informe a quantidade de parafusos A:");
        //    QuantA = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Informe a quantidade de parafusos B:");
        //    QuantB = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Informe o Valor dos parafusos A:");
        //    precoA = float.Parse(Console.ReadLine());

        //    Console.WriteLine("Informe o valor dos parafusos B");
        //    precoB = float.Parse(Console.ReadLine());



        //}

        // QUESTÃO 7

        //static void Main(string[] args)

        //{

        //    int numeroVendedor;
        //    float salario_fixo, total_vendas;
        //    float comissao;

        //    Console.WriteLine("Numero do vendedor: ");
        //    numeroVendedor = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Salário Fixo....: R$ ");
        //    salario_fixo = float.Parse(Console.ReadLine());

        //    Console.WriteLine("Total de vendas.: R$ ");
        //    total_vendas = float.Parse(Console.ReadLine());

        //    Console.WriteLine("Digite o valor da comissão em %:");
        //    comissao = float.Parse(Console.ReadLine());

        //    salario_fixo = salario_fixo + (total_vendas * (comissao / 100));

        //    Console.WriteLine("O número do vendedor é:" + numeroVendedor);
        //    Console.WriteLine("Comissão: R$" + salario_fixo);


        //}


        //QUESTÃO 8

        //static void Main(string[] args)
        //{
        //    float c, f, conversao;

        //    Console.WriteLine("Digite a temperatura em graus Fahrenheit:\n");
        //    f = float.Parse(Console.ReadLine());

        //    Console.WriteLine("Digite a temperatura em graus Celsius");
        //    c = float.Parse(Console.ReadLine());

        //    conversao = (f = (9 * c + 160) / 5);

        //    Console.WriteLine("O valor da conversão foi de:\n" + conversao);

        //}




        //QUESTÃO 9

        //static void Main(string[] args)
        //{
        //    float prest1, prest2, ValorM, ValorEnt;


        //    Console.WriteLine("Informe o valor da Mercadoria:");
        //    ValorM = float.Parse(Console.ReadLine());

        //    prest1 = ValorM/3;
        //    prest2 = prest1;
        //    ValorEnt = ValorM - (prest1 + prest2);

        //    Console.WriteLine("O valor de primeira prestação é:\n" + prest1);
        //    Console.WriteLine("O valor da segunda prestação é:\n" + ValorEnt.ToString() + prest1.ToString() + prest2.ToString());


        //}


        //QUESTÃO 10
        //static void Main(string[] args)
        //{

        //    Console.WriteLine("|-----------------------------------------------------------------|");
        //    Console.WriteLine("|              CAIXA ELETRÔNICO | BANCO PETROLINA | Sair ---> 0   |");
        //    Console.WriteLine("|-----------------------------------------------------------------|");

        //    int valor, q50, q10, q5, q1 = 0, resto50, resto10 = 0, resto5 = 0;

        //    Console.WriteLine("Digite o valor de saque:\n");
        //    Console.WriteLine("R$");
        //    valor = int.Parse(Console.ReadLine());

        //    q50 = (valor / 50);
        //    resto50 = (valor - (q50 * 50));
        //    q10 = (resto50 / 10);
        //    resto10 = (valor - (q10 * 10) - (q50 * 50));
        //    q5 = (resto10 / 5);
        //    resto5 = (valor - (q10 * 10) - (q50 * 50) - (q5 * 5));
        //    q1 = (resto5 / 1);

        //    Console.WriteLine("|------------------------------------|");
        //    Console.WriteLine("|>> NOTAS DE R$50,00 << -------------|" + q50);
        //    Console.WriteLine("|>> NOTAS DE R$10,00 << -------------|" + q10);
        //    Console.WriteLine("|>> NOTAS DE R$5,00 << --------------|" + q5);
        //    Console.WriteLine("|>> NOTAS DE R$1,00 << --------------|" + q1);
        //    Console.WriteLine("|------------------------------------|");
        //    Console.WriteLine("\n\n>>|----- SEU DINHEIRO SAIRÁ EM BREVE!!! -----|<<");

        //    Console.ReadKey();
        //    Console.Clear();

        //    }


        //QUESTÃO 11
        //static void Main(string[] args)

        //{
        //    int eleitores, brancos, nulos, validos;
        //    float percBrancos, percNulos, percValidos;

        //    Console.WriteLine("|------------------------------------------------|");
        //    Console.WriteLine("|=================== ELEIÇÃO 2022 ===============|");
        //    Console.WriteLine("|------------------------------------------------|");


        //    Console.WriteLine("Informe o eleitorado:\n");
        //    eleitores = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Informe o número de votos válidos:\n");
        //    validos = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Informe o número de votos brancos:\n");
        //    brancos = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Informe o número de votos nulos:\n");
        //    nulos = int.Parse(Console.ReadLine());

        //    percValidos = (validos / eleitores) * 100;
        //    percBrancos = (brancos / eleitores) * 100;
        //    percNulos = (nulos / eleitores) * 100;

        //    Console.WriteLine(validos + " % de votos válidos. " + percValidos);
        //    Console.WriteLine(brancos + " % de votos brancos. " + percBrancos);
        //    Console.WriteLine(nulos + " % de votos nulos. " + percNulos);

        // }


        //QUESTÃO 12

        //static void Main(string[] args)

        //{
        //    double valorRecebido, combustivelGasto, totalkm, marcadorfinaldia, marcadoriniciodia, mediaConsumo, lucrodia;


        //    Console.WriteLine("Qual a marcação no inicio do dia?\n");
        //    marcadoriniciodia = double.Parse(Console.ReadLine());

        //    Console.WriteLine("Quantos quilometros rodados no dia?\n");
        //    totalkm = double.Parse(Console.ReadLine());

        //    Console.WriteLine("Quantidade de Litros gastos no dia\n?");
        //    combustivelGasto = double.Parse(Console.ReadLine());

        //    Console.WriteLine("Qual foi o lucro total recebido?\n");
        //    lucrodia = double.Parse(Console.ReadLine());

        //    Console.WriteLine("Qual foi o valor recebido?\n");
        //    valorRecebido = double.Parse(Console.ReadLine());

        //    Console.WriteLine("Marcador no final do dia?\n");
        //    marcadorfinaldia = double.Parse(Console.ReadLine());

        //    Console.WriteLine("Qual a média de consumo?\n");
        //    mediaConsumo = double.Parse(Console.ReadLine());

        //    totalkm = marcadorfinaldia - marcadoriniciodia;
        //    mediaConsumo = totalkm / combustivelGasto;
        //    lucrodia = valorRecebido - (combustivelGasto * 6.90);

        //    Console.WriteLine(totalkm + "<-- Foi a quilometragem total!\n");
        //    Console.WriteLine(mediaConsumo + "<-- Foi a media de consumo total!\n");
        //    Console.WriteLine(lucrodia + "<-- Foi o lucro do dia!\n");


        //}


        //////QUESTÃO 13

        ////static void Main(string[] args)

        ////{

        ////}

        //----------------------- LISTA 2 ----------------------------//

        //QUESTÃO 1<<<<<<<<<<<


        //static void Main(string[] args)

        //{
        //    Console.WriteLine("-----------------------------------------");
        //    Console.WriteLine("|                  OLÁ!!                |");
        //    Console.WriteLine("-----------------------------------------");

        //    double b, h, area;

        //    Console.WriteLine("-----------------------------------------");
        //    Console.WriteLine("|     CALCULE A ÁREA DO TRIÂNGULO!      |");
        //    Console.WriteLine("-----------------------------------------");

        //    Console.WriteLine("Digite o valor da base em cm:");
        //    b = double.Parse(Console.ReadLine());

        //Console.WriteLine("Digite o valor da altura em cm:");
        //    h = double.Parse(Console.ReadLine());


        //area = (b* h) / 2;

        //    Console.WriteLine("A área do triângulo é:" + area.ToString("F2") + "(cm²)");
        //    Console.WriteLine("Pressione qualquer tecla para sair do programa.");
        //    Console.ReadKey();


        //}

        //QUESTÃO 2


        //static void Main(string[] args)
        //{

        //    float num;

        //    Console.WriteLine("Digite um valor:");
        //    num = float.Parse(Console.ReadLine());

        //    if (num % 2 == 0)
        //    {
        //        Console.WriteLine("O número é par!");


        //    }

        //    else

        //    {

        //        Console.WriteLine("O número é ímpar!");

        //    }

        // QUESTÃO 3 
        //static void Main(string[] args)

        //{

        //    int n1, n2, n3;
        //    float media;


        //    Console.WriteLine("Informe a primeira nota:");
        //    n1 = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Informe a segunda nota:");
        //    n2 = int.Parse(Console.ReadLine());

        //    Console.WriteLine("informe a terceira nota:");
        //    n3 = int.Parse(Console.ReadLine());

        //    media = (n1 + n2 + n3) / 3;

        //    Console.WriteLine("A média do aluno foi:" + media);

        //    if (media >= 5) 
        //    {
        //        Console.WriteLine("Aluno Aprovado!!");
        //    }else
        //    {
        //        Console.WriteLine("Aluno Reprovado!!");
        //    }

        //QUESTÃO 4

        //        static void Main(string[] args)


        //        double[] valorProf = new double[2], salProf = new double[2];
        //        int[] horaProf = new int[2];

        //            for (int i = 0; i< 2; i++)
        //            {
        //                Console.Write("Informe as horas/aula do Professor {0}: ", i+1);
        //                horaProf[i] = int.Parse(Console.ReadLine());

        //        Console.Write("Informe o valor da hora/aula do Professor {0}: ", i);
        //                valorProf[i] = double.Parse(Console.ReadLine());

        //        Console.Clear();

        //                salProf[i] = valorProf[i] * horaProf[i];
        //            }

        //            if (salProf[0] > salProf[1])
        //            {
        //                Console.WriteLine("Professor 1 tem o salário maior que o professor 2");
        //            }
        //            else
        //{
        //    Console.WriteLine("Professor 2 tem o salário maior que o professor 1");
        //}

        //QUESTÃO 5

        //static void Main(string[] args)
        //{
        //    double n1, n2, media;
        //    int cont, resp;

        //    n1 = 0;
        //    n2 = 0;
        //    media = 0;
        //    resp = 0;
        //    cont = 0;

        //    do
        //    {
        //        Console.WriteLine("Digite a primeira nota:\n ");
        //        n1 = double.Parse(Console.ReadLine());
        //        Console.WriteLine("Digite a segunda nota:\n ");
        //        n2 = double.Parse(Console.ReadLine());
        //        media = (n1 + n2) / 2;
        //        Console.WriteLine("A média do aluno é:\n " + media);

        //        if (media >= 5)
        //        {
        //            Console.WriteLine("ALUNO APROVADO");
        //            cont++;
        //        }
        //        if (media < 5)
        //        {
        //            Console.WriteLine("ALUNO REPROVADO");
        //        }

        //        if (resp == 2)
        //        {
        //            break;
        //        }

        //        Console.WriteLine("Deseja calcular a média do próximo aluno?\n 1.SIM\n 2.Não");
        //        resp = int.Parse(Console.ReadLine());

        //    } while (true);
        //}

        //QUESTÃO 6
        //static void Main (string[] args)
        //{
        //    double  imc, peso, altura;
        //    string resp;

        //        Console.WriteLine("||---------- CALCULAR IMC -------------------||");
        //        Console.WriteLine("||INSTRUÇÕES: -------------------------------||");
        //        Console.WriteLine("||I - CASO O USUÁRIO DESEJE SAIR DIGITE 'FIM'||");
        //        Console.WriteLine("||-------------------------------------------||\n");
        //        Console.WriteLine("DIGITE A ALTURA DO USUÁRIO EM METROS:\n ");
        //        altura = double.Parse(Console.ReadLine());

        //        Console.WriteLine("DIGITE O PESO DO USUÁRIO:\n ");
        //        peso = double.Parse(Console.ReadLine());

        //        imc = peso / (altura * altura);

        //        Console.WriteLine("O INDÍCE DE MASSA CORPORAL DO USUÁRIO É:\n " + imc);
        //    do
        //    {
        //        Console.WriteLine("O IMC DO USUÁRIO É:\n ");
        //        if (imc < 18)
        //        {
        //            Console.WriteLine("O USUÁRIO ESTÁ ABAIXO DO PESO IDEAL.\n");
        //            Console.WriteLine(+imc);

        //        }

        //        else if ((imc > 18) && (imc < 25))
        //        {
        //            Console.WriteLine("O USUÁRIO ESTÁ NO PESO IDEAL!\n");
        //            Console.WriteLine(+imc);

        //        }

        //        else if ((imc > 25) && (imc < 30))
        //        {
        //            Console.WriteLine("O USUÁRIO ESTÁ COM SOBREPESO.\n");
        //            Console.WriteLine(+imc);
        //        }

        //        else if ((imc > 30) && (imc < 35))
        //        {
        //            Console.WriteLine("O USUÁRIO ESTÁ OBESO!\n");
        //            Console.WriteLine(+imc);
        //        }

        //        else if (imc > 35)
        //        {
        //            Console.WriteLine("O USUÁRIO ESTÁ COM OBESIDADE DE GRAU SÉRIO.\n ");
        //        }


        //        Console.WriteLine("DESEJA CALCULAR OUTRO IMC? CASO NÃO DESEJE DIGITE 'FIM' ");
        //        resp = Console.ReadLine().ToUpper();

        //    } while (resp == "FIM");

        //}

        //QUESTÃO 7
        //static void Main(string[] args)
        //{
        //    string palavra, frase;
        //    bool busca;

        //    Console.Write("Por favor, digite uma frase: ");
        //    frase = Console.ReadLine();

        //    Console.Write("Por favor, digite a palavra que deseja encontrar: ");
        //    palavra = Console.ReadLine();
        //    busca = frase.Contains(palavra);

        //    if (busca)
        //    {
        //        Console.WriteLine("A palavra '" + palavra + "' está presente na frase!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("A palavra '" + palavra + "' não foi encontrada na frase!");
        //    }
        //}


        //QUESTÃO 8
        //tatic void Main(string[] args)
        //{
        //        string codigo, nome;
        //        double salarioBase, salarioFinal, totalVendas;

        //        Console.Write("Digite o código do funcionário: ");
        //            codigo = Console.ReadLine();

        //            Console.Write("Digite o nome do mesmo funcionário: ");
        //            nome = Console.ReadLine();

        //            Console.Write("Digite o salário base do funcionário " + nome + ": ");
        //            salarioBase = double.Parse(Console.ReadLine());

        //        Console.Write("Digite o total em vendas do funcionário " + nome + ": ");
        //            totalVendas = double.Parse(Console.ReadLine());

        //        Console.Clear();

        //            if (totalVendas > 500 && totalVendas< 1000)
        //            {
        //                salarioFinal = salarioBase + (totalVendas* 0.05);
        //                Console.WriteLine("O funcionário {0} receberá uma comissão de 5% e seu salário final será {1:C}", nome, salarioFinal);
        //            }
        //            else if (totalVendas > 1000 && totalVendas< 5000)
        //            {
        //                salarioFinal = salarioBase + (totalVendas* 0.07);            
        //                Console.WriteLine("O funcionário {0} receberá uma comissão de 7% e seu salário final será {1:C}", nome, salarioFinal);
        //            }
        //            else if (totalVendas > 5000)
        //{
        //    salarioFinal = salarioBase + (totalVendas * 0.1);
        //    Console.WriteLine("O funcionário {0} receberá uma comissão de 10% e seu salário final será {1:C}", nome, salarioFinal);
        //}
        //else
        //{
        //    salarioFinal = salarioBase;
        //    Console.WriteLine("O funcionário {0} não bateu a meta e não receberá comissão. Seu salário final será {1:C}", nome, salarioFinal);
        //}
        //}


        //QUESTÃO 9

        //static void Main(string[] args)
        //{
        //    double[] glicemia = new double[3];
        //    double mediaDiaria = 0;
        //    bool menorQue65 = false, maiorQue250 = false;

        //    for (int i = 0; i < 3; i++)
        //    {
        //        Console.Write("Informe o {0}º valor da glicemia em jejum: ", i + 1);
        //        glicemia[i] = double.Parse(Console.ReadLine());
        //        mediaDiaria += glicemia[i];

        //        if (glicemia[i] < 65) { menorQue65 = true; }
        //        if (glicemia[i] > 250) { maiorQue250 = true; }
        //    }
        //    mediaDiaria /= 3;
        //    Console.Clear();

        //    if (menorQue65)
        //    {
        //        Console.WriteLine("Um dos seus valores está abaixo de 65.\nVocê corre risco de Hipoglicemia!");
        //    }
        //    if (maiorQue250)
        //    {
        //        Console.WriteLine("Um dos seus valores está acima de 250.\nVocê corre risco de Hiperglicemia!");
        //    }

        //    if (mediaDiaria < 80)
        //    {
        //        Console.WriteLine("A sua média está em " + mediaDiaria.ToString("F") + " e você deve diminuir 2 unidades de insulina");
        //    }
        //    else if (mediaDiaria > 150)
        //    {
        //        Console.WriteLine("A sua média está em " + mediaDiaria.ToString("F") + " e você deve adicionar 2 unidades de insulina");
        //    }
        //}

        //QUESTAO 10

        //static void Main(string[] args)
        //{
        //    string[] nomes = new string[2];
        //    int[] idades = new int[2];
        //    int indiceMaisNovo = 0, indiceMaisAlto = 0, idadeMaisNovo = 100;
        //    double[] alturas = new double[2];
        //    double alturaMaisAlto = 0;


        //    for (int i = 0; i < 2; i++)
        //    {
        //        Console.Write("Informe o nome do atleta {0}: ", i + 1);
        //        nomes[i] = Console.ReadLine();

        //        Console.Write("Informe a idade do atleta {0}: ", i + 1);
        //        idades[i] = int.Parse(Console.ReadLine());

        //        if (idades[i] < idadeMaisNovo)
        //        {
        //            idadeMaisNovo = idades[i];
        //            indiceMaisNovo = i;
        //        }

        //        Console.Write("Informe a altura do atleta {0}: ", i + 1);
        //        alturas[i] = double.Parse(Console.ReadLine());

        //        if (alturas[i] > alturaMaisAlto)
        //        {
        //            alturaMaisAlto = alturas[i];
        //            indiceMaisAlto = i;
        //        }
        //        Console.WriteLine();
        //    }

        //    Console.Clear();

        //    Console.WriteLine("\nAtleta mais novo: ");
        //    Console.WriteLine(nomes[indiceMaisNovo]);
        //    Console.WriteLine(idades[indiceMaisNovo] + " anos");
        //    Console.WriteLine("{0:0.00m}", alturas[indiceMaisNovo]);
        //    Console.WriteLine("\n-------------------\n");
        //    Console.WriteLine("Atleta mais alto: ");
        //    Console.WriteLine(nomes[indiceMaisAlto]);
        //    Console.WriteLine(idades[indiceMaisAlto] + " anos");
        //    Console.WriteLine("{0:0.00}m", alturas[indiceMaisAlto]);
        //}


        //QUESTAO 11
        //static void Main(string[] args)
        //{
        //    int hora, minuto;
        //    bool valido = false;

        //    Console.Write("Informe a hora desejada: ");
        //    hora = int.Parse(Console.ReadLine());

        //    Console.Write("Informe os minutos desejados: ");
        //    minuto = int.Parse(Console.ReadLine());

        //    if (hora >= 0 && hora <= 23)
        //    {
        //        valido = true;
        //    }

        //    if (minuto >= 0 && minuto <= 59)
        //    {
        //        valido = true;
        //    }

        //    if (valido == true)
        //    {
        //        Console.WriteLine("{0:00}:{1:00} a hora informada é válida!", hora, minuto);
        //    }
        //}

        //QUESTAO 12

        //static void Main(string[] args)
        //{
        //    string codigo;
        //    int numeroHoras;
        //    double salario, extra, salarioFinal = 0;

        //    Console.Write("Informe o código do funcionário: ");
        //    codigo = Console.ReadLine();

        //    Console.Write("Informe o número de horas trabalhadas do funcionário: ");
        //    numeroHoras = int.Parse(Console.ReadLine());

        //    if (numeroHoras < 50)
        //    {
        //        salarioFinal = numeroHoras * 10;
        //    }
        //    if (numeroHoras > 50)
        //    {
        //        numeroHoras -= 50;
        //        salario = 10 * 50;
        //        extra = numeroHoras * 20;
        //        salarioFinal = salario + extra;
        //    }

        //    Console.WriteLine("Salário final do funcionário: " + salarioFinal.ToString("C"));
        //}

        //QUESTAO 13


        //static void Main(string[] args)
        //{

        //    double h, pesoI;
        //    char sexo;

        //    Console.Write("Você é do sexo (M)asculino ou (F)eminino? ");
        //    sexo = char.Parse(Console.ReadLine());

        //    Console.Write("Informe sua altura: ");
        //    h = double.Parse(Console.ReadLine());

        //    if (sexo == 'm' || sexo == 'M')
        //    {
        //        pesoI = (72.7 * h) - 58;
        //        Console.WriteLine("Peso ideal: " + pesoI.ToString("F") + "Kg");
        //    }
        //    else if (sexo == 'f' || sexo == 'F')
        //    {
        //        pesoI = (62.1 * h) - 44.7;
        //        Console.WriteLine("Peso ideal: " + pesoI.ToString("F") + "Kg");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Informe um sexo válido!\nM para masculino ou F para feminino");
        //    }
        //}

        //QUESTAO 14

        //static void Main(string[] args)
        //{
        //    double tamanhoArq, velocidadeInternet, minutos;

        //    Console.Write("Informe o tamanho do arquivo em MB: ");
        //    tamanhoArq = double.Parse(Console.ReadLine());
        //    Console.Write("Informe a banda da conexão em Mbp/s: ");
        //    velocidadeInternet = double.Parse(Console.ReadLine());

        //    minutos = tamanhoArq / velocidadeInternet;

        //    Console.WriteLine("Tempo de download: {0:0.00} minutos.", minutos);
        //}

        //QUESTAO 15

        //static void Main(string []args)
        //{
        //    double metrosQuadrados, lata, valor;

        //    Console.Write("Informe a área a ser pintada (em m²): ");
        //    metrosQuadrados = double.Parse(Console.ReadLine());
        //    lata = Math.Ceiling(metrosQuadrados / 54);
        //    valor = lata * 80;

        //    if (lata == 1)
        //    {
        //        Console.WriteLine("\nSerá necessária " + lata + " lata de 18L no valor de " + valor.ToString("C"));
        //    }
        //    else if (lata > 1)
        //    {
        //        Console.WriteLine("\nSerá necessário " + lata + " latas de 18L no valor de " + valor.ToString("C"));
        //    }
        //}

        //QUESTAO 16

        //static void Main(string [] args)
        //{
        //    int timeCasa, timeFora;

        //    Console.Write("Informe a quantidade de gols do time da casa: ");
        //    timeCasa = int.Parse(Console.ReadLine());

        //    Console.Write("Informe a quantidade de gols do time de fora: ");
        //    timeFora = int.Parse(Console.ReadLine());
        //    if (timeFora >= timeCasa + 2)
        //    {
        //        Console.WriteLine("\nO time de fora já se classificou");
        //    }
        //    else
        //    {
        //        Console.WriteLine("\nOs times se enfrentarão no próximo jogo\n\n");

        //        Console.Write("Informe a quantidade de gols do time da casa: ");
        //        timeCasa = int.Parse(Console.ReadLine());

        //        Console.Write("Informe a quantidade de gols do time de fora: ");
        //        timeFora = int.Parse(Console.ReadLine());

        //        if (timeCasa > timeFora)
        //        {
        //            Console.Clear();
        //            Console.WriteLine("Time da casa está na próxima fase!");
        //        }
        //        else
        //        {
        //            Console.Clear();
        //            Console.WriteLine("Time de fora da próxima fase!");
        //        }
        //    }
        //}

        //QUESTAO 17
        //static void Main(string[] args)
        //{
        //    int ladoA, ladoB, ladoC;

        //    Console.Write("Informe o lado A do triângulo: ");
        //    ladoA = int.Parse(Console.ReadLine());

        //    Console.Write("Informe o lado B do triângulo: ");
        //    ladoB = int.Parse(Console.ReadLine());

        //    Console.Write("Informe o lado C do triângulo: ");
        //    ladoC = int.Parse(Console.ReadLine());


        //    if (ladoA < (ladoB + ladoC) && ladoB < (ladoA + ladoC) && ladoC < (ladoA + ladoB))
        //    {
        //        Console.Write("\nÉ um triângulo ");
        //        if (ladoA == ladoB && ladoB == ladoC)
        //        {
        //            Console.WriteLine("Equilátero");
        //        }
        //        else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
        //        {
        //            Console.WriteLine("Isósceles");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Escaleno");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("OS VALORES NÃO FORMAM UM TRIÂNGULO VÁLIDO!");
        //    }
        //}

        //QUESTAO 18

        //static void Main(string[] args)
        //{
        //    int valor1, valor2, valor3;

        //    Console.Write("Informe o primeiro valor: ");
        //    valor1 = int.Parse(Console.ReadLine());

        //    Console.Write("Informe o segundo valor: ");
        //    valor2 = int.Parse(Console.ReadLine());

        //    Console.Write("Informe o terceiro valor: ");
        //    valor3 = int.Parse(Console.ReadLine());

        //    if (valor1 > valor2 && valor1 > valor3)
        //    {
        //        Console.WriteLine("\n" + valor1 + " é o valor maior.");
        //    }
        //    else if (valor2 > valor1 && valor2 > valor3)
        //    {
        //        Console.WriteLine("\n" + valor2 + " é o valor maior.");
        //    }
        //    else if (valor3 > valor1 && valor3 > valor2)
        //    {
        //        Console.WriteLine("\n" + valor3 + " é o valor maior.");
        //    }
        //}

        //QUESTAO 19

        //static void Main(string[] args)
        // {
        //int valor1, valor2, valor3;
        //string maior = "", meio = "", menor = "";

        //Console.Write("Informe o primeiro valor: ");
        //valor1 = int.Parse(Console.ReadLine());

        //Console.Write("Informe o segundo valor: ");
        //valor2 = int.Parse(Console.ReadLine());

        //Console.Write("Informe o terceiro valor: ");
        //valor3 = int.Parse(Console.ReadLine());

        //if (valor1 > valor2 && valor1 > valor3)
        //{
        //    maior = "Valor 1: " + valor1;

        //    if (valor2 > valor3)
        //    {
        //        meio = "Valor 2: " + valor2;
        //        menor = "Valor 3: " + valor3;
        //    }
        //    else
        //    {
        //        meio = "Valor 3: " + valor3;
        //        menor = "Valor 2: " + valor2;
        //    }
        //}
        //else if (valor2 > valor1 && valor2 > valor3)
        //{
        //    maior = "Valor 2: " + valor2;

        //    if (valor1 > valor3)
        //    {
        //        meio = "Valor 1: " + valor1;
        //        menor = "Valor 3: " + valor3;
        //    }
        //    else
        //    {
        //        meio = "Valor 3: " + valor3;
        //        menor = "Valor 1: " + valor1;
        //    }
        //}
        //else if (valor3 > valor1 && valor3 > valor2)
        //{
        //    maior = "Valor 3: " + valor3;

        //    if (valor1 > valor2)
        //    {
        //        maior = "Valor 1: " + valor1;
        //        menor = "Valor 2: " + valor2;
        //    }
        //    else
        //    {
        //        meio = "Valor 2: " + valor2;
        //        menor = "Valor 1: " + valor1;
        //    }
        //}

        //Console.Clear();

        //Console.WriteLine("Segue abaixo os números de forma crescente: ");
        //Console.WriteLine(maior);
        //Console.WriteLine(meio);
        //Console.WriteLine(menor);
        //}

        //QUESTAO 20
        //        static void Main(string[] args)
        //        {
        //            int numSecreto = 10, tentativas = 3, op;

        //            Console.WriteLine("-----?SHOW DO NÚMERO SECRETO?----");
        //            Console.WriteLine("--------------------------------");

        //            do
        //            {
        //                Console.Write("Vamos tentar: ");
        //                opcao = int.Parse(Console.ReadLine());

        //                if (opcao != numSecreto)
        //                {
        //                    tentativas -= 1;
        //                    Console.WriteLine("\nVocê errou!");
        //                    if (numSecreto > opcao)
        //                    {
        //                        Console.WriteLine("É MAIOR!");
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("É MENOR!");
        //                    }

        //                    if (tentativas > 1)
        //                    {
        //                        Console.WriteLine("Ainda restam " + tentativas + " tentivas...\n");
        //                    }
        //                    else if (tentativas == 0)
        //                    {
        //                        Console.WriteLine("\n");
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("'EEEEEEEPAAAAAA' ESSA É A SUA ÚLTIMA CHANCE!\n");
        //                    }
        //                }
        //                else
        //                {
        //                    Console.WriteLine("CARAMBOLAS, VOCÊ ACERTOU O NÚMERO SECRETO!");
        //                    break;
        //                }
        //            }
        //            while (tentativas > 0);


        //        }
        //    }
        //}

        //----------------EXERCICIO 3--------------------

        //QUESTÃO 1

        //static void Main(string[] args)

        //{
        //    int num, positivos = 0, negativos = 0;

        //    do
        //    {
        //        Console.WriteLine("|||OS VALORES PODERÃO SER DIGITADOS ATÉ QUE O NÚMERO '0' SEJA DIGITADO!!|||");

        //        Console.WriteLine("Digite alguns valores: ");

        //        num = int.Parse(Console.ReadLine());

        //        if (num > 0)
        //        {
        //            positivos++;
        //        }
        //        if (num < 0)
        //        {
        //            negativos++;                
        //        }

        //    } while (num != 0);

        //    Console.WriteLine("Positivos: " + positivos);
        //    Console.WriteLine("Negativos: " + negativos);
        //}

        //QUESTÃO 2

        //static void Main(string[] args)

        //{
        //int num;
        //char op = 's';

        //while (op == 's' || op == 'S')
        //{
        //    Console.Write("Informe um número positivo: ");
        //    num = int.Parse(Console.ReadLine());

        //    while (num <= 0)
        //    {
        //        Console.Clear();
        //        Console.Write("Informe um número positivo: ");
        //        num = int.Parse(Console.ReadLine());
        //    }

        //    Console.Write("Números inteiros pares entre 1 e {0}: ", numero);

        //    for (int i = 1; i < num; i++)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            Console.Write("{0} ", i);
        //        }
        //    }
        //    Console.Write("\n\nQuer informar outro número? (s)im ou (n)ão? ");
        //    op = char.Parse(Console.ReadLine());
        //}

        //}


        // QUESTÃO 3

        //static void Main(string[] args)

        //{
        //    int num;
        //    do
        //    {
        //        Console.WriteLine("Digite um número inteiro qualquer ou digite 0 para sair do programa: ");
        //        num = int.Parse(Console.ReadLine());
        //        if (num % 2 == 0)
        //        {
        //            Console.WriteLine(num + ("é par!!"));
        //        }
        //        else
        //        {
        //            Console.WriteLine(num + ("é ímpar"));
        //        }
        //        int divPerfeitas = 0;
        //        for (int i = 1; i <= num; i++)
        //        {
        //            divPerfeitas++;
        //        }
        //        if (divPerfeitas > 2)
        //        {
        //            Console.WriteLine(num + "Não é primo!!");
        //        }
        //        else
        //        {
        //            Console.WriteLine(num + "É primo!!");
        //        }
        //    } while (num != 0);

        //}


        //QUESTÃO 4

        //static void Main(string[] args)

        //{
        //    string voto;
        //    int votosJoao, votosZeca, votosBrancos;

        //    votosJoao = 0;
        //    votosZeca = 0;
        //    votosBrancos = 0;
        //    Console.WriteLine("||------------------------ INSTRUÇÕES ---------------------||");
        //    Console.WriteLine("|| I - DIGITE APENAS JOAO OU ZECA.                         ||");
        //    Console.WriteLine("|| II - QUALQUER VOTO DIFERENTE SERÁ COMPUTADA COMO BRANCO.||");
        //    Console.WriteLine("||---------------------------------------------------------||");

        //    do
        //    {
        //        Console.WriteLine(" DESEJA DEPOSITAR SEUS VOTOS EM JOÃO OU EM ZECA?\n");
        //        Console.WriteLine(" DIGITE 'JOAO' PARA VOTAR EM JOÃO OU DIGITE 'ZECA' PARA VOTAR EM ZECA:\n");
        //        voto = Console.ReadLine().ToUpper();

        //        if (voto == "FIM")
        //        {
        //            break;
        //        }

        //        if (voto == "JOAO")
        //        {
        //            votosJoao++;
        //        }
        //        else if (voto == "ZECA")
        //        {
        //            votosZeca++;
        //        }
        //        else
        //        {
        //            votosBrancos++;
        //        }
        //    } while (true);

        //    Console.WriteLine("Total de eleitores: " + (votosJoao + votosZeca + votosBrancos));
        //    Console.WriteLine("João recebeu " + votosJoao);
        //    Console.WriteLine("Zeca recebeu " + votosZeca);
        //    Console.WriteLine("Os votos Brancos somam um total de: " + votosBrancos);


        //    Console.ReadKey();
        //}

        //QUESTAO 5

        //static void Main(string[] args)
        //{

        //    int idade = 0;

        //    while (idade <= 0)
        //    {
        //        Console.Clear();
        //        Console.Write("Informe a idade do usuário: ");
        //        idade = int.Parse(Console.ReadLine());
        //    }
        //    Console.WriteLine("\n{0} é válida!", idade);
        //}

        //QUESTAO 6

        //static void Main(string[] args)
        //{
        //    string nome;
        //    int idade;
        //    float salario;
        //    do
        //    {​
        //    Console.Write("Nome: ");
        //        nome = Console.ReadLine();
        //        if (nome.Any(char.IsDigit) || string.IsNullOrWhiteSpace(nome))
        //        {​
        //        Console.WriteLine("Digite um nome válido!!");
        //        }​ else
        //        {​
        //        break;
        //        }​
        //}​ while (true) ;
        //    do
        //    {​
        //    Console.Write("Idade: ");
        //        idade = int.Parse(Console.ReadLine());
        //        if (idade <= 0)
        //        {​
        //        Console.WriteLine("Digite uma idade válida!!");
        //        }​ else
        //        {​
        //        break;
        //        }​
        //}​ while (true) ;
        //    do
        //    {​
        //    Console.Write("Salário: ");
        //        salario = float.Parse(Console.ReadLine());
        //        if (salario <= 0)
        //        {​
        //        Console.WriteLine("Digite um salário válido!!");
        //        }​ else
        //        {​
        //        break;
        //        }​
        //}​ while (true) ;
        //    Console.WriteLine("Seus dados são: ");
        //    Console.WriteLine("Nome: " + nome.ToUpper());
        //    Console.WriteLine("Idade: " + idade);
        //    Console.WriteLine("Salário: " + salario);
        //}


        //QUESTAO 7

        //static void Main(string[] args)
        //{
        //    int numero = 0;
        //    char opcao = 's';

        //    while (opcao == 's' || opcao == 'S')
        //    {
        //        Console.Write("Informe um número inteiro: ");
        //        numero = int.Parse(Console.ReadLine());

        //        while (numero < 0)
        //        {
        //            Console.Clear();
        //            Console.Write("Informe um número inteiro: ");
        //            numero = int.Parse(Console.ReadLine());
        //        }

        //        Console.Write("\nNúmeros pares entre 0 e {0}: ", numero);

        //        for (int i = 0; i < numero + 1; i++)
        //        {
        //            if (i % 2 == 0)
        //            {
        //                Console.Write("{0} ", i);
        //            }
        //        }

        //        Console.Write("\n\nDeseja informar algum outro numeral? (s)im ou (n)ão? ");
        //        opcao = char.Parse(Console.ReadLine());
        //        Console.Clear();
        //    }
        //}

        //QUESTAO 8

        //static void Main(string[] args)
        //{
        //    int filhos, filhos1a3 = 0, filhos4a7 = 0, filhos8 = 0, filhos0 = 0;

        //    for (int i = 1; i < 5; i++)     //usado 5 para fins de testes...
        //    {
        //        Console.Write("Informe quantos filhos o visitante {0} possui (0 para nenhum): ", i);
        //        filhos = int.Parse(Console.ReadLine());
        //        Console.Clear();

        //        if (filhos == 0)
        //        {
        //            filhos0++;
        //        }
        //        if (filhos >= 1 && filhos <= 3)
        //        {
        //            filhos1a3++;
        //        }
        //        if (filhos >= 4 && filhos <= 7)
        //        {
        //            filhos4a7++;
        //        }
        //        if (filhos >= 8)
        //        {
        //            filhos8++;
        //        }
        //    }

        //    Console.Clear();
        //    Console.WriteLine("Número de visitantes sem filhos: {0}", filhos0);
        //    Console.WriteLine("Número de visitantes com 1 a 3 filhos : {0}", filhos1a3);
        //    Console.WriteLine("Número de visitantes com 4 a 7 filhos : {0}", filhos4a7);
        //    Console.WriteLine("Número de visitantes com mais de 8 filhos : {0}", filhos4a7);
        //    Console.WriteLine("-------------------------------------------------------");
        //    Console.WriteLine("Aperte qualquer uma tecla para sair.");
        //    Console.Read();

        //}

        //QUESTAO 9

        //static void Main(string[] args)
        //{

        //    string nome;
        //    int idade, masculino = 0, feminino = 0, menosDe30 = 0, maior60 = 0, mediaIdadeMulheres = 0;
        //    char sexo;

        //    for (int i = 1; i <= 5; i++)     //feito com 5 para fins de testes...
        //    {
        //        Console.Write("Informe o {0}º nome: ", i);
        //        nome = Console.ReadLine();

        //        Console.Write("Informe o sexo do(a) {0} (m)asculino ou (f)eminino: ", nome);
        //        sexo = char.Parse(Console.ReadLine());

        //        Console.Write("Informe a idade do(a) {0}: ", nome);
        //        idade = int.Parse(Console.ReadLine());

        //        Console.Clear();

        //        if (sexo == 'm' || sexo == 'M') { masculino++; }

        //        if (sexo == 'f' || sexo == 'F')
        //        {
        //            feminino++;
        //            mediaIdadeMulheres += idade;
        //        }

        //        if (idade < 30) { menosDe30++; }
        //        else if (idade > 60) { maior60++; }
        //    }

        //    mediaIdadeMulheres = mediaIdadeMulheres / feminino;

        //    Console.Clear();
        //    Console.WriteLine("Pessoas do sexo masculino: " + masculino);
        //    Console.WriteLine("Pessoas do sexo feminino: " + feminino);
        //    Console.WriteLine("Pessoas com menos de 30 anos: " + menosDe30);
        //    Console.WriteLine("Pessoas com mais de 60 anos: " + maior60);
        //    Console.WriteLine("Média de idade das mulheres: " + mediaIdadeMulheres);
        //    Console.WriteLine("------------------------------------------------------");
        //    Console.WriteLine("\nPressione qualquer uma tecla para sair...");
        //    Console.Read();
        //}

        //QUESTAO 10

        //static void Main(string[] args)
        //{

        //    double nota = 0, notaMaisAlta = 0, notaMaisBaixa = 10, media = 0;
        //    int quantidade = 0;

        //    while (nota != -1)
        //    {
        //        Console.Write("Informe a nota do(a) aluno(a) (use -1 para encerrar): ");
        //        nota = double.Parse(Console.ReadLine());

        //        if (nota > notaMaisAlta) { notaMaisAlta = nota; }
        //        if (nota < notaMaisBaixa && nota > -1) { notaMaisBaixa = nota; }

        //        if (nota > -1)
        //        {
        //            media += nota;
        //            quantidade++;
        //        }
        //    }

        //    media = media / quantidade;

        //    Console.WriteLine("\nNota mais alta: {0}", notaMaisAlta);
        //    Console.WriteLine("Nota mais baixa: {0}", notaMaisBaixa);
        //    Console.WriteLine("Média da turma: {0:0.0}", media);
        //    Console.WriteLine("Alunos na turma: {0}", quantidade);
        //}

        //QUESTAO 11

        //static void Main(string[] args)
        //{

        //    int numeros = 0;

        //    for (int i = 1; i <= 100; i++)
        //    {
        //        numeros += i;
        //    }

        //    Console.WriteLine(numeros);
        //    Console.WriteLine("Pressione qualquer tecla para sair");
        //    Console.ReadKey();
        //}

        //QUESTAO 12

        //static void Main(string[] args)
        //{
        //    int numeros = 0;

        //    for (int i = 1; i <= 500; i++)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            numeros += i;
        //        }
        //    }
        //    Console.WriteLine("A soma dos pares entre 1 e 500 é: {0}", numeros);
        //}

        //QUESTAO 13

        //static void Main(string[] args)
        //{

        //    int potencias;

        //    for (int i = 0; i <= 10; i++)
        //    {
        //        Console.WriteLine("2^{0}: {1}", i, Math.Pow(2, i));
        //    }
        //}

        //QUESTAO 14

        //static void Main(string[] args)
        //{
        //    double[] notas = new double[4], pesos = { 2, 1, 2, 4 };
        //    double media = 0, divisao = 0;

        //    for (int i = 0; i < pesos.Length; i++)
        //    {
        //        Console.Write("Informe a nota {0}: ", i + 1);
        //        notas[i] = double.Parse(Console.ReadLine());
        //        Console.Clear();

        //        media += notas[i] * pesos[i];
        //        divisao += pesos[i];
        //    }

        //    media = media / divisao;

        //    Console.WriteLine(media >= 7 ? "\nAprovado!" : "\nReprovado...");
        //}

        //QUESTAO 15
        //static void Main(string[] args)
        // {

        //     Random aleatorio = new Random();
        //     int numero = aleatorio.Next(1, 50);
        //     int aux = 0;

        //     Console.WriteLine("Número sorteado: {0}", numero);

        //     while (numero < 250)
        //     {
        //         aux = numero;
        //         numero *= 3;
        //     }

        //     Console.WriteLine(aux);
        // }

        //QUESTAO 16

        //static void Main(string[] args)
        //{
        //    for (int i = 15; i <= 200; i++)
        //    {
        //        Console.WriteLine("{0}² = {1}", i, (Math.Pow(i, 2)));
        //    }
        //}

        //QUESTAO 17 

        //static void Main(string[] args)
        //{
        //    double Base, potencia;

        //    Console.Write("Informe a base: ");
        //    Base = double.Parse(Console.ReadLine());

        //    Console.Write("Informe o expoente: ");
        //    potencia = double.Parse(Console.ReadLine());

        //    Console.WriteLine("\n{0} elevado a {1} é igual a {2}", Base, potencia, (Math.Pow(Base, potencia)));
        //}

        //QUESTAO 18

        //static void Main(string[] args)
        //{
        //    double salario = 0, mediaSalario = 0, maiorSalario = 0;
        //    int filhos, numFilhos = 0, mediaFilhos = 0, salariosAteCem = 0, habitantes = 0;

        //    while (salario > -1)
        //    {
        //        Console.Clear();
        //        Console.WriteLine("Habitante {0}\n", habitantes);
        //        Console.Write("Qual o seu salário? R$");
        //        salario = double.Parse(Console.ReadLine());

        //        if (salario < 0) { break; }

        //        if (salario <= 100) { salariosAteCem++; }

        //        if (salario > maiorSalario) { maiorSalario = salario; }

        //        mediaSalario += salario;

        //        Console.Write("\nQuantos filhos você tem? ");
        //        filhos = int.Parse(Console.ReadLine());

        //        mediaFilhos += filhos;
        //        habitantes++;
        //    }

        //    mediaSalario /= habitantes;
        //    mediaFilhos /= habitantes;
        //    salariosAteCem = (100 * salariosAteCem) / habitantes;

        //    Console.Clear();
        //    Console.WriteLine("População: {0}", habitantes);
        //    Console.WriteLine("Média de salário da população: {0:C}", mediaSalario);
        //    Console.WriteLine("Média de filhos da população: {0}", mediaFilhos);
        //    Console.WriteLine("Maior salário da população: {0:C}", maiorSalario);
        //    Console.WriteLine("{0}% da população recebe até R$100.", salariosAteCem);
        //}

        //QUESTAO 19

        //        static void Main(string[] args)
        //        {
        //            int maiorIdade = 0, feminino18_35 = 0, idade = 1;
        //            char sexo, olho, cabelo;

        //            while (idade > 0)
        //            {
        //                Console.WriteLine("Informe a idade -1 para encerrar o programa.\n");

        //                Console.Write("Informe a idade: ");
        //                idade = int.Parse(Console.ReadLine());

        //                if (idade < 0) { break; }

        //                Console.Write("Informe o sexo: (m)asculino ou (f)eminino: ");
        //                sexo = char.Parse(Console.ReadLine());

        //                Console.Write("Informe a cor dos olhos: (a)zuis ou (v)erdes ou (c)astanhos: ");
        //                olho = char.Parse(Console.ReadLine());

        //                Console.Write("Informe a cor dos cabelos: (l)ouros ou (p)retos ou (c)astanhos: ");
        //                cabelo = char.Parse(Console.ReadLine());


        //                if (idade > maiorIdade) { maiorIdade = idade; }

        //                if (
        //                    (sexo == 'f' || sexo == 'F')
        //                    && (idade >= 18 && idade <= 35)
        //                    && (olho == 'v' || olho == 'V')
        //                    && (cabelo == 'l' || cabelo == 'L'))
        //                {
        //                    feminino18_35++;
        //                }
        //                Console.Clear();
        //            }

        //            Console.Clear();

        //            Console.WriteLine("Maior idade dos habitantes: " + maiorIdade);
        //            Console.WriteLine("Indivíduos do sexo feminino entre 18 e 35 anos com olhos verdes e cabelos louros: " + feminino18_35);


        //        }
        //    }
        //}

        //-------------------------- LISTA 4 --------------------------
        //QUESTAO 1
        //static void Main(string[] args) {

        //    int[] numeros = new int[10];
        //    int pares = 0, impares = 0;

        //    for (int i = 0; i < numeros.Length; i++)
        //    {
        //        Console.Write("Informe o número da posição {0}: ", i);
        //        numeros[i] = int.Parse(Console.ReadLine());

        //        if (numeros[i] % 2 == 0)
        //        {
        //            pares++;
        //        }
        //        else if (numeros[i] % 2 != 0)
        //        {
        //            impares++;
        //        }
        //    }

        //    Console.Clear();

        //    Console.WriteLine("Números pares: {0}", pares);
        //    Console.WriteLine("Números ímpares: {0}", impares);


        //}

        //QUESTAO 2
        //static void Main(string[] args)
        //            {

        //                int[] vetor1 = new int[20], vetor2 = new int[20], vetorSoma = new int[20];

        //                for (int i = 0; i < 20; i++)
        //                {
        //                    Console.Write("Informe o valor da posição {0} do Vetor 1: ", i);
        //                    vetor1[i] = int.Parse(Console.ReadLine());
        //                }

        //                for (int i = 0; i < 20; i++)
        //                {
        //                    Console.Write("Informe o valor da posição {0} do Vetor 2: ", i);
        //                    vetor2[i] = int.Parse(Console.ReadLine());
        //                }

        //                Console.Clear();

        //                for (int i = 0; i < 20; i++)
        //                {
        //                    vetorSoma[i] = vetor1[i] + vetor2[i];
        //                    Console.WriteLine("Vetor1[{0}] + Vetor2[{0}]: {1}", i, vetorSoma[i]);
        //                }
        //            }

        //QUESTÃO 3
        //static void Main(string[] args)
        //{
        //    int[] vetor = new int[5];
        //    for (int i = 0; i < vetor.Length; i++)
        //    {
        //        Console.WriteLine("Informe um valor para a posição " + (i + 1) + "do vetor");
        //        vetor[i] = int.Parse(Console.ReadLine());
        //    }
        //    for (int i = 0; i < vetor.Length; i++)
        //    {
        //        int count = 0;
        //        for (int x = 1; x <= vetor[i]; x++)
        //        {
        //            if (vetor[i] % x == 0)
        //            {
        //                count++;
        //            }
        //        }
        //        if (count == 2)
        //        {
        //            Console.WriteLine("O valor da " +
        //                "posição " + i + ":" + vetor[i] + " é um " +
        //                "número primo!");
        //        }
        //    }


        //}

        //QUESTAO 4

        //static void Main(string[] args)
        //{
        //    int[] vetor1 = new int[10], vetor2 = new int[10], vetorMulti = new int[10];

        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write("Informe o valor da posição {0} do Vetor 1: ", i);
        //        vetor1[i] = int.Parse(Console.ReadLine());
        //    }

        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write("Informe o valor da posição {0} do Vetor 2: ", i);
        //        vetor2[i] = int.Parse(Console.ReadLine());
        //    }

        //    Console.Clear();

        //    for (int i = 0; i < 10; i++)
        //    {
        //        vetorMulti[i] = vetor1[i] * vetor2[i];
        //        Console.WriteLine("Vetor1[{0}] + Vetor2[{0}]: {1}", i, vetorMulti[i]);
        //    }
        //}

        //QUESTAO 5

        //static void Main(string[] args)
        //{

        //    int[] vetor = new int[80];
        //    int menor = 1000000000, pos = 0;

        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.Write("Informe o {0}º número: ", i + 1);
        //        vetor[i] = int.Parse(Console.ReadLine());

        //        if (vetor[i] < menor)
        //        {
        //            menor = vetor[i];
        //            pos = i;
        //        }
        //    }
        //}

        //QUESTAO 6

        //static void Main(string[] args)
        //{

        //    int[] numeros = new int[10];

        //    for (int i = 0; i < numeros.Length; i++)
        //    {
        //        Console.Write("Informe o número da posição {0} do vetor: ", i);
        //        numeros[i] = int.Parse(Console.ReadLine());
        //    }

        //    for (int i = 9; i >= 0; i--)
        //    {
        //        Console.Write("\n" + numeros[i] + " ");
        //    }
        //}

        //QUESTAO 7

        //static void Main(string[] args)
        //{
        //    int[] numeros = new int[10];

        //    for (int i = 0; i < numeros.Length; i++)
        //    {
        //        Console.Write("Informe o número da posição {0} do vetor: ", i);
        //        numeros[i] = int.Parse(Console.ReadLine());
        //    }

        //    for (int i = 0; i < numeros.Length; i++)
        //    {
        //        if (numeros[i] % 2 == 0)
        //        {
        //            Console.Write(numeros[i] + " ");
        //        }
        //    }

        //    for (int i = 0; i < numeros.Length; i++)
        //    {
        //        if (numeros[i] % 2 != 0)
        //        {
        //            Console.Write(numeros[i] + " ");
        //        }
        //    }
        //}

        //QUESTAO 8

        //static void Main(string[] args)
        //{

        //    double[] numeros = new double[30];

        //    for (int i = 0; i < numeros.Length; i++)
        //    {
        //        Console.Write("Informe o número da posição {0} do vetor: ", i);
        //        numeros[i] = double.Parse(Console.ReadLine());
        //    }

        //    for (int i = 0; i < numeros.Length; i++)
        //    {
        //        if (numeros[i] < 0)
        //        {
        //            Console.Write(i + 1 + " ");
        //        }
        //    }
        //}

        //QUESTAO 9

        //static void Main(string[] args)
        //{

        //    int[] numeros = new int[] { 7, 40, 3, 9, 21, 0, 63, 31, 7, 22 }, usados = new int[numeros.Length], ordenado = new int[numeros.Length];
        //    int menor = 0;

        //    for (int i = 0; i < numeros.Length; i++)    //roda a quantidade de vezes que tiver no vetor
        //    {
        //        for (int j = 0; j < numeros.Length - 1; j++)
        //        {    //faz a busca do menor número

        //            if (numeros[j + 1] < numeros[j])
        //            {
        //                menor = numeros[j];
        //                numeros[j] = numeros[j + 1];
        //                numeros[j + 1] = menor;
        //            }
        //        }
        //    }

        //    Console.WriteLine("Ordenado");
        //    for (int i = 0; i < numeros.Length; i++)
        //    {
        //        Console.Write(numeros[i] + " ");
        //    }
        //}

        //QUESTAO 10

        //static void Main(string[] args)
        //{
        //    int[] numeros = new int[20], validados = new int[20];

        //    for (int i = 0; i < numeros.Length; i++)
        //    {
        //        Console.Write("Informe o número da posição {0} do vetor: ", i);
        //        numeros[i] = int.Parse(Console.ReadLine());
        //    }

        //    for (int i = 0; i < numeros.Length; i++)
        //    {
        //        if (numeros[i] == 0 || numeros[i] == null)
        //        {
        //            validados[i] = 2;
        //        }
        //        else
        //        {
        //            validados[i] = numeros[i];
        //        }
        //    }
        //    Console.Clear();

        //    for (int i = 0; i < validados.Length; i++)
        //    {
        //        Console.WriteLine("Valor do vetor na posição {0}: {1}", i, numeros[i]);
        //    }

        //    Console.WriteLine("/////////////////////////////////////////////////");

        //    for (int i = 0; i < validados.Length; i++)
        //    {
        //        Console.WriteLine("Valor do vetor validado na posição {0}: {1}", i, validados[i]);
        //    }
        //}

        //QUESTAO 11

        //static void Main(string[] args)
        //{

        //    int[] numeros = new int[5];

        //    for (int i = 0; i < numeros.Length; i++)
        //    {
        //        Console.Write("Informe o número da posição {0} do vetor: ", i);
        //        numeros[i] = int.Parse(Console.ReadLine());
        //    }

        //    for (int i = numeros.Length - 1; i >= 0; i--)
        //    {
        //        Console.Write("\n" + numeros[i] + " ");
        //    }
        //}

        //QUESTAO 12

        //static void Main(string[] args)
        //{

        //    int[] numeros = new int[10];
        //    int busca, pos = 0;

        //    for (int i = 0; i < numeros.Length; i++)
        //    {
        //        Console.Write("Informe o número da posição {0} do vetor: ", i);
        //        numeros[i] = int.Parse(Console.ReadLine());
        //    }

        //    Console.Write("\nQual número deseja procurar no vetor? ");
        //    busca = int.Parse(Console.ReadLine());

        //    for (int i = 0; i < numeros.Length; i++)
        //    {
        //        if (numeros[i] == busca)
        //        {
        //            pos = i;
        //        }
        //    }

        //    Console.Clear();

        //    if (pos != 0)
        //    {
        //        Console.WriteLine("O número {0} encontra-se na posição {1} do vetor!", busca, pos);
        //    }
        //    else
        //    {
        //        Console.WriteLine("O número {0} não existe no vetor...", busca);
        //    }
        //}


        //QUESTAO 13

        //static void Main(string[] args)
        //{
        //    int[] numeros = new int[100];
        //    int dois = 0, quatro = 0, oito = 0;

        //    Console.WriteLine("Digite -1 ou 100 números para encerrar o programa");

        //    for (int i = 0; i < numeros.Length; i++)
        //    {

        //        Console.Write("Digite um número: ");
        //        numeros[i] = int.Parse(Console.ReadLine());

        //        if (numeros[i] == -1)
        //        {
        //            break;
        //        }

        //        if (numeros[i] == 2) { dois++; }
        //        if (numeros[i] == 4) { quatro++; }
        //        if (numeros[i] == 8) { oito++; }
        //    }

        //    Console.Clear();

        //    Console.WriteLine("O número 2 apareceu {0} vezes.", dois);
        //    Console.WriteLine("O número 4 apareceu {0} vezes.", quatro);
        //    Console.WriteLine("O número 8 apareceu {0} vezes.", oito);
        //}

        //QUESTAO 14

        //static void Main(string[] args)
        //{

        //    int codigo = 0, numeros = 0;
        //    int[] vetor = new int[50];

        //    for (int i = 0; i < vetor.Length; i++)
        //    {
        //        Console.Clear();
        //        Console.WriteLine("0: Encerra o programa");
        //        Console.WriteLine("1: Encerra o programa e mostra os números na ordem que foram digitadas");
        //        Console.WriteLine("2: Encerra o programa e mostra os números na ordem inversa que foram digitados");
        //        Console.WriteLine("Digite o número desejado para prosseguir");
        //        Console.Write("\nDigite o código: ");
        //        codigo = int.Parse(Console.ReadLine());

        //        if (codigo == 0 || codigo == 1 || codigo == 2) { break; }
        //        else
        //        {
        //            Console.Write("Digite um número para a posição {0} do vetor: ", i);
        //            vetor[i] = int.Parse(Console.ReadLine());
        //            numeros++;
        //        }
        //    }

        //    if (codigo == 1)
        //    {
        //        Console.Clear();

        //        Console.Write("\nNúmeros na ordem digitada: ");
        //        for (int i = 0; i < numeros; i++)
        //        {
        //            Console.Write(vetor[i] + " ");
        //        }
        //    }

        //    if (codigo == 2)
        //    {
        //        Console.Clear();

        //        Console.Write("\nNúmeros na ordem inversa: ");
        //        for (int i = numeros - 1; i >= 0; i--)
        //        {
        //            Console.Write(vetor[i] + " ");
        //        }
        //    }
        //}

        //QUESTAO 15

        //static void Main(string[] args)
        //{

        //    int[] vetor = new int[20], vetorInvert = new int[20];

        //    for (int i = 0; i < vetor.Length; i++)
        //    {
        //        Console.Write("Informe o valor {0} do vetor: ");
        //        vetor[i] = int.Parse(Console.ReadLine());

        //        vetorInvert[19 - i] = vetor[i];
        //    }
        //    Console.Clear();

        //    Console.Write("\nConteúdo do vetor: ");

        //    for (int i = 0; i < vetor.Length; i++)
        //    {
        //        Console.Write("{0} ", vetor[i]);
        //    }

        //    Console.Write("\nConteúdo do vetor em ordem invertida: ");

        //    for (int i = 0; i < vetorInvert.Length; i++)
        //    {
        //        Console.Write("{0} ", vetorInvert[i]);
        //    }
        //    Console.WriteLine("");
        //}

        //QUESTAO 16

        //        static void Main(string[] args)
        //        {
        //            int[] x = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //            int[] y = new int[10] { 1, 6, 30, 4, 5, 60, 7, 9, 10, 11 };

        //            int[] uniao = new int[20];
        //            int[] diferenca = new int[20];
        //            int[] intersecao = new int[10];

        //            Console.WriteLine("UNIÃO");

        //            x.CopyTo(uniao, 0);
        //            int auxU = 10;

        //            for (int i = 0; i < y.Length; i++)
        //            {
        //                for (int j = 0; j < x.Length; j++)
        //                {
        //                    if (y[i] == x[j])
        //                    {
        //                        break;
        //                    }

        //                    if (j == (x.Length - 1))
        //                    {
        //                        uniao[auxU] = y[i];
        //                        auxU++;
        //                    }
        //                }
        //            }

        //            for (int i = 0; i < auxU; i++)
        //            {
        //                Console.WriteLine(uniao[i]);
        //            }

        //            Console.WriteLine("");

        //            Console.WriteLine("DIFERENÇA");

        //            int auxD = 0;

        //            for (int i = 0; i < x.Length; i++)
        //            {
        //                for (int j = 0; j < y.Length; j++)
        //                {
        //                    if (x[i] == y[j])
        //                    {
        //                        break;
        //                    }

        //                    if (j == (y.Length - 1))
        //                    {
        //                        diferenca[auxD] = x[i];
        //                        auxD++;
        //                    }
        //                }
        //            }

        //            for (int i = 0; i < auxD; i++)
        //            {
        //                Console.WriteLine(diferenca[i]);
        //            }

        //            Console.WriteLine("");

        //            Console.WriteLine("INTERSEÇÃO");

        //            int auxI = 0;

        //            for (int i = 0; i < x.Length; i++)
        //            {
        //                for (int j = 0; j < y.Length; j++)
        //                {
        //                    if (x[i] == y[j])
        //                    {
        //                        intersecao[auxI] = x[i];
        //                        auxI++;
        //                        break;
        //                    }
        //                }
        //            }

        //            for (int i = 0; i < auxI; i++)
        //            {
        //                Console.WriteLine(intersecao[i]);
        //            }

        //        }
        //    }
        //}

        // -------------------------------------------------------------

        //LISTA 5

        //QUESTÃO 1


        //static void Main(string[] args)
        //{
        //    int[,] matriz = new int[5, 3];

        //    for (int i = 0; i < 5; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {
        //            Console.WriteLine("Dê um valor para a posição " + i + " - " + j + " da matriz:");
        //            matriz[i, j] = int.Parse(Console.ReadLine());
        //        }
        //    }

        //    for (int i = 0; i < 5; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {
        //            Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + "  ");
        //        }
        //        Console.WriteLine();
        //    }
        //}
        //QUESTÃO 2

        //static void Main(string[] args)
        //{
        //    int[,] matriz = new int[3, 3];

        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {
        //            Console.WriteLine("Dê um valor para a posição " + i + " - " + j + " da matriz:");
        //            matriz[i, j] = int.Parse(Console.ReadLine());
        //        }
        //    }

        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {
        //            Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + "  ");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //QUESTÃO 3

        //static void Main(string[] args)
        //{
        //    int[,] matriz = new int[4, 4];
        //    Random numA = new Random();


        //    for (int i = 0; i < matriz.GetLength(1); i++)
        //    {
        //        for (int j = 0; j < matriz.GetLength(1); j++)
        //        {
        //            matriz[i, j] = numA.Next(-50, 50);
        //            Console.Write(matriz[i, j] + " ");

        //        }
        //        Console.WriteLine("");
        //    }

        //    Console.WriteLine("\n" + (" [ ") + (matriz[0, 0]) + ("|") + (matriz[1, 1]) + ("|") + (matriz[2, 2]) + ("|") + ((matriz[3, 3]) + ("|") + (" ] ")));
        //}

        //QUESTÃO 4
        //static void Main(string[] args)
        //{
        //    int[,] matriz = new int[5, 5];
        //    Random r = new Random();

        //    for (int i = 0; i < matriz.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matriz.GetLength(0); j++)
        //        {
        //            matriz[i, j] = r.Next(-50, 50);
        //            Console.Write(" [ " + matriz[i, j] + " ] ");

        //        }
        //           Console.WriteLine("");

        //      }


        //     }

        //QUESTÃO 5

        //static void Main(string[] args)
        //{
        //    double[,] matrizA = new double[2, 3], matrizB = new double[2, 3], matrizC = new double[2, 3];
        //    for (int i = 0; i < matrizA.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrizA.GetLength(1); j++)
        //        {
        //            Console.Write("Informe o valor [{0},{1}] da Matriz A: ", i, j);
        //            matrizA[i, j] = double.Parse(Console.ReadLine());
        //        }
        //    }
        //    Console.WriteLine();
        //    for (int i = 0; i < matrizB.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrizB.GetLength(1); j++)
        //        {
        //            Console.Write("Informe o valor [{0},{1}] da Matriz B: ", i, j);
        //            matrizB[i, j] = double.Parse(Console.ReadLine());
        //        }
        //    }
        //    for (int i = 0; i < matrizA.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrizA.GetLength(1); j++)
        //        {
        //            matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
        //        }
        //    }
        //    Console.WriteLine("Soma dos valores: ");
        //    for (int i = 0; i < matrizC.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrizC.GetLength(1); j++)
        //        {
        //            Console.Write(matrizC[i, j] + " ");
        //        }
        //    }

        //}


        //QUESTAO 6

        //static void Main(string[] args)
        //{

        //    int[,] M = new int[4, 4];
        //    Random random = new Random();
        //    int maior = 0;
        //    for (int i = 0; i < M.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < M.GetLength(1); j++)
        //        {
        //            M[i, j] = random.Next(0, 100);
        //        }
        //    }
        //    for (int i = 0; i < M.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < M.GetLength(1); j++)
        //        {
        //            if (M[i, j] > maior)
        //            {
        //                maior = M[i, j];
        //            }
        //            Console.WriteLine("[{0},{1}]: {2}", i, j, M[i, j]);
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine("O maior valor da matriz M é " + maior);
        //}

        //QUESTAO 7

        //static void Main(string[] args)
        //{

        //    Random random = new Random();   //usando Random para não precisar digitar...
        //    int[,] matrizA = new int[2, 3], matrizB = new int[2, 3], matrizC = new int[2, 3];

        //    for (int i = 0; i < matrizA.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrizA.GetLength(1); j++)
        //        {
        //            //Console.Write("Informe o valor [{0},{1}] da Matriz A: ", i, j);
        //            //matrizA[i, j] = int.Parse(Console.ReadLine());
        //            matrizA[i, j] = random.Next(0, 20);
        //            Console.WriteLine("[{0},{1}]: {2}", i, j, matrizA[i, j]);
        //        }
        //        Console.WriteLine();
        //    }

        //    for (int i = 0; i < matrizB.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrizB.GetLength(1); j++)
        //        {
        //            //Console.Write("Informe o valor [{0},{1}] da Matriz B: ", i, j);
        //            //matrizB[i, j] = int.Parse(Console.ReadLine());
        //            matrizB[i, j] = random.Next(0, 20);
        //            Console.WriteLine("[{0},{1}]: {2}", i, j, matrizB[i, j]);
        //        }
        //        Console.WriteLine();
        //    }
        //    for (int i = 0; i < matrizA.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrizA.GetLength(1); j++)
        //        {
        //            matrizC[i, j] = matrizA[i, j] - matrizB[i, j];
        //        }
        //    }
        //    Console.WriteLine("Subtração dos valores: ");
        //    for (int i = 0; i < matrizC.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrizC.GetLength(1); j++)
        //        {
        //            Console.Write(matrizC[i, j] + " ");
        //        }
        //    }
        //}

        //QUESTAO 8

        //static void Main(string[] args)
        //{

        //    Random random = new Random();   //usando Random para não precisar digitar...
        //    int[,] matriz = new int[4, 4];

        //    Console.WriteLine("==== Lista na ordem digitada ====");

        //    for (int i = 0; i < matriz.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matriz.GetLength(1); j++)
        //        {
        //            //Console.Write("Informe o valor [{0},{1}] da Matriz A: ", i, j);
        //            //matrizA[i, j] = int.Parse(Console.ReadLine());
        //            matriz[i, j] = random.Next(0, 20);
        //            Console.WriteLine("[{0},{1}]: {2}", i + 1, j + 1, matriz[i, j]);
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine("==== Lista na ordem invertida ====");

        //    for (int i = matriz.GetLength(0) - 1; i >= 0; i--)
        //    {
        //        for (int j = matriz.GetLength(1) - 1; j >= 0; j--)
        //        {
        //            Console.WriteLine("[{0},{1}]: {2}", i + 1, j + 1, matriz[i, j]);
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //QUESTAO 9

        //static void Main(string[] args)
        //{
        //    Random random = new Random();   //usando Random para não precisar digitar...
        //    int[,] matriz = new int[3, 3];
        //    int numeroSelecionado = random.Next(0, 20);
        //    bool numeroExiste = false;

        //    Console.WriteLine("Número selecionado: {0}\n", numeroSelecionado);

        //    for (int i = 0; i < matriz.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matriz.GetLength(1); j++)
        //        {
        //            //Console.Write("Informe o valor [{0},{1}] da Matriz A: ", i, j);
        //            //matrizA[i, j] = int.Parse(Console.ReadLine());
        //            matriz[i, j] = random.Next(0, 20);
        //            Console.WriteLine("[{0},{1}]: {2}", i + 1, j + 1, matriz[i, j]);
        //        }
        //        Console.WriteLine();
        //    }

        //    for (int i = 0; i < matriz.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matriz.GetLength(1); j++)
        //        {
        //            if (matriz[i, j] == numeroSelecionado)
        //            {
        //                numeroExiste = true;
        //                break;
        //            }
        //            else
        //            {
        //                numeroExiste = false;
        //            }
        //        }
        //    }

        //    if (numeroExiste)
        //    {
        //        Console.WriteLine("O número existe no vetor");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Número inexistente");
        //    }
        //}

        //QUESTAO 10

        //static void Main(string[] args)
        //{
        //    Random random = new Random();   //usando Random para não precisar digitar...
        //    int[,] matrizA = new int[4, 4], matrizB = new int[4, 4];
        //    int mediaA = 0, mediaB = 0, abaixoA = 0, abaixoB = 0, acimaA = 0, acimaB = 0, naMediaA = 0, naMediaB = 0;

        //    Console.WriteLine("Elementos da Matriz A:");
        //    for (int i = 0; i < matrizA.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrizA.GetLength(1); j++)
        //        {
        //            //Console.Write("Informe o valor [{0},{1}] da Matriz A: ", i, j);
        //            //matrizA[i, j] = int.Parse(Console.ReadLine());
        //            matrizA[i, j] = random.Next(0, 20);
        //            Console.WriteLine("[{0},{1}]: {2}", i + 1, j + 1, matrizA[i, j]);
        //            mediaA += matrizA[i, j];
        //        }
        //        Console.WriteLine();
        //    }

        //    Console.WriteLine("Elementos da Matriz B:");
        //    for (int i = 0; i < matrizB.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrizB.GetLength(1); j++)
        //        {
        //            //Console.Write("Informe o valor [{0},{1}] da Matriz A: ", i, j);
        //            //matrizB[i, j] = int.Parse(Console.ReadLine());
        //            matrizB[i, j] = random.Next(0, 20);
        //            Console.WriteLine("[{0},{1}]: {2}", i + 1, j + 1, matrizB[i, j]);
        //            mediaB += matrizB[i, j];
        //        }
        //        Console.WriteLine();
        //    }

        //    mediaA /= 16;
        //    mediaB /= 16;

        //    for (int i = 0; i < matrizA.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrizA.GetLength(1); j++)
        //        {
        //            //verifica os elementos da MatrizA
        //            if (matrizA[i, j] == mediaA)
        //            {
        //                naMediaA++;
        //            }
        //            else if (matrizA[i, j] > mediaA)
        //            {
        //                acimaA++;
        //            }
        //            else if (matrizA[i, j] < mediaA)
        //            {
        //                abaixoA++;
        //            }
        //            //verifica os elementos da MatrizB
        //            if (matrizB[i, j] == mediaB)
        //            {
        //                naMediaB++;
        //            }
        //            else if (matrizB[i, j] > mediaB)
        //            {
        //                acimaB++;
        //            }
        //            else if (matrizB[i, j] < mediaB)
        //            {
        //                abaixoB++;
        //            }
        //        }
        //    }

        //    Console.WriteLine("/////////////////////////////////////////////////");
        //    Console.WriteLine("Média da Matriz A: " + mediaA);
        //    Console.WriteLine("Média da Matriz B: " + mediaB);
        //    Console.WriteLine("\nElementos na média na Matriz A: " + naMediaA);
        //    Console.WriteLine("Elementos na média na Matriz B: " + naMediaB);
        //    Console.WriteLine("\nElementos na acima da média na Matriz A: " + acimaA);
        //    Console.WriteLine("Elementos na acima da média na Matriz B: " + acimaB);
        //    Console.WriteLine("\nElementos na abaixo da média na Matriz A: " + acimaA);
        //    Console.WriteLine("Elementos na abaixo da média na Matriz B: " + acimaB);
        //    Console.WriteLine("//////////////////////////////////////////////////");

        //}

        //QUESTAO 11

        //static void Main(string[] args)
        //{

        //    Random random = new Random();   //usando Random para não precisar digitar...
        //    double[,] matrizA = new double[3, 3], matrizResult = new double[3, 3];
        //    string excesoes = "";

        //    Console.WriteLine("Matriz A:\n");

        //    for (int i = 0; i < matrizA.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrizA.GetLength(1); j++)
        //        {
        //            //Console.Write("Informe o valor [{0},{1}] da Matriz A: ", i, j);
        //            //matrizA[i, j] = double.Parse(Console.ReadLine());
        //            matrizA[i, j] = random.Next(0, 20);
        //            Console.Write("[{0},{1}]: {2} ", i + 1, j + 1, matrizA[i, j]);

        //            if (matrizA[i, j] == 0 || (i + j) == 0)
        //            {
        //                excesoes += "O elemento [" + i + "," + j + "] não pode ser dividido por ser zero\n";
        //                matrizA[i, j] = 0;
        //            }
        //            else
        //            {
        //                matrizResult[i, j] = matrizA[i, j] / (i + j);
        //            }
        //            Console.WriteLine();
        //        }
        //    }

        //    Console.WriteLine("\nMatriz resultante:\n");

        //    for (int i = 0; i < matrizA.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrizA.GetLength(1); j++)
        //        {
        //            Console.Write("[{0},{1}] = {2:F} ", i, j, matrizResult[i, j]);
        //        }
        //        Console.WriteLine();
        //    }

        //    Console.WriteLine("\n" + excesoes);
        //}

        //QUESTAO 12

        //static void Main(string[] args)
        //{

        //    Random random = new Random();   //usando Random para não precisar digitar...
        //    int[,] matriz = new int[4, 3];

        //    Console.WriteLine("Valores digitados da Matriz:\n");
        //    for (int i = 0; i < matriz.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matriz.GetLength(1); j++)
        //        {
        //            //Console.Write("Informe o valor [{0},{1}] da Matriz: ", i, j);
        //            //matriz[i, j] = int.Parse(Console.ReadLine());
        //            matriz[i, j] = random.Next(0, 20);
        //            Console.Write("[{0},{1}]: {2} ", i + 1, j + 1, matriz[i, j]);
        //        }
        //        Console.WriteLine();
        //    }

        //    Console.WriteLine("\nValores da Matriz cujo índices são pares:\n");
        //    for (int i = 0; i < matriz.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matriz.GetLength(1); j++)
        //        {
        //            if ((i + j) % 2 == 0)
        //            {
        //                Console.Write("[{0},{1}]: {2} ", i + 1, j + 1, matriz[i, j]);
        //            }
        //        }
        //    }
        //}

        //QUESTAO 13

        //static void Main(string[] args)
        //{
        //    Random random = new Random();   //usando Random para não precisar digitar...
        //    int[,] matriz = new int[5, 5];
        //    int diagonalPrincipal = 0, diagonalSecundaria = 0;

        //    Console.WriteLine("Valores digitados da Matriz:\n");
        //    for (int i = 0; i < matriz.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matriz.GetLength(1); j++)
        //        {
        //            //Console.Write("Informe o valor [{0},{1}] da Matriz: ", i, j);
        //            //matriz[i, j] = int.Parse(Console.ReadLine());
        //            matriz[i, j] = random.Next(0, 20);
        //            Console.Write("[{0},{1}]: {2} ", i + 1, j + 1, matriz[i, j]);

        //            if (i == j) { diagonalPrincipal += matriz[i, j]; }
        //            if ((i + j) == matriz.GetLength(0) - 1) { diagonalSecundaria += matriz[i, j]; }
        //        }
        //        Console.WriteLine();
        //    }

        //    Console.WriteLine();
        //    if (diagonalPrincipal == diagonalSecundaria)
        //    {
        //        Console.WriteLine("A soma dos elementos da diagonal principal é igual a diagonal secundária.");
        //        Console.WriteLine("Diagonal principal: " + diagonalPrincipal);
        //        Console.WriteLine("Diagonal secundária: " + diagonalSecundaria);
        //    }
        //    else
        //    {
        //        Console.WriteLine("A soma dos elementos da diagonal principal não é igual a diagonal secundária.");
        //        Console.WriteLine("Diagonal principal: " + diagonalPrincipal);
        //        Console.WriteLine("Diagonal secundária: " + diagonalSecundaria);
        //    }
        //}

        //QUESTAO 14 

        //static void Main(string[]args)
        //{

        //    Random random = new Random();   //usando Random para não precisar digitar...
        //    int[,] matriz = new int[5, 5];
        //    bool Igual = false;

        //    Console.WriteLine("Valores digitados da Matriz:\n");
        //    for (int i = 0; i < matriz.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matriz.GetLength(1); j++)
        //        {
        //            //Console.Write("Informe o valor [{0},{1}] da Matriz: ", i, j);
        //            //matriz[i, j] = int.Parse(Console.ReadLine());
        //            matriz[i, j] = random.Next(0, 20);
        //            Console.Write("[{0},{1}]: {2} ", i, j, matriz[i, j]);
        //        }
        //        Console.WriteLine();
        //    }

        //    for (int i = 0; i < matriz.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matriz.GetLength(1); j++)
        //        {
        //            if (i == j)
        //            {
        //                if (matriz[i, j] == matriz[i, (matriz.GetLength(0) - 1) - i])
        //                {
        //                    Igual = true;
        //                }
        //                else
        //                {
        //                    Igual = false;
        //                    break;
        //                }
        //            }
        //        }
        //    }

        //    if (Igual)
        //    {
        //        Console.WriteLine("\nOs elementos da diagonal principal são iguais da diagonal secundária!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("\nOs elementos da diagonal principal Não são iguais da diagonal secundária...");
        //    }
        //}

        //QUESTAO 15
        //static void Main(string[] args)
        //{
        //    Random random = new Random();   //usando Random para não precisar digitar...
        //    int[,] matrizA = new int[4, 4], matrizB = new int[4, 4];

        //    Console.WriteLine("Valores digitados da Matriz A:\n");
        //    for (int i = 0; i < matrizA.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrizA.GetLength(1); j++)
        //        {
        //            //Console.Write("Informe o valor [{0},{1}] da Matriz: ", i, j);
        //            //matrizA[i, j] = int.Parse(Console.ReadLine());
        //            matrizA[i, j] = random.Next(0, 20);
        //            Console.Write("[{0},{1}]: {2} ", i, j, matrizA[i, j]);
        //        }
        //        Console.WriteLine();
        //    }

        //    Console.WriteLine("\nValores digitados da Matriz B:\n");
        //    for (int i = 0; i < matrizB.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrizB.GetLength(1); j++)
        //        {
        //            //Console.Write("Informe o valor [{0},{1}] da Matriz: ", i, j);
        //            //matrizB[i, j] = int.Parse(Console.ReadLine());
        //            matrizB[i, j] = random.Next(0, 20);
        //            Console.Write("[{0},{1}]: {2} ", i, j, matrizB[i, j]);
        //        }
        //        Console.WriteLine();
        //    }

        //    Console.WriteLine("\nSoma das Matrizes:\n");
        //    for (int i = 0; i < matrizA.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrizA.GetLength(1); j++)
        //        {
        //            Console.WriteLine("MatrizA[{0},{1}] + MatrizB[{0},{1}] = {2} ", i, j, (matrizA[i, j] + matrizB[i, j]));
        //        }
        //    }
        //}

        //QUESTAO 16 

        //static void Main(string[] args)
        //{

        //    Random random = new Random();   //usando Random para não precisar digitar...
        //    int[,] matrizA = new int[3, 4], matrizP = new int[4, 3];

        //    Console.WriteLine("Valores digitados da Matriz:\n");
        //    for (int i = 0; i < matrizA.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrizA.GetLength(1); j++)
        //        {
        //            Console.Write("Informe o valor [{0},{1}] da Matriz: ", i, j);
        //            matrizA[i, j] = int.Parse(Console.ReadLine());
        //            matrizA[i, j] = random.Next(0, 20);
        //            Console.Write("[{0},{1}]: {2} ", i, j, matrizA[i, j]);
        //        }
        //        Console.WriteLine();
        //    }

        //    Console.WriteLine("\nValores Transportados:\n");
        //    for (int i = 0; i < matrizP.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrizP.GetLength(1); j++)
        //        {
        //            matrizP[i, j] = matrizA[j, i];
        //            Console.Write("[{0},{1}]: {2} ", i, j, matrizP[i, j]);
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //QUESTAO 17

        //        static void Main(string[] args)
        //        {

        //            Random random = new Random();   //usando Random para não precisar digitar...
        //            int[,] matriz = new int[10, 10];
        //            int maior = 0, menor = 1000000000, linhaMaior = 0, colunaMaior = 0, colunaMenor = 0;

        //            Console.WriteLine("Valores digitados da Matriz:");
        //            Console.WriteLine("=============================================================\n");
        //            for (int i = 0; i < matriz.GetLength(0); i++)
        //            {
        //                for (int j = 0; j < matriz.GetLength(1); j++)
        //                {
        //                    //Console.Write("Informe o valor [{0},{1}] da Matriz: ", i, j);
        //                    //matriz[i, j] = int.Parse(Console.ReadLine());
        //                    matriz[i, j] = random.Next(0, 100);
        //                    Console.Write("[{0},{1}]: {2} ", i, j, matriz[i, j]);
        //                }
        //                Console.WriteLine();
        //            }

        //            // Buscando o  maior...
        //            for (int i = 0; i < matriz.GetLength(0); i++)
        //            {
        //                for (int j = 0; j < matriz.GetLength(1); j++)
        //                {
        //                    if (matriz[i, j] > maior)
        //                    {
        //                        maior = matriz[i, j];
        //                        linhaMaior = i;
        //                        colunaMaior = j;
        //                    }
        //                }
        //            }

        //            //Buscando o menor...
        //            for (int i = 0; i < matriz.GetLength(1); i++)
        //            {
        //                if (matriz[linhaMaior, i] < menor)
        //                {
        //                    menor = matriz[linhaMaior, i];
        //                    colunaMenor = i;
        //                }
        //            }

        //            Console.WriteLine("=============================================================\n");
        //            Console.WriteLine("O maior elemento é o {0} e está na posição [{1},{2}] do vetor", maior, linhaMaior, colunaMaior);
        //            Console.WriteLine("O menor elemento da linha {0} é o {1} e está na coluna {2}", linhaMaior, menor, colunaMenor);

        //        }
        //    }
        //}
        // -------------------------- LISTA 6 ---------------
        //QUESTÃO 1
        //static void Main(string[] args)

        //{
        //    List<string> nomesP = new List<string>();
        //    string nomeComp;
        //    int seletor;
        //    string[] dadosNome;

        //    do
        //    {
        //        do
        //        {
        //            Console.WriteLine("Digite o nome completo para continuar ou digite 'sair' para sair.: ");
        //            nomeComp = Console.ReadLine().ToUpper();
        //            dadosNome = nomeComp.Split(" ");
        //        } while (nomeComp.Length <= 1);
        //        if (nomeComp == "sair")
        //        {
        //            break;
        //        }
        //        if (nomesP.Contains(nomeComp))
        //        {
        //            Console.WriteLine("Nome já cadastrado!");
        //        }
        //        else { nomesP.Add(nomeComp); 
        //        }            
        //    } while (true);
        //    Console.WriteLine(nomesP);
        //}

        //QUESTÃO 2
        //static void Main(string[] args)
        //{
        //    Random numAleatorio = new Random();
        //    List<int> num = new List<int>();
        //    int[,] rand = new int[5, 5];

        //    for (int i = 0; i < rand.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < rand.GetLength(1); j++)
        //        {
        //            rand[i, j] = numAleatorio.Next(0, 1000);
        //            Console.Write(" [ " + rand[i, j] + " ] ");
        //        }
        //        Console.WriteLine(" ");
        //    }

        //}

        //QUESTÃO 3



        //static void Main(string[] args)
        //{
        //    int op;
        //    List<string> emails = new List<string>();
        //    do
        //    {
        //        Console.Clear();
        //        Console.WriteLine(">>---- CONTROLE DE E-MAILS: ----<<");
        //        Console.WriteLine(">>---- SELECIONE A OPÇÃO E PRESSIONE ENTER ----<<");
        //        Console.WriteLine("1 - CADASTRAR.");
        //        Console.WriteLine("2 - LISTAR.");
        //        Console.WriteLine("3 - SAIR.");
        //        op = int.Parse(Console.ReadLine());

        //        if (op == 3)
        //        {
        //            break;
        //        }


        //        if (op == 1)
        //        {
        //            string nomeEmail = " ";

        //            Console.Clear();
        //            Console.WriteLine(">>---- CADASTRO DE E-MAILS ----<<");
        //            Console.WriteLine(">>---- DIGITE O E-MAIL E PRESSIONE ENTER ----<<");
        //            Console.WriteLine("ENDEREÇO DE E-MAILS:");
        //            nomeEmail = Console.ReadLine();

        //            if (emails.Contains(nomeEmail))
        //            {
        //                Console.WriteLine("O E-MAIL JÁ ESTÁ CADASTRADO!");
        //                Console.ReadKey();
        //            }
        //            else
        //            {
        //                emails.Add(nomeEmail);
        //                Console.WriteLine("E-MAIL CADASTRADO COM SUCESSO!");
        //                Console.ReadKey();
        //                Console.WriteLine("PRESSIONE ENTER PARA CONTINUAR.");
        //            }
        //            if (op == 2)
        //            {
        //                Console.WriteLine(nomeEmail);
        //            }

        //        }


        //    } while (true);



        //}
        //QUESTAO 4

        //static void Main(string[] args)
        //{
        //    List<string> cripto = new List<string>();
        //    int opcao = 0, indice = 0;
        //    string criptoDigit, updateCripto;
        //    char opcaoAtualiza;

        //    do
        //    {
        //        Console.WriteLine("==== Menu ====\n");
        //        Console.WriteLine("1 - Cadastrar criptomoeda");
        //        Console.WriteLine("2 - Listar criptomoedas");
        //        Console.WriteLine("3 - Remover criptomoeda");
        //        Console.WriteLine("4 - Sair");
        //        Console.Write("\nEscolha uma opção: ");
        //        opcao = int.Parse(Console.ReadLine());

        //        if (opcao == 1)
        //        {
        //            Console.Clear();
        //            Console.Write("\nCadastre a criptomoeda desejada (ou 'cancelar' para desistir): ");
        //            criptoDigit = Console.ReadLine().ToUpper();

        //            if (criptoDigit == "cancelar" || criptoDigit == "CANCELAR")
        //            {
        //                Console.WriteLine("\nOperação cancelada\n");
        //            }
        //            else
        //            {

        //                if (criptoDigit.Length < 4)
        //                {
        //                    Console.Clear();
        //                    Console.WriteLine("É necessário informar apenas o nome da criptomoeda.\nVocê inseriu um valor com apenas {0} caracteres.\nÉ necessário ao menos 4 caracteres.\n", criptoDigit.Length);
        //                }
        //                else
        //                {
        //                    if (cripto.Contains(criptoDigit))
        //                    {
        //                        Console.Write("\nCriptomoeda já cadastrada! Deseja atualizar? (s)im ou (n)ão? ");
        //                        opcaoAtualiza = char.Parse(Console.ReadLine());
        //                        Console.WriteLine();

        //                        if (opcaoAtualiza == 's' || opcaoAtualiza == 'S')
        //                        {
        //                            indice = cripto.IndexOf(criptoDigit);
        //                            Console.Clear();

        //                            do
        //                            {
        //                                Console.Write("Qual o novo nome para '{0}' (ou 'cancelar' para não atualizar)? ", criptoDigit);
        //                                updateCripto = Console.ReadLine().ToUpper();
        //                                Console.WriteLine();

        //                                if (updateCripto == "cancelar" || updateCripto == "CANCELAR")
        //                                {
        //                                    break;
        //                                }

        //                                if (updateCripto.Length < 4)
        //                                {
        //                                    Console.WriteLine("\nO novo nome da criptomoeda '{0}' não pode ser menor que 4 caracteres!\n", criptoDigit);
        //                                }

        //                                if (updateCripto == criptoDigit)
        //                                {
        //                                    Console.WriteLine("O nome da nova moeda não pode ser igual a anterior\n");
        //                                }

        //                                if ((updateCripto.Length > 3 || updateCripto != criptoDigit) && (updateCripto != "cancelar" || updateCripto != "CANCELAR"))
        //                                {
        //                                    cripto[indice] = updateCripto;
        //                                }
        //                            }
        //                            while (updateCripto.Length < 4 || updateCripto == criptoDigit);
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Console.Clear();
        //                        cripto.Add(criptoDigit);
        //                        Console.WriteLine("'{0}' cadastrada!\n", criptoDigit);
        //                    }
        //                }
        //            }
        //        }

        //        if (opcao == 2)
        //        {
        //            Console.Clear();
        //            if (cripto.Count < 1)
        //            {
        //                Console.WriteLine("Nenhuma criptomoeda foi cadastrada...\n");
        //            }
        //            else
        //            {
        //                cripto.Sort();

        //                Console.WriteLine("== Criptomoedas cadastradas ==\n");

        //                foreach (string cript in cripto)
        //                {
        //                    Console.WriteLine(cript);
        //                }
        //                Console.WriteLine();
        //            }
        //        }

        //        if (opcao == 3)
        //        {
        //            Console.Clear();
        //            if (cripto.Count < 1)
        //            {
        //                Console.WriteLine("Nenhuma criptomoeda foi cadastrada ainda...\n");
        //            }
        //            else
        //            {
        //                do
        //                {
        //                    Console.Write("Qual criptomoeda deseja remover? ('cancelar' para não remover) ");
        //                    updateCripto = Console.ReadLine().ToUpper();
        //                    Console.WriteLine();

        //                    if (updateCripto == "cancelar" || updateCripto == "CANCELAR")
        //                    {
        //                        break;
        //                    }

        //                    if (updateCripto.Length < 4)
        //                    {
        //                        Console.WriteLine("\nO nome da criptomoeda '{0}' não pode ser menor que 4 caracteres!\n", updateCripto);
        //                    }

        //                    if (cripto.Contains(updateCripto))
        //                    {
        //                        cripto.Remove(updateCripto);
        //                        Console.WriteLine("\nCriptomoeda '{0}' removida com sucesso!\n", updateCripto);
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("\nA moeda '{0}' não está na lista. Tente novamente.\n", updateCripto);
        //                    }
        //                }
        //                while (updateCripto.Length < 4);
        //            }
        //        }
        //    }
        //    while (opcao != 4);
        //}

        //QUESTAO 5

        //static void Main(string[] args)
        //{
        //    Random random = new Random();
        //    List<int> lista1 = new List<int>(), lista2 = new List<int>();
        //    int quant;

        //    Console.Write("Quantos números deseja gerar? ");
        //    quant = int.Parse(Console.ReadLine());

        //    for (int i = 0; i < quant; i++)
        //    {
        //        lista1.Add(random.Next(100, 200));
        //        lista2.Add(random.Next(100, 200));
        //    }

        //    Console.WriteLine("Lista 1\n");

        //    foreach (int i in lista1) { Console.WriteLine(i); }

        //    Console.WriteLine("\nLista 2\n");

        //    foreach (int i in lista2) { Console.WriteLine(i); }

        //    Console.Write("\nNúmeros que pertencem as duas listas: ");
        //    // aproveitando o quant...
        //    quant = 0;

        //    for (int i = 0; i < quant; i++)
        //    {
        //        for (int j = 0; j < lista1.Count; j++)
        //        {
        //            if (lista1[i] == lista2[j])
        //            {
        //                Console.Write(lista1[i] + ", ");
        //                quant++;
        //            }
        //        }
        //    }

        //    if (quant == 0)
        //    {
        //        Console.Write("Nenhum.");
        //    }

        //    Console.WriteLine();
        //}

        //QUESTAO 6

        //        static void Main(string[] args)
        //        {

        //            List<string> nomes = new List<string>(), sobrenomes = new List<string>();
        //            List<int> mesmaFamilia = new List<int>();
        //            string nome, sobrenome = "";
        //            string[] valida;

        //            do
        //            {
        //                Console.WriteLine("*** Sistema de cadastro de nomes ***");
        //                Console.Write("\nCadastre um nome ou 'sair' para encerrar: ");
        //                nome = Console.ReadLine().ToUpper();

        //                if (nome == "SAIR")
        //                {
        //                    break;
        //                }

        //                valida = nome.Split(" ");

        //                for (int i = 1; i < valida.Length; i++)
        //                {
        //                    if (valida[i] != "DA" && valida[i] != "DAS" && valida[i] != "DE" && valida[i] != "DO" && valida[i] != "DOS" && valida[i] != "DU")
        //                    {
        //                        sobrenome += " " + valida[i];
        //                    }
        //                }

        //                if (valida.Length > 1)
        //                {

        //                    if (nomes.Contains(nome))
        //                    {
        //                        Console.Clear();
        //                        Console.WriteLine("\nO nome '{0}' já está cadastrado na lista. Favor insira outro.", nome);
        //                    }
        //                    else
        //                    {

        //                        nomes.Add(valida[0]);
        //                        sobrenomes.Add(sobrenome);

        //                        Console.Clear();
        //                        Console.WriteLine("Nome cadastrado!\n");
        //                    }
        //                    sobrenome = "";
        //                }
        //                else
        //                {
        //                    Console.Clear();
        //                    Console.WriteLine("\nFavor insira seu nome completo. Você informou um nome com apenas {0} palavra\n", valida.Length);
        //                }
        //            }
        //            while (true);

        //            Console.Clear();

        //            Console.WriteLine("Cadastramos {0} nomes!\nExibindo os sobrenomes:\n", nomes.Count);

        //            foreach (string s in sobrenomes)
        //            {
        //                Console.WriteLine(s);
        //            }

        //            Console.WriteLine("\nPessoas da mesma família:");

        //            for (int i = 0; i < nomes.Count; i++)
        //            {
        //                for (int j = 0; j < sobrenomes.Count; j++)
        //                {
        //                    if (sobrenomes[i] == sobrenomes[j] && i != j)
        //                    {
        //                        if (!mesmaFamilia.Contains(i))
        //                        {
        //                            mesmaFamilia.Add(i);
        //                        }
        //                        if (!mesmaFamilia.Contains(j))
        //                        {
        //                            mesmaFamilia.Add(j);
        //                        }
        //                    }
        //                }
        //            }

        //            foreach (int m in mesmaFamilia)
        //            {
        //                Console.WriteLine(nomes[m] + sobrenomes[m]);
        //            }

        //        }
        //    }
        //}

    }

}











            