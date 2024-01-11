using System;

namespace MyMath
{
    public class Matrix
    {
        public static int[,] Divide(int[,] matrix, int num)
        {
            try
            {
                // Check if the matrix is null
                if (matrix == null)
                {
                    Console.WriteLine("Matrix cannot be null.");
                    return null;
                }

                // Check if the divisor (num) is 0
                if (num == 0)
                {
                    Console.WriteLine("Num cannot be 0.");
                    return null;
                }

                int rows = matrix.GetLength(0);
                int columns = matrix.GetLength(1);

                // Create a new matrix to store the divided elements
                int[,] resultMatrix = new int[rows, columns];

                // Divide each element in the matrix by num
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        resultMatrix[i, j] = matrix[i, j] / num;
                    }
                }

                return resultMatrix;
            }
            catch (Exception ex)
            {
                // Handle any other exceptions that might occur
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }
    }
}
