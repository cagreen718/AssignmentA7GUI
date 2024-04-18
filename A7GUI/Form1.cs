using System;
using System.Globalization;
using System.IO;
using System.Web;
using System.Text;


namespace A7GUI
{
    public partial class Form1 : Form
    {
        //https://youtu.be/nPARDhK7iso?si=QrvUldQpYXKoBn4j
        string[] lines = File.ReadAllLines(@"\Users\user\Downloads\A7Sav\savings.txt");


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
            comboBox1.DataSource= lines;
        }
    }
}
