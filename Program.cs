using System;
using Emgu.CV;
using Emgu.CV.Dnn;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using Emgu.CV.Cuda;
using Emgu.CV.CvEnum;
using Emgu.Util;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld.Print();
            var text = OcrUtils.GetText("test.png");
            System.Console.WriteLine(text);
        }
    }
}