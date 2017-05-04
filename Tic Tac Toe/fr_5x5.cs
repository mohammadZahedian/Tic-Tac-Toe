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
    public partial class fr_5x5 : Form
    {
        public fr_5x5()
        {
            InitializeComponent();
            Storage.turn = 0;
        }

        //...................................................
        static int Game_Size = 5;
        int[,,] Situation = new int[2, Game_Size, Game_Size];
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


            //Array filled

            if (Storage.turn <= Game_Size * Game_Size)
            {
                if (but.Text == "")
                {
                    if ((Storage.turn % 2 == 0))
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
                    Storage.turn++;
                }
            }

            //check player status
            this.winner = Check.winner(Situation, Game_Size);





            //first player won
            if (winner == 0)
            {
                Storage.Player1_Point++;

                mark_winner();

                var a = MessageBox.Show(Storage.Player1_Name + " Won. Play again?", "1st player won", MessageBoxButtons.YesNo);

                if (a == DialogResult.Yes)
                {
                    resetGame();
                }
                else
                {
                    this.Close();
                }
            }

            //second player won
            if (winner == 1)
            {
                Storage.Player2_Point++;
                mark_winner();
                var a = MessageBox.Show(Storage.Player2_Name + " Won. Play again?", "2nd player won", MessageBoxButtons.YesNo);

                if (a == DialogResult.Yes)
                {
                    resetGame();
                }
                else
                {
                    this.Close();
                }

            }

            //game is pot
            if (Storage.turn == Game_Size * Game_Size)
            {
                var a = MessageBox.Show("Draw. Play again?", "Draw", MessageBoxButtons.YesNo);

                if (a == DialogResult.Yes)
                {
                    resetGame();
                }
                else
                {
                    this.Close();
                }

            }

        }



        private void resetGame()
        {
            foreach (Control cn in this.Controls)
            {
                cn.Text = "";
                cn.BackColor = Color.Gainsboro;
            }

            Storage.turn = 0;
            Situation = new int[2, Game_Size, Game_Size];
            winner = -1;
        }



        private void mark_winner()
        {
            string[] b = Check.Winner_line_location();

            foreach (Control cn in this.Controls)
            {
                if (cn.Tag.ToString() == b[0] || cn.Tag.ToString() == b[1] || cn.Tag.ToString() == b[2])
                {
                    var s = cn.BackColor;
                    cn.BackColor = Color.Green;

                }
            }
        }
    }
}
