namespace Planeador;
class Program
{
    static void Main(string[] args)
    {
        // Crear la matriz
        int[,] matrix = new int[25, 50];

        // Llenar la matriz aleatoriamente con células vivas o muertas
        Random random = new Random();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = random.Next(0, 2);
            }
        }

        // Bucle infinito
        while (true)
        {
            // Imprimir la matriz
            Console.Clear();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] == 1 ? "O" : " ");
                }
                Console.WriteLine();
            }

            // Crear una copia de la matriz para calcular la siguiente iteración
            int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    newMatrix[i, j] = matrix[i, j];
                }
            }

            // Aplicar las normas del Juego de la Vida de Conway
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // Contar el número de vecinos vivos
                    int neighbors = 0;
                    for (int newI = i - 1; newI <= i + 1; newI++)
                    {
                        for (int newJ = j - 1; newJ <= j + 1; newJ++)
                        {
                            if (newI >= 0 && newI < matrix.GetLength(0) && newJ >= 0 && newJ < matrix.GetLength(1) && (newI != i || newJ != j))
                            {
                                neighbors += matrix[newI, newJ];
                            }
                        }
                    }

                    // Aplicar las normas
                    if (matrix[i, j] == 1 && (neighbors < 2 || neighbors > 3))
                    {
                        newMatrix[i, j] = 0;
                    }
                    else if (matrix[i, j] == 0 && neighbors == 3)
                    {
                        newMatrix[i, j] = 1;
                    }
                }
            }

            // Reemplazar la matriz actual con la siguiente iteración
            matrix = newMatrix;

            // Esperar 250 milisegundos antes de la siguiente iteración
            Thread.Sleep(250);
        }
    }
}