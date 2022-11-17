using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class PerfInfo
    {
        Teacher teacher;
        bool info;
        public PerfInfo(String FIO)
        {
            teacher = new Teacher(FIO);
            info = false;
        }
        public Teacher getTeacher()
        {
            return teacher;
        }
        public bool getInfo()
        {
            return info;
        }
        public void setInfo(bool info)
        {
            this.info = info;
        }

    }
}
