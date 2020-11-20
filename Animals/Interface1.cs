using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    interface Interface1
    {
        public int Weight { get; set; }
        public int Age { get; set; }
        public void Eating();
        public void Older();
    }
}
