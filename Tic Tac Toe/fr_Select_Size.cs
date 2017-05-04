using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class fr_Select_Size : Form
    {

        
        public fr_Select_Size()
        {

            InitializeComponent();
            
           
            
        }
       
        
        public static void Point_print()
        {
           
        }

        private void btn3x3_Click(object sender, EventArgs e)
        {
            fr_3x3 fr = new fr_3x3();
            fr.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fr_4x4 fr = new fr_4x4();
            fr.ShowDialog();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            fr_5x5 fr = new fr_5x5();
            fr.ShowDialog();
        }
    }
}
