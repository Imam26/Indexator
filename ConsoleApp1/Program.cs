using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1.	Создать индексатор для одномерного массива который при установке значения будет возводить 
 * в квадрат передаваемое значение переменной и устанавливать его для указанного индекса. 
 * При получении элемента массива по индексу будет возвращаться его текущее значение.*/
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            Massive mas = new Massive(size);
            try
            {
                for(int i = 0; i<size; i++)
                {
                    mas[i] = i;
                    Console.WriteLine($"mas[{i}] = {mas[i]}");
                }
                mas[11] = 2;
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
            }
        }
    }
}
