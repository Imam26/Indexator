using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Massive
    {
        private int[] mas;
        private int size;

        public Massive(int size)
        {
            mas = new int[size];
            this.size = size;
        }

        public int this[int index]
        {
            get
            {
                return mas[index];
            }
            set
            {
                mas[index] = value * value;
            }
        }

        public int Size
        {
            get=>size;
            set
            {
                mas = new int[value];
                size = value;
            }
        }
    }
}
