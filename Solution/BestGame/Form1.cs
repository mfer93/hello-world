using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cleaner() {
            richTextBox1.Clear();
            richTextBox2.Clear();
            textBox1.Clear();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void vsComputer_CheckedChanged(object sender, EventArgs e)
        {
            Cleaner();
            groupBox3.Enabled = false;
            groupBox2.Enabled = true;
        }

        private void vsHuman_CheckedChanged(object sender, EventArgs e)
        {
            Cleaner();
            groupBox3.Enabled = true;
            groupBox2.Enabled = false;
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
            MessageBox.Show("No me toques!");
        }
    }
}
