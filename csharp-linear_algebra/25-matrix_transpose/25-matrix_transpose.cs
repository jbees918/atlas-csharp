using System;

/// <summary>
/// Class to perform mathematical operations on matrices.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Transposes a matrix and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix">The matrix.</param>
    /// <returns>The resulting matrix after transposition, or an empty matrix if the input matrix is empty.</returns>
    public static double[,] Transpose(double[,] matrix)
    {
        if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
        {
            return new double[,] { };
        }

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] result = new double[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[j, i] = matrix[i, j];
            }
        }

        return result;
    }
}
