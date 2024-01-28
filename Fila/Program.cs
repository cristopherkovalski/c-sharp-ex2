namespace Fila
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite o número de jogadores: ");
            int numeroDeJogadores = int.Parse(Console.ReadLine());

            JogoDeBatataQuente(numeroDeJogadores);
        }
        static void JogoDeBatataQuente(int numeroDeJogadores)
        {
            Queue<int> filaDeJogadores = new Queue<int>();

            for (int i = 1; i <= numeroDeJogadores; i++)
            {
                filaDeJogadores.Enqueue(i);
            }

            Random random = new Random();
            int quantidadePasses = random.Next(1, 100); 
            Console.WriteLine($"Quantidade de passes até a batata explodir: {quantidadePasses}");

            while (filaDeJogadores.Count > 1)
            {
                for (int i = 1; i < quantidadePasses; i++)
                {
                    
                    int jogadorAtual = filaDeJogadores.Dequeue();
                    filaDeJogadores.Enqueue(jogadorAtual);
                }
                int jogadorEliminado = filaDeJogadores.Dequeue();
                Console.WriteLine($"Jogador {jogadorEliminado} está fora!");
                quantidadePasses = random.Next(1, 101); 
            }
            int jogadorVencedor = filaDeJogadores.Dequeue();
            Console.WriteLine($"Jogador {jogadorVencedor} é o vencedor!");
        }
    }
}
