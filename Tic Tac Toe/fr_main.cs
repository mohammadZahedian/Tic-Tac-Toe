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
    public partial class fr_main : Form
    {
        public fr_main()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter first player name", "Empty name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Enter second player name", "Empty name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Storage.Player1_Name = textBox1.Text;
                Storage.Player2_Name = textBox2.Text;
                this.Close();


            }

        }


        private void Select_area_form_Load(object sender, EventArgs e)
        {

        }
    }
}
