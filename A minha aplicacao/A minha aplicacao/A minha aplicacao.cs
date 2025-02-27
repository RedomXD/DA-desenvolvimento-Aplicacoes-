using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_minha_aplicacao
{

    public partial class Form1 : Form
    {
        private DateTime contadorTempo;
        public Form1()
        {
            InitializeComponent();
            contadorTempo = new DateTime(0);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            toolStripStatusLabelHora.Text = DateTime.Now.ToLongTimeString();
            contadorTempo = contadorTempo.Add(new TimeSpan(0, 0, 1));
            toolStripStatusLabelContador.Text = contadorTempo.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;

            if (timer1.Enabled)
            {
                button1.Text = "Stop";
            }
            else
            {
                button1.Text = "Start";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contadorTempo = new DateTime(0);
            toolStripStatusLabelContador.Text = contadorTempo.ToLongTimeString(); // Atualiza o display ou seja mais rápido
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ToolStripItem item in statusStrip1.Items)
            {
                listBox1.Items.Add(item.Text);
            }
        }
    }
}