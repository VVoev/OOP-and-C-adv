using System;

class IntroduceYourself
{
    static void Main()
    {
        //1.Fill The Matrix
        //    int number = int.Parse(Console.ReadLine());
        //    string letter = Console.ReadLine().ToLower();
        //    int rows = number; int cols = number;
        //    int[,] matrix = new int[rows, cols];
        //    switch (letter)
        //    {
        //        case "a":
        //            matrix = VerticalMatrix(rows, cols);
        //            break;
        //        case "b":
        //            matrix = ReverseVertical(rows, cols);
        //            break;
        //    }
        //    for (int r = 0; r < rows; r++)
        //    {
        //        for (int c = 0; c < cols; c++)
        //        {
        //            if (c < cols - 1)
        //            {
        //                Console.Write(matrix[r, c] + " ");
        //            }
        //            else
        //            {
        //                Console.Write(matrix[r, c]);
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //private static int[,] ReverseVertical(int rows, int cols)
        //{
        //    int a = 1; int[,] matrix = new int[rows, cols];
        //    for (int row = 0; row < rows; row++)
        //    {
        //        if (row % 2 == 0)                                   /*1  8  9   16*/
        //        {                                                   /*2  7  10  15*/
        //            for (int col = 0; col < cols; col++)            /*3  6  11  14*/
        //            {                                               /*4  5  12  13*/
        //                matrix[col, row] = a;
        //                a++;
        //            }
        //        }
        //        else
        //        {
        //            for (int col = cols - 1; col >= 0; col--)
        //            {
        //                matrix[col, row] = a;
        //                a++;
        //            }
        //        }
        //    }
        //    return matrix;
        //}

        //private static int[,] VerticalMatrix(int rows, int cols)
        //{
        //    int a = 1;
        //    int[,] matrix = new int[rows, cols];                    /*1  5  9   13*/
        //    for (int row = 0; row < cols; row++)                    /*2  6  10  14*/
        //    {                                                       /*3  7  11  15*/
        //        for (int col = 0; col < rows; col++)                /*4  8  12  16*/
        //        {
        //            matrix[col, row] = a; a++;
        //        }
        //    }
        //    return matrix;
        //}

        //2.Find Max in Matrix
        //// Declare and initialize the matrix
        //var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        //int rows = input[0];
        //int cols = input[1];
        //int[,] matrix = new int[rows, cols];
        //for (int r = 0; r < rows; r++)
        //{
        //    var columd = Console.ReadLine().Split().Select(int.Parse).ToList();
        //    for (int c = 0; c < cols; c++)
        //    {
        //        matrix[r, c] = columd[c];
        //    }
        //}

        //// Find the maximal sum platform of size 2 x 2
        //int bestSum = int.MinValue;
        //int bestRow = 0;
        //int bestCol = 0;
        //for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        //{
        //    for (int col = 0; col < matrix.GetLength(1) - 2; col++)
        //    {
        //        int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
        //                  matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
        //                  matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
        //        if (sum > bestSum)
        //        {
        //            bestSum = sum;
        //            bestRow = row;
        //            bestCol = col;
        //        }
        //    }
        //}
        ////Console.WriteLine("The best platform is:");
        ////Console.WriteLine(" {0} {1}",
        ////matrix[bestRow, bestCol],
        ////matrix[bestRow, bestCol + 1]);
        ////Console.WriteLine(" {0} {1}",
        ////matrix[bestRow + 1, bestCol],
        ////matrix[bestRow + 1, bestCol + 1]);
        //Console.WriteLine("{0}", bestSum);

    //    3.Sequence in Matrix
    //         static void Main()
    //{
    //        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    //        int rows = input[0];
    //        int cols = input[1];
    //        var matrix = FillMatrix(rows, cols);
    //        int counter = 1;
    //        int bestcounter = 1;
    //        CheckingVertical(rows, cols, matrix, ref counter, ref bestcounter);
    //        CheckingHorizontal(rows, cols, matrix, ref counter, ref bestcounter);
    //        CheckingLeftRightDiagonal(rows, cols, matrix, ref counter, ref bestcounter);
    //        CheckingRightLeftDiagonal(rows, cols, matrix, ref counter, ref bestcounter);

    //        Console.WriteLine(bestcounter);


    //    }

    //private static void CheckingRightLeftDiagonal(int rows, int cols, int[,] matrix, ref int counter, ref int bestcounter)
    //{
    //    int startRow = 0;
    //    int StartCol = 0;
    //    for (int r = 0; r < rows; r++)
    //    {
    //        for (int c = cols; c >= 0; c--)
    //        {
    //            startRow = r;
    //            StartCol = c - 1;
    //            while (startRow < rows - 1 && StartCol > 0)
    //            {
    //                if (matrix[startRow, StartCol] == matrix[startRow + 1, StartCol - 1])
    //                {
    //                    counter++;
    //                    startRow++;
    //                    StartCol--;
    //                }
    //                else
    //                {
    //                    startRow++;
    //                    StartCol--;
    //                }
    //            }
    //            if (counter > bestcounter)
    //            {
    //                bestcounter = counter;
    //            }
    //            counter = 1;
    //        }
    //    }
    //}

    //private static int CheckingLeftRightDiagonal(int rows, int cols, int[,] matrix, ref int counter, ref int bestcounter)
    //{
    //    int startRow = 0;
    //    int StartCol = 0;
    //    for (int r = 0; r < rows; r++)
    //    {
    //        for (int c = 0; c < cols; c++)
    //        {
    //            startRow = r;
    //            StartCol = c;
    //            while (startRow < rows - 1 && StartCol < cols - 1)
    //            {
    //                if (matrix[startRow, StartCol] == matrix[startRow + 1, StartCol + 1])
    //                {
    //                    counter++;
    //                    startRow++;
    //                    StartCol++;
    //                }
    //                else
    //                {
    //                    startRow++;
    //                    StartCol++;
    //                }
    //            }
    //            if (counter > bestcounter)
    //            {
    //                bestcounter = counter;
    //            }
    //            counter = 1;
    //        }
    //    }
    //    return counter;
    //}

    //private static int CheckingHorizontal(int rows, int cols, int[,] matrix, ref int counter, ref int bestcounter)
    //{
    //    int startRow = 0;
    //    int StartCol = 0;
    //    for (int r = 0; r < rows; r++)
    //    {
    //        for (int c = 0; c < cols; c++)
    //        {
    //            startRow = r;
    //            StartCol = c;
    //            while (startRow < rows - 1)
    //            {
    //                if (matrix[startRow, StartCol] == matrix[startRow + 1, StartCol])
    //                {
    //                    counter++;
    //                    startRow++;
    //                }
    //                else
    //                {
    //                    startRow++;
    //                }
    //            }
    //            if (counter > bestcounter)
    //            {
    //                bestcounter = counter;
    //            }
    //            counter = 1;
    //        }
    //    }
    //    return bestcounter;
    //}

    //private static int CheckingVertical(int rows, int cols, int[,] matrix, ref int counter, ref int bestcounter)
    //{
    //    int startRow = 0;
    //    int StartCol = 0;
    //    for (int r = 0; r < rows; r++)
    //    {
    //        for (int c = 0; c < cols; c++)
    //        {
    //            startRow = r;
    //            StartCol = c;
    //            while (StartCol < cols - 1)
    //            {
    //                if (matrix[startRow, StartCol] == matrix[startRow, StartCol + 1])
    //                {
    //                    counter++;
    //                    StartCol++;
    //                }
    //                else
    //                {
    //                    StartCol++;
    //                }
    //            }
    //            if (counter > bestcounter)
    //            {
    //                bestcounter = counter;
    //            }
    //            counter = 1;
    //        }
    //    }
    //    return bestcounter;
    //}

    //private static int CheckingSameCol(int r, int c, int rows, int cols)
    //{
    //    int count = 1;
    //    int[,] matrix = new int[r, c];
    //    if (matrix[r, c] == matrix[r, c + 1])
    //    {
    //        count++;
    //        if (c < 0 || c > cols - 1)
    //        {
    //            c--;
    //        }
    //    }
    //    return count;
    //}

    //private static int[,] FillMatrix(int rows, int cols)
    //{
    //    var matrix = new int[rows, cols];
    //    for (int r = 0; r < rows; r++)
    //    {
    //        var comand = Console.ReadLine().Split().Select(int.Parse).ToList();
    //        for (int c = 0; c < cols; c++)
    //        {
    //            matrix[r, c] = comand[c];
    //        }
    //    }
    //    return matrix;
    //}
}
}

