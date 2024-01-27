using System;

/// <summary>
/// Class that performs math operations on matrices.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Calculates determinant of a matrix.
    /// </summary>
    /// <param name="matrix">The matrix itself.</param>
    /// <returns>Determinant of matrix, -1 if matrix is not 2D or 3D.</returns>
    public static double Determinant(double[,] matrix)
    {
        if (matrix == null || (matrix.GetLength(0) != 2 && matrix.GetLength(0) != 3))
        {
            return -1;
        }

        int size = matrix.GetLength(0);
        double det = 1;

        for (int i = 0; i < size; i++)
        {
            det *= matrix[i, i];
        }

        return det;
    }
}
