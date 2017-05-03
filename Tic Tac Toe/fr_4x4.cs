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
    public partial class fr_4x4 : Form
    {
        public string Name1 { get; set;}
        public string Name2 { get; set; }


        public fr_4x4()
        {
            InitializeComponent();
        }
        //...................................................
        int Turn = 0;
        int[,,] Situation = new int[2, 4, 4];
        int winner = -1;
        //...................................................


        private void buttons_Click(object sender, EventArgs e)
        {
            var but = (Button)sender;

            //stafill the array 
            int row, column = 0;
            row = int.Parse(but.Tag.ToString().Split(',')[0]);
            column = int.Parse(but.Tag.ToString().Split(',')[1]);


            //Array filled

            if (Turn <= 16)
            {
                if (but.Text == "")
                {
                    if ((Turn % 2 == 0))
                    {
                        Situation[0, row, column] = 1;
                        but.Text = "X";
                        but.ForeColor = Color.Red;

                    }
                    else
                    {
                        Situation[1, row, column] = 1;
                        but.Text = "O";
                        but.ForeColor = Color.Blue;
                    }



                    // but.Enabled = false;
                    Turn++;
                }
            }

            //check player status
            this.winner = Check.winner(Situation, 4);





            //first player won
            if (winner == 0)
            {
                MessageBox.Show(Name1);
                point.pointPlayer1++;
            }

            //second player won
            if (winner == 1)
            {
                MessageBox.Show(Name2);
            }

            //game is pot
            if (Turn == 16)
            {
                MessageBox.Show("ennnnnnnnnnnnnnnd");
            }







        }

        private void fr_4x4_Load(object sender, EventArgs e)
        {

        }
    }
}
