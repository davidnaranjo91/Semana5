using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumNoRepeat.Logic
{
    public class NNoRepeat
    {
        private int[] array;

        public NNoRepeat(int num)
        {
            array = new int[num];
        }

        public void NumUnico (int NUnico)
        {
            int N = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool NumeroUnico = true;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        NumeroUnico = false;
                    }
                }

                if (NumeroUnico)
                {
                    array[N] = array[i];
                    N++;
                }
            }
        }
    }
}
