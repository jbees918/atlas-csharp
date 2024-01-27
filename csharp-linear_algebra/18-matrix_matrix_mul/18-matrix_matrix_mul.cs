using System;

/// <summary>
/// Class to perform mathematical operations on matrices.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Multiplies two matrices and returns resulting matrix.
    /// </summary>
    /// <param name="matrix1">First matrix.</param>
    /// <param name="matrix2">The second matrix.</param>
    /// <returns>The resulting matrix after multiplication, or matrix containing -1 if the matrices cannot be multiplied.</returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1 == null || matrix2 == null)
        {
            return new double[,] { { -1 } };
        }

        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        if (cols1 != rows2)
        {
            return new double[,] { { -1 } };
        }

        double[,] result = new double[rows1, cols2];
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                double sum = 0;
                for (int k = 0; k < cols1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                result[i, j] = sum;
            }
        }

        return result;
    }
}
