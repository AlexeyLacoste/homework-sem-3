﻿// Задача 2: Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет
// количество чётных чисел в массиве.

namespace Task_01
{
    public class Task_01
    {
        public const int MIN = 1;
        public const int MAX = 100;

        public static void Main(string[] args) {
            System.Console.Write("Введите размерность генерируемого массива: ");

            int arraySize = GetArraySizeFromConsole();
            while (arraySize < 0) {
                arraySize = GetArraySizeFromConsole();
            }

            int[] array = GetArrayWithRandomValue(arraySize);

            System.Console.WriteLine("Оригинальный массив:");
            System.Console.WriteLine(PrintArray(array));

            System.Console.WriteLine("Количество чётных элементов входящих в массив:");
            System.Console.WriteLine(CountEvenNumber(array));
        }

        public static int GetArraySizeFromConsole() {
            try{
                return Convert.ToInt32(Console.ReadLine());
            } catch (Exception)
                {
                System.Console.WriteLine("Введеное значение не ядляется числом. Попробуйте снова.");
            }
            return -1;
        }

        public static int[] GetArrayWithRandomValue(int size) {
            int[] array = new int[size];
            for(int i = 0; i < size; i++) {
                array[i] = new Random().Next(MIN, MAX);
            }
            return array;
        }

        public static int CountEvenNumber(int[] array) {
            int count = 0;
            foreach(int item in array) {
                if(item % 2 == 0) count++;
            }
            return count;
        }

        public static string PrintArray(int[] array) {
            string result = "";
            foreach(int item in array) {
                result = result + item + " ";
            }
            return result;
        }
    }
}