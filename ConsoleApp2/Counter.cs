using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Counter
    {
        private int current = 0;
        private int min;

        public int Min
        {
            get { return min; }
            set { min = value; }
        }

        private int max;

        public int Max
        {
            get { return max; }
            set { max = value; }
        }

        public Counter()
        {
            min = 0; max = 0;
        }
        public Counter(int min, int max)
        {
            this.min = min; this.max = max;
        }
        public void increment()
        {
            if( current<max)
            {
                current++;
            }
            else { current = min; }
        }
        public void decrement()
        {
            if(current>min)
            {
                current--;
            }
            else {current=max; }
            
        }
        public int getCurrent() { return current; }


    }
}
