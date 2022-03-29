using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_game
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Additionbtn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.TopLevel = false;
            frm.AutoScroll = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(frm);
            frm.Show();
        }

        private void Subtractionbtn_Click(object sender, EventArgs e)
        {
            sub frm = new sub();
            frm.TopLevel = false;
            frm.AutoScroll = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(frm);
            frm.Show();
        }

        private void Multiplicationbtn_Click(object sender, EventArgs e)
        {
            multi frm = new multi();
            frm.TopLevel = false;
            frm.AutoScroll = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(frm);
            frm.Show();
        }

        private void divisionbtn_Click(object sender, EventArgs e)
        {
            div frm = new div();
            frm.TopLevel = false;
            frm.AutoScroll = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(frm);
            frm.Show();
        }
    }
}
