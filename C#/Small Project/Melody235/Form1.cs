using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melody235
{
    public partial class Form1 : Form
    {
        String[] Location, File;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//exit Button
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)//minimized Button
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Songs_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = Location[Songs.SelectedIndex];
        }

        private void button1_Click_1(object sender, EventArgs e)//Music add
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Multiselect = true;

            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File = fd.SafeFileNames;
                Location = fd.FileNames;

                for(int i=0; i < File.Length; i++)
                {
                    Songs.Items.Add(File[i]);
                }
            }
        }
    }
}
