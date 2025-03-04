using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Wack_A_Mole
{
    public partial class Form1 : Form
    {

        Random rand = new Random();
        List<PictureBox> items = new List<PictureBox>();
        static Image mole = Wack_A_Mole.Properties.Resources.Mole1;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox tempPic = sender as PictureBox;
            score += 10;
            items.Remove(tempPic);
            tempPic.Visible = false;
            lblScore.Text = "Score: " + score;

        }

        private void Mole_ShowUp()
        {
            items.AddRange(new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5,
                pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12,
                pictureBox13, pictureBox14, pictureBox15 });

            int randPicBox = rand.Next(15);

            foreach (PictureBox pic in items)
            {
                
            }
        }

        private void MoleTimer_Tick(object sender, EventArgs e)
        {
            Mole_ShowUp();
        }
    }


}




