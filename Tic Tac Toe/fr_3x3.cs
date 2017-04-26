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
    public partial class fr_3x3 : Form
    {
        public fr_3x3()
        {
            InitializeComponent();
        }
        //...................................................
        int Turn = 0;
        int[,,] Situation = new int[2,3,3];
        int winner = -1;
        //...................................................

        //start
        private void buttons_Click(object sender, EventArgs e)
        {
            var but = (Button)sender;
      
            //stafill the array 
            int row, column = 0;
            row = int.Parse(but.Tag.ToString().Split(',')[0]);
            column = int.Parse(but.Tag.ToString().Split(',')[1]);
            
            if ((Turn % 2 == 0))
            {
                Situation[0,row, column] = 1;
            }
            else
            {
                Situation[1,row, column] = 1;
            }
            //Array filled

            if (Turn <= 9)
            {
                but.Text = (Turn % 2 == 0) ? "X" : "O";
                but.Enabled = false;
                Turn++;
            }
           
            //check player status
            this.winner = Check.winner(Situation, 3);
           
            
            
            
            
            //first player won
            if (winner == 0)
            {
                MessageBox.Show("majid");
            }

            //second player won
            if (winner == 1)
            {
                MessageBox.Show("mamad");
            }

            //game is pot
            if (Turn == 9)
            {
                MessageBox.Show("ennnnnnnnnnnnnnnd");
            }







        }
    }
}
