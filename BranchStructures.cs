using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class BranchStructures
    {
        public static int GetSolutionComprasion(int a, int b)
        {
            int c;
            if (a > b)
            {
                c = (a + b);
            }
            else if (a == b)
            {
                c = (a * b);
            }
            else
            {
                c = (a - b);
            }
            return c;
        }
        public static string GetQuarter(int x, int y)
        {
            string result = "";
            if (x == 0 || y == 0)
            {
                throw new Exception("It's Impossible to define quarter because x or y are equals zero");
            }
            if (x > 0 && y > 0)
            {
                result = "Первая четверть";
            }
            else if (x < 0 && y > 0)
            {
                result = "Вторая четверть";
            }
            else if (x < 0 && y < 0)
            {
                result = "Третья четверть";
            }
            else if (x > 0 && y < 0)
            {
                result = "Четвертая четверть";
            }
            return result;
        }
        public static int[] GetAscending(int a, int b, int c)
        {

            int[] arr = new int[3];
            int[] result = Copy(arr);
            if (a < b && a < c && b < c)
            {
                arr = new int[3] {a, b, c};
            }
            else if (c < b && b < a && c < b)
            {
                arr = new int[3] {c, b, a};
            }
            else if (b < a && a < c && b < c)
            {
                arr = new int[3] {b, a, c};
            }
            else if (a < c && c < b && a < b)
            {
                arr = new int[3] {a, c, b};
            }
            else if (b < c && c < a && b < a)
            {
                arr = new int[3] {b, c, a};
            }
            else
            {
                arr = new int[3] {c, a, b};
            }
            return arr;
        }
        public static double[] SolvingTheEquationUsingTheDiscriminant(int a, int b, int c)
        {
            if (a == 0)
            {
                throw new Exception("<a> can't be equals zero");
            }
            double[] arr = new double[2];
            
            double result1;
            double result2;
            double d = (b * b) - (4 * a * c);
            if (d<0)
            {
                throw new Exception("the equation has no solutions");
            }
            else if (d > 0)
            {
                result1 = ((-b) + Math.Sqrt(d)) / (2 * a);
                result2 = ((-b) - Math.Sqrt(d)) / (2 * a);
                arr = new double[2] { result1, result2 };
            }
            else if (d==0)
            {
                result1 = ((-b) + Math.Sqrt(d)) / (2 * a);
                arr = new double[1] { result1 };
            }
            return arr;
        }
        public static string Translate(int num)
        {
            string Minus = "";
            string firstWord = "";
            string secondWord = "";
            string result = "";

            if ((num >= -9 && num <= 9) || (num < -99 || num > 99))
            {
                throw new Exception("Number is not in raange");
            }
            if (num < 0)
            {
                num *= -1;
                Minus = "Минус ";
            }
            if (num < 20)
            {
                switch (num)
                {
                    case 10: firstWord = "Десять"; 
                    break;
                    case 11: firstWord = "Одиннадцать"; 
                    break;
                    case 12: firstWord = "Двенадцать"; 
                    break;
                    case 13: firstWord = "Тринадцать"; 
                    break;
                    case 14: firstWord = "Четырнадцать"; 
                    break;
                    case 15: firstWord = "Пятнадцать"; 
                    break;
                    case 16: firstWord = "Шестнадцать";
                    break;
                    case 17: firstWord = "Семьнадцать"; 
                    break;
                    case 18: firstWord = "Восемьнадцать"; 
                    break;
                    case 19: firstWord = "Девятнадцать"; 
                    break;
                }
                result = $"{Minus}{firstWord}";
            }
            else
            {
                switch (num - (num % 10))
                {
                    case 20: firstWord = "Двадцать";
                    break;
                    case 30: firstWord = "Тридцать";
                    break;
                    case 40: firstWord = "Сорок";
                    break;
                    case 50: firstWord = "Пятьдесят"; 
                    break;
                    case 60: firstWord = "Шестьдесят"; 
                    break;
                    case 70: firstWord = "Семьдесят"; 
                    break;
                    case 80: firstWord = "Восемьдесят";
                    break;
                    case 90: firstWord = "Девяносто"; 
                    break;
                }
                switch (num % 10)
                {
                    case 0: secondWord = ""; 
                    break;
                    case 1: secondWord = "один"; 
                    break;
                    case 2: secondWord = "два"; 
                    break;
                    case 3: secondWord = "три"; 
                    break;
                    case 4: secondWord = "четыре"; 
                    break;
                    case 5: secondWord = "пять";
                    break;
                    case 6: secondWord = "шесть";
                    break;
                    case 7: secondWord = "семь";
                    break;
                    case 8: secondWord = "восемь";
                    break;
                    case 9: secondWord = "девять"; 
                    break;
                }
                result = $"{Minus}{firstWord} {secondWord}";

            }
            return result;
        }
        public static int[] Copy(int[] array)
        {
            int[] newArray = new int[array.Length];
            Array.Copy(array, newArray, array.Length);
            return newArray;
        }
    }
}
