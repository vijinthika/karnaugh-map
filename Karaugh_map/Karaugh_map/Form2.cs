using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Globalization;
using System.Resources;
using System.Threading;
namespace Karaugh_map
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("English"))
            {
                Form1 f = new Form1(new CultureInfo("en-US"));
                this.Hide();
                f.Show();

            }
            else if (comboBox1.Text.Equals("සිංහල(sinhala)"))
            {
                Form1 f = new Form1(new CultureInfo("si"));
                this.Hide();
                f.Show();
            }
            else if (comboBox1.Text.Equals("தமிழ்(tamil)"))
            {
                Form1 f = new Form1(new CultureInfo("ta-LK"));
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Please Select Language!","error",MessageBoxButtons.OK);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
