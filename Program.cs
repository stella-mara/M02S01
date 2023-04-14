internal class Program
{
  private static void Main(string[] args)
  {

    Console.WriteLine("Exercícios Semana 01 - Módulo 2");

    // Exercício 1
    Console.WriteLine("Digite um número: ");
    int.TryParse(Console.ReadLine(), out int numero1);

    Console.WriteLine("Digite outro número: ");
    int.TryParse(Console.ReadLine(), out int numero2);

    int resultado = numero1 + numero2;

    Console.WriteLine("A soma dos dois números é " + resultado);

    // Exercício 2
    int numero02;

    Console.WriteLine("Digite um número: ");

    numero02 = int.Parse(Console.ReadLine());

    if (numero02 % 2 == 0)
    {
      Console.WriteLine("O número " + numero02 + " é par");
    }
    else
    {
      Console.WriteLine("O número " + numero02 + " é ímpar");
    }

    // Exercício 3
    string nome;
    int idade;

    Console.WriteLine("Digite o nome do paciente");
    nome = Console.ReadLine();

    Console.WriteLine("Digite o idade do paciente");
    idade = int.Parse(Console.ReadLine());

    Console.WriteLine($"O nome do paciente é {nome}");

    if (idade < 18)
    {
      Console.WriteLine("O paciente é menor de idade.");
    }
    else if (idade >= 60)
    {
      Console.WriteLine("O paciente é idoso.");
    }
    else
    {
      Console.WriteLine("O paciente é maior de idade.");
    }

    // Exercício 4
    string marca, modelo;
    double km;

    Console.WriteLine("Digite a marca do carro: ");
    marca = Console.ReadLine();

    Console.WriteLine("Digite o modelo do carro: ");
    modelo = Console.ReadLine();

    Console.WriteLine("Digite a quilometragem rodada do carro: ");
    km = double.Parse(Console.ReadLine());

    Console.WriteLine($"\n- Marca do carro: {marca}\n- Modelo do carro: {modelo}\n- Quilometragem do carro: {km}");

    if (km > 10000)
    {
      Console.WriteLine("É necessário fazer a revisão do carro.");
    }

    // Exercício 5
    // Declarando um array para armazenar os 4 números
    int[] numeros05 = new int[4];

    // Lendo os números digitados pelo usuário e armazenando no array
    for (int i = 0; i < 4; i++)
    {
      Console.Write("Digite o {0}º número: ", i + 1);
      numeros05[i] = int.Parse(Console.ReadLine());
    }

    // Ordenando o array em ordem crescente
    Array.Sort(numeros05);

    // Imprimindo os números ordenados
    Console.WriteLine("Números ordenados:");
    for (int i = 0; i < 4; i++)
    {
      Console.WriteLine(numeros05[i]);
    }

    // Exercício 6
    // Declarando a variável com a frase
    string frase = "A linguagem de programação C# é muito poderosa";

    // Separando as palavras em uma lista
    List<string> palavras = new List<string>(frase.Split(' '));

    // Exibindo a palavra "poderosa" na tela
    Console.WriteLine(palavras[palavras.Count - 1]);

    // Exercício 7
    int numero07;

    do
    {
      Console.Write("Digite um número inteiro positivo: ");
      numero07 = int.Parse(Console.ReadLine());
      if (numero07 <= 0)
      {
        Console.WriteLine("Número inválido. Tente novamente.");
      }
    } while (numero07 <= 0);

    Console.WriteLine("Números pares de 0 até {0}:", numero07);

    for (int i = 0; i < numero07; i += 2)
    {
      Console.WriteLine(i);
    }



    // Excercício 8
    int[] numeros = new int[5];
    int maiorNumero = 0;

    for (int i = 0; i < numeros.Length; i++)
    {
      Console.Write("Digite o {0}º número: ", i + 1);
      numeros[i] = int.Parse(Console.ReadLine());
      if (numeros[i] > maiorNumero)
      {
        maiorNumero = numeros[i];
      }
    }

    Console.WriteLine("O maior número digitado foi: {0}", maiorNumero);



    // Exercício 9
    Console.Write("Digite a quantidade de números que deseja calcular a média: ");
    int quantidadeNumeros = int.Parse(Console.ReadLine());

    double[] numeros09 = new double[quantidadeNumeros];
    double soma = 0;

    for (int i = 0; i < numeros09.Length; i++)
    {
      Console.Write("Digite o {0}º número: ", i + 1);
      numeros09[i] = double.Parse(Console.ReadLine());
      soma += numeros09[i];
    }

    double media = soma / numeros09.Length;
    Console.WriteLine("A média aritmética é: {0}", media);



    // Calculadora

    bool continuar = true;

    Console.WriteLine("Bem-vindo à calculadora!");

    while (continuar)
    {
      Console.WriteLine("Escolha uma operação:");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Multiplicação");
      Console.WriteLine("4 - Divisão");
      Console.WriteLine("0 - Sair");

      int operacao = int.Parse(Console.ReadLine());

      if (operacao == 0)
      {
        continuar = false;
        Console.WriteLine("Obrigado por utilizar a calculadora!");
      }
      else if (operacao < 1 || operacao > 4)
      {
        Console.WriteLine("Operação inválida!");
      }
      else
      {
        Console.WriteLine("Digite o primeiro número:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        double num2 = double.Parse(Console.ReadLine());

        switch (operacao)
        {
          case 1:
            Console.WriteLine("Resultado: " + (num1 + num2));
            break;
          case 2:
            Console.WriteLine("Resultado: " + (num1 - num2));
            break;
          case 3:
            Console.WriteLine("Resultado: " + (num1 * num2));
            break;
          case 4:
            if (num2 == 0)
            {
              Console.WriteLine("Não é possível dividir por zero!");
            }
            else
            {
              Console.WriteLine("Resultado: " + (num1 / num2));
            }
            break;
        }
      }

      Console.WriteLine();
    }





  }

}


