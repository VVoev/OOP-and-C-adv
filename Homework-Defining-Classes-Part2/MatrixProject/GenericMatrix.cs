using System;
using System.Text;

namespace Homework_Defining_Classes_Part2.MatrixProject
{
    class GenericMatrix<T>
        where T : struct, IComparable, IComparable<T>, IConvertible, IFormattable
    {
        //Fields 
        private readonly T[,] matrixFields;
        private int row;
        private int col;

        //Property

        public int Row
        {
            get { return this.row; }
            set { this.row = value; }
        }

        public int Col
        {
            get { return this.col; }
            set { this.col = value; }
        }

        //Indexer
        public T this[int row, int col]
        {
            get
            {
                return this.matrixFields[row, col];
            }
            set
            {
                this.matrixFields[row, col] = value;
            }
        }

        //Constructor
        public GenericMatrix(int row, int col)
        {
            this.Row = row;
            this.Col = col;
            this.matrixFields = new T[row, col];
        }

        //Predefine Operators +,-,*,/,true,false
        public static GenericMatrix<T> operator +(GenericMatrix<T> firstMatrix, GenericMatrix<T> secondMatrix)
        {
            if (checkIsInBoundaries(firstMatrix, secondMatrix))
            {
                throw new ArithmeticException("Dimensions of the two matrices must be with same size");
            }
            GenericMatrix<T> additionMatrix = new GenericMatrix<T>(firstMatrix.Row, firstMatrix.Col);
            for (int r = 0; r < firstMatrix.Row; r++)
            {
                for (int c = 0; c < firstMatrix.Col; c++)
                {
                    additionMatrix[r, c] = (dynamic)firstMatrix[r, c] + secondMatrix[r, c];
                }
            }
            return additionMatrix;
        }

        public static GenericMatrix<T> operator -(GenericMatrix<T> firstMatrix, GenericMatrix<T> secondMatrix)
        {
            if (checkIsInBoundaries(firstMatrix, secondMatrix))
            {
                throw new ArithmeticException("Dimensions of the two matrices must be with same size");
            }
            GenericMatrix<T> additionMatrix = new GenericMatrix<T>(firstMatrix.Row, firstMatrix.Col);
            for (int r = 0; r < firstMatrix.Row; r++)
            {
                for (int c = 0; c < firstMatrix.Col; c++)
                {
                    additionMatrix[r, c] = (dynamic)firstMatrix[r, c] - secondMatrix[r, c];
                }
            }
            return additionMatrix;
        }

        public static GenericMatrix<T> operator *(GenericMatrix<T> firstMatrix, GenericMatrix<T> secondMatrix)
        {
            if (checkIsInBoundaries(firstMatrix, secondMatrix))
            {
                throw new ArithmeticException("Dimensions of the two matrices must be with same size");
            }
            GenericMatrix<T> additionMatrix = new GenericMatrix<T>(firstMatrix.Row, firstMatrix.Col);
            for (int r = 0; r < firstMatrix.Row; r++)
            {
                for (int c = 0; c < firstMatrix.Col; c++)
                {
                    additionMatrix[r, c] = (dynamic)firstMatrix[r, c] * secondMatrix[r, c];
                }
            }
            return additionMatrix;
        }

        public static GenericMatrix<T> operator /(GenericMatrix<T> firstMatrix, GenericMatrix<T> secondMatrix)
        {
            if (checkIsInBoundaries(firstMatrix, secondMatrix))
            {
                throw new ArithmeticException("Dimensions of the two matrices must be with same size");
            }
            GenericMatrix<T> additionMatrix = new GenericMatrix<T>(firstMatrix.Row, firstMatrix.Col);
            for (int r = 0; r < firstMatrix.Row; r++)
            {
                for (int c = 0; c < firstMatrix.Col; c++)
                {
                    additionMatrix[r, c] = (dynamic)firstMatrix[r, c] / secondMatrix[r, c];
                }
            }
            return additionMatrix;
        }
        
        public static bool operator true(GenericMatrix<T> matrix)
        {
            bool hasZeroElementh = false;
            for (int r = 0; r < matrix.Row; r++)
            {
                for (int c = 0; c < matrix.Col; c++)
                {
                    if ((dynamic)matrix[r, c] == 0)
                    {
                        return hasZeroElementh = true; 
                    }
                }
            }
            return hasZeroElementh;
        }

        public static bool operator false(GenericMatrix<T> matrix)
        {
            bool hasZeroElementh = false;
            for (int r = 0; r < matrix.Row; r++)
            {
                for (int c = 0; c < matrix.Col; c++)
                {
                    if ((dynamic)matrix[r, c] == 0)
                    {
                        return hasZeroElementh = true;
                    }
                }
            }
            return hasZeroElementh;
        }

        //Methods

        private static bool checkIsInBoundaries(GenericMatrix<T> firstMatrix, GenericMatrix<T> secondMatrix)
        {
            if (firstMatrix.Row != secondMatrix.Row || firstMatrix.Col!=secondMatrix.Col)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int r = 0; r < this.Row; r++)
            {
                for (int c = 0; c < this.Col; c++)
                {
                    sb.Append(matrixFields[r, c] + "  ");
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}