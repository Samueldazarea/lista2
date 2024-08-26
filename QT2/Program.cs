/*------------------------------------------------------------------- 
Questão 2: Sistema de Pontuação em Batalha 
* Contextualização: Em um jogo de RPG, o jogador ganha pontos após derrotar inimigos em uma 
batalha. A pontuação máxima é de 100 pontos, e é determinada pela quantidade de inimigos 
derrotados, a duração da batalha e se o jogador sofreu danos crítico. 
* Comando: Crie um programa que calcule a pontuação final do jogador. O programa deve 
receber o número de inimigos derrotados, a duração da batalha em minutos e se o jogador 
sofreu danos crítico (sim ou não). A pontuação é calculada da seguinte forma: 
* 10 pontos para cada inimigo derrotado; 
* Subtraia 10 pontos se a batalha durar mais de 5 minutos; 
* Subtraia 10 pontos se o jogador sofreu dano crítico; 

@Lista: 02 - Condicionais 
@Autor: Samuel Barbosa Chaves Brandão 
@Data: 24/08/2024 ---------------------------------------------------------------------*/
using System;

class Program
{
    public static void Main()

 {
     int ini, dr, total, fim;
     string dn;
      Console.WriteLine(" numero de inimigos derrotados");
      int.TryParse(Console.ReadLine(), out ini);
      
        Console.WriteLine ("a duracao da batalha em minutos");
        int.TryParse(Console.ReadLine(), out dr);
        
        Console.WriteLine("Sofreu dano critico:");
        dn = Console.ReadLine();
        
        total = ini * 10;
        
        if (dr > 5)
        {
           fim = total - 10;
           Console.WriteLine($"O resultado final:{fim}");
            if(fim > 100)
        {
             Console.WriteLine("O resultado final é igual a: 100");
        }
        }
        if(dn == "sim")
        {
            fim = total - 10;
             Console.WriteLine($"O resultado final:{fim}");
              if(fim > 100)
        {
             Console.WriteLine("O resultado final é igual a: 100");
        }
        }
        if (total > 100)
        {
            Console.WriteLine("O resultado final é igual a: 100");
        }
       else{
            Console.WriteLine($"O resultado final é igual a:{total}");
       }
        
        
 }    
}
