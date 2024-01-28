namespace ExED
{
    class Program
    {
            static void Main()
            {
                var input = new List<string>{
                "Idiossincrasia",
                "Ambivalente",
                "Quimérica",
                "Perpendicular",
                "Efêmero",
                "Pletora",
                "Obnubilado",
                "Xilografia",
                "Quixote",
                "Inefável"
            };

                var result = FiltrarStringsPorTamanho(input, 10);

                Console.WriteLine("Strings com 10 ou mais caracteres:");
                foreach (var str in result)
                {
                    Console.WriteLine(str);
                }
            }

            static List<string> FiltrarStringsPorTamanho(List<string> input, int tamanhoMinimo)
            {
                List<string> resultado = new List<string>();

                foreach (var str in input)
                {
                    if (str.Length >= tamanhoMinimo)
                    {
                        resultado.Add(str);
                    }
                }

                return resultado;
            }
    }
}

