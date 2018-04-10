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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void resim_MouseMove(object sender, MouseEventArgs e)
        {
            Form2 ikinciform = new Form2();
            Random rnd = new Random();
            int locx = rnd.Next(0,ikinciform.Right-resim.Right);
            int locy = rnd.Next(0, ikinciform.Bottom-resim.Bottom);
            labelx.Text = locx.ToString();
            labely.Text = locy.ToString();
            resim.Location = new Point(locx, locy);


        }
    }
}
