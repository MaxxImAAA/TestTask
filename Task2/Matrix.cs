using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Matrix
    {
        public List<int> GetArray(int[,] array )
        {
           


            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            var newArray = new List<int>();

            int razmernos = rows * cols;



            int jStart = 0;
            int iStart = 0;

            int iEnd = rows-1;
            int jEnd = cols-1;


            var numbers = new List<int>();
            int Count = 0;

            while (Count != razmernos)
            {
                for (int i = iStart, j = jStart; i <= iEnd; i++)
                {
                    if (Count == razmernos)
                        break;
                    newArray.Add(array[i, j]);
                    Count++;


                }

                jStart++;

                for (int i = iEnd, j = jStart; j <= jEnd; j++)
                {
                    if (Count == razmernos)
                        break;
                    newArray.Add(array[i, j]);
                    Count++;

                }

                iEnd--;

                for (int i = iEnd, j = jEnd; i >= iStart; i--)
                {
                    if (Count == razmernos)
                        break;
                    newArray.Add(array[i, j]);
                    Count++;

                }

                jEnd--;

                for (int i = iStart, j = jEnd; j >= jStart; j--)
                {
                    if (Count == razmernos)
                        break;
                    newArray.Add(array[i, j]);
                    Count++;

                }
                iStart++;


            }

            return newArray;
        }

        public void SetArray(int[,]array)
        {
            var rnd = new Random();
            for (int i1 = 0; i1 < array.GetLength(0); i1++)
            {
                for (int j1 = 0; j1 < array.GetLength(1); j1++)
                {
                    array[i1, j1] = rnd.Next(1, 10);
                }

            }

        }

        public void VyvodArray(int[,]array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
