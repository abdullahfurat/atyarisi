using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }
        Random rnd = new Random();
        private void BtnYarisiBaslat_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled==true)
            { timer1.Stop();
            }

            else {

                timer1.Start();
            }
        }
        

        private void Timer1_Tick(object sender, EventArgs e)
        {
           
            pc1.Left += rnd.Next(1,20);
            pc2.Left += rnd.Next(1,20);
            pc3.Left += rnd.Next(1,20);

            if (pc1.Right >= lblFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("Yarışı 1. Kulvardaki ŞahBatur Kazandı!");
                
            }

            else if (pc2.Right >= lblFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("Yarışı 1. Kulvardaki GülBatur Kazandı!");
               
            }

            else if (pc3.Right >= lblFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("Yarışı 1. Kulvardaki CanBatur Kazandı!");
                
            }



        }
    }
}
