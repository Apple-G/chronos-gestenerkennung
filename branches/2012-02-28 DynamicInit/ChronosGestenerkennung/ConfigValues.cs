using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChronosGestenerkennung
{
    class ConfigValues
    {
        public int X { get; private set; }
        public int Y { get; private set; }
          public int Z { get; private set; }

          ConfigValues(int x, int y, int z)
          {
              ChangeValues(x, y, z);
          }
          public void ChangeValues(int x, int y, int z)
          {
              X = x;
              Y = y;
              Z = z;
          }


    }
}
