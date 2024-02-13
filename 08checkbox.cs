using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08RadioCheckbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Text = "Rezervacija aviona je uspjesna.";
            }
            else if (radioButton2.Checked)
            {
                textBox1.Text = "Rezervacija autobusa je uspjesna.";
            }
            else if (radioButton3.Checked)
            {
                textBox1.Text = "Rezervacija vlastiti prijevoz je uspjesna.";
            }
            else
            {
                textBox1.Text = "Molimo odaberite vrstu prijevoza.";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
