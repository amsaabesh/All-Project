using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Mash02
{
    public partial class Form1 : Form
    {
        Point EmptyPoint, S;
        ArrayList image = new ArrayList();
        public Form1()
        {
            EmptyPoint.X = 180;
            EmptyPoint.Y = 180;
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            foreach (Button b in panel2.Controls)
                b.Enabled = true;
            Image original = Image.FromFile(@"E:\mash.jpg");
            cropImage(original, 270, 270);
            AddImagesToButtons(image);
        }

        private void AddImagesToButtons(ArrayList image)
        {
            int i = 0;
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7 };
            arr = suffle(arr);

            foreach(Button b in panel2.Controls)
            {
                if (i < arr.Length)
                {
                    b.Image = (Image)image[arr[i]];
                    i++;
                }
            }
        }

        private int[] suffle(int[] arr)
        {
            Random rand = new Random();
            arr = arr.OrderBy(x => rand.Next()).ToArray();
            return arr;
        }


        private void cropImage(Image original, int w, int h)
        {
            Bitmap bmp = new Bitmap(w, h);
            Graphics graphic = Graphics.FromImage(bmp);
            graphic.DrawImage(original, 0, 0, w, h);
            graphic.Dispose();
            int movr = 0, movd = 0;
            for(int x = 0; x < 8; x++)
            {
                Bitmap piece = new Bitmap(90, 90);

                for (int i = 0; i < 90; i++)
                    for (int j = 0; j < 90; j++)
                        piece.SetPixel(i, j, bmp.GetPixel(i + movr, j + movd));

                image.Add(piece);
                movr += 90;
                if (movr == 270)
                {
                    movr = 0;
                    movd += 90;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            moveB((Button)sender);
        }

        public void moveB(Button  bt)
        {
            MessageBox.Show(bt.ToString());
            if(((bt.Location.Y==EmptyPoint.X-90||bt.Location.Y==EmptyPoint.X+90) && bt.Location.X==EmptyPoint.Y)||
                ((bt.Location.X == EmptyPoint.Y - 90 || bt.Location.X == EmptyPoint.Y + 90) && bt.Location.Y == EmptyPoint.X))
            {
                S = bt.Location;
                MessageBox.Show("bl"+bt.Location.ToString());
                bt.Location = EmptyPoint;
                EmptyPoint = S;
            }
        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
