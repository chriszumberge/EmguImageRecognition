using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageRecognitionEmGu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            long score;
            long matchTime;

            //using (Mat modelImage = CvInvoke.Imread("phone_rotated.JPG", Emgu.CV.CvEnum.ImreadModes.Grayscale))
            //using (Mat modelImage = CvInvoke.Imread("phone.JPG", Emgu.CV.CvEnum.ImreadModes.Grayscale))
            //using (Mat observedImage = CvInvoke.Imread("desk_top.JPG", Emgu.CV.CvEnum.ImreadModes.Grayscale))
            using (Mat modelImage = CvInvoke.Imread("k_rune.JPG", Emgu.CV.CvEnum.ImreadModes.Grayscale))
            using (Mat observedImage = CvInvoke.Imread("alpha_rune.JPG", Emgu.CV.CvEnum.ImreadModes.Grayscale))
            {
                try
                {
                    Mat result = DrawMatches.Draw(modelImage, observedImage, out matchTime, out score);

                    //var iv = new emguImageViewer(result, score);
                    //iv.Show();
                    Application.Run(new emguImageViewer(result, score));
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex);
                }
            }
        }
    }
}
