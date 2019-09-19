SCREEN.cs


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Graphics3Dto2D
{
    class SCREEN
    {
       public _2Dpoint center;
       public _2Dpoint size;
        public SCREEN()
        {
            center = new _2Dpoint(720,420);
            size = new _2Dpoint(800, 800);
        }
    }
}