using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18023892Brink_GADE6112_Task1
{
    public partial class frmRTSGame : Form
    {
        //creating an instance of map in this class
        Map myMap = new Map(20);
        public frmRTSGame()
        {
            InitializeComponent();
        }

        private void frmRTSGame_Load(object sender, EventArgs e)
        {

        }

        //code that runs when the button "Start" is clicked
        private void btnStart_Click(object sender, EventArgs e)
        {
            //clearing the label
            lblUnits.Text = "";
            //loops to loop through the x and y positions
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    lblUnits.Text += myMap.battlefield[i,j];

                }
                //making new lines so that everything doesnt run on one line
                lblUnits.Text += Environment.NewLine;
            }
        }
    }
}
