// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;


// ### Exercicio ###
string produto1 = "Computador";
string produto2 = "Mesa de escritorio";

byte idade = 30;
int codigo = 5290;
char genero = 'M';

double preco1 = 2100.0;
double preco2 = 650.50;
double medida = 53.234567;

System.Console.WriteLine("Produtos:");
System.Console.WriteLine(produto1 + ", cujo preço é " + preco1);
System.Console.WriteLine(produto2 + ", cujo preço é " + preco2);
System.Console.WriteLine();
System.Console.WriteLine("Registro: " + idade + " anos de idade, código " + codigo + " e gênero " + genero);
System.Console.WriteLine();
System.Console.WriteLine("Medida com oito casa decimais: " + medida.ToString("F8"));
System.Console.WriteLine("Arredondando (três casas decimais): " + medida.ToString("F3"));
System.Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

System.Console.WriteLine("================ USO DO CAST ======================");

int x = 5;
int y = 2;

double result = (double) x / y;

System.Console.WriteLine(result);

System.Console.WriteLine("======================================");
// Float contem 4 Bytes
// Double contém 8 Bytes

double a = 5.1;
float b = (float) a;

System.Console.WriteLine(b);

System.Console.WriteLine("=============== Entrada de dados =======================");

System.Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();
System.Console.WriteLine("--------");

System.Console.Write("Digite seu idade: ");
string nasc = Console.ReadLine();
System.Console.WriteLine("--------");

System.Console.Write("Digite seu estado civil: ");
string sexo = Console.ReadLine();
System.Console.WriteLine("--------");

System.Console.WriteLine("Nome: " + nome);
System.Console.WriteLine("Idade: " + nasc);
System.Console.WriteLine("Sexo: " + sexo);
System.Console.WriteLine("--------");

System.Console.Write("Deseja salvar seus dados? S/N? ");
string salvar = Console.ReadLine();

System.Console.WriteLine("Dados salvos com sucesso!");