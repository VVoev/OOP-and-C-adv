using Homework_Defining_Classes_Part2.PointProject;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Defining_Classes_Part2.MatrixProject
{
    class MatrixTest
    {
        public static void Matrix()
        {
            //Start 
            NewLine.ProgramStart("Matrix");
            Stopwatch watch = NewLine.StartProgram();


            var firstMatrix  = new GenericMatrix<int>(10, 20);
            var secondMatrix = new GenericMatrix<int>(10, 20);
            for (int i = 0; i < firstMatrix.Row; i++)
            {
                for (int j = 0; j < firstMatrix.Col; j++)
                {
                    firstMatrix[i, j] = i + 2;
                    secondMatrix[i, j] = i * 2;
                }
            }

            //First matrix
            Console.WriteLine("First Matrix");
            Console.WriteLine(CheckZero(firstMatrix));
            Console.WriteLine(firstMatrix.ToString());
            NewLine.MakeThreeNewLines();

            //Second matrix
            Console.WriteLine("Second Matrix");
            Console.WriteLine(CheckZero(secondMatrix));
            Console.WriteLine(secondMatrix.ToString());
            NewLine.MakeThreeNewLines();

            //Math Operations with two matrixes
            var additionalMatrix = firstMatrix + secondMatrix;
            var substractMatrix = firstMatrix - secondMatrix;
            var multiMatrix = firstMatrix * secondMatrix;
            
            //Printing each matrix
            //+
            Console.WriteLine("------------------------");
            Console.WriteLine("-----Operation Plus-----");
            Console.WriteLine(additionalMatrix);

            //-
            Console.WriteLine("------------------------");
            Console.WriteLine("-----Operation Minus-----");
            Console.WriteLine(substractMatrix);

            //*
            Console.WriteLine("------------------------");
            Console.WriteLine("-----Operation Multiply-----");
            Console.WriteLine(multiMatrix);


            //Finish
            NewLine.ProgramFinish("Matrix");
            NewLine.EndProgram(watch);
            NewLine.MakeThreeNewLines();

        }

         static string  CheckZero(GenericMatrix<int> matrix)
        {
            string res = string.Empty;
            if(matrix)
            {
                return res = "Current matrix has zero elementh";
            }
            else
            {
                return res = "Current matrix has NOT zero elementh";
            }
        }
    }
}
