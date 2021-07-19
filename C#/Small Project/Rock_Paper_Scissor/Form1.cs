using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Rock_Paper_Scissor
{
    public partial class RPS : Form
    {
        Random rand = new Random();
        int ng;
        SoundPlayer sp1 = new SoundPlayer(soundLocation: @"E:\Code\C_Sharp\Rock_Paper_Scissor\mu\loss.wav");
        SoundPlayer sp2 = new SoundPlayer(soundLocation: @"E:\Code\C_Sharp\Rock_Paper_Scissor\mu\tada.wav");

        public RPS()
        {
            
            InitializeComponent();
        }

        private void RPS_Load(object sender, EventArgs e)
        {

        }

        private void pap_Click(object sender, EventArgs e)
        {
            ng = rand.Next(1, 3);
            if (ng == 1)
            {
                sp2.Play();
                MessageBox.Show("You Win, Computer Choose Rock");
            }
            else if (ng == 2)
            {
                MessageBox.Show("Draw, Computer Choose Paper");
            }
            else
            {
                sp1.Play();
                MessageBox.Show("You Loss, Coumputer Choose scissor");
            }
        }

        private void roc_Click(object sender, EventArgs e)
        {
            ng = rand.Next(1, 3);
            if (ng == 1)
            {
                sp1.Play();
                MessageBox.Show("You Loss, Coumputer Choose scissor");
            }
            else if (ng == 2)
            {
                MessageBox.Show("Draw,  Computer Choose Rock");
            }
            else
            {
                sp2.Play();
                MessageBox.Show("You Win,  Computer Choose Paper");
            }
        }

        private void sci_Click(object sender, EventArgs e)
        {
            ng = rand.Next(1, 3);
            if (ng == 1)
            {
                MessageBox.Show("Draw, Coumputer Choose scissor");
            }
            else if (ng == 2)
            {
                sp1.Play();
                MessageBox.Show("You Loss,  Computer Choose Rock");
            }
            else
            {
                sp2.Play();
                MessageBox.Show("You Win,  Computer Choose Paper");
            }
        }
    }
}
