using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class RangeOfArray
    {
        private int[] mas;
        private int upperIndex;
        private int lowerIndex;

        public RangeOfArray(int upperIndex, int lowerIndex)
        {
            mas = new int[upperIndex - lowerIndex];
            this.upperIndex = upperIndex;
            this.lowerIndex = lowerIndex;
        }

        public int this[int index]
        {
            get
            {
                return mas[index - lowerIndex];
            }
            set
            {
                mas[index - lowerIndex] = value;
            }
        }

        public int[] Mas
        {
            get=>mas;
        }
    }
}
