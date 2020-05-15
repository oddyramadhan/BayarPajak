using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasAkhir
{
    public partial class Form1 : Form
    {
        private Form activeform;
        public Form1()
        {
            InitializeComponent();
            customizedesign();
        }
        
        private void customizedesign()
        {
            panelpph.Visible = false;
        }

        private void hidesubmenu()
        {
            if (panelpph.Visible == true)
                panelpph.Visible = false;
        }

        private void showmenu(Panel menu)
        {
            if (menu.Visible == false)
            {
                hidesubmenu();
                menu.Visible = true;
            }
            else menu.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showmenu(panelpph);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openchildform(new Form2());
            hidesubmenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (activeform != null)
                activeform.Close();
            hidesubmenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void openchildform(Form childform)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel1.Controls.Add(childform);
            panel1.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
