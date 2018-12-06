using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2lon
{
   abstract class Agent
    {
        public double ChiSoHP { get; set; }
        public Agent (double chisohp)
        {
            ChiSoHP = chisohp;
         
            }
    }
}
