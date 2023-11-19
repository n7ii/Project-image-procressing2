namespace Project_image_procressing2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap pict_o, pict_c;
        public Bitmap ConvertToGray1(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color clr = source.GetPixel(x, y);
                    int avg = ((clr.R + clr.G + clr.B) / 3);
                    bmp.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                }
            }
            return bmp;
        }
        public Bitmap ConvertToGray2(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color c = source.GetPixel(i, j);
                    //Luminance
                    int nP = (int)(0.3 * c.R + 0.59 * c.G + 0.11 * c.B);
                    bmp.SetPixel(i, j, Color.FromArgb(nP, nP, nP));
                }
            }
            return bmp;
        }

        public Bitmap ConvertToBlackAndWhite(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            int t = int.Parse(textBox1.Text);

            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color c = source.GetPixel(i, j);
                    int avg = (int)((c.R + c.G + c.B) / 3);
                    if (avg > t)
                        avg = 255;
                    else avg = 0;

                    bmp.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
                }
            }
            return bmp;

        }

        public Bitmap Negative(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            int t = int.Parse(textBox1.Text);

            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color c = source.GetPixel(i, j);
                    int r1, g1, b1;
                    r1 = 255 - (int)(c.R);
                    g1 = 255 - (int)(c.G);
                    b1 = 255 - (int)(c.B);
                    bmp.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            }
            return bmp;
        }


        public Bitmap Invert(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            int t = int.Parse(textBox1.Text);

            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color c = source.GetPixel(i, j);
                    int avg = (int)((c.R + c.G + c.B) / 3);
                    if (avg == 255)
                        avg = 0;
                    else if (avg == 0)
                        avg = 255;

                    bmp.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
                }
            }
            return bmp;
        }

        public Bitmap Log_transformation(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            int t = int.Parse(textBox2.Text);

            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color c = source.GetPixel(i, j);

                    int red = (int)(Math.Log(1 + c.R) * t);
                    int green = (int)(Math.Log(1 + c.G) * t);
                    int blue = (int)(Math.Log(1 + c.B) * t);

                    // Handle cases where color values are greater than 255
                    red = Math.Min(red, 255);
                    green = Math.Min(green, 255);
                    blue = Math.Min(blue, 255);

                    bmp.SetPixel(i, j, Color.FromArgb(red, green, blue));
                }
            }
            return bmp;
        }


        public Bitmap PowerLawTransformation(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            double c = double.Parse(textBox3.Text);
            double gamma = double.Parse(textBox4.Text);

            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color pixelColor = source.GetPixel(i, j);

                    int red = (int)(c * Math.Pow(pixelColor.R / 255.0, gamma) * 255);
                    int green = (int)(c * Math.Pow(pixelColor.G / 255.0, gamma) * 255);
                    int blue = (int)(c * Math.Pow(pixelColor.B / 255.0, gamma) * 255);

                    // Handle cases where color values are greater than 255
                    red = Math.Min(Math.Max(red, 0), 255);
                    green = Math.Min(Math.Max(green, 0), 255);
                    blue = Math.Min(Math.Max(blue, 0), 255);

                    bmp.SetPixel(i, j, Color.FromArgb(pixelColor.A, red, green, blue));
                }
            }
            return bmp;
        }







        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pict_o = new Bitmap(opf.FileName);
                pictureBox1.Image = pict_o;
                pict_c = pict_o;
                pictureBox1.Image = pict_o;
            }
        }

        private void btnGray1_Click(object sender, EventArgs e)
        {
            pict_c = ConvertToGray1(pict_o);
            pictureBox1.Image = pict_c;
        }

        private void btnGray2_Click(object sender, EventArgs e)
        {
            pict_c = ConvertToGray2(pict_o);
            pictureBox1.Image = pict_c;
        }

        private void btnOrigin_Click(object sender, EventArgs e)
        {
            pict_c = pict_o;
            pictureBox1.Image = pict_c;
        }

        private void btnblackwhite_Click(object sender, EventArgs e)
        {
            pict_c = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = ConvertToBlackAndWhite(pict_c);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pict_c = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = Negative(pict_c);

        }

        private void btn_invert_Click(object sender, EventArgs e)
        {
            pict_c = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = Invert(pict_c);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = Log_transformation(pict_c);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_powerlaw_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = PowerLawTransformation(pict_c);
        }
    }
}