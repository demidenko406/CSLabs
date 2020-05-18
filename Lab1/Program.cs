using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void InfoMatrix(float[,] array, int position, int row, int coloms, int i)
        {
            Console.WriteLine("Enter members of matrix:" + (position + 1) + "/" + row * coloms + "\n");
            for (int g = 0, point = 0; g <= i; g++)
            {
                for (int k = 0; point != position && k < coloms; k++, point++)
                {
                    Console.Write(String.Format("{0,3}", array[g, k]) + " ");
                }
                Console.Write("\n");

            }
        }

        static void ShowMatrix(float[,] array, int row, int coloms)
        {
            Console.WriteLine("Show matrix:");
            for (int g = 0; g < row; g++)
            {
                for (int k = 0; k < coloms; k++)
                {
                    Console.Write(String.Format("{0,3}", array[g, k]) + " ");
                }
                Console.Write("\n");
            }
        }


        static void ErrorFunc(string error, string myExplanation)
        {
            Console.WriteLine("------------------------------------------------------------------\n");
            Console.WriteLine("Error. Code:" + error + " \nExplanation:" + myExplanation + " \n");
            Console.WriteLine("Press any key to overwrite number\n");
            Console.WriteLine("------------------------------------------------------------------\n");
            Console.ReadKey();
            Console.Clear();
        }

        static void MenuSwitch(int space)
        {
            space--;
            Console.WriteLine("  Введите матрицу(обновите)\n  Показать матрицу\n  Найти определитель\n  Найти обратную\n  Транспонировать\n  Умножить на\n  Возвести в степень\n  Сложить с матрицей\n  Отнять матрицу\n  Выход ");
            Console.SetCursorPosition(0, space);
            Console.Write("->");
        }

        static void Menu()
        {
            int row = 0;
            int coloms = 0;
            float[,] array = new float[0, 0];
            float[,] array2 = new float[0, 0];
            while (true)
            {
                int switchMenu = 1;
                MenuSwitch(switchMenu);
                ConsoleKeyInfo menu;
                while (true)
                {
                    do
                    {
                        menu = Console.ReadKey();
                    } while (menu.Key != ConsoleKey.UpArrow && menu.Key != ConsoleKey.DownArrow && menu.Key != ConsoleKey.Enter);
                    Console.Clear();
                    if (menu.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                    if (menu.Key == ConsoleKey.UpArrow)
                    {
                        switchMenu--;
                    }
                    else
                    {
                        switchMenu++;
                    }

                    if (switchMenu <= 0)
                    {
                        switchMenu = 10;
                    }
                    else if (switchMenu >= 11)
                    {
                        switchMenu = 1;
                    }
                    MenuSwitch(switchMenu);

                }
                Console.Clear();
                if (switchMenu != 1 && switchMenu != 10 && row == 0 && coloms == 0)
                {
                    ErrorFunc("Error0x5378", "Enter matrix");

                }
                else
                {
                    switch (switchMenu)
                    {
                        case 1:
                            array = MatrixBuild(ref row, ref coloms);
                            break;
                        case 2:
                            ShowMatrix(array, row, coloms);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 3:
                            Console.Clear();
                            if (row == coloms)
                            {
                                UInt64[] comArray = CombInfo(row);

                                double result = FindDet(array, comArray, row);
                                Console.WriteLine(result);
                                Console.WriteLine("Press any key");
                                Console.ReadKey();
                                Console.Clear();

                            }
                            else
                            {
                                ErrorFunc("Error0x76465", "Need square matrix");
                            }

                            break;
                        case 4:
                            Console.Clear();
                            if (row == coloms)
                            {
                                UInt64[] comArray = CombInfo(row);

                                double result = FindDet(array, comArray, row);
                                if (result != 0)
                                {

                                    array = FindMinor(array, row, coloms, result);
                                    Console.WriteLine("Successful, Press any key");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    ErrorFunc("Error0x65475", "Explanation: Determinant = 0");
                                }

                            }
                            else
                            {
                                ErrorFunc("Error0x76465", "Need square matrix");
                            }
                            break;
                        case 5:
                            array = Transposed(array, ref row, ref coloms);
                            Console.WriteLine("Successful, Press any key");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine("Please, write number:");
                            float number;
                            do
                            {

                                if (!float.TryParse(Console.ReadLine(), out number))
                                {
                                    break;
                                }
                                ErrorFunc("Error0x0120", "Number entered incorrectly");


                            } while (true);
                            array = Multiplication(array, row, coloms, number);
                            Console.WriteLine("Successful, Press any key");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 7:
                            if (row == coloms)
                            {
                                array = PowerArray(array, row);
                                Console.WriteLine("Successful, Press any key");
                                Console.ReadKey();
                                Console.Clear();

                            }
                            else
                            {
                                ErrorFunc("Error0x76465", "Need square matrix");
                            }
                            break;
                        case 8:
                            array2 = Build(array2, row, coloms);

                            array = MatrixSum(array, array2, row, coloms);
                            break;
                        case 9:
                            array2 = Build(array2, row, coloms);
                            array = MatrixMinus(array, array2, row, coloms);
                            break;
                        case 10:
                            Environment.Exit(0);
                            break;

                    }
                }
            }
        }

        static float[,] MatrixSum(float[,] array, float[,] array2, int row, int coloms)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < coloms; j++)
                {
                    array[i, j] += array2[i, j];
                }
            }
            return array;
        }

        static float[,] MatrixMinus(float[,] array, float[,] array2, int row, int coloms)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < coloms; j++)
                {
                    array[i, j] -= array2[i, j];
                }
            }
            return array;
        }



        static float[,] MatrixBuild(ref int row, ref int coloms)
        {
            do
            {
                Console.WriteLine("Please, set number of coloms:");


                if (int.TryParse(Console.ReadLine(), out coloms) && coloms > 0)
                {
                    break;
                }
                ErrorFunc("Error0x0120", "Number entered incorrectly");

            } while (true);

            do
            {
                Console.WriteLine("Please, set number of row:");

                if (int.TryParse(Console.ReadLine(), out row) && row > 0)
                {
                    break;
                }
                ErrorFunc("Error0x0120", "Number entered incorrectly");

            } while (true);

            float[,] array = new float[row, coloms];


            array = Build(array, row, coloms);
            return array;
        }

        static float[,] Build(float[,] array, int row, int coloms)
        {
            array = new float[row, coloms];
            int position = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < coloms; j++)
                {
                    do
                    {
                        InfoMatrix(array, position, row, coloms, i);
                        if (float.TryParse(Console.ReadLine(), out array[i, j]))
                        {
                            break;
                        }
                        ErrorFunc("Error0x0120", "Number entered incorrectly");

                    } while (true);
                    position++;
                    Console.Clear();

                }
            }
            return array;
        }


        static UInt64[] CombInfo(int row)
        {

            int result = Factorial(row);
            UInt64[] tempArray = new UInt64[row];
            UInt64[] comArray = new UInt64[result];
            int temp = 0;

            for (int i = 0; i < row; i++)
            {
                tempArray[i] = Convert.ToUInt64(i + 1);
            }
            for (int i = 0; i < result; i++)
            {
                comArray[i] = 0;
            }
            for (int i = 0; i < row; i++)
            {
                comArray[temp] += Convert.ToUInt64(tempArray[i] * Convert.ToUInt64(Math.Pow(10, i)));
            }
            while (NextSet(tempArray, row))
            {
                temp++;
                for (int i = 0; i < row; i++)
                {
                    comArray[temp] += Convert.ToUInt64(tempArray[i] * Convert.ToUInt64(Math.Pow(10, i)));
                }
            }

            return comArray;
        }

        static bool NextSet(UInt64[] tempArray, int row)
        {
            int j = row - 2;

            while (j != -1 && tempArray[j] >= tempArray[j + 1])
            {
                j--;
            }
            if (j == -1)
            {
                return false;
            }
            int k = row - 1;
            while (tempArray[j] >= tempArray[k])
            {
                k--;
            }
            Swap(tempArray, j, k);
            int l = j + 1;
            int r = row - 1;
            while (l < r)
            {
                Swap(tempArray, l++, r--);
            }
            return true;
        }

        static void Swap(UInt64[] tempArray, int i, int j)
        {
            UInt64 s = tempArray[i];
            tempArray[i] = tempArray[j];
            tempArray[j] = s;
        }

        static int Factorial(int row)
        {
            int result = 1;
            for (int i = 1; i <= row; i++)
            {
                result *= i;
            }
            return result;
        }



        static double FindDet(float[,] array, UInt64[] comArray, int row)
        {
            int leng = Factorial(row);
            UInt64[] tempArray = new UInt64[row];
            double result = 0;
            double tempResult = 0;
            for (int i = 0; i < row; i++)
            {
                if (comArray[i] < 0)
                {
                    ErrorFunc("Error0x846343", "Explanation: Int overflow");
                    Environment.Exit(0);
                }
            }
            for (int i = 0; i < leng; i++)
            {
                tempResult = 1;
                for (int j = 0; j < row; j++)
                {


                    tempResult *= array[j, (comArray[i] % 10) - 1];
                    tempArray[j] = comArray[i] % 10;
                    comArray[i] /= 10;

                }
                int sign = SortSelect(tempArray, row);
                if (sign % 2 == 0)
                {
                    result += tempResult;
                }
                else
                {
                    result -= tempResult;
                }



            }
            return result;
        }

        static int SortSelect(UInt64[] tempArray, int size)
        {
            int sign = 0;
            for (int i = 0; i < size - 1; i++)
            {
                UInt64 temp = tempArray[0];
                for (int j = i + 1; j < size; j++)
                {
                    if (tempArray[i] > tempArray[j])
                    {
                        Swap(tempArray, i, j);
                        sign++;
                    }
                }
            }
            return sign;
        }

        static float[,] Transposed(float[,] array, ref int row, ref int coloms)
        {
            float[,] newArray = new float[coloms, row];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < coloms; j++)
                {
                    newArray[j, i] = array[i, j];
                }
            }
            int temp = row;
            row = coloms;
            coloms = temp;
            return newArray;
        }

        static float[,] FindMinor(float[,] array, int row, int coloms, double result)
        {
            float[,] newArray = new float[row, coloms];
            float[,] detArray = new float[row - 1, coloms - 1];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < coloms; j++)
                {
                    UInt64[] comArray = CombInfo(row - 1);
                    detArray = DetArrayNumber(detArray, array, row, i, j);
                    newArray[i, j] = Convert.ToInt32(Convert.ToInt64(Math.Pow(-1, j + i)) * FindDet(detArray, comArray, row - 1) / result);
                }
            }
            return newArray;
        }

        static float[,] DetArrayNumber(float[,] detArray, float[,] array, int size, int deleteI, int deleteJ)
        {
            float[,] tempArray1 = new float[size - 1, size];
            for (int i = 0; i < deleteI; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    tempArray1[i, j] = array[i, j];
                }
            }
            for (int i = deleteI + 1; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    tempArray1[i - 1, j] = array[i, j];
                }
            }
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = 0; j < deleteJ; j++)
                {
                    detArray[i, j] = tempArray1[i, j];
                }
            }
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = deleteJ + 1; j < size; j++)
                {
                    detArray[i, j - 1] = tempArray1[i, j];
                }
            }

            return detArray;
        }

        static float[,] Multiplication(float[,] array, int row, int coloms, float number)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < coloms; j++)
                {
                    array[i, j] *= number;
                }
            }
            return array;
        }

        static float[,] PowerArray(float[,] array, int row)
        {
            float[,] tempArray = new float[row, row];
            int j = 0;
            for (int i = 0; i < row; i++)
            {                // заполнение нового массива
                for (int g = 0; g < row; g++, j++)
                {
                    tempArray[i, g] = array[i, g];
                }
            }
            int u;
            Console.Write("\n\n\nSet k = ");
            do
            {
                if (int.TryParse(Console.ReadLine(), out u))
                {
                    break;
                }
                ErrorFunc("Error0x0120", "Number entered incorrectly");

            } while (true);

            float[,] newArray = new float[row, row];
            float sum = 0;


            for (int p = 1; p < u; p++)
            {
                for (int y1 = 0; y1 < row; y1++)
                {
                    for (int x2 = 0; x2 < row; x2++)
                    {
                        sum = 0;
                        for (int x1 = 0, y2 = 0; x1 < row || y2 < row; x1++, y2++)
                        {
                            sum += array[y1, x1] * tempArray[y2, x2];
                            newArray[y1, x2] = sum;
                        }
                    }
                }
                for (int i = 0; i < row; i++)
                {                // заполнение нового массива
                    for (int g = 0; g < row; g++, j++)
                    {
                        tempArray[i, g] = newArray[i, g];
                    }
                }
            }
            return newArray;
        }

    }
}
