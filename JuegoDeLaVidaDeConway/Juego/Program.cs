namespace Juego
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 25, cols = 50;
            int[,] m = new int[rows, cols];
            Random r = new Random();

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    m[i, j] = r.Next(2);

            while (true)
            {
                Console.Clear();
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                        Console.Write(m[i, j] == 1 ? "O" : " ");
                    Console.WriteLine();
                }

                int[,] n = new int[rows, cols];
                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < cols; j++)
                    {
                        int c = 0;
                        for (int x = -1; x <= 1; x++)
                            for (int y = -1; y <= 1; y++)
                                if (x != 0 || y != 0)
                                    c += m[(i + x + rows) % rows, (j + y + cols) % cols];

                        n[i, j] = m[i, j] == 1 ? c < 2 || c > 3 ? 0 : 1 : c == 3 ? 1 : 0;
                    }

                m = n;
                Thread.Sleep(250);
            }
        }
    }
}