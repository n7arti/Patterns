using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Storage
    {

        public List<Driver> dr = new List<Driver>();
        public List<Passenger> ps = new List<Passenger>();
        public void Info()
        {
            int i;
            for (i = 0; i < dr.Count; ++i) 
                dr[i].Info();
            for (i = 0; i < ps.Count; ++i)
                ps[i].Info();
        }

    }
}
