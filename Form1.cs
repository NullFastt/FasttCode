using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;

namespace FasttCode
{
    public partial class Form1 : MetroSuite.MetroForm
    {
        public static DiscordRpcClient Client { get; set; }

        private static RichPresence _currentPresence;

        public static string Username = "Username: Unkown";
        public static string hastag = "Discriminator: Unkown";
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";
                var name = openFileDialog1.FileName;
                fastColoredTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                label3.Text = name;
                File.WriteAllText(Application.StartupPath + @"B.backup", fastColoredTextBox1.Text);
               
                label7.Text = Application.StartupPath + @"//B.backup";


            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
           if(label3.Text == "UNKNOWN")
            {
                return;
            } else
            {
                Process.Start(label3.Text);
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(guna2ComboBox1.SelectedIndex == 1)
            {

                guna2Button1.FillColor = Color.FromArgb(0, 192, 0);
                guna2Button2.FillColor = Color.FromArgb(0, 192, 0);
               // guna2Button3.FillColor = Color.FromArgb(0, 192, 0);
                guna2Button6.FillColor = Color.FromArgb(0, 192, 0);
            }
            if(guna2ComboBox1.SelectedIndex == 2)
            {
                guna2Button1.FillColor = Color.Blue;
                guna2Button2.FillColor = Color.Blue;
                // guna2Button3.FillColor = Color.FromArgb(0, 192, 0);
                guna2Button6.FillColor = Color.Blue;
            }
            if (guna2ComboBox1.SelectedIndex == 3)
            {

                guna2Button1.FillColor = Color.IndianRed;
                guna2Button2.FillColor = Color.IndianRed;
              //  guna2Button3.FillColor = Color.IndianRed;
                guna2Button6.FillColor = Color.IndianRed;
            }
            if (guna2ComboBox1.SelectedIndex == 4)
             {
                Random random = new Random();
                var r1 = random.Next(0, 255);
                var r2 = random.Next(0,255);
                var r3 = random.Next(0,255);
                guna2Button1.FillColor = Color.FromArgb(r1, r2, r3);
                guna2Button2.FillColor = Color.FromArgb(r1, r2, r3);
                guna2Button6.FillColor = Color.FromArgb(r1, r2, r3);
            }
                if (guna2ComboBox1.SelectedIndex == 5)
            {
                guna2Button1.FillColor = Color.DimGray;
                guna2Button2.FillColor = Color.DimGray;
              //  guna2Button3.FillColor = Color.Gray;
                guna2Button6.FillColor = Color.DimGray;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (label3.Text == "UNKNOWN")
            {
                return;
            }
            else
            {
                Process.Start(label3.Text);
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

         
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(fastColoredTextBox1.Text);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
          
            RPC.Start();
           
            label10.Text = Username;
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
