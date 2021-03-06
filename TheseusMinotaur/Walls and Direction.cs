﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheseusMinotaur
{
    [Flags]
    enum TheWalls
    {
        None = 0x0,
        North = 0x1,
        East = 0x2,
        South = 0x4,
        West = 0x8,
        End = 0x10
    }

    internal struct Direction
    {
        internal static Point Up = new Point(0, -1);
        internal static Point Down = new Point(0, 1);
        internal static Point Right = new Point(1, 0);
        internal static Point Left = new Point(-1, 0);
        internal static Point Pass = new Point(0, 0);
    }

}
