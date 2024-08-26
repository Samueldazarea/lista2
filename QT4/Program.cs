/*-------------------------------------------------------------------
Questão 4: Decisão de Ataque Especial
* Contextualização: Durante uma batalha em um jogo de RPG, o jogador pode realizar um ataque
especial se tiver mana suficiente, se a vida do inimigo estiver baixa e se o nível do jogador for
alto o bastante.
* Comando: Crie um programa que determine se o jogador deve realizar um ataque especial. O
programa deve receber a quantidade de mana do jogador, a vida atual do inimigo em
porcentagem e o nível do jogador. As condições para realizar o ataque especial são:
* Mana maior que 30.
* Vida do inimigo menor que 50%.
* Nível do jogador maior que 5.


@Lista: 02 - Condicionais
@Autor: Samuel Barbosa Chaves Brandão 
@Data: 25/08/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    public static void Main(string[] args)
    {
        int mn, vd, nv;
        
        Console.WriteLine ("Informe a quantidade de mana:");
        int.TryParse(Console.ReadLine(), out mn);
        
        Console.WriteLine ("Informe a quantidade de vida do adversario:");
        int.TryParse(Console.ReadLine(), out vd);
        
        Console.WriteLine ("Informe o seu nível:");
        int.TryParse(Console.ReadLine(), out nv);
        
        if(mn > 30 && vd < 50 && nv > 5)
        {
            Console.WriteLine("Ataque Especial realizado");
        }
         if(mn < 30 && vd < 50 && nv > 5)
        {
            Console.WriteLine("Mana insuficiente");
        }
         if(mn > 30 && vd > 50 && nv > 5)
        {
            Console.WriteLine("Vida do inimigo muito alta");
        }
         if(mn > 30 && vd < 50 && nv < 5)
        {
            Console.WriteLine("Nível insuficiente");
        }
      
    }
}