﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1.	В С # индексация начинается с нуля, но в некоторых языках программирования это не так. 
 * Например, в Turbo Pascal индексация массиве начинается с 1. Напишите класс RangeOfArray, 
 * который позволяет работать с массивом такого типа, в котором индексный диапазон устанавливается пользователем. 
 * Например, в диапазоне от 6 до 10, или от –9 до 15.
Подсказка: В классе можно объявить две переменных, которые будут содержать верхний и нижний индекс допустимого диапазона.
*/
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowerIndex = -5;
            int upperIndex = 10;
            RangeOfArray rArray = new RangeOfArray(upperIndex, lowerIndex);
            try
            {
                for (int i = lowerIndex; i < upperIndex; i++)
                {
                    rArray[i] = i;
                    Console.WriteLine($"rArray[{i}] = {rArray[i]}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
