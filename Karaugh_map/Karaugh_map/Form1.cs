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
    public partial class Form1 : Form
    {
        public Form1(CultureInfo culture)
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            ResourceManager rm = new ResourceManager("Karaugh_map.Form1", System.Reflection.Assembly.GetExecutingAssembly());

            this.Text = this.Text + " " + DateTime.Now.ToLongDateString();

            btnClear.Text = rm.GetString("btnClear.Text");
            btnSolve.Text = rm.GetString("btnSolve.Text");
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        



        private void n0_Click(object sender, EventArgs e)
        {
            s0.Text = "1";
          
        }

        private void n1_Click(object sender, EventArgs e)
        {
            s1.Text = "1";
        }

        private void n3_Click(object sender, EventArgs e)
        {
            s3.Text = "1";
        }

        private void n2_Click(object sender, EventArgs e)
        {
            s2.Text = "1";
        }

        private void n4_Click(object sender, EventArgs e)
        {
            s4.Text = "1";

        }

        private void n5_Click(object sender, EventArgs e)
        {
            s5.Text = "1";

        }

        private void n7_Click(object sender, EventArgs e)
        {
            s7.Text = "1";

        }

        private void n6_Click(object sender, EventArgs e)
        {
            s6.Text = "1";

        }

        private void n12_Click(object sender, EventArgs e)
        {
            s12.Text = "1";

        }

        private void n13_Click(object sender, EventArgs e)
        {
            s13.Text = "1";

        }

        private void n15_Click(object sender, EventArgs e)
        {
            s15.Text = "1";

        }

        private void n14_Click(object sender, EventArgs e)
        {
            s14.Text = "1";

        }

        private void n8_Click(object sender, EventArgs e)
        {
            s8.Text = "1";

        }

        private void n9_Click(object sender, EventArgs e)
        {
            s9.Text = "1";

        }

        private void n11_Click(object sender, EventArgs e)
        {
            s11.Text = "1";

        }

        private void n10_Click(object sender, EventArgs e)
        {
            s10.Text = "1";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            s0.Clear();
            s1.Clear();
            s2.Clear();
            s3.Clear();
            s4.Clear();
            s5.Clear();
            s6.Clear();
            s7.Clear();
            s8.Clear();
            s9.Clear();
            s10.Clear();
            s11.Clear();
            s12.Clear();
            s13.Clear();
            s14.Clear();
            s15.Clear();
            or.Checked = false;
            and.Checked = false;
            answer.Clear();
        }
        public void dTob(int ans)
        {
            
            int[] array0 = new int[100];
            int count = 0;
            string temp = "";
            while (ans != 0)
            {
                array0[count] = ans % 2;
                ans = ans / 2;
                count++;
                
            }

            while (count >= 0)
            {
                temp+= (array0[count]).ToString();
                count--;
            }
            answer.Text = temp.ToString();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            int[,] array1 = { { 0, 1, 3, 2 }, { 4, 5, 7, 6 }, { 12, 13, 15, 14 }, { 8, 9, 11, 10 } };
            int[,] array2 = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
            int cal = 0;
            int cal2 = 1;
           // string minterms = "{";

            if (s0.Text == "1")
            {
                array2[0, 0] = 1;
               // minterms += "0,";
            }
            if (s1.Text == "1")
            {
                array2[0, 1] = 1;
               // minterms += "1,";
            }
            if (s3.Text == "1")
            {
                array2[0, 2] = 1;
               // minterms += "3,";
            }
            if (s2.Text == "1")
            {
                array2[0, 3] = 1;
              //  minterms += "2,";
            }


            if (s4.Text == "1")
            {
                array2[1, 0] = 1;
               // minterms += "4,";

            }
            if (s5.Text == "1")
            {
                array2[1, 1] = 1;
               // minterms += "5,";
            }
            if (s7.Text == "1")
            {
                array2[1, 2] = 1;
                //minterms += "7,";
            }
            if (s6.Text == "1")
            {
                array2[1, 3] = 1;
               // minterms += "6,";
            }


            if (s12.Text == "1")
            {
                array2[2, 0] = 1;
               // minterms += "12,";
            }
            if (s13.Text == "1")
            {
                array2[2, 1] = 1;
                //minterms += "13,";
            }
            if (s15.Text == "1")
            {
                array2[2, 2] = 1;
                //minterms += "15,";
            }
            if (s14.Text == "1")
            {
                array2[2, 3] = 1;
               // minterms += "14,";
            }


            if (s8.Text == "1")
            {
                array2[3, 0] = 1;
               // minterms += "8,";
            }
            if (s9.Text == "1")
            {
                array2[3, 1] = 1;
               // minterms += "9,";
            }
            if (s11.Text == "1")
            {
                array2[3, 2] = 1;
               // minterms += "11,";
            }
            if (s10.Text == "1")
            {
                array2[3, 3] = 1;
               // minterms += "10,";
            }
            /*
            for (int i=0;i<4;i++)
            {
                for(int j=0;j<4;j++)
                    if(array2[i,j]==1)
                    {
                            MessageBox.Show("minterms are " + minterms,minterms);       
                    }
                Close();
            }

            int count = 0; // how to assign into a variable
            for (int i = 0; i < array1.Length; i++)
            {
               
                    if (array2[0, 0] == 1 && array2[0, 1] == 1 && array2[0, 2] == 1 && array2[0, 3] == 1)
                    {
                         count++; // how to assign into a variable
                }
                    else if (array2[0, 0] == 1 && array2[0, 1] == 1 && array2[0, 2] != 1 && array2[0, 3] != 1)
                    {

                         count++; // how to assign into a variable
                }
                    else if (array2[0, 0] == 1 && array2[0, 1] == 1 && array2[0, 2] != 1 && array2[0, 3] == 1)
                      {
                    count = 2; // how to assign into a variable
                }


                    else if (array2[0, 0] == 1 && array2[0, 1] != 1 && array2[0, 2] == 1 && array2[0, 3] == 1)
                    {
                    count = 2; // how to assign into a variable
                }
                    else if (array2[0, 0] == 1 && array2[0, 1] != 1 && array2[0, 2] != 1 && array2[0, 3] == 1)
                    {
                    count = 1; // how to assign into a variable
                }
                    else if(array2[0, 0] !=1  && array2[0, 1] != 1 && array2[0, 2] ==1 && array2[0, 3] == 1)
                    {
                    count = 1; // how to assign into a variable
                }
                    else if (array2[0, 0] != 1 && array2[0, 1] != 1 && array2[0, 2] == 1 && array2[0, 3] == 1)
                    {
                    count = 1; // how to assign into a variable
                }
            }
            
             */




            if (or.Checked == true)
            {
                int a = 0;
                while (a < 4)
                {
                    int b = 0;
                    while (b < 4)
                    {
                        if (array2[a, b] == 1)
                        {
                            cal += array1[a, b];
                        }
                        b++;
                    }
                    a++;

                }
                dTob(cal);

            }
            else
            {
                int a = 0;
                while (a < 4)
                {
                    int b = 0;
                    while (b < 4)
                    {
                        if (array2[a, b] == 1)
                        {
                            cal2*= array1[a, b];
                        }
                        b++;
                    }
                    a++;

                }
                dTob(cal2);
            }
           
         
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void answer_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();   
            f2.Show();
        }
    }
  
}
