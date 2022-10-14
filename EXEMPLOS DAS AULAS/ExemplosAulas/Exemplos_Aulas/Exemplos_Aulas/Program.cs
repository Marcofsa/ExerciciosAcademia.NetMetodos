namespace Exemplos_Aulas_
{
    internal class Program
    {
        //EX1
        //static void Main(string[] args)

        //{
        //    int[] b = new int[5];
        //    b[0] = 2;
        //    b[2] = 5;
        //    b[1] = b[0] - b[2];
        //    b[3] = b[2] * b[2];
        //    b[4] = b[3] - 1;

        //    Console.WriteLine(b[0] + " " + b[1] + " " + b[2] + " " + b[3] + " " + b[4]);

        //}

        //EX2
        //static void Main(string[] args)

        //    {

        //        int i;
        //        int[] b = new int[5];

        //        Console.WriteLine("||------------- LEITURA DE VALORES ----------------||");

        //            for (i = 0; i < 5; i++) ;
        //        {
        //            Console.WriteLine("Digite o valor " + i + ": ");
        //            b[i] = int.Parse(Console.ReadLine());

        //        }

        //        for (i = 0; i < 5; i++) ;
        //        {
        //            Console.WriteLine("Valor índice " + i + "é igual a " + b[i]);

        //        }

        //    }


        //EX3

        //static void Main(string[] args)

        //{

        //    double[] notas = new double[3];
        //    double media;

        //    int i;

        //    Console.WriteLine("||---------------- LEITURA DOS VALORES -----------------||");

        //    for (i = 0; i <3; i++)
        //    {
        //        Console.WriteLine("Digite a nota do aluno " + i + ":");
        //        notas[i] = double.Parse(Console.ReadLine());

        //    }

        //    media = 0;

        //    Console.WriteLine("||----------- CÁLCULO DA MEDIA SENDO FEITO --------------||");
        //    Console.WriteLine("||----------------- POR FAVOR AGUARDE! ------------------||");
        //    Console.WriteLine("");
        //    for (i = 0; i < 3; i++)
        //    {
        //        media += notas[i];

        //    }
        //    media = media / 3;

        //    Console.WriteLine("||--------------------- MOSTRA A NOTA -------------------||");
        //    Console.WriteLine("A MÉDIA DAS NOTAS É IGUAL A: " + media);



        //}

        //EX4

        //static void Main(string[] args)

        //{
        //    int[] vetor = new int[10];
        //    int i, maior, pos;

        //    for (i = 0; i< 10; i++)
        //    {

        //        Console.WriteLine("Digite o valor do elemento " + i);
        //        vetor[i] = int.Parse(Console.ReadLine());
        //    }

        //    maior = vetor[0];
        //    pos = 0;

        //    for (i = 0; i < 10; i++)
        //    {

        //        if (vetor[i] > maior)
        //        {
        //            maior = vetor[i];
        //            pos = i;
        //        }
        //    }

        //    Console.WriteLine("O maior elemento é:" + maior + " e está na posição " + pos);
        //    Console.ReadKey();

        //}

        //EX5

        //static void Main(string[] args)
        //{
        //    int[] idade = new int[40];
        //    int i, conta = 0;
        //        Console.WriteLine("Informe as idades dos alunos da turma: ");
        //    for (i = 0; i < 40; i++) 
        //    {
        //        idade[i] = int.Parse(Console.ReadLine());
        //        if (idade[i] >= 18)
        //        {
        //            conta++;
        //        }
        //    }
        //    Console.WriteLine("Existem " + conta + "alunos  com idade maior ou igual a 18 anos de idade");
        //    for (i = 0; i < 40; i++) ;
        //    {

        //        if (idade[i] >= 18)
        //        {
        //            Console.WriteLine("Aluno "+i+" tem "+ idade[i]+ "anos de idade.");

        //        }
        //    }
        //}

        //EX6

        //static void Main(string[] args)

        //{
        //    int[] vetor = new int[10];
        //    int i, maior, pos, menor, posMenor;

        //    for (i = 0; i < 10; i++)
        //    {

        //        Console.WriteLine("Digite o valor do elemento " + i);
        //        vetor[i] = int.Parse(Console.ReadLine());
        //    }

        //    maior = vetor[0];
        //    pos = 0;

        //    for (i = 0; i < 10; i++)
        //    {

        //        if (vetor[i] > maior)
        //        {
        //            maior = vetor[i];
        //            pos = i;
        //        }
        //    }

        //    Console.WriteLine("O maior elemento é:" + maior + " e está na posição " + pos);

        //    menor = vetor[0];
        //    posMenor = 0;

        //    for (i = 0; i < 10; i++)
        //    {
        //        if (vetor[i] < menor)
        //        {
        //            menor = vetor[i];
        //            posMenor = i;

        //        }
        //    }
        //    Console.WriteLine("O maior elemento é:" + menor + " e está na posição " + posMenor);

        //    Console.ReadKey();

        //}

        //static void Main(string[] args)
        //{

        //    int[] vetorA = new int[10], vetorB = new int[10];
        //    int i, prod = 0;
        //    Console.WriteLine("Leitura dos elementos do vetor A:");
        //    for (i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine("Digite o elemento " + i + " do vetor A");
        //        vetorA[i] = int.Parse(Console.ReadLine());


        //    }
        //}

        //EX7 -----  UNIÃO
        //static void Main(string[] args)
        //{
        //    int[] x = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //    int[] y = new int[10] { 1, 6, 30, 4, 5, 60, 7, 9, 10, 11 };
        //    int[] uniao = new int[20];
        //    int[] diferenca = new int[10];
        //    int[] interseccao = new int[10];
        //    Console.WriteLine("UNIÃO");
        //    x.CopyTo(uniao, 0);
        //    int auxU = 10;
        //    //                        0  1  2  3  4  5  6  7  8   9
        //    //int[] x = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //    //int[] y = new int[10] { 1, 6,30, 4, 5,60, 7, 9,10, 11 };
        //    for (int i = 0; i < y.Length; i++)//elementos de x e elementos y que não estão em X
        //    {
        //        for (int j = 0; j < x.Length; j++)
        //        {
        //            if (x[i] == y[j])
        //            {
        //                break;
        //            }
        //            if (j == (x.Length - 1))
        //            {
        //                uniao[auxU] = y[i];
        //                auxU++;
        //            }
        //        }
        //    }
        //    for (int i = 0; i < auxU; i++)
        //    {
        //        Console.WriteLine(uniao[i]);
        //    }
        //    Console.WriteLine("");
        //}

        //EX8

        //static void Main(string[] args)
        //{

        //    int[] vetor = new int[5] { 10, 7, 3, 4, 2 };
        //    int aux = 0;
        //    //o vetor é percorrido com o uso de um laço auxiliar para a ordenação            for (int i = 0; i < 5; i++)
        //    {
        //        for (int j = 0; j < 4; j++)
        //        {
        //            //verifica se a valor atual é menor que o próximo valor                    if (vetor[j + 1] < vetor[j])
        //            {
        //                //inverte-se o valor caso a condição acima seja verdadeira                        aux = vetor[j];
        //                vetor[j] = vetor[j + 1];
        //                vetor[j + 1] = aux;
        //            }
        //        }
        //    }
        //    //mostra o vetor ordenado            for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine("vetor[" + i + "] = " + vetor[i]);
        //    }

        //}
        //EX9
        //static void Main(string[] args)
        //{
        //    int[,] matriz = new int[3,3];
        //    matriz[0,0] = 1;
        //    matriz[0,1] = 2;
        //    matriz[0,2] = 3;
        //    matriz[1,0] = 4;
        //    matriz[1,1] = 5;   
        //    matriz[1,2] = 6;
        //    matriz[2,0] = 7;
        //    matriz[2,1] = 8;
        //    matriz[2,2] = 9;

        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < 4; j++)
        //        {
        //            Console.Write("[" + matriz[i, j] + "]");

        //        }
        //        Console.WriteLine();
        //    }

        //}

        //EX10
        //static void Main(string[] args)
        //{
        //    int[,] matriz = new int[3, 3];
        //    //preencher a matriz
        //    for (int i = 0; i < 3; i++) 
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {
        //            Console.WriteLine("Informe um valor para a posição " + i + " - " + j + " da matriz:");
        //            matriz[i, j] = int.Parse(Console.ReadLine());
        //        }
        //    }
        //    //mostrando o conteúdo da matríz
        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {
        //            Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + "  ");
        //        }
        //        Console.WriteLine();
        //    }

        //}

        //EX11

        static void Main(string[] args)
        {


        }

    }
}