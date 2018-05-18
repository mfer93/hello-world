using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clases;

namespace BestGame
{
    public partial class Form1 : Form
    {
        Adivinante oAdivinante;
        Adivinador oAdivinador;

        public Form1()
        {
            InitializeComponent();
        }

        private void Cleaner() {
            richTextBox1.Clear();
            richTextBox2.Clear();
            textBox1.Clear();
            oAdivinador = new Adivinador();
            oAdivinante = new Adivinante();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void vsComputer_CheckedChanged(object sender, EventArgs e)
        {
            Cleaner();
            groupBox3.Enabled = false;
            groupBox2.Enabled = true;
            richTextBox1.AppendText("Adivina mi numero!\n");
        }

        private void vsHuman_CheckedChanged(object sender, EventArgs e)
        {
            Cleaner();
            groupBox3.Enabled = true;
            groupBox2.Enabled = false;
            richTextBox2.AppendText("Tu Numero es: " + Convert.ToString(oAdivinador.Question(0)) + "?\n");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) //Al pulsar un numero
            {
                e.Handled = false; //Se acepta (todo OK)
            }
            else if (char.IsControl(e.KeyChar)) //Al pulsar teclas como Borrar y eso.
            {
                e.Handled = false; //Se acepta (todo OK)

                if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                    button1_Click(sender, e);
                }
            }
            else //Para todo lo demas
            {
                e.Handled = true; //No se acepta (si pulsas cualquier otra cosa pues no se envia)
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0) {
                switch (oAdivinante.Answer(Convert.ToInt32(textBox1.Text)))
                {
                    case -1:
                        richTextBox1.AppendText("Mi Numero es Mayor a " + textBox1.Text + "\n");
                        break;
                    case 1:
                        richTextBox1.AppendText("Mi Numero es Menor a " + textBox1.Text + "\n");
                        break;
                    case 0:
                        MessageBox.Show("Adivinaste! Buen Trabajo\n Lo hiciste en: " + Convert.ToString(oAdivinante.GetIntentos()) + " intentos\n");
                        //richTextBox1.AppendText("Adivinaste! Buen trabajo\n");
                        //richTextBox1.AppendText("Lo hiciste en: " + Convert.ToString(oAdivinante.GetIntentos()) + " intentos\n");
                        Cleaner();
                        richTextBox1.AppendText("Adivina mi numero!\n");
                        break;
                }
                richTextBox1.ScrollToCaret();
                textBox1.Clear();
                
            }
        }

        private void menor_Click(object sender, EventArgs e)
        {
            //oAdivinador.Question(1);
            richTextBox2.AppendText("Tu Numero es: " + Convert.ToString(oAdivinador.Question(1)) + "?\n");
            richTextBox2.ScrollToCaret();
        }

        private void mayor_Click(object sender, EventArgs e)
        {
            richTextBox2.AppendText("Tu Numero es: " + Convert.ToString(oAdivinador.Question(-1)) + "?\n");
            richTextBox2.ScrollToCaret();
        }

        private void igual_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YAY! \nY solo me llevo "+oAdivinador.GetIntentos()+" intentos\n");
            Cleaner();
            richTextBox2.AppendText("Tu Numero es: " + Convert.ToString(oAdivinador.Question(0)) + "?\n");
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            richTextBox2.ScrollToCaret();
        }
    }
}
