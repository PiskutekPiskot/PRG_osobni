using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Matice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> operations = new List<string>//list s možnými operacemi
            {
              "SwapTwoNumbers","SwapTwoRows","SwapTwoColumns","SwapValuesOnMainDiagonal","SwapValuesOnSecondaryDiagonal",
              "MultiplyArrayByNumber","MultiplyRowByNumber","MultiplyColumnByNumber","AddTwoArrays","SubtractTwoArrays",
              "MultiplyTwoArrays","FlipArrayByMainDiagonal","CreateNewRandomarray","CreateNewSequentialArray"
            };
            bool IncorrectInput = true;
            int a = 0;
            int b=0;
            int[,] mainArray =new int[a,b];
            Console.WriteLine("Create an array" +'\n'+ "type 1 for a sequential array" + '\n' + "type 2 for a random array");
            while (IncorrectInput)//opakovaně čte vstup, dokud uživatel nezadá 1 nebo 2
            {
                string input = Console.ReadLine();
                if (input == "1")
                {
                    IncorrectInput = false;
                    Console.WriteLine("input size x off array (vertical)");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("input size y off array (horizontal)");
                    b = Convert.ToInt32(Console.ReadLine());
                    mainArray = sequentialArray(a, b);
                    writeArray(a,b,mainArray);
                }
                else if (input == "2")
                {
                    IncorrectInput = false;
                    Console.WriteLine("input size x off array (vertical)");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("input size y off array (horizontal)");
                    b = Convert.ToInt32(Console.ReadLine());
                    mainArray = randomArray(a, b);
                    writeArray(a,b,mainArray );
                }
                else
                {
                    Console.WriteLine("Write 1 or 2");
                }
            } 
            Console.WriteLine("This program can:");
            foreach (string op in operations)
            {
                Console.WriteLine(op);
            }Console.WriteLine('\n');
            while (true)
            {
                Console.WriteLine("Pick an operation");
                string operation = Console.ReadLine();
                while (!operations.Contains(operation))
                {
                    Console.WriteLine("The operation you picked isn't in the list. Pick an operation");
                    operation = Console.ReadLine();
                }
                switch (operation)//přečtený vstup vyvolá funkci
                {
                    case ("SwapTwoNumbers"):
                        writeArray(a, b, numsSwap(a, b, mainArray)); break;
                    case ("SwapTwoRows"):
                        writeArray(a, b, rowSwap(b, mainArray)); break;
                    case ("SwapTwoColumns"):
                        writeArray(a, b, columnSwap(a, mainArray)); break;
                    case ("SwapValuesOnMainDiagonal"):
                        writeArray(a, b, mainDiagonalSwap(a, b, mainArray)); break;
                    case ("SwapValuesOnSecondaryDiagonal"):
                        writeArray(a, b, secondaryDiagonalSwap(a, b, mainArray)); break;
                    case ("MultiplyArrayByNumber"):
                        writeArray(a, b, arrayMultiplication(a, b, mainArray)); break;
                    case ("MultiplyRowByNumber"):
                        writeArray(a, b, rowMlutiplication(b, mainArray)); break;
                    case ("MultiplyColumnByNumber"):
                        writeArray(a, b, columnMlutiplication(a, mainArray)); break;
                    case ("AddTwoArrays"):
                        writeArray(a, b, arrayAdition(a, b, mainArray, sequentialArray(a, b))); break;
                    case ("SubtractTwoArrays"):
                        writeArray(a, b, arraySubtraction(a, b, mainArray, sequentialArray(a, b))); break;
                    case ("FlipArrayByMainDiagonal"):
                        writeArray(b, a, arrayTransposition(a, b, mainArray)); break;
                    case ("MultiplyTwoArrays"):
                        arrayByArrayMultiplication(a, b, mainArray); break;
                    case ("CreateNewRandomarray"):
                        randomArray(a, b); break;
                    case ("CreateNewSequentialArray"):
                        sequentialArray(a, b); break;
                }
            }
        }
        static int[,] randomArray(int a,int b)
        {
            Random rnd = new Random();
            int[,] mainArray = new int[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    mainArray[i, j] = rnd.Next(9);
                }
            }
            return mainArray;
        }
        static int[,] sequentialArray(int a, int b)
        {
            int num = 1;
            int[,] mainArray = new int[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    mainArray[i, j] = num;
                    num++;
                }
            }
            return mainArray;
        }
        static void writeArray(int a,int b, int[,] array)
        {
            Console.WriteLine(" ");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
        }
        static int[,] numsSwap(int a, int b,int[,] array)
        {
            int [,] numsSwapArray = (int[,])array.Clone();
            Random rnd = new Random();
            int xFirst, yFirst, xSecond, ySecond, swap;
            xFirst = rnd.Next(a);
            yFirst = rnd.Next(b);
            xSecond = rnd.Next(a);
            ySecond = rnd.Next(b);
            swap = numsSwapArray[xFirst, yFirst];
            numsSwapArray[xFirst, yFirst] = numsSwapArray[xSecond, ySecond];
            numsSwapArray[xSecond, ySecond] = swap;
            return numsSwapArray;
        }
        static int[,] rowSwap(int b, int[,]array)
        {
            int[,] rowSwapArray = (int[,])array.Clone();
            Random rnd = new Random();
            int nRowSwap = rnd.Next(b);
            int mRowSwap = rnd.Next(b);
            int[] arrayRow = new int[b];
            for (int i = 0; i < b; i++)
            {
                arrayRow[i] = rowSwapArray[mRowSwap, i];
                rowSwapArray[mRowSwap, i] = rowSwapArray[nRowSwap, i];
                rowSwapArray[nRowSwap, i] = arrayRow[i];
            }
            return rowSwapArray;
        }
        static int[,] columnSwap(int a, int[,] array)
        {
            int[,] columnSwapArray = (int[,])array.Clone();
            Random rnd = new Random();
            int nColumnSwap = rnd.Next(a);
            int mColumnSwap = rnd.Next(a);
            int[] arrayColumn = new int[a];
            for (int i = 0; i < a; i++)
            {
                arrayColumn[i] = columnSwapArray[i,mColumnSwap];
                columnSwapArray[i,mColumnSwap] = columnSwapArray[i,nColumnSwap];
                columnSwapArray[i,nColumnSwap] = arrayColumn[i];
            }
            return columnSwapArray;
        }
        static int[,] mainDiagonalSwap(int a,int b, int[,]array)
        {
            int[,] mainDiagonalSwapArray = (int[,])array.Clone();
            int c = Math.Min(a, b);
            int[] arrayDiagonal = new int[c];
            for (int i = 0; i < c; i++)
            {
                arrayDiagonal[i] = mainDiagonalSwapArray[i, i];
            }
            for (int i = 0; i < c; i++)
            {
                mainDiagonalSwapArray[i, i] = arrayDiagonal[arrayDiagonal.GetLength(0) - 1 - i];
            }
            return mainDiagonalSwapArray;
        }
        static int[,]secondaryDiagonalSwap(int a, int b, int[,]array)
        {
            int[,] secondaryDiagonalSwapArray = (int[,])array.Clone();
            int c = Math.Min(a, b);
            int[] array2Diagonal = new int[a];
            for (int i = 0; i < c; i++)
            {
                array2Diagonal[i] = secondaryDiagonalSwapArray[i, b - 1 - i];
            }
            for (int i = 0; i < c; i++)
            {
                secondaryDiagonalSwapArray[i, b - 1 - i] = array2Diagonal[c - 1 - i];
            }
            return secondaryDiagonalSwapArray;
        }
        static int[,]arrayMultiplication(int a, int b, int[,]array)
        {
            int[,] multipliedArray = (int[,])array.Clone();
            Console.WriteLine("Input the multiplier of the array");
            int multiplier = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    multipliedArray[i, j] = multipliedArray[i, j] * multiplier;
                }
            }
            return multipliedArray;
        }
        static int[,]rowMlutiplication(int b, int[,]array)
        {
            int[,] multipliedRowArray = (int[,])array.Clone();
            Console.WriteLine("Input the multiplier of the array");
            int multiplier = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the row to multiply");
            int row= Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < b; i++)
            {
                multipliedRowArray[row, i]= multipliedRowArray[row, i]*multiplier;
            }
            return multipliedRowArray;
        }
        static int[,] columnMlutiplication(int a, int[,] array)
        {
            int[,] multipliedColumnArray = (int[,])array.Clone();
            Console.WriteLine("Input the multiplier of the array");
            int multiplier = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the column to multiply");
            int column = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                multipliedColumnArray[i,column] = multipliedColumnArray[i,column] * multiplier;
            }
            return multipliedColumnArray;
        }
        static int[,] arrayAdition(int a, int b, int[,] arrayA, int[,]arrayB)
        {
            int[,] addedArray = (int[,])arrayA.Clone();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    addedArray[i, j] = addedArray[i, j] + arrayB[i,j];
                }
            }
            return addedArray;
        }
        static int[,] arraySubtraction(int a, int b, int[,] arrayA, int[,] arrayB)
        {
            int[,] subtractedArray = (int[,])arrayA.Clone();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    subtractedArray[i, j] = subtractedArray[i, j] - arrayB[i, j];
                }
            }
            return subtractedArray;
        }
        static int[,] arrayTransposition(int a,int b, int[,]array)
        {
            int[,] transposedArray = new int[b,a];
            int[,] arrayClone = (int[,])array.Clone(); 
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    transposedArray[i,j] = arrayClone[j,i];
                }
            }
            return transposedArray;
        }
        static void arrayByArrayMultiplication(int a, int b, int[,] array)
        {
            int[,] arrayA = (int[,])array.Clone();
            int aa = b;
            Console.WriteLine("input size y off second array (horizontal)");
            int bb = Convert.ToInt32(Console.ReadLine());
            int[,] arrayB = sequentialArray(aa, bb);
            int[,] multipliedByArray = new int[a,bb];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < bb; j++)
                {
                    for (int k = 0; k < b; k++)
                    {
                        multipliedByArray[i, j] += arrayA[i, k] * arrayB[k, j];
                    }
                }
            }
            Console.WriteLine(" ");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < bb; j++)
                {
                    Console.Write(multipliedByArray[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
        }
    }
}