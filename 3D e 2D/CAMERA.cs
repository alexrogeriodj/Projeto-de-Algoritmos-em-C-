CAMERA.cs


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Graphics3Dto2D
{
    class CAMERA
    {
       public _3Dpoint from;
       public _3Dpoint to;
       public _3Dpoint up;
       public double angleh, anglev;
       public double zoom;
       public double front, back;
       public short projection;
       public CAMERA()
        {
            from = new _3Dpoint(0,-50,0);
            to = new _3Dpoint(0,50,0);
            up = new _3Dpoint(0,0,1);
            angleh = 45.0;
            anglev = 45.0;
            zoom = 1.0;
            front = 1.0;
            back = 200.0;
            projection = 0;
 
        }
    }
}