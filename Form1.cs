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
        static Image mole = Wack_A_Mole.Properties.Resources.Mole3;
        static Image nomole = Wack_A_Mole.Properties.Resources.Hole;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox tempPic = sender as PictureBox;
            score += 10; // Increment the score
            lblScore.Text = "Score: " + score; // Update score label

            // Change the image to 'nomole'
            tempPic.BackgroundImage = nomole;
            tempPic.BackgroundImageLayout = ImageLayout.Stretch; // Ensure the image fits properly
        }



        private void Mole_ShowUp()
        {
            // Add all PictureBox controls to the list
            items.AddRange(new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5,
        pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12,
        pictureBox13, pictureBox14, pictureBox15 });

           
           

            // Select a random PictureBox to display the mole
            int randPicBox = rand.Next(items.Count);
            items[randPicBox].BackgroundImage = mole; // Set the mole image as the background
            items[randPicBox].BackgroundImageLayout = ImageLayout.Stretch; // Optional: ensures the image fits
           
        }
        private void MoleTimer_Tick(object sender, EventArgs e)
        {
            Mole_ShowUp();
        }
    }
}




