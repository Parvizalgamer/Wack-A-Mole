using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Wack_A_Mole
{
    public partial class Form1 : Form
    {   
        
        Random rand = new Random();
        List<PictureBox> items = new List<PictureBox>();
        static Image mole = Wack_A_Mole.Properties.Resources.Mole1;
        public Form1()
        {
            InitializeComponent();
        }

    }
}
    

