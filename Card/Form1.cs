using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen titlePen = new Pen(Color.Gray, 20);
            Font titleFont = new Font(" Arial New", 25);
            SolidBrush titleBrush = new SolidBrush(Color.Yellow);
            g.DrawString("Constellation Card", titleFont, titleBrush, 260, 200);
            g.DrawLine(titlePen, 240, 180, 570, 180);
            g.DrawLine(titlePen, 240, 260, 570, 260);
            g.DrawLine(titlePen, 250, 180, 250, 260);
            g.DrawLine(titlePen, 560, 180, 560, 260);

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen conPen = new Pen(Color.White, 4);
            Font conFont = new Font(" Arial New", 25);
            SolidBrush conBrush = new SolidBrush(Color.White);
            SoundPlayer starSound = new SoundPlayer(Properties.Resources.star);
            SoundPlayer decapSound = new SoundPlayer(Properties.Resources.decap);
            SoundPlayer shotgunSound = new SoundPlayer(Properties.Resources.shotgun);
            SolidBrush wordBrush = new SolidBrush(Color.Red);
            Font wordFont = new Font(" Monaco New", 15);

            //All Frames for the constellation
            //Frame 1
            g.Clear(Color.Black);
            Thread.Sleep(1000);
            g.FillEllipse(conBrush, 40, 255, 9, 9);
            starSound.Play();

            //Frame 2
            Thread.Sleep(1000);
            g.FillEllipse(conBrush, 94, 249, 9, 9);
            starSound.Play();

            //Frame 3
            Thread.Sleep(1000);
            g.FillEllipse(conBrush, 158, 229, 9, 9);
            starSound.Play();

            //Frame 4
            Thread.Sleep(1000);
            g.FillEllipse(conBrush, 175, 230, 9, 9);
            starSound.Play();

            //Frame 5
            Thread.Sleep(1000);
            g.FillEllipse(conBrush, 292, 294, 9, 9);
            starSound.Play();

            //Frame 6
            Thread.Sleep(1000);
            g.FillEllipse(conBrush, 321, 282, 9, 9);
            starSound.Play();

            //Frame 7
            Thread.Sleep(1000);
            g.FillEllipse(conBrush, 362, 254, 9, 9);
            starSound.Play();

            //Frame 8
            Thread.Sleep(1000);
            g.FillEllipse(conBrush, 404, 255, 9, 9);
            starSound.Play();

            //Frame 9
            Thread.Sleep(1000);
            g.FillEllipse(conBrush, 388, 185, 9, 9);
            starSound.Play();

            //Frame 10
            Thread.Sleep(1000);
            g.FillEllipse(conBrush, 426, 190, 9, 9);
            starSound.Play();

            //Frame 11
            Thread.Sleep(1000);
            g.FillEllipse(conBrush, 451, 160, 9, 9);
            starSound.Play();

            //Frame 12
            Thread.Sleep(1000);
            g.FillEllipse(conBrush, 480, 174, 9, 9);
            starSound.Play();

            //Frame 13
            Thread.Sleep(1000);
            g.FillEllipse(conBrush, 520, 134, 9, 9);
            starSound.Play();

            //Frame 14
            Thread.Sleep(1000);
            g.FillEllipse(conBrush, 500, 86, 9, 9);
            starSound.Play();

            //Frame 15
            Thread.Sleep(1000);
            g.FillEllipse(conBrush, 540, 56, 9, 9);
            starSound.Play();

            //Frame 16
            Thread.Sleep(1000);
            g.FillEllipse(conBrush, 565, 32, 9, 9);
            starSound.Play();

            //Frame 17
            Thread.Sleep(1000);
            g.FillEllipse(conBrush, 580, 27, 9, 9);
            starSound.Play();

            //Frame 18
            Thread.Sleep(1000);
            g.FillEllipse(conBrush, 592, 30, 9, 9);
            starSound.Play();

            //Frame 19
            Thread.Sleep(1000);
            g.FillEllipse(conBrush, 589, 47, 9, 9);
            starSound.Play();

            //Code for lines connecting to stars
            //Frame 20
            Thread.Sleep(1000);
            g.DrawLine(conPen, 42, 257, 96, 251);
            decapSound.Play();

            //Frame 21
            Thread.Sleep(1000);
            g.DrawLine(conPen, 96, 251, 160, 231);
            decapSound.Play();

            //Frame 22
            Thread.Sleep(1000);
            g.DrawLine(conPen, 160, 231, 177, 232);
            decapSound.Play();

            //Frame 23
            Thread.Sleep(1000);
            g.DrawLine(conPen, 177, 232, 294, 296);
            decapSound.Play();

            //Frame 24
            Thread.Sleep(1000);
            g.DrawLine(conPen, 294, 296, 323, 284);
            decapSound.Play();

            //Frame 25
            Thread.Sleep(1000);
            g.DrawLine(conPen, 323, 284, 364, 256);
            decapSound.Play();

            //Frame 26
            Thread.Sleep(1000);
            g.DrawLine(conPen, 364, 256, 406, 257);
            decapSound.Play();

            //Frame 27
            Thread.Sleep(1000);
            g.DrawLine(conPen, 406, 257, 390, 187);
            decapSound.Play();

            //Frame 28
            Thread.Sleep(1000);
            g.DrawLine(conPen, 390, 187, 428, 192);
            decapSound.Play();

            //Frame 29
            Thread.Sleep(1000);
            g.DrawLine(conPen, 428, 192, 453, 162);
            decapSound.Play();

            //Frame 30
            Thread.Sleep(1000);
            g.DrawLine(conPen, 453, 162, 482, 176);
            decapSound.Play();

            //Frame 31
            Thread.Sleep(1000);
            g.DrawLine(conPen, 482, 176, 522, 136);
            decapSound.Play();

            //Frame 32
            Thread.Sleep(1000);
            g.DrawLine(conPen, 522, 136, 502, 88);
            decapSound.Play();

            //Frame 33
            Thread.Sleep(1000);
            g.DrawLine(conPen, 502, 88, 542, 58);
            decapSound.Play();

            //Frame 34
            Thread.Sleep(1000);
            g.DrawLine(conPen, 542, 58, 567, 34);
            decapSound.Play();

            //Frame 35
            Thread.Sleep(1000);
            g.DrawLine(conPen, 567, 34, 582, 29);
            decapSound.Play();

            //Frame 36
            Thread.Sleep(1000);
            g.DrawLine(conPen, 582, 29, 594, 32);
            decapSound.Play();

            //Frame 37
            Thread.Sleep(1000);
            g.DrawLine(conPen, 594, 32, 591, 49);
            decapSound.Play();

            //Frame 38
            Thread.Sleep(1000);
            g.DrawLine(conPen, 591, 49, 567, 34);
            decapSound.Play();

            //text commands
            Thread.Sleep(1500);
            g.DrawString("Hydra is the largest of the 88 modern constellations.", wordFont, wordBrush, 250, 395);
            shotgunSound.Play();
        }
    }
}
