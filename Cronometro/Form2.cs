using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace Cronometro
{
    
    public partial class Form2 : Form
    {
        public int[] tramos;
        int segundos;
        int minutos;
        bool pausa;
        int intervalo;
        int seg_t=0;
        int min_t=0;
        int suma = 0;

        public Form2()
        {
            InitializeComponent();
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            WindowState = FormWindowState.Normal;
            TopMost = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            
           

        }
        public void onePing()
        {
            System.Media.SoundPlayer player =new System.Media.SoundPlayer();
            player.SoundLocation= Application.StartupPath + "\\tictac.wav"; 
            player.Load();
            player.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            label1.Text = "00:00";
            label1.ForeColor = Color.Red;
            label5.Text = "00:00";
            label5.ForeColor = Color.Red;
            minutos = 0;
            segundos = 0;
            intervalo = 0;
            timer1.Stop();
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            if (tramos[intervalo - 1]<10)
            {
                label1.Text = "0"+tramos[intervalo - 1].ToString() + ":00";
                minutos=tramos[intervalo - 1];
                segundos = 0;
                label1.ForeColor=Color.FromArgb(120, 255, 3);
            }
            else
            {
                label1.Text =tramos[intervalo - 1].ToString() + ":00";
                minutos = tramos[intervalo - 1];
                segundos = 0;
                label1.ForeColor = Color.FromArgb(120, 255, 3);
            }

            for(int k = 0; k < intervalo-1; k++)
            {
               
                suma += tramos[k];
            }
            
            if (intervalo <= 1)
            {
                min_t = 0;
                seg_t = 0;
            }
            else
            {
                min_t = suma;
                seg_t = 0;
               
            }
            if (min_t < 10)
            {
                label5.Text = "0" + min_t.ToString() + ":00";
            }
            else
            {
                label5.Text = min_t.ToString() + ":00";
            }
            suma = 0;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!pausa)
            {
                timer1.Stop();
                if (minutos >= 10 && segundos >= 10)
                {
                    label1.Text = minutos.ToString() + ':' + segundos.ToString();
                    

                }
                else
                {
                    if (minutos >= 10 && segundos < 10)
                    {
                        label1.Text = minutos.ToString() + ":0" + segundos.ToString();
                        

                    }
                    else
                    {
                        if (minutos < 10 && segundos >= 10)
                        {
                            label1.Text = '0' + minutos.ToString() + ':' + segundos.ToString();
                            
                        }
                        else
                        {
                            label1.Text = '0' + minutos.ToString() + ":0" + segundos.ToString();
                            

                        }
                    }
                }
                pausa = true;
                button2.Text = "Reanudar";
                label1.ForeColor = Color.Blue;
                label5.ForeColor = Color.Blue;
            }
            else
            {
                timer1.Start();
                pausa = false;
                button2.Text = "Pausa";
                label1.ForeColor = Color.FromArgb(120, 255, 3);
                label5.ForeColor = Color.FromArgb(120, 255, 3);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cronometro menu = new cronometro();
            menu.Show();


            Form menu1 = new Form();
            this.Hide();
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
           
                if (minutos >= 10 && segundos >= 10)
                {
               
                     label1.Text = minutos.ToString() + ':' + segundos.ToString();
                    label1.ForeColor = Color.FromArgb(120, 255, 3);
                   /* if (min_t < 10)
                    {
                        label5.Text = '0' + min_t.ToString() +":0"+ seg_t.ToString();
                        label5.ForeColor = Color.FromArgb(120, 255, 3);
                    }
                    else
                    {
                        label5.Text = min_t.ToString() +":0"+ seg_t.ToString();
                        label5.ForeColor = Color.FromArgb(120, 255, 3);
                    }*/
                }
                else
                {
                    if (minutos >= 10 && segundos < 10)
                    {
                        label1.Text = minutos.ToString() + ":0" + segundos.ToString();
                        label1.ForeColor = Color.FromArgb(120, 255, 3);
                       /* if (min_t < 10)
                        {
                            label5.Text = '0' + min_t.ToString() + ":" + seg_t.ToString();
                            label5.ForeColor = Color.FromArgb(120, 255, 3);
                        }
                        else
                        {
                            label5.Text = min_t.ToString() + ":" + seg_t.ToString();
                            label5.ForeColor = Color.FromArgb(120, 255, 3);
                        }*/

                }
                    else
                    {
                        if (minutos < 10 && segundos >= 10)
                        {
                            label1.Text = '0' + minutos.ToString() + ':' + segundos.ToString();
                            label1.ForeColor = Color.FromArgb(120, 255, 3);

                           /* if (min_t < 10)
                            {
                                label5.Text = '0' + min_t.ToString() +":0"+ seg_t.ToString();
                                label5.ForeColor = Color.FromArgb(120, 255, 3);
                            }
                            else
                            {
                                label5.Text = min_t.ToString() + ":0"+seg_t.ToString();
                                label5.ForeColor = Color.FromArgb(120, 255, 3);
                            }*/
                    }
                        else
                        {
                            label1.Text = '0' + minutos.ToString() + ":0" + segundos.ToString();
                            label1.ForeColor = Color.FromArgb(120, 255, 3);
                            

                        /*
                            if (min_t < 10)
                            {
                                label5.Text = '0' + min_t.ToString() + ":" + seg_t.ToString();
                                label5.ForeColor = Color.FromArgb(120, 255, 3);
                            }
                            else
                            {
                                label5.Text = min_t.ToString() + ":" + seg_t.ToString();
                                label5.ForeColor = Color.FromArgb(120, 255, 3);
                            }*/
                        }
                    }
                }


                if (segundos == 0 && minutos == 0)
                {
                intervalo++;

                
                
                if (intervalo > tramos.Length)
                {
                    
                        onePing();
                    
                    timer1.Stop();
                    label4.Text = "";
                    
                   
                    label1.ForeColor = Color.Red;
                    pausa = false;
                    button1.Enabled = true;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = true;
                    
                }
                    else {

                    
                        onePing();
                    
                    label1.ForeColor = Color.Red;
                    minutos = tramos[intervalo - 1];
                    segundos = 0;
                    label4.Text = intervalo.ToString();


                    }




                }
                else
                {
              

                if (minutos >= 1)
                    {
                
                    if (segundos == 0)
                        {
                            
                            minutos += -1;
                            segundos = 59;
                            
                            ;
                              
                    }
                        else
                        {
                        
                        if (segundos <= 59)
                            {
                           
                            segundos += -1;
                               
                            }


                        }
                    }
                    else
                    {
                   

                    segundos += -1;
                       
                    }






                }

            if (seg_t == -1)
            {
                label5.Text = "00:00";
                label5.ForeColor = Color.FromArgb(120, 255, 3);
            }
            else
            {
                if (seg_t == 60)
                {
                    seg_t = 0;
                    min_t++;
                }
                if (seg_t >= 10 && min_t >= 10)
                {
                    label5.Text = min_t.ToString() + ":" + seg_t.ToString();
                    label5.ForeColor = Color.FromArgb(120, 255, 3);
                }
                else
                {
                    if (seg_t < 10 && min_t >= 10)
                    {
                        label5.Text = min_t.ToString() + ":0" + seg_t.ToString();
                        label5.ForeColor = Color.FromArgb(120, 255, 3);
                    }
                    else
                    {
                        if (seg_t < 10 && min_t < 10)
                        {
                            label5.Text = "0" + min_t.ToString() + ":0" + seg_t.ToString();
                            label5.ForeColor = Color.FromArgb(120, 255, 3);
                        }
                        else
                        {
                            label5.Text = "0" + min_t.ToString() + ":" + seg_t.ToString();
                            label5.ForeColor = Color.FromArgb(120, 255, 3);
                        }
                    }
                }
            }
            seg_t++;



        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;
            intervalo = 1;
            pausa = false;
            minutos = tramos[0];
            segundos = 0;
            min_t = 0;
            seg_t = -1;
            timer1.Interval = 1000;
            timer1.Start();
            label1.ForeColor = Color.FromArgb(120,255,3);
            label4.Text = intervalo.ToString();
            label4.ForeColor = Color.Red;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }

        private void Form2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
