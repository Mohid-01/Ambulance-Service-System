using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Service_System
{
    class Review
    {
        public float rev;
        public float revC;

        public Review(string arev, string arevC)
        {
            rev = float.Parse(arev);
            revC = float.Parse(arevC);
        }
        public float calculate()
        {
            rev = rev / revC;
            return rev;
        }
    }
}
