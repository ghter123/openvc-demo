using Emgu.CV;
using Emgu.CV.OCR;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class OcrUtils
    {
        public static string GetText(string imgPath)
        {
            using (Tesseract engine = new(Directory.GetCurrentDirectory() + @"\tessdata", "chi_sim", OcrEngineMode.Default))
            {
                var testImg = new Mat(imgPath);
                engine.SetImage(testImg);
                var text = engine.GetUTF8Text().Trim();
                return text;
            }
        }
    }
}
