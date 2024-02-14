using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPrimos.Logic
{
    public class NumPrimos
    {

        //atributos
        private bool [] array;
              
        

        //constructor
        public NumPrimos(int num)
        {
            array = new bool [num];
            int N = num +1 ;
            for (int i = 2; i <= N; i++)
            {
                array[i] = true;
            }

            for (int j = 2; j * j <= N; j++)
            {
                if (array[j] == true)
                {
                    for(int i = j * j; i <= N; i += j)
                    {
                        array[i] = false;
                    }
                }
            }

            int c = 0;
            for(int i = 2; i <= N; i++)
            {
                if (array[i])
                {
                    c++;
                }
            }

     
        }

        public static int[] NumPrimos(int n)
        {
            throw new NotImplementedException();
        }
    }
}
