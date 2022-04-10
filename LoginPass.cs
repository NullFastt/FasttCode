using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FasttCode
{
    public partial class LoginPass : MetroSuite.MetroForm
    {
        Form1 home;
        public LoginPass()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            RPC.Start();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(guna2TextBox1.Text != null)
            {
                 var corecto = File.ReadAllText(Application.LocalUserAppDataPath + @"//Pass.fasttcodding");
                if(guna2TextBox1.Text == corecto)
                {
                    home = new Form1();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("|Error| Contraseña incorrecta");
                }
            }
            else
            {
                MessageBox.Show("|Error| No pusistes nada.");
            }
        }

        private void metroControlBox1_AreaClicked(object sender, MetroSuite.MetroControlBox.MetroControlBoxEventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            timer1.Stop();
        }
    }
}
