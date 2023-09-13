Menu();

static void Menu()
{
  Console.Clear();
  Console.WriteLine("Bem vindo a supercalculadora!!!");
  Console.WriteLine("Escolha uma opção abaixo:");

  Console.WriteLine("0 - Sair");
  Console.WriteLine("1 - Soma");
  Console.WriteLine("2 - Subtracao");
  Console.WriteLine("3 - Divisao");
  Console.WriteLine("4 - Multiplicacao");

  Console.WriteLine("-----------------");

  short opcaoEscolhida = short.Parse(Console.ReadLine());

  switch (opcaoEscolhida)
  {
    case 1:
      Soma();
      break;
    case 2:
      Subtracao();
      break;
    case 3:
      Divisao();
      break;
    case 4:
      Multiplicacao();
      break;
    case 0:
      System.Environment.Exit(0);
      break;
    default:
      Menu();
      break;
  }

}

static void Soma()
{
  Console.WriteLine("Informe o primeiro valor");
  float num1 = float.Parse(Console.ReadLine());

  Console.WriteLine("Informe o segundo valor");
  float num2 = float.Parse(Console.ReadLine());

  double result = num1 + num2;

  Console.WriteLine($"O resultado é {result}");
  Console.ReadKey();
  Menu();
}

static void Subtracao()
{
  Console.WriteLine("Informe o primeiro valor");
  float num1 = float.Parse(Console.ReadLine());

  Console.WriteLine("Informe o segundo valor");
  float num2 = float.Parse(Console.ReadLine());

  double result = num1 - num2;

  Console.WriteLine($"O resultado é {result}");
  Console.ReadKey();
  Menu();
}

static void Divisao()
{
  Console.WriteLine("Informe o primeiro valor");
  float num1 = float.Parse(Console.ReadLine());

  Console.WriteLine("Informe o segundo valor");
  float num2 = float.Parse(Console.ReadLine());

  double result = num1 / num2;

  Console.WriteLine($"O resultado é {result}");
  Console.ReadKey();
  Menu();
}

static void Multiplicacao()
{
  Console.WriteLine("Informe o primeiro valor");
  float num1 = float.Parse(Console.ReadLine());

  Console.WriteLine("Informe o segundo valor");
  float num2 = float.Parse(Console.ReadLine());

  double result = num1 * num2;

  Console.WriteLine($"O resultado é {result}");
  Console.ReadKey();
  Menu();
}