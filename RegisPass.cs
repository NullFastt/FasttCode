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
using NeoSmart.Utils;

namespace FasttCode
{
    public partial class RegisPass : MetroSuite.MetroForm
    {
        LoginPass login;
        public RegisPass()
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
            if(guna2TextBox1 != null) {
                File.WriteAllText(Application.LocalUserAppDataPath + @"//Pass.fasttcodding", guna2TextBox1.Text);
                login = new LoginPass();
                login.Show();
                this.Hide();
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
