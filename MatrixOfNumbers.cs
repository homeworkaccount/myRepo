using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops

class MatrixOfNumbers
{
	//new line here
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (row > 0)
                {
                    matrix[row, col] = matrix[row - 1, col] + 1;
                }
                else
                {
                    matrix[row, col] = col + 1;
                }
                Console.Write(matrix[row, col]);
            }

            Console.WriteLine();

        }

    }
}

