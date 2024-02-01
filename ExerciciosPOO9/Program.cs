namespace ExerciciosPOO9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Digite o numero M: ");
            int Linhas = int.Parse(Console.ReadLine());

            Console.Write("Digite o numero N: ");
            int Colunas = int.Parse(Console.ReadLine());

            int[,] Matriz = new int[Linhas, Colunas];

            Console.WriteLine("Digite os elementos da matriz:");
            for (int x = 0; x < Linhas; x++)
            {
                for (int y = 0; y < Colunas; y++)
                {
                    Console.Write($"Elemento [{x}, {y}]: ");
                    Matriz[x, y] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Digite o numero X: ");
            int NumeroBusca = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x < Linhas; x++)
            {
                for (int y = 0; y < Colunas; y++)
                {
                    if (Matriz[x,y] == NumeroBusca)
                    {
                        Console.WriteLine($"Posição ({x}, {y}): {NumeroBusca}");

                        if (x > 0)
                            Console.WriteLine($"Acima: {Matriz[x - 1, y]}");
                        if (y > 0)
                            Console.WriteLine($"À esquerda: {Matriz[x, y - 1]}");
                        if (y < Colunas - 1)
                            Console.WriteLine($"À direita: {Matriz[x,y + 1]}");
                        if (x < Linhas- 1)
                            Console.WriteLine($"Abaixo: {Matriz[x + 1, y]}");
                    }                    
                }
            }
            Console.ReadKey();
            Console.Beep();                     
        }
    }
}

