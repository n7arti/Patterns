using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class Performance
    {
        bool info;
        public Performance(String FIO)
        {
            info = false;
        }
        public void setInfo(bool info)
        {
            this.info = info;
        }
        public bool getInfo()
        {
            return info;
        }
    }
}
