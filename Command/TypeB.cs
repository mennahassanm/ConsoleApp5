﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeB
    {

        private int X;

        internal int Y;

        public int Z; 

        void Fun01()
        { 
            TypeA typeA = new TypeA();

            TypeB typeB = new TypeB();

             typeB.X = 12 ; // Valid

            typeB.Y = 13; // Valid

            typeB.Z = 14; // Valid


        }
    }
}
