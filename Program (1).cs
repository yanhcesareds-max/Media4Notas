Console.WriteLine("-- Média --");
Console.WriteLine();
Console.WriteLine("Digite as suas notas abaixo.");

// 1. Ler as 4 notas, com uma casa decimal
Console.Write("Nota 1: ");
double nota1 = Math.Round(double.Parse(Console.ReadLine()), 1);
Console.Write("Nota 2: ");
double nota2 = Math.Round(double.Parse(Console.ReadLine()), 1);
Console.Write("Nota 3: ");
double nota3 = Math.Round(double.Parse(Console.ReadLine()), 1);
Console.Write("Nota 4: ");
double nota4 = Math.Round(double.Parse(Console.ReadLine()), 1);

Console.WriteLine();

// 2. Validar: todas precisam estar entre 0 e 10
bool valida1 = nota1 >= 0 && nota1 <= 10;
bool valida2 = nota2 >= 0 && nota2 <= 10;
bool valida3 = nota3 >= 0 && nota3 <= 10;
bool valida4 = nota4 >= 0 && nota4 <= 10;

if (!valida1 || !valida2 || !valida3 || !valida4)
{
    Console.WriteLine("Digite somente notas entre 0 e 10.");
    return;
}

// 3. Calcular a média
double media = (nota1 + nota2 + nota3 + nota4) / 4;

// 4. Definir o resultado
string resultado;
if (media < 5.0)
    resultado = "Reprovado";
else if (media <= 6.0)
    resultado = "Em recuperação";
else
    resultado = "Aprovado";

Console.WriteLine($"Você ficou com média {media:F1}. Resultado: {resultado}");