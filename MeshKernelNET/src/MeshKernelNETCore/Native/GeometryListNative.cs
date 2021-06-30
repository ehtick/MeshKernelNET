﻿using System;
using System.Runtime.InteropServices;

namespace MeshKernelNETCore.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GeometryListNative
    {
        public double geometrySeperator;

        public double innerOuterSeperator;

        public int numberOfCoordinates;

        public IntPtr xCoordinates;

        public IntPtr yCoordinates;

        public IntPtr zCoordinates;
    }
}
