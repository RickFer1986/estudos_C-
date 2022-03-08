// See https://aka.ms/new-console-template for more information
using System;

string nome = "Rick";
int idade = 35;
char genero = 'M';
double salario = 1.800;

// ### Placeholder ###
System.Console.WriteLine("{0} do sexo {1} com {2} anos já ganha um salário de R$ {3:F4}", nome, genero, idade, salario);

// ### Interpolação ###
System.Console.WriteLine($"{nome} do sexo {genero} com {idade} anos já ganha um salário de R$ {salario:F4}");

// ### Concatenação ###
System.Console.WriteLine(nome + " do sexo " + genero + " com " + idade + " anos já ganha um salário de R$ " + salario.ToString("F4"));

