﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Simpleprograms
{
    public static class Staticdemo
    {
        static int cno = 123, pre = 5000, cur = 7000;
        static double amt;

        public static int Cno { get => cno; set => cno = value; }
        public static int Pre { get => pre; set => pre = value; }
        public static int Cur { get => cur; set => cur = value; }
        public static double Amt { get => amt; set => amt = value; }


        static Staticdemo()
        {
            if(Cur - Pre <= 100)
            {
                Amt= 0;
            }
        }
        public static void Calc()
        {
            int usage = (Cur - Pre);
            if(usage>100 && usage<=200) {
                Amt = usage * 2;
            }
            else
            {
                Amt = usage * 4;
            }
        }
    }
}
