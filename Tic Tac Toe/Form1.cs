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
    public partial class Select_area_form : Form
    {
        public Select_area_form()
        {
            InitializeComponent();
        }

        private void Select_area_form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fr_3x3 fr = new fr_3x3();
            fr.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            fr_4x4 fr = new fr_4x4();
            fr.ShowDialog();
        }
    }
}
