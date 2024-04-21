using System;
using System.Globalization;
using System.IO;
using System.Web;
using System.Text;


namespace A7GUI
{
    public partial class Form1 : Form
    {
        string JanEld = "The electric savings for January is 38.17";
        string JanAvg = "The average monthly savings is ";
        string FebEld = "The electric savings for Febuarary is 41.55";
        string FebAvg = "The average monthly savings is ";
        string MarEld = "The electric savings for March is 27.02";
        string MarAvg = "The average monthly savings is ";
        string AprEld = "The electric savings for April is 25.91";
        string AprAvg = "The average monthly savings is ";
        string MayEld = "The electric savings for May is 3.28";
        string MayAvg = "The average monthly savings is ";
        string JunEld = "The electric savings for June is 18.08";
        string JunAvg = "The average monthly savings is ";
        string JulEld = "The electric savings for July is 45.66";
        string JulAvg = "The average monthly savings is ";
        string AugEld = "The electric savings for August is 16.17";
        string AugAvg = "The average monthly savings is ";
        string SeptEld = "The electric savings for September is 3.98";
        string SeptAvg = "The average monthly savings is ";
        string OctEld = "The electric savings for October is 17.11";
        string OctAvg = "The average monthly savings is ";
        string NovEld="The electric savings for November is 25.78";
        string NovAvg = "The average monthly savings is ";
        string DecEld = "The electric savings for December is 51.03";
        string DecAvg = "The average monthly savings is ";
        string mosMon = " December has the most significant monthly savings";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtElectric_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAverage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMost_TextChanged(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //source: https://youtu.be/TsyddVNbXHk?si=Si58O0tZJRq7kk-4
            StreamReader sr = new StreamReader(@"C:\Users\user\source\repos\A7GUI\savings.txt");
            
            string x = sr.ReadToEnd();
            string[] y = x.Split('\n');
            string[] mon= { y[0], y[2], y[4], y[6], y[8], y[10], y[12], y[14], y[16], y[18], y[20], y[22] };
            foreach (string s in mon)
            {
                comboBox1.Items.Add(s);
            }

            if(comboBox1.SelectedIndex ==1)
            {
                txtElectric.Text= JanEld;
                txtAverage.Text = JanAvg;
                txtMost.Text = mosMon;
            }    
            if (comboBox1.SelectedIndex == 1)
            {
                txtElectric.Text = FebEld;
                txtAverage.Text = FebAvg;
                txtMost.Text = mosMon;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                txtElectric.Text = MarEld;
                txtAverage.Text = MarAvg;
                txtMost.Text = mosMon;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                txtElectric.Text = AprEld;
                txtAverage.Text = AprAvg;
                txtMost.Text = mosMon;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                txtElectric.Text = MayEld;
                txtAverage.Text = MayAvg;
                txtMost.Text = mosMon;
            }
            if (comboBox1.SelectedIndex == 5)
            {
                txtElectric.Text = JunEld;
                txtAverage.Text = JunAvg;
                txtMost.Text = mosMon;
            }
            if (comboBox1.SelectedIndex == 6)
            {
                txtElectric.Text = JulEld;
                txtAverage.Text = JulAvg;
                txtMost.Text = mosMon;
            }
            if (comboBox1.SelectedIndex == 7)
            {
                txtElectric.Text = AugEld;
                txtAverage.Text = AugAvg;
                txtMost.Text = mosMon;
            }
            if (comboBox1.SelectedIndex == 8)
            {
                txtElectric.Text = SeptEld;
                txtAverage.Text = SeptAvg;
                txtMost.Text = mosMon;
            }
            if (comboBox1.SelectedIndex == 9)
            {
                txtElectric.Text = OctEld;
                txtAverage.Text = OctAvg;
                txtMost.Text = mosMon;
            }
            if (comboBox1.SelectedIndex == 10)
            {
                txtElectric.Text = NovEld;
                txtAverage.Text = NovAvg;
                txtMost.Text = mosMon;
            }
            if (comboBox1.SelectedIndex == 11)
            {
                txtElectric.Text = DecEld;
                txtAverage.Text = DecAvg;
                txtMost.Text = mosMon;
            }
        }
    }
}
