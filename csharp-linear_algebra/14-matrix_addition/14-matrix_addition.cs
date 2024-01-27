using System;

/// <summary>
/// Class to perform mathematical operations on matrices.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Adds two matrices and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix1">The first matrix.</param>
    /// <param name="matrix2">The second matrix.</param>
    /// <returns>The resulting matrix after addition, or a matrix containing -1 if the matrices are not of the same size or if any matrix is not 2D or 3D.</returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1 == null || matrix2 == null || (matrix1.GetLength(0) != 2 && matrix1.GetLength(0) != 3) || (matrix2.GetLength(0) != 2 && matrix2.GetLength(0) != 3) || matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
        {
            return new double[,] { { -1 } };
        }

        double[,] result = new double[matrix1.GetLength(0), matrix1.GetLength(1)];
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }
}
