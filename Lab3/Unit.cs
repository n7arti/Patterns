using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    abstract class Unit
    {
        public int weight;
        public int maxweight;
        public int len;
        public int id;
        public abstract void addUnit(Unit p, int i);
        public abstract void deleteUnit(int i);
        public abstract void info();
    }
}