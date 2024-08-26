/*-------------------------------------------------------------------
Questão 1: Informações do Personagem
* Contextualização: Em um jogo de RPG, o jogador precisa inserir
as informações básicas do personagem antes de começar a aventura.
* Comando: Crie um programa que receba o nome, idade, nível inicial,
classe, e raça do personagem e exiba esses dados no console.

@Lista: 02 - Condicionais
@Autor: Samuel Barbosa Chaves Brandão
@Data: 24/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {
string cls;
int df, agi;

Console.WriteLine("Informe a classe do personagem: ");
cls = Console.ReadLine();

Console.WriteLine("Informe o valor da defesa: ");
int.TryParse(Console.ReadLine(), out df);

Console.WriteLine("Informe a penalidade de agilidade: ");
int.TryParse(Console.ReadLine(), out agi);

if (cls == "guerreiro")
{
    if (df > 50 && agi < 20)
    {
        Console.WriteLine("Armadura adequada");
    }
}
    if (cls == "arqueiro")
    {
        if (df > 30 && agi < 10)
        {
            Console.WriteLine("Armadura adequada");
        }
    }
    if (cls == "mago")
    {
        if (df > 20 && agi < 40)
        {
            Console.WriteLine("Armadura adequada");
        }
    }
        else
        {
            Console.WriteLine("Armadura inadequada");
        }
    }
}