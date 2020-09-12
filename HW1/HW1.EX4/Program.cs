using System;
using System.Threading;

namespace HW1.EX4
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int row, col;
            Console.Write("Eg1\ninput:\n3\n4\n| 1 2 3 4 |\n| 4 1 2 3 |\n| 3 4 1 2 |\noutput: True\n\nEg2\ninput:\n4\n4\n| 1 2 3 4 |\n| 4 1 2 3 |\n| 3 4 1 2 |\n| 2 3 1 4 |\noutput: False\n\n");
            Console.WriteLine("the number of rows is : ");
            row = int.Parse( Console.ReadLine());
            Console.WriteLine("the number of cols is : ");
            col = int.Parse( Console.ReadLine());

            string[] str = new string[row];
            int[,] matrix = new int[row, col];

            for(int i = 0; i < row; i++)
            {
                str[i] = Console.ReadLine();

            }
            CreateMatrix(ref matrix, row, col, str);
            Console.WriteLine(IsToeplitzMatrix(matrix,row,col));

            
        }

        public static void CreateMatrix(ref int[,] matrix, int row, int col,string[] str)
        {
            for ( int i = 0; i < row; i++)
            {
                int a = -1;
                string[] s = new string[col];
                int j = 0;
                while(j < str[i].Length && a < col)
                {
                    if ( str[i][j] == ' ')
                    {
                        a++;
                    }
                    else if (a >= 0)
                    {
                        s[a] += str[i][j];
                    }
                    j++;
                }
                for(int n = 0; n < col; n++ )
                {
                    matrix[i, n] = int.Parse(s[n]);
                }
            }
        }

        public static bool IsToeplitzMatrix(int[,] matrix, int row, int col)
        {
            bool flag = true;
            int i = 0;
            while (i < row)
            {
                int a1 = i, a2 = 0;
                int value = matrix[a1, a2];
                while (a1 < row && a2 < col)
                {
                    if (matrix[a1, a2] != value)
                    {
                        flag = false;
                        return flag;
                    }
                    a1++;
                    a2++;
                }
                i++;
            }
            i = 0;
            while (i < col)
            {
                int a1 = 0, a2 = i;
                int value = matrix[a1, a2];
                while (a1 < row && a2 < col)
                {
                    if (matrix[a1, a2] != value)
                    {
                        flag = false;
                        return flag;
                    }
                    a1++;
                    a2++;
                }
                i++;
            }
            return flag;
        }

    }
}
