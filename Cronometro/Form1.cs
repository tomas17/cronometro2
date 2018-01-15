using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronometro
{
    public partial class cronometro : Form
    {
        
        
        public cronometro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] valores = {3,6,6,6,6,6,6,6,6,6,6};
            this.Hide();
            Form2 reloj2 = new Form2();
            reloj2.tramos = valores;
            reloj2.Show();
         
        }

        

        private void button2_Click(object sender, EventArgs e)
        {

            int[] valores = { 10, 10, 10, 10, 10, 10};
            this.Hide();
            Form2 reloj2 = new Form2();
            reloj2.tramos = valores;
            reloj2.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] valores = { 15, 15, 15, 15 };
            this.Hide();
            Form2 reloj2 = new Form2();
            reloj2.tramos = valores;
            reloj2.Show();
        
        }

       

        
        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            WindowState = FormWindowState.Normal;
            TopMost = true;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void cronometro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
