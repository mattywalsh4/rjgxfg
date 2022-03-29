using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_game
{
    public class Account
    {
        public string Uname { get; set; }
        public int? ID { get; set; }
    }


    public partial class div : Form
    {
        public int timeLeft;
        public int a;
        public int b;
        int num = 0;
        public div()
        {
            InitializeComponent();
        }

        private void initiate()
        {
          
            Random r = new Random();
            a = r.Next(120);
            b = r.Next(10);
            label1.Text = a.ToString();
            label2.Text = b.ToString();
            

            timer1.Start();

            Startbtn.Enabled = false;
            Donebtn.Enabled = true;
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            initiate();
            timeLeft = 20;
            num = num = 0;
            label3.Text = num.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                timertxt.Text = timeLeft.ToString();
            }
            if (timeLeft == 0)
            {
                Donebtn.Enabled = false;
                Startbtn.Enabled = true;
                timer1.Stop();
                timertxt.Text = "You Lose!";

                /////////////////////////////////

                OleDbConnection conn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\20229310\Downloads\matty-main\matty-main\New folder (2)\gibjohn8\DB\Database11.accdb");

                //Get user data
                Account acc = JsonConvert.DeserializeObject<Account>(File.ReadAllText(@"C:\Users\20229310\Downloads\matty-main\matty-main\New folder (2)\gibjohn8\DB\accounts.json"));



                //Open database connection
                conn.Open();
                //Prepare SQL command to execute
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand("UPDATE [Accounts] SET [games] = games +'" + num + "' WHERE ID=" + acc.ID + "", conn);
                command.ExecuteReader();

                String my_querry = "INSERT INTO accounts(games)VALUES('" + num + "')";





                /////////////////////////////////
            }
        }

        private void Donebtn_Click(object sender, EventArgs e)
        {
            //Donebtn.Enabled = false;
            //Startbtn.Enabled = true;
            

            int c = a / b;
            label4.Text = (c.ToString());
            if (ansertxt.Text == c.ToString()) 
            {
                timeLeft += 50;
                timer1txt.Text = "Correct!";
                num = num + 100;
                label3.Text = num.ToString();

            } else 
            {
                timer1txt.Text = "Wrong!";
                num = num - 100;
                label3.Text = num.ToString();
            }
            initiate();
            ansertxt.Text = "";
        }

        private void div_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Stop();
        }
    }
}
