﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GIDOO_Lib;
using OpenCvSharp;

namespace GIDOOCV{
    public static class G{
        static public char[] _sep={' ',',','\t'};
        static public char[] _sepC={','};
        static public string _backupDir="backupDir";
        static public Scalar[] colokAky={ Scalar.Red,  Scalar.Blue, Scalar.Green,  Scalar.Yellow, Scalar.Purple, Scalar.RoyalBlue };
    }
}
