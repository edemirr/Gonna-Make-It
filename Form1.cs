using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gonna_Make_It
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text = textBox1.Text.ToUpper() + "'s App";
            if(textBox1.Text=="")
            {   
                this.Text = "Change my name";
                MessageBox.Show("You didn't enter a name", "Fatal Error!");
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ikincifrm = new Form2();
            ikincifrm.ShowDialog();
            this.Close();
        }
    }
}
