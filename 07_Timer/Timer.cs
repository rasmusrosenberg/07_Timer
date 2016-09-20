using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Timer
{
    class Timer
    {

        public int Seconds = 0;

        public override String ToString()
        {

            int h = (Seconds / 60) / 60;
            int m = (Seconds / 60) - (h * 60);
            int s = (Seconds - (h * 60 * 60) - (m * 60));

            return Padded(h) + ":" +
                   Padded(m) + ":" +
                   Padded(s);

        }

        public String Padded(int number)
        {
            return number.ToString("00");
        }

    }
}
