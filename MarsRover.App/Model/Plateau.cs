using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.App.Model
{
    public static class Plateau
    {
        public static readonly int LX = 0;
        public static readonly int LY = 0;
        public static int UX { get; internal set; }
        public static int UY { get; internal set; }

        public static void SetUpperCoordinate(int ux , int uy)
        {
            UX = ux;
            UY = uy;
        }
    }
    
}
