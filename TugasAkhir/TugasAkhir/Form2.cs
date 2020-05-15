using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasAkhir
{
    public partial class Form2 : Form
    {
        double penghasilan;
        double kawin;
        double x;
        double persen;
        double bulan;
        double ptkp;
        double pkp;
        double lain;
        double pph;
        double pph1;
        double pph2;
        double pph3;
        double persen1;
        double persen2;
        double persen3;
        double total;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("========== Perhitungan PPh 21 ==========" + "\n\nNama\t\t: " + textBox11.Text + "\nPekerjaan\t\t: " + textBox10.Text + "\nPPh 21/bulan\t: Rp " + bulan);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            kawin = 4500000;
            textBox8.Text = kawin.ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
                panel3.Enabled = false;
                pictureBox1.Enabled = true;
            kawin = 0;
            textBox8.Text = kawin.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Status Wanita meskipun sudah kawin tetap mempunyai PTKP tidak kawin ");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            kawin = 0;
            textBox8.Text = kawin.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            panel3.Enabled = true;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            x = 4500000;
            textBox9.Text = x.ToString();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            x = 9000000;
            textBox9.Text = x.ToString();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            x = 13500000;
            textBox9.Text = x.ToString();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            x = 0;
            textBox9.Text = x.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ptkp = 54000000 + kawin + x;
            textBox3.Text = ptkp.ToString();
            pkp = penghasilan*12 - lain*12 - ptkp;
            textBox4.Text = pkp.ToString();
            if (pkp < 0)
            {
                MessageBox.Show("Penghasilan anda tidak memenuhi syarat untuk dikenai pajak ");
            }
            else if (pkp <= 50000000)
            {
                persen = 5;
                textBox5.Text = "5%";
                pph = pkp * persen * 0.01;
                textBox6.Text = pph.ToString();
                bulan = pph / 12;
                textBox7.Text = bulan.ToString();
            }
            else if (pkp <= 250000000)
            {
                persen = 5;
                persen1 = 15;
                textBox5.Text = "5% - 15%";
                pph = 50000000 * persen * 0.01;
                pph1 = (pkp - 50000000) * persen1 * 0.01;
                total = pph + pph1;
                textBox6.Text = total.ToString();
                bulan = total / 12;
                textBox7.Text = bulan.ToString();
            }
            else if (pkp <= 500000000)
            {
                persen = 5;
                persen1 = 15;
                persen2 = 25;
                textBox5.Text = "5% - 25%";
                pph = 50000000 * persen * 0.01;
                pph1 = 200000000 * persen1 * 0.01;
                pph2 = (pkp - 250000000) * persen2 * 0.01;
                total = pph + pph1 + pph2;
                textBox6.Text = total.ToString();
                bulan = total / 12;
                textBox7.Text = bulan.ToString();
            }
            else
            {
                persen = 5;
                persen1 = 15;
                persen2 = 25;
                persen3 = 30;
                textBox5.Text = "5% - 30%";
                pph = 50000000 * persen * 0.01;
                pph1 = 200000000 * persen1 * 0.01;
                pph2 = 250000000 * persen2 * 0.01;
                pph3 = (pkp - 500000000) * persen3 * 0.01;
                total = pph + pph1 + pph2 + pph3;
                textBox6.Text = total.ToString();
                bulan = total / 12;
                textBox7.Text = bulan.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            penghasilan = Double.Parse(textBox1.Text);
            textBox1.Text = penghasilan.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lain = double.Parse(textBox2.Text);
            textBox2.Text = lain.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }
    }
}
