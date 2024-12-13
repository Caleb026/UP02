using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassLibrary
{
    public class LearnClass
    {
        public int TimeInSeconds(int a, int b) 
        {
            return a * 3600 + b * 60;
        }
        public void EndButton_Click(object sender, EventArgs e)
        {
            int ch, min, sec;
            ch = 11;
            min = 50;
            sec = TimeInSeconds(ch, min);
            int dur = 2400;
            sec = sec + dur;
            int a = sec / 3600;
            sec = sec % 3600;
            int b = sec / 60;
        }
    }
}
