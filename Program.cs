// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

/* #############################################

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

####################################################### */

/* ##################### Entrada de dados 01 ########################################
System.Console.WriteLine("=============== Entrada de dados =======================");

string frase = Console.ReadLine();
string x = Console.ReadLine();
string y = Console.ReadLine();
string z = Console.ReadLine();

// string s = Console.ReadLine();

string [] v = Console.ReadLine().Split(' ');

string a = v[0];
string b = v[1];
string c = v[2];

System.Console.WriteLine("Você digitou: ");
System.Console.WriteLine(frase);
System.Console.WriteLine(x);
System.Console.WriteLine(y);
System.Console.WriteLine(z);
System.Console.WriteLine(a);
System.Console.WriteLine(b);
System.Console.WriteLine(c);

############################ Fim entrada de dados 01 ################################## */

/* ######################### Entadada de dados 02 - Conversões de saída de dados ##################################### */
int n1 = int.Parse(Console.ReadLine());
char ch = char.Parse(Console.ReadLine());
// ########### Regra para usar a virgula no numero flutuante ##########################
double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

System.Console.WriteLine("Você Digitou: ");
System.Console.WriteLine(n1);
System.Console.WriteLine(ch);

// ########### Saída de dados com ponto do numero flutuante ##########################
System.Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));