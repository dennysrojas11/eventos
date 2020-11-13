using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEventos_Click(object sender, EventArgs e)
        {
            textBoxEvento1.BackColor = Color.Aqua;
            buttonEvento2.BackgroundImage = Properties.Resources.encender;
        }

        private void textBoxEvento1_BackColorChanged(object sender, EventArgs e)
        {
            labelEvento1.Text = "El color del textbox ha cambiado";
        }

        private void labelEvento2_Click(object sender, EventArgs e)
        {

        }

        private void buttonEvento2_BackgroundImageChanged(object sender, EventArgs e)
        {
            labelEvento2.Text = "La imagen del botón ha cambiado";
        }

        private void buttonEvento2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBoxEvento1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelEvento3_MouseHover(object sender, EventArgs e)
        {
            labelEvento3.Text = "El texto ha cambiado";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEvento4_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Ha presionado una tecla", "Evento 4", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEvento5_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = Color.Coral;
            labelEvento5.Text = "El color de fondo cambió";
        }
    }
}
