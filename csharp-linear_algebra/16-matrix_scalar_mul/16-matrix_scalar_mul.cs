using System;

/// <summary>
/// Class to perform mathematical operations on matrices.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Multiplies a matrix and a scalar and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix">The matrix.</param>
    /// <param name="scalar">The scalar.</param>
    /// <returns>The resulting matrix after multiplication, or a matrix containing -1 if the matrix is not 2D or 3D.</returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (matrix == null || (matrix.GetLength(0) != 2 && matrix.GetLength(0) != 3))
        {
            return new double[,] { { -1 } };
        }

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix[i, j] * scalar;
            }
        }

        return result;
    }
}
