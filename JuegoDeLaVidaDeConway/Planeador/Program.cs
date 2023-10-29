namespace Planeador;
class Program
{
    static void Main(string[] args)
    {
        int[,] m = new int[25, 50];

        for (int i = 0; i < m.GetLength(0); i++)
            for (int j = 0; j < m.GetLength(1); j++)
                m[i, j] = 0;

        m[1, 2] = 1;
        m[2, 3] = 1;
        m[3, 3] = 1;
        m[3, 2] = 1;
        m[3, 1] = 1;

        while (true)
        {
            Console.Clear();
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                    Console.Write(m[i, j] == 1 ? "O" : " ");
                Console.WriteLine();
            }

            int[,] n = new int[m.GetLength(0), m.GetLength(1)];
            for (int i = 0; i < m.GetLength(0); i++)
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    int c = 0;
                    for (int x = -1; x <= 1; x++)
                        for (int y = -1; y <= 1; y++)
                            if (x != 0 || y != 0)
                                c += m[(i + x + m.GetLength(0)) % m.GetLength(0), (j + y + m.GetLength(1)) % m.GetLength(1)];

                    n[i, j] = m[i, j] == 1 ? c < 2 || c > 3 ? 0 : 1 : c == 3 ? 1 : 0;
                }

            m = n;
            Thread.Sleep(250);
        }
    }
}
