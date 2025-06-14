using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16FormAppliction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button btn1 = new Button();
            btn1.Text = "Click this Button...";
            this.Controls.Add(btn1);
            btn1.Click += new EventHandler(btn1_Click);
        }

        public void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button clicked!");
        }
    }
}
