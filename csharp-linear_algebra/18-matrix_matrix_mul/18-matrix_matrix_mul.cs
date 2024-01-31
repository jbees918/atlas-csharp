using System;

/// <summary>
///  Class responsible for matrix mathematical operations
/// </summary>
public class MatrixMath
{
    /// <summary Method to multiply two matrices </summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        // Check if matrices can be multiplied
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
        {
            // If not, return a matrix with a single element (-1)
            return new double[,] { { -1 } };
        }

        // Create a matrix to store the result
        double[,] result = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

        // Perform matrix multiplication
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                result[i, j] = 0;

                // Sum the products of corresponding elements
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        // Return the resulting matrix
        return result;
    }
}
