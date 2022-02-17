using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=M:\\year 2\\Database111.accdb;Persist Security Info=False;");
        public OleDbCommand cmd = new OleDbCommand();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Table1 (Name,password) values('" + textBox1.Text + "','" + textBox2.Text + "')";
            cmd.ExecuteNonQuery();

            /*con = new OleDbConnection(connetionString);
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Insert into Table1(Name)Values('" + textBox1.Text + "'), Table1(password)Values('" + textBox2.Text + "')";
            NewMethod(cmd);
            //cmd.CommandText = "Insert into Table1(password)Values('" + textBox2.Text + "')";
            //NewMethod(cmd);
            cmd.Connection = con;
            MessageBox.Show("Record Submitted", "Congrats");
            con.Close();*/
        }
        
        void NewMethod(OleDbCommand cmd)
        {
            cmd.ExecuteNonQuery();
        }
    }
}
