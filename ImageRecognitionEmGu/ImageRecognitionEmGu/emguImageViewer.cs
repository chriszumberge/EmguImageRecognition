using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageRecognitionEmGu
{
    public partial class emguImageViewer : Form
    {
        public emguImageViewer(IImage image, long score = 0)
        {
            InitializeComponent();

            this.Text = $"Score: {score}";

            if (image != null)
            {
                imgBox.Image = image.Bitmap;

                // Get the size of the image and add a little width and height
                Size size = image.Size;
                size.Width += 12;
                size.Height += 42;

                // Set the form to be the size of the image
                if (!this.Size.Equals(size)) this.Size = size;
            }
        }
    }
}
