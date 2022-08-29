using Emgu.CV;
using Emgu.CV.Structure;

var image = new Image<Bgr, Byte>(200, 200);
image.Save("aa.png");
var a = CvInvoke.Imread("aa.png");

Console.WriteLine("hello world");