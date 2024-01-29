namespace Fila
{
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

            while (filaDeJogadores.Count > 1)
            {
                // O ideal é que cada rodada tenha um número de passes diferente, para que o jogo seja menos previsivel
                int quantidadePasses = random.Next(1, 100);
                Console.WriteLine($"Quantidade de passes até a batata explodir: {quantidadePasses}");

                // Pelo nome da variavel, os passes devem ser completados antes de a batata explodir
                for (int i = 1; i <= quantidadePasses; i++)
                {
                    int jogadorAtual = filaDeJogadores.Dequeue();
                    filaDeJogadores.Enqueue(jogadorAtual);
                }
                int jogadorEliminado = filaDeJogadores.Dequeue();
                Console.WriteLine($"Jogador {jogadorEliminado} está fora!");
            }
            int jogadorVencedor = filaDeJogadores.Dequeue();
            Console.WriteLine($"Jogador {jogadorVencedor} é o vencedor!");
        }
    }
}
