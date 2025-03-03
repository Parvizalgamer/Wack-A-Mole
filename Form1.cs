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
        static Image mole = Wack_A_Mole.Properties.Resources.Hole;

        static Image[] Rising = new Image[]
        {
            Wack_A_Mole.Properties.Resources.R1,
            Wack_A_Mole.Properties.Resources.R2,
            Wack_A_Mole.Properties.Resources.R3,

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
            Wack_A_Mole.Properties.Resources.R3,
            Wack_A_Mole.Properties.Resources.hit6,
            Wack_A_Mole.Properties.Resources.hit7,

        };//Sinking pictures
        public Form1()
        {
            InitializeComponent();
        }

       
    }
}


