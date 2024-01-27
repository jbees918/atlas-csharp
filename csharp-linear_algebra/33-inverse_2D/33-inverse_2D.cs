using System;

/// <summary>
/// Class that performs math operations on matrices.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Calculates inverse of 2D matrix. Returns resulting matrix.
    /// </summary>
    /// <param name="matrix">Matrix.</param>
    /// <returns>The inverse of the matrix, or a matrix containing -1 if the matrix is not 2D or is non-invertible.</returns>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix == null || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return new double[,] { { -1 } };
        }

        double det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        if (det == 0)
        {
            return new double[,] { { -1 } };
        }

        double[,] inverse = new double[2, 2];
        inverse[0, 0] = matrix[1, 1];
        inverse[0, 1] = -matrix[0, 1];
        inverse[1, 0] = -matrix[1, 0];
        inverse[1, 1] = matrix[0, 0];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                inverse[i, j] /= det;
            }
        }

        return inverse;
    }
}
