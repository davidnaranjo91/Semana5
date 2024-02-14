using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumMostRepeat.Logic
{
    public class NMostRepeat
    {
        private int[] array;

        public NMostRepeat(int num)
        {
            array = new int[num];
        }

        public void NumRepeat(int NRepeat)
        {
            int N = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool NumeroRepetido = true;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        NumeroRepetido = false;
                    }
                }

                if (NumeroRepetido)
                {
                    array[N] = array[i];
                    N++;
                }
            }
        }
    }
}
