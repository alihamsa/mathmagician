using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Integer
    {
        public int GetFirst()
        {
            return 0;
        }

        public int GetNext(int current)
        {
            return current + 1;
        }

        public int[] GetSequence(int how_many)
        {
            int[] seq_array = new int[how_many];
            /*
            for (int i = 0; i < how_many; i++)
            {
                seq_array[i] = i;
            }
            return seq_array;
            */
            int counter = 0;
            seq_array[counter] = GetFirst();
            while (counter < how_many)
            {
                /*
                seq_array[counter + 1] = GetNext(counter);
                counter++;
                */
            }
        }
    }
}
