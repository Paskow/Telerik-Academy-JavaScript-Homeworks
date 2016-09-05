﻿using System;

namespace CohesionAndCoupling
{
    public class UtilsExamples
    {
        public static void Main()
        {
            Console.WriteLine(StringUtils.GetFileExtension("example"));
            Console.WriteLine(StringUtils.GetFileExtension("example.pdf"));
            Console.WriteLine(StringUtils.GetFileExtension("example.new.pdf"));
            Console.WriteLine(StringUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(StringUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(StringUtils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine(
                "Distance in the 2D space = {0:f2}",
                MathUtils.CalcDistance2D(1, -2, 3, 4));

            Console.WriteLine(
                "Distance in the 3D space = {0:f2}",
                MathUtils.CalcDistance3D(5, 2, -1, 3, -6, 4));

            double width = 3;
            double height = 4;
            double depth = 5;

            Console.WriteLine("Volume = {0:f2}", MathUtils.CalcVolume(width, height, depth));
            Console.WriteLine("Diagonal XYZ = {0:f2}", MathUtils.CalcDiagonalXYZ(width, height, depth));
            Console.WriteLine("Diagonal XY = {0:f2}", MathUtils.CalcDiagonalXY(width, height));
            Console.WriteLine("Diagonal XZ = {0:f2}", MathUtils.CalcDiagonalXZ(width, depth));
            Console.WriteLine("Diagonal YZ = {0:f2}", MathUtils.CalcDiagonalYZ(height, depth));
        }
    }
}
