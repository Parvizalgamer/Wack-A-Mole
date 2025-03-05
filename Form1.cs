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
        PictureBox currentMolePic = null;
        public Form1()
        {
            InitializeComponent();
            // Initialize the items list with your PictureBoxes
            items.AddRange(new PictureBox[] 
            { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5,
              pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10,
              pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15 
            });

        }
        static Image[] Rising = new Image[]
        {
            Wack_A_Mole.Properties.Resources.Mole1,
            Wack_A_Mole.Properties.Resources.Mole2,
            Wack_A_Mole.Properties.Resources.Mole3,

        };//Rising picture

        static Image[] HitSinking = new Image[]
        {
            Wack_A_Mole.Properties.Resources.hit1,
            Wack_A_Mole.Properties.Resources.hit2,
            Wack_A_Mole.Properties.Resources.hit3,
            Wack_A_Mole.Properties.Resources.hit4,
            Wack_A_Mole.Properties.Resources.hit5,
            Wack_A_Mole.Properties.Resources.hit6,
            Wack_A_Mole.Properties.Resources.hit7,
            Wack_A_Mole.Properties.Resources.Hole,
        };//hiting and sinking picture array

        static Image[] Sinking = new Image[]
        {
            Wack_A_Mole.Properties.Resources.Mole3,
            Wack_A_Mole.Properties.Resources.hit6,
            Wack_A_Mole.Properties.Resources.hit7,

        };//Sinking pictures

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox tempPic = sender as PictureBox;

            if (tempPic == currentMolePic && currentMolePic != null) // Check if the clicked PictureBox has the mole
            {
                score += 10;
                lblScore.Text = "Score: " + score;
                tempPic.BackgroundImage = nomole;
                currentMolePic = null; // Reset the current mole PictureBox
            }

        }

        private void Mole_ShowUp()
        {
            if (currentMolePic != null)
            {
                currentMolePic.BackgroundImage = nomole;
            }

            // Select a random PictureBox to display the mole
            int randPicBox = rand.Next(items.Count);
            items[randPicBox].BackgroundImage = mole;
            items[randPicBox].BackgroundImageLayout = ImageLayout.Stretch;
            currentMolePic = items[randPicBox]; // Store the PictureBox with the mole
        }
        private void MoleTimer_Tick(object sender, EventArgs e)
        {
            Mole_ShowUp();
        }

    }
}





