using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace underover

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string HomeTeamName = textBox7.Text;
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            try { int totalGames1 = Convert.ToInt32(textBox1.Text); }
            catch(FormatException) { textBox1.Text = " "; }
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            try { int homeTeamOver = Convert.ToInt32(textBox2.Text); }
            catch (FormatException) { textBox2.Text = " "; }
            DoMath();

        }


        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            string awayTeam = textBox8.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try { int totalGames2 = Convert.ToInt32(textBox6.Text); }
            catch (FormatException) { textBox6.Text = " "; }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try { int awayOver = Convert.ToInt32(textBox4.Text); }
            catch (FormatException) { textBox4.Text = " "; }
            DoMath2();
            Label8Text();
        }


        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            try { double overOdds = Convert.ToDouble(textBox10.Text); }
            catch (FormatException) { textBox10.Text = " "; }
            DoPercent();
           Value();
        }




        public void resultDisplay_Click(object sender, EventArgs e)
        {


        }
        double DoMath()
        {
            double totalGames1 = Convert.ToInt32(textBox1.Text);
            double homeTeamOver = Convert.ToInt32(textBox2.Text);
            double r1 = homeTeamOver / totalGames1 * 100;


            resultDisplay.Text = Math.Round(r1, 2).ToString() + "%";
            return r1;
        }
        double DoMath2()
        {
            double totalGames2 = Convert.ToInt32(textBox6.Text);
            double awayOver = Convert.ToInt32(textBox4.Text);
            double r2 = awayOver / totalGames2 * 100;


            label13.Text = Math.Round(r2, 2).ToString() + "%";
            return r2;


        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        double Label8Text()
        {
            double totalGames1 = Convert.ToInt32(textBox1.Text);
            double homeTeamOver = Convert.ToInt32(textBox2.Text);

            double totalGames2 = Convert.ToInt32(textBox6.Text);
            double awayOver = Convert.ToInt32(textBox4.Text);
            double r3 = (homeTeamOver + awayOver) / (totalGames1 + totalGames2) * 100;



            label8.Text = Math.Round(r3, 2).ToString();
            return r3;

        }
        double DoPercent()
        {
            double overOdds = Convert.ToDouble(textBox10.Text);
            double res = (1 / overOdds) * 95;
            label11.Text = Math.Round(res, 2).ToString();
            return res;


        }
       double Value()
        {
            double t1=double.Parse(label11.Text);
            double t2=double.Parse(label8.Text);
            double value = t2 - t1;
            label12.ForeColor = (value > 0) ? Color.Green : Color.Red;//set color nice!
            label12.Text = Math.Round(value, 2).ToString();
            return value;
            
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}