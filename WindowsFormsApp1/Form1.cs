using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

		private void steal_Click_1(object sender, EventArgs e)
		{
			#region Stuff we dont care about
			toolStripProgressBar1.Value = 10;
            WebClient wc = new WebClient();
            toolStripProgressBar1.Value = 20;
            Random random = new Random();
            toolStripProgressBar1.Value = 40;

            string lmao = "https://api.brick-hill.com/v1/games/retrieveAsset?id=" + textBox1.Text + "&type=png";
            toolStripProgressBar1.Value = 60;

            string filename = textBox1.Text + "Rnd_" + random.Next(1, 1000) + ".png";
            toolStripProgressBar1.Value = 70;

            webBrowser1.Navigate(lmao);
            toolStripProgressBar1.Value = 85;
			#endregion

			#region the downloading process lol
            //checking if the directory exists.
            //if not it will create one for you
			if (Directory.Exists(".\\Downloads"))
			{

                    wc.DownloadFile(lmao, ".\\Downloads\\" + filename);
                    toolStripProgressBar1.Value = 100;
                    MessageBox.Show("Saved as " + filename, "Done!");
            }
            else
			{
                MessageBox.Show("Did you seriously remove the downloads folder? wtf bro now u broke it >:((((\nOkay ill create a folder for you.\nNow click this message away and try again.", "bro what");

                    Directory.CreateDirectory("Downloads");


            }
			#endregion

		}

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            string lmao = "https://api.brick-hill.com/v1/games/retrieveAsset?id=" + textBox1.Text + "&type=png";
            webBrowser1.Navigate(lmao);


        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            string lmao1 = "https://api.brick-hill.com/v1/games/retrieveAsset?id=" + textBox2.Text + "&type=png";
            webBrowser2.Navigate(lmao1);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            #region Stuff we dont care about
            toolStripProgressBar1.Value = 10;
            WebClient wc = new WebClient();
            toolStripProgressBar1.Value = 20;
            Random random = new Random();
            toolStripProgressBar1.Value = 40;

            string lmao = "https://api.brick-hill.com/v1/games/retrieveAsset?id=" + textBox2.Text + "&type=obj";
            toolStripProgressBar1.Value = 60;

            string filename = textBox1.Text + "Rnd_" + random.Next(1, 1000) + ".obj";
            toolStripProgressBar1.Value = 70;

            webBrowser1.Navigate(lmao);
            toolStripProgressBar1.Value = 85;
            #endregion

            #region the downloading process lol
            //checking if the directory exists.
            //if not it will create one for you
            if (Directory.Exists(".\\Downloads"))
            {

                wc.DownloadFile(lmao, ".\\Downloads\\" + filename);
                toolStripProgressBar1.Value = 100;
                MessageBox.Show("Saved as " + filename, "Done!");
            }
            else
            {
                MessageBox.Show("Did you seriously remove the downloads folder? wtf bro now u broke it >:((((\nOkay ill create a folder for you.\nNow click this message away and try again.", "bro what");

                Directory.CreateDirectory("Downloads");


            }
            #endregion

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If the ID is not a hat then this will drop a error");
        }
    }
    }

