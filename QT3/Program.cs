/*-------------------------------------------------------------------
Questão 3: Loja de Poções
* Contextualização: Em uma loja de poções mágicas, o jogador pode comprar poções que
aumentam sua vida, mana ou resistência. O preço das poções é fixo: Vida custa 10 moedas,
Mana custa 15 moedas, e Resistência custa 20 moedas. Dependendo da classe do jogador, há
um desconto aplicável.
* Comando: Crie um programa que receba a classe do jogador (Guerreiro, Mago, Paladino), o tipo
de poção (Vida, Mana, Resistência), e a quantidade que deseja comprar. Calcule o preço total
das poções, aplicando o desconto correspondente:
* Guerreiro recebe 10% de desconto na compra de poções de Vida.
* Mago recebe 15% de desconto na compra de poções de Mana.
* Paladino recebe 20% de desconto na compra de poções de Resistência.
* Exiba o preço total com e sem desconto.

@Lista: 02 - Condicionais
@Autor: Samuel Barbosa Chaves Brandão 
@Data: 25/08/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    public static void Main(string[] args)
    {
            string cla, por;
            int qua, res;
            double total;
            
        Console.WriteLine ("Informe a classe do jogador:(guerreiro, mago, paladino)");
        cla = Console.ReadLine();
        
        Console.WriteLine ("Informe a poção que deseja comprar:(Vida, Mana, Resistência)");
        por = Console.ReadLine();
        
        Console.WriteLine ("Informe a quantidade de porção:");
        int.TryParse(Console.ReadLine(), out qua);
        
        if(por == "vida")
        {
            res = 10 * qua;
            Console.WriteLine($"Resultado sem desconto:{res}");
        }
        if(por == "mana")
        {
        res = 15 * qua;
        Console.WriteLine($"Resultado sem desconto:{res}");
        }
         if(por == "resistencia")
        {
        res = 20 * qua;
        Console.WriteLine($"Resultado sem desconto :{res}");
        }
        if(cla == "guerreiro" && por == "vida")
        {
            res = (10 * qua);
            total = res - (res * 0.1);
            Console.WriteLine($"O resultado sem desconto:{res}");
            Console.WriteLine($"Resultado com descoonto:{total}");
        }
        if(cla == "mago" && por == "mana")
        {
            res = (15 * qua);
            total = res - (res * 0.15);
             Console.WriteLine($"O resultado sem desconto:{res}");
            Console.WriteLine($"Resultado com descoonto:{total}");
        }
        if(cla == "paladino" && por == "resistencia")
        {
            res = (20 * qua);
           total = res - (res * 0.2);
             Console.WriteLine($"O resultado sem desconto:{res}");
           Console.WriteLine($"Resultado com desconto:{total}");
        }
     }
        
}